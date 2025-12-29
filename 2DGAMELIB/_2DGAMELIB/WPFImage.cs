using GLFW;
using Silk.NET.OpenGL;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace _2DGAMELIB
{
    public enum MouseButtons { 
    	None = 0,
    	Left = 1,
    	Right = 2,
    	Middle = 4,
    	Button4 = 8,
    	Button5 = 16
    }

    public class GlImage
    {

        Silk.NET.OpenGL.GL gl;

    	//yeah this is a little bit sketchy
        public static unsafe GLFW.Window PtrToWindow(IntPtr source)
        {
            var sourceRef = __makeref(source);
            var dest = default(GLFW.Window);
            var destRef = __makeref(dest);
            *(IntPtr*)&destRef = *(IntPtr*)&sourceRef;
            return __refvalue(destRef, GLFW.Window);
        }

        public GLFW.Window window;
    	private uint shader_program;
    	private uint texture;
    	private uint vertex_buf;
    	private uint vao;

        public GlImage() { }

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

    	public delegate void ShouldCloseCallback();

    	public ShouldCloseCallback Closing = delegate () { };
    	public MouseButtonCallback Click = delegate (IntPtr window, MouseButton button, InputState state, ModifierKeys modifiers) { };
    	public MouseCallback Move = delegate (IntPtr window, double x, double y) { };
    	public SizeCallback Resize = delegate (IntPtr window, int width, int height) { };
    	public MouseCallback Scroll = delegate (IntPtr window, double x, double y) { };
    	public MouseEnterCallback Leave = delegate (IntPtr window, bool entered) { };

    	public void SetTitle(string title) {
    		Glfw.SetWindowTitle(window, title);
    	}

        public void PollEvents() {
    		Glfw.PollEvents();
    		if (Glfw.WindowShouldClose(window))
    			Closing();
    	} 
        public unsafe void SetBitmap(Bitmap bmp)
        {
            gl.UseProgram(shader_program);
            gl.Viewport(new Size(bmp.Width, bmp.Height));

            gl.ActiveTexture(Silk.NET.OpenGL.GLEnum.Texture0);
    		gl.BindTexture(Silk.NET.OpenGL.GLEnum.Texture2D, texture);

            BitmapData data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            
            gl.TexImage2D(
                Silk.NET.OpenGL.GLEnum.Texture2D, 
                0,
                InternalFormat.Rgba8, 
                (uint)bmp.Width, 
                (uint)bmp.Height, 
                0,
                Silk.NET.OpenGL.GLEnum.Bgra,
                Silk.NET.OpenGL.GLEnum.UnsignedByte, 
                (void*)data.Scan0
            );

            bmp.UnlockBits(data);


            int res_pos = gl.GetUniformLocation(shader_program, "res");
    		gl.Uniform2(res_pos, (float)bmp.Width, (float)bmp.Height);

            gl.BindBuffer(GLEnum.ArrayBuffer, vertex_buf);
            uint vert_pos = (uint)gl.GetAttribLocation(shader_program, "vertPos");
            gl.EnableVertexAttribArray(vert_pos);


            gl.BindVertexArray(vao);
            gl.VertexAttribPointer(
                vert_pos,
                2,
                GLEnum.Float,
                false,
                0,
                IntPtr.Zero
            );


            gl.DrawArrays(GLEnum.TriangleStrip, 0, 4);
            Glfw.SwapBuffers(window);
        }

    	public unsafe void BitmapSetting(Bitmap bmp)
    	{
    		Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
    		Glfw.WindowHint(Hint.ContextVersionMajor, 3);
    		Glfw.WindowHint(Hint.ContextVersionMinor, 3);
    		Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
    		Glfw.WindowHint(Hint.Doublebuffer, true);
    		Glfw.WindowHint(Hint.Decorated, true);
    		Glfw.WindowHint(Hint.OpenglForwardCompatible, true);

    		window = Glfw.CreateWindow(bmp.Width, bmp.Height, "yayy", Monitor.None, GLFW.Window.None);

            Glfw.SetWindowSizeCallback(window, Resize);
            Glfw.SetMouseButtonCallback(window, Click);
            Glfw.SetCursorPositionCallback(window, Move);
    		Glfw.SetScrollCallback(window, Scroll);
    		Glfw.SetCursorEnterCallback(window, Leave);

    		GCHandle handle = GCHandle.Alloc(this);
    		Glfw.SetWindowUserPointer(window, GCHandle.ToIntPtr(handle));

            Glfw.MakeContextCurrent(window);
            gl = Silk.NET.OpenGL.GL.GetApi(Glfw.GetProcAddress);


    		string vertexShaderSource =
    @"
#version 100
precision mediump float;

attribute vec2 vertPos;

void main()
{
    gl_Position = vec4(vertPos, 0.0, 1.0);
}
";

            string fragmentShaderSource =
    @"
#version 100
precision mediump float;

uniform sampler2D sTexture;
uniform vec2 res;

void main()
{
	vec2 tc = gl_FragCoord.xy / res;
	tc.y = 1.0 - tc.y;

    gl_FragColor = texture2D(sTexture, tc);
}
";

            uint vertexShader = gl.CreateShader(Silk.NET.OpenGL.GLEnum.VertexShader);
            gl.ShaderSource(vertexShader, vertexShaderSource);
            gl.CompileShader(vertexShader);

            uint fragmentShader = gl.CreateShader(Silk.NET.OpenGL.GLEnum.FragmentShader);
            gl.ShaderSource(fragmentShader, fragmentShaderSource);
            gl.CompileShader(fragmentShader);

            shader_program = gl.CreateProgram();
            gl.AttachShader(shader_program, vertexShader);
            gl.AttachShader(shader_program, fragmentShader);
            gl.LinkProgram(shader_program);

            
            System.Diagnostics.Debug.WriteLine(gl.GetShaderInfoLog(fragmentShader));
            System.Diagnostics.Debug.WriteLine(gl.GetShaderInfoLog(vertexShader));
            System.Diagnostics.Debug.WriteLine(gl.GetProgramInfoLog(shader_program));

            gl.UseProgram(shader_program);
            gl.Uniform1(gl.GetUniformLocation(shader_program, "sTexture"), 0);

            texture = gl.GenTexture();

            gl.ActiveTexture(Silk.NET.OpenGL.GLEnum.Texture0);
            gl.BindTexture(Silk.NET.OpenGL.GLEnum.Texture2D, texture);
            
            gl.TexParameterI(Silk.NET.OpenGL.GLEnum.Texture2D, Silk.NET.OpenGL.GLEnum.TextureWrapS, new int[] {(int)TextureWrapMode.ClampToEdge});
            gl.TexParameterI(Silk.NET.OpenGL.GLEnum.Texture2D, Silk.NET.OpenGL.GLEnum.TextureWrapT, new int[] {(int)TextureWrapMode.ClampToEdge});
    		gl.TexParameterI(Silk.NET.OpenGL.GLEnum.Texture2D, Silk.NET.OpenGL.GLEnum.TextureMagFilter, new int[] {(int)TextureMagFilter.Nearest});
    		gl.TexParameterI(Silk.NET.OpenGL.GLEnum.Texture2D, Silk.NET.OpenGL.GLEnum.TextureMinFilter, new int[] {(int)TextureMinFilter.Nearest});


            float[] buf = { 1.0f, 1.0f, -1.0f, 1.0f, 1.0f, -1.0f, -1.0f, -1.0f };
            vertex_buf = gl.GenBuffer();
            gl.BindBuffer(Silk.NET.OpenGL.GLEnum.ArrayBuffer, vertex_buf);
            fixed (float* buf_ = buf) gl.BufferData(Silk.NET.OpenGL.GLEnum.ArrayBuffer, (uint)(sizeof(float) * buf.Length), buf_, Silk.NET.OpenGL.GLEnum.StaticDraw);

    		vao = gl.GenVertexArray();
        }
    }
}