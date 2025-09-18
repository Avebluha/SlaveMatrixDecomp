using System.Drawing;
using System.Drawing.Imaging;

namespace _2DGAMELIB
{

    //Basically used to animate switching between two static images
    public class Sce
    {
    	private Bitmap Start;
    	private Graphics GS;

    	private Bitmap End;
    	private Graphics GE;

    	private int w;

    	private int h;

    	private Rectangle r;

    	private ColorMatrix cm = new ColorMatrix();

    	private ImageAttributes ia = new ImageAttributes();

    	public Sce(int Width, int Height)
    	{
    		w = Width;
    		h = Height;
    		Start = new Bitmap(w, h);
    		GS = Graphics.FromImage(Start);
    		End = new Bitmap(w, h);
    		GE = Graphics.FromImage(End);
    		r = new Rectangle(0, 0, w, h);
    	}

    	public void TransformAlpha(Graphics Graphics, double Rate)
    	{
    		Graphics.DrawImage(Start, 0, 0);
    		cm.Matrix33 = (float)Rate;
    		ia.SetColorMatrix(cm);
    		Graphics.DrawImage(End, r, 0, 0, w, h, GraphicsUnit.Pixel, ia);
    	}

    	public void TransD(Graphics Graphics, double Rate)
    	{
    		Graphics.DrawImage(End, 0, 0);
    		cm.Matrix33 = (float)Rate.Inverse();
    		ia.SetColorMatrix(cm);
    		Graphics.DrawImage(Start, r, 0, 0, w, h, GraphicsUnit.Pixel, ia);
    	}

    	public void DrawStart(Are Are)
    	{
    		Are.DrawTo(GS);
    	}

    	public void DrawEnd(Are Are)
    	{
    		Are.DrawTo(GE);
    	}

    	public void ClearStart(ref Color ClearColor)
    	{
    		GS.Clear(ClearColor);
    	}

    	public void Dispose()
    	{
    		Start.Dispose();
    		GS.Dispose();
    		End.Dispose();
    		GE.Dispose();
    		ia.Dispose();
    	}
    }
}
