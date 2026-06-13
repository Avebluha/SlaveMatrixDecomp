using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 飛膜色更新
    {
    	public 飛膜_根 根;

    	public 飛膜_先 先;

    	private ShapePart[] 飛膜;

    	private Vector2D[] 飛膜m;

    	public 飛膜色更新(飛膜_根 根, 飛膜_先 先)
    	{
    		this.根 = 根;
    		this.先 = 先;
    		飛膜 = new ShapePart[4] { 根.X0Y0_飛膜, 根.X0Y1_飛膜, 先.X0Y0_飛膜, 先.X0Y1_飛膜 };
    	}

    	public void 色更新()
    	{
    		飛膜.GetMiY_MaY(out 飛膜m);
    		根.色更新(飛膜m);
    		先.色更新(飛膜m);
    	}
    }
}
