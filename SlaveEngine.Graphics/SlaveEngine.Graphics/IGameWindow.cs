using System;
using Silk.NET.OpenGL;
using _2DGAMELIB;

//TODO keyboard input?
namespace SlaveEngine.Graphics
{

    public interface IGameWindow : IDisposable
    {
        // registers/obtains the active silk opengl api context
        GL CreateGlContext();

        public Vector2D GetCursorPoint();
        public void SetCursorPoint(Vector2D pos);
        public MouseButtons GetMouseButtons();
  	    public void SetTitle(string title);
        public void PollEvents();


        // lifecycle actions
        event Action Closing;
        event Action<int, int> Resize;
        

        event Action<Vector2D> MouseMove;
        event Action<Vector2D> MouseLeave;
        event Action<double, double> MouseScroll;
        event Action<MouseButtons> MouseClick;
    }
}