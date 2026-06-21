using _2DGAMELIB;

namespace SlaveMatrix
{
    public class VaginaOrigin_人 : VaginaOrigin
    {
    	public ShapePart X0Y0_VaginaOrigin;

    	public ColorD VaginaOriginCD;

    	public ColorP X0Y0_VaginaOriginCP;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    		}
    	}

    	public override bool 筋肉
    	{
    		get
    		{
    			return 筋肉_;
    		}
    		set
    		{
    			筋肉_ = value;
    		}
    	}

    	public override bool 拘束
    	{
    		get
    		{
    			return 拘束_;
    		}
    		set
    		{
    			拘束_ = value;
    		}
    	}

    	public bool VaginaOrigin_表示
    	{
    		get
    		{
    			return X0Y0_VaginaOrigin.Dra;
    		}
    		set
    		{
    			X0Y0_VaginaOrigin.Dra = value;
    			X0Y0_VaginaOrigin.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return VaginaOrigin_表示;
    		}
    		set
    		{
    			VaginaOrigin_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return VaginaOriginCD.不透明度;
    		}
    		set
    		{
    			VaginaOriginCD.不透明度 = value;
    		}
    	}

    	public VaginaOrigin_人(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, VaginaOrigin_人D e)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(GlobalState.胴体["VaginaOrigin"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_VaginaOrigin = partGroup["膣基"].ToPar();
    		Body.SetJoints();
    		接続根 = new JointD(Body);
    		右 = e.右;
    		反転X = e.反転X;
    		反転Y = e.反転Y;
    		基準C = e.基準C;
    		位置C = e.位置C;
    		角度B = e.角度B;
    		角度C = e.角度C;
    		尺度B = e.尺度B;
    		尺度C = e.尺度C;
    		尺度XB = e.尺度XB;
    		尺度XC = e.尺度XC;
    		尺度YB = e.尺度YB;
    		尺度YC = e.尺度YC;
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		VaginaOrigin_表示 = e.VaginaOrigin_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_VaginaOriginCP = new ColorP(X0Y0_VaginaOrigin, VaginaOriginCD, DisUnit, abj: true);
    		Intensity = e.濃度;
    		尺度YB = 0.95;
    	}

    	public override void 色更新()
    	{
    		X0Y0_VaginaOriginCP.Update();
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		ColorHelper.Alpha(ref 体配色.粘膜, 160, out var ret);
    		VaginaOriginCD = new ColorD(ref 体配色.粘膜線, ref ret);
    	}
    }
}
