using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ドレス色更新
    {
    	public 上着トップ_ドレス トップ;

    	public 上着ミドル_ドレス ミドル;

    	private ShapePart[] ドレス;

    	private ShapePart[] 縁左;

    	private ShapePart[] 縁右;

    	private Vector2D[] ドレスm;

    	private Vector2D[] 縁左m;

    	private Vector2D[] 縁右m;

    	public ドレス色更新(上着トップ_ドレス トップ, 上着ミドル_ドレス ミドル)
    	{
    		this.トップ = トップ;
    		this.ミドル = ミドル;
    		ドレス = new ShapePart[5] { トップ.X0Y0_左_服, トップ.X0Y0_左_バスト, トップ.X0Y0_右_服, トップ.X0Y0_右_バスト, ミドル.X0Y0_服 };
    		縁左 = new ShapePart[2] { トップ.X0Y0_左_縁, ミドル.X0Y0_縁_縁左 };
    		縁右 = new ShapePart[2] { トップ.X0Y0_右_縁, ミドル.X0Y0_縁_縁右 };
    	}

    	public void 色更新()
    	{
    		ドレス.GetMiY_MaY(out ドレスm);
    		縁左.GetMiY_MaY(out 縁左m);
    		縁右.GetMiY_MaY(out 縁右m);
    		トップ.色更新(ドレスm, 縁左m, 縁右m);
    		ミドル.色更新(ドレスm, 縁左m, 縁右m);
    	}

    	public bool Contains(Element e)
    	{
    		if (トップ != e)
    		{
    			return ミドル == e;
    		}
    		return true;
    	}
    }
}
