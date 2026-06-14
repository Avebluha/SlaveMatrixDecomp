using GLFW;
using Silk.NET.OpenGL;
using _2DGAMELIB;
using System;
using System.Runtime.InteropServices;

namespace SlaveEngine.Graphics
{
    public class GLFWWindow : IGameWindow
    {
        public GLFW.Window window;
        private bool isDisposed = false;

        // backing fields to keep the native function pointers alive in memory
        private readonly MouseButtonCallback nativeClickCallback;
        private readonly MouseCallback nativeMoveCallback;
        private readonly SizeCallback nativeResizeCallback;
        private readonly MouseCallback nativeScrollCallback;
        private readonly MouseEnterCallback nativeLeaveCallback;

        // interface actions
        public event Action Closing = delegate { };
        public event Action<int, int> Resize = delegate { };
        public event Action<Vector2D> MouseMove = delegate { };
        public event Action<Vector2D> MouseLeave = delegate { };
        public event Action<double, double> MouseScroll = delegate { };
        public event Action<MouseButtons> MouseClick = delegate { };

        public static unsafe GLFW.Window PtrToWindow(IntPtr source)
        {
            var sourceRef = __makeref(source);
            var dest = default(GLFW.Window);
            var destRef = __makeref(dest);
            *(IntPtr*)&destRef = *(IntPtr*)&sourceRef;
            return __refvalue(destRef, GLFW.Window);
        }

        public Vector2D GetCursorPoint() {
            double x, y;
            Glfw.GetCursorPosition(window, out x, out y);
            return new Vector2D(x, y);
        }

        public void SetCursorPoint(Vector2D pos) {
            Glfw.SetCursorPosition(window, pos.X, pos.Y);
        }

        public MouseButtons GetMouseButtons() {
            MouseButtons btns = 0;

            if (Glfw.GetMouseButton(window, MouseButton.Left) == InputState.Press)
                btns |= MouseButtons.Left;

            if (Glfw.GetMouseButton(window, MouseButton.Right) == InputState.Press)
                btns |= MouseButtons.Right;

            if (Glfw.GetMouseButton(window, MouseButton.Middle) == InputState.Press)
                btns |= MouseButtons.Middle;

            if (Glfw.GetMouseButton(window, MouseButton.Button4) == InputState.Press)
                btns |= MouseButtons.Button4;

            if (Glfw.GetMouseButton(window, MouseButton.Button5) == InputState.Press)
                btns |= MouseButtons.Button5;

            return btns;
        }

        private static GLFWWindow GetContext(IntPtr winPtr)
        {
            IntPtr userPtr = Glfw.GetWindowUserPointer(PtrToWindow(winPtr));
            if (userPtr != IntPtr.Zero)
            {
                GCHandle handle = GCHandle.FromIntPtr(userPtr);
                return handle.Target as GLFWWindow;
            }
            return null;
        }

        public void SetTitle(string title) {
            Glfw.SetWindowTitle(window, title);
        }

        public void PollEvents() {
            Glfw.PollEvents();
            if (Glfw.WindowShouldClose(window))
                Closing?.Invoke();
        }

        public unsafe GLFWWindow(int Width, int Height)
        {
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.Doublebuffer, true);
            Glfw.WindowHint(Hint.Decorated, true);
            Glfw.WindowHint(Hint.OpenglForwardCompatible, true);

            window = Glfw.CreateWindow(Width, Height, "GLFWWindow", GLFW.Monitor.None, GLFW.Window.None);

            // instantiate native signatures bound to our context conversion handlers
            nativeResizeCallback = (win, w, h) => GetContext(win)?.Resize?.Invoke(w, h);
            nativeMoveCallback = (win, x, y) => GetContext(win)?.MouseMove?.Invoke(new Vector2D(x, y));
            nativeScrollCallback = (win, x, y) => GetContext(win)?.MouseScroll?.Invoke(x, y);
            
            nativeLeaveCallback = (win, entered) => {
                if (!entered) GetContext(win)?.MouseLeave?.Invoke(GetContext(win).GetCursorPoint());
            };

            MouseButtons activeButtons = 0;  
            nativeClickCallback = (win, button, state, modifiers) => {
                MouseButtons targetBtn = 0;
                if (button == MouseButton.Left) targetBtn = MouseButtons.Left;
                else if (button == MouseButton.Right) targetBtn = MouseButtons.Right;
                else if (button == MouseButton.Middle) targetBtn = MouseButtons.Middle;
                else if (button == MouseButton.Button4) targetBtn = MouseButtons.Button4;
                else if (button == MouseButton.Button5) targetBtn = MouseButtons.Button5;

                if (targetBtn == 0) return;

                MouseButtons oldButtons = activeButtons;

                if (state == InputState.Press)
                {
                    activeButtons |= targetBtn; // or together new bits
                }
                else if (state == InputState.Release)
                {
                    activeButtons &= ~targetBtn; // clear released bits
                }

                if (activeButtons != oldButtons)
                {
                    GetContext(win)?.MouseClick?.Invoke(activeButtons);
                }
            };

            // pass the persistent delegates down to GLFW
            Glfw.SetWindowSizeCallback(window, nativeResizeCallback);
            Glfw.SetMouseButtonCallback(window, nativeClickCallback);
            Glfw.SetCursorPositionCallback(window, nativeMoveCallback);
            Glfw.SetScrollCallback(window, nativeScrollCallback);
            Glfw.SetCursorEnterCallback(window, nativeLeaveCallback);

            GCHandle handle = GCHandle.Alloc(this);
            Glfw.SetWindowUserPointer(window, GCHandle.ToIntPtr(handle));

            Glfw.MakeContextCurrent(window);
            Glfw.SwapInterval(0);
        }

        public GL CreateGlContext(){
            return Silk.NET.OpenGL.GL.GetApi(Glfw.GetProcAddress);
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                IntPtr userPtr = Glfw.GetWindowUserPointer(window);
                if (userPtr != IntPtr.Zero)
                {
                    GCHandle handle = GCHandle.FromIntPtr(userPtr);
                    if (handle.IsAllocated) handle.Free();
                }
                Glfw.DestroyWindow(window);
                isDisposed = true;
            }
        }
    }
}