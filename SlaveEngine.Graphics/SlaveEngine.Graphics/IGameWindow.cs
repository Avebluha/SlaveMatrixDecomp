using System;
using Silk.NET.OpenGL;
using _2DGAMELIB;

namespace SlaveEngine.Graphics
{
    public enum KeyCode
    {
        Unknown,
        Left, Right, Up, Down,
        Space, Escape,
        Home, End,
        LeftBracket, RightBracket,
        R, C, P
    }

    public interface IGameWindow : IDisposable
    {
        GL CreateGlContext();

        public Vector2D GetCursorPoint();
        public void SetCursorPoint(Vector2D pos);
        public MouseButtons GetMouseButtons();
  	    public void SetTitle(string title);
        public void PollEvents();

        event Action Closing;
        event Action<int, int> Resize;
        event Action<Vector2D> MouseMove;
        event Action<Vector2D> MouseLeave;
        event Action<double, double> MouseScroll;
        event Action<MouseButtons> MouseClick;
        event Action<KeyCode> KeyDown;
    }
}