using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 前翅_甲 : 前翅
    {
    	public ShapePart X0Y0_前翅_前翅軸_軸1;

    	public ShapePart X0Y0_前翅_前翅軸_軸2;

    	public ShapePart X0Y0_前翅_前翅軸_軸3;

    	public ShapePart X0Y0_前翅_前翅甲_甲2;

    	public ShapePart X0Y0_前翅_前翅甲_甲1;

    	public ShapePart X0Y0_前翅_前翅甲_紋1;

    	public ShapePart X0Y0_前翅_前翅甲_紋2;

    	public ShapePart X0Y0_前翅_前翅甲_紋3;

    	public ShapePart X0Y0_前翅_前翅甲_紋4;

    	public ShapePart X0Y0_前翅_前翅甲_紋5;

    	public ShapePart X0Y0_前翅_前翅甲_紋6;

    	public ShapePart X0Y0_前翅_前翅甲_紋7;

    	public ShapePart X0Y0_付根_付根0;

    	public ShapePart X0Y0_付根_付根1;

    	public ShapePart X0Y0_付根_付根2;

    	public ShapePart X0Y0_甲付根;

    	public ShapePart X0Y0_紋1;

    	public ShapePart X0Y0_紋2;

    	public ShapePart X0Y1_前翅_前翅軸_軸1;

    	public ShapePart X0Y1_前翅_前翅軸_軸2;

    	public ShapePart X0Y1_前翅_前翅軸_軸3;

    	public ShapePart X0Y1_前翅_前翅軸_罅線;

    	public ShapePart X0Y1_前翅_前翅甲_甲2;

    	public ShapePart X0Y1_前翅_前翅甲_甲1;

    	public ShapePart X0Y1_前翅_前翅甲_紋1;

    	public ShapePart X0Y1_前翅_前翅甲_紋2;

    	public ShapePart X0Y1_前翅_前翅甲_紋3;

    	public ShapePart X0Y1_前翅_前翅甲_紋4;

    	public ShapePart X0Y1_前翅_前翅甲_紋5;

    	public ShapePart X0Y1_前翅_前翅甲_紋6;

    	public ShapePart X0Y1_前翅_前翅甲_紋7;

    	public ShapePart X0Y1_前翅_前翅甲_罅線1;

    	public ShapePart X0Y1_前翅_前翅甲_罅線2;

    	public ShapePart X0Y1_付根_付根0;

    	public ShapePart X0Y1_付根_付根1;

    	public ShapePart X0Y1_付根_付根2;

    	public ShapePart X0Y1_甲付根;

    	public ShapePart X0Y1_紋1;

    	public ShapePart X0Y1_紋2;

    	public ShapePart X0Y1_欠け1;

    	public ShapePart X0Y1_欠け2;

    	public ShapePart X0Y1_欠け3;

    	public ColorD 前翅_前翅軸_軸1CD;

    	public ColorD 前翅_前翅軸_軸2CD;

    	public ColorD 前翅_前翅軸_軸3CD;

    	public ColorD 前翅_前翅軸_罅線CD;

    	public ColorD 前翅_前翅甲_甲2CD;

    	public ColorD 前翅_前翅甲_甲1CD;

    	public ColorD 前翅_前翅甲_紋1CD;

    	public ColorD 前翅_前翅甲_紋2CD;

    	public ColorD 前翅_前翅甲_紋3CD;

    	public ColorD 前翅_前翅甲_紋4CD;

    	public ColorD 前翅_前翅甲_紋5CD;

    	public ColorD 前翅_前翅甲_紋6CD;

    	public ColorD 前翅_前翅甲_紋7CD;

    	public ColorD 前翅_前翅甲_罅線1CD;

    	public ColorD 前翅_前翅甲_罅線2CD;

    	public ColorD 付根_付根0CD;

    	public ColorD 付根_付根1CD;

    	public ColorD 付根_付根2CD;

    	public ColorD 甲付根CD;

    	public ColorD 紋1CD;

    	public ColorD 紋2CD;

    	public ColorD 欠け1CD;

    	public ColorD 欠け2CD;

    	public ColorD 欠け3CD;

    	public ColorP X0Y0_前翅_前翅軸_軸1CP;

    	public ColorP X0Y0_前翅_前翅軸_軸2CP;

    	public ColorP X0Y0_前翅_前翅軸_軸3CP;

    	public ColorP X0Y0_前翅_前翅甲_甲2CP;

    	public ColorP X0Y0_前翅_前翅甲_甲1CP;

    	public ColorP X0Y0_前翅_前翅甲_紋1CP;

    	public ColorP X0Y0_前翅_前翅甲_紋2CP;

    	public ColorP X0Y0_前翅_前翅甲_紋3CP;

    	public ColorP X0Y0_前翅_前翅甲_紋4CP;

    	public ColorP X0Y0_前翅_前翅甲_紋5CP;

    	public ColorP X0Y0_前翅_前翅甲_紋6CP;

    	public ColorP X0Y0_前翅_前翅甲_紋7CP;

    	public ColorP X0Y0_付根_付根0CP;

    	public ColorP X0Y0_付根_付根1CP;

    	public ColorP X0Y0_付根_付根2CP;

    	public ColorP X0Y0_甲付根CP;

    	public ColorP X0Y0_紋1CP;

    	public ColorP X0Y0_紋2CP;

    	public ColorP X0Y1_前翅_前翅軸_軸1CP;

    	public ColorP X0Y1_前翅_前翅軸_軸2CP;

    	public ColorP X0Y1_前翅_前翅軸_軸3CP;

    	public ColorP X0Y1_前翅_前翅軸_罅線CP;

    	public ColorP X0Y1_前翅_前翅甲_甲2CP;

    	public ColorP X0Y1_前翅_前翅甲_甲1CP;

    	public ColorP X0Y1_前翅_前翅甲_紋1CP;

    	public ColorP X0Y1_前翅_前翅甲_紋2CP;

    	public ColorP X0Y1_前翅_前翅甲_紋3CP;

    	public ColorP X0Y1_前翅_前翅甲_紋4CP;

    	public ColorP X0Y1_前翅_前翅甲_紋5CP;

    	public ColorP X0Y1_前翅_前翅甲_紋6CP;

    	public ColorP X0Y1_前翅_前翅甲_紋7CP;

    	public ColorP X0Y1_前翅_前翅甲_罅線1CP;

    	public ColorP X0Y1_前翅_前翅甲_罅線2CP;

    	public ColorP X0Y1_付根_付根0CP;

    	public ColorP X0Y1_付根_付根1CP;

    	public ColorP X0Y1_付根_付根2CP;

    	public ColorP X0Y1_甲付根CP;

    	public ColorP X0Y1_紋1CP;

    	public ColorP X0Y1_紋2CP;

    	public ColorP X0Y1_欠け1CP;

    	public ColorP X0Y1_欠け2CP;

    	public ColorP X0Y1_欠け3CP;

    	public Ele[] 軸1_接続;

    	public Ele[] 軸2_接続;

    	public Ele[] 軸3_接続;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    			Body.IndexY = (欠損_ ? 1 : 0);
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

    	public bool 前翅_前翅軸_軸1_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅軸_軸1.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅軸_軸1.Dra = value;
    			X0Y1_前翅_前翅軸_軸1.Dra = value;
    			X0Y0_前翅_前翅軸_軸1.Hit = value;
    			X0Y1_前翅_前翅軸_軸1.Hit = value;
    		}
    	}

    	public bool 前翅_前翅軸_軸2_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅軸_軸2.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅軸_軸2.Dra = value;
    			X0Y1_前翅_前翅軸_軸2.Dra = value;
    			X0Y0_前翅_前翅軸_軸2.Hit = value;
    			X0Y1_前翅_前翅軸_軸2.Hit = value;
    		}
    	}

    	public bool 前翅_前翅軸_軸3_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅軸_軸3.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅軸_軸3.Dra = value;
    			X0Y1_前翅_前翅軸_軸3.Dra = value;
    			X0Y0_前翅_前翅軸_軸3.Hit = value;
    			X0Y1_前翅_前翅軸_軸3.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_甲2_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_甲2.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_甲2.Dra = value;
    			X0Y1_前翅_前翅甲_甲2.Dra = value;
    			X0Y0_前翅_前翅甲_甲2.Hit = value;
    			X0Y1_前翅_前翅甲_甲2.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_甲1_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_甲1.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_甲1.Dra = value;
    			X0Y1_前翅_前翅甲_甲1.Dra = value;
    			X0Y0_前翅_前翅甲_甲1.Hit = value;
    			X0Y1_前翅_前翅甲_甲1.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_紋1_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_紋1.Dra = value;
    			X0Y1_前翅_前翅甲_紋1.Dra = value;
    			X0Y0_前翅_前翅甲_紋1.Hit = value;
    			X0Y1_前翅_前翅甲_紋1.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_紋2_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_紋2.Dra = value;
    			X0Y1_前翅_前翅甲_紋2.Dra = value;
    			X0Y0_前翅_前翅甲_紋2.Hit = value;
    			X0Y1_前翅_前翅甲_紋2.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_紋3_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_紋3.Dra = value;
    			X0Y1_前翅_前翅甲_紋3.Dra = value;
    			X0Y0_前翅_前翅甲_紋3.Hit = value;
    			X0Y1_前翅_前翅甲_紋3.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_紋4_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_紋4.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_紋4.Dra = value;
    			X0Y1_前翅_前翅甲_紋4.Dra = value;
    			X0Y0_前翅_前翅甲_紋4.Hit = value;
    			X0Y1_前翅_前翅甲_紋4.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_紋5_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_紋5.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_紋5.Dra = value;
    			X0Y1_前翅_前翅甲_紋5.Dra = value;
    			X0Y0_前翅_前翅甲_紋5.Hit = value;
    			X0Y1_前翅_前翅甲_紋5.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_紋6_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_紋6.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_紋6.Dra = value;
    			X0Y1_前翅_前翅甲_紋6.Dra = value;
    			X0Y0_前翅_前翅甲_紋6.Hit = value;
    			X0Y1_前翅_前翅甲_紋6.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_紋7_表示
    	{
    		get
    		{
    			return X0Y0_前翅_前翅甲_紋7.Dra;
    		}
    		set
    		{
    			X0Y0_前翅_前翅甲_紋7.Dra = value;
    			X0Y1_前翅_前翅甲_紋7.Dra = value;
    			X0Y0_前翅_前翅甲_紋7.Hit = value;
    			X0Y1_前翅_前翅甲_紋7.Hit = value;
    		}
    	}

    	public bool 付根_付根0_表示
    	{
    		get
    		{
    			return X0Y0_付根_付根0.Dra;
    		}
    		set
    		{
    			X0Y0_付根_付根0.Dra = value;
    			X0Y1_付根_付根0.Dra = value;
    			X0Y0_付根_付根0.Hit = value;
    			X0Y1_付根_付根0.Hit = value;
    		}
    	}

    	public bool 付根_付根1_表示
    	{
    		get
    		{
    			return X0Y0_付根_付根1.Dra;
    		}
    		set
    		{
    			X0Y0_付根_付根1.Dra = value;
    			X0Y1_付根_付根1.Dra = value;
    			X0Y0_付根_付根1.Hit = value;
    			X0Y1_付根_付根1.Hit = value;
    		}
    	}

    	public bool 付根_付根2_表示
    	{
    		get
    		{
    			return X0Y0_付根_付根2.Dra;
    		}
    		set
    		{
    			X0Y0_付根_付根2.Dra = value;
    			X0Y1_付根_付根2.Dra = value;
    			X0Y0_付根_付根2.Hit = value;
    			X0Y1_付根_付根2.Hit = value;
    		}
    	}

    	public bool 甲付根_表示
    	{
    		get
    		{
    			return X0Y0_甲付根.Dra;
    		}
    		set
    		{
    			X0Y0_甲付根.Dra = value;
    			X0Y1_甲付根.Dra = value;
    			X0Y0_甲付根.Hit = value;
    			X0Y1_甲付根.Hit = value;
    		}
    	}

    	public bool 紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋1.Dra = value;
    			X0Y1_紋1.Dra = value;
    			X0Y0_紋1.Hit = value;
    			X0Y1_紋1.Hit = value;
    		}
    	}

    	public bool 紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋2.Dra = value;
    			X0Y1_紋2.Dra = value;
    			X0Y0_紋2.Hit = value;
    			X0Y1_紋2.Hit = value;
    		}
    	}

    	public bool 前翅_前翅軸_罅線_表示
    	{
    		get
    		{
    			return X0Y1_前翅_前翅軸_罅線.Dra;
    		}
    		set
    		{
    			X0Y1_前翅_前翅軸_罅線.Dra = value;
    			X0Y1_前翅_前翅軸_罅線.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_罅線1_表示
    	{
    		get
    		{
    			return X0Y1_前翅_前翅甲_罅線1.Dra;
    		}
    		set
    		{
    			X0Y1_前翅_前翅甲_罅線1.Dra = value;
    			X0Y1_前翅_前翅甲_罅線1.Hit = value;
    		}
    	}

    	public bool 前翅_前翅甲_罅線2_表示
    	{
    		get
    		{
    			return X0Y1_前翅_前翅甲_罅線2.Dra;
    		}
    		set
    		{
    			X0Y1_前翅_前翅甲_罅線2.Dra = value;
    			X0Y1_前翅_前翅甲_罅線2.Hit = value;
    		}
    	}

    	public bool 欠け1_表示
    	{
    		get
    		{
    			return X0Y1_欠け1.Dra;
    		}
    		set
    		{
    			X0Y1_欠け1.Dra = value;
    			X0Y1_欠け1.Hit = value;
    		}
    	}

    	public bool 欠け2_表示
    	{
    		get
    		{
    			return X0Y1_欠け2.Dra;
    		}
    		set
    		{
    			X0Y1_欠け2.Dra = value;
    			X0Y1_欠け2.Hit = value;
    		}
    	}

    	public bool 欠け3_表示
    	{
    		get
    		{
    			return X0Y1_欠け3.Dra;
    		}
    		set
    		{
    			X0Y1_欠け3.Dra = value;
    			X0Y1_欠け3.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 前翅_前翅軸_軸1_表示;
    		}
    		set
    		{
    			前翅_前翅軸_軸1_表示 = value;
    			前翅_前翅軸_軸2_表示 = value;
    			前翅_前翅軸_軸3_表示 = value;
    			前翅_前翅甲_甲2_表示 = value;
    			前翅_前翅甲_甲1_表示 = value;
    			前翅_前翅甲_紋1_表示 = value;
    			前翅_前翅甲_紋2_表示 = value;
    			前翅_前翅甲_紋3_表示 = value;
    			前翅_前翅甲_紋4_表示 = value;
    			前翅_前翅甲_紋5_表示 = value;
    			前翅_前翅甲_紋6_表示 = value;
    			前翅_前翅甲_紋7_表示 = value;
    			付根_付根0_表示 = value;
    			付根_付根1_表示 = value;
    			付根_付根2_表示 = value;
    			甲付根_表示 = value;
    			紋1_表示 = value;
    			紋2_表示 = value;
    			前翅_前翅軸_罅線_表示 = value;
    			前翅_前翅甲_罅線1_表示 = value;
    			前翅_前翅甲_罅線2_表示 = value;
    			欠け1_表示 = value;
    			欠け2_表示 = value;
    			欠け3_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 前翅_前翅軸_軸1CD.不透明度;
    		}
    		set
    		{
    			前翅_前翅軸_軸1CD.不透明度 = value;
    			前翅_前翅軸_軸2CD.不透明度 = value;
    			前翅_前翅軸_軸3CD.不透明度 = value;
    			前翅_前翅軸_罅線CD.不透明度 = value;
    			前翅_前翅甲_甲2CD.不透明度 = value;
    			前翅_前翅甲_甲1CD.不透明度 = value;
    			前翅_前翅甲_紋1CD.不透明度 = value;
    			前翅_前翅甲_紋2CD.不透明度 = value;
    			前翅_前翅甲_紋3CD.不透明度 = value;
    			前翅_前翅甲_紋4CD.不透明度 = value;
    			前翅_前翅甲_紋5CD.不透明度 = value;
    			前翅_前翅甲_紋6CD.不透明度 = value;
    			前翅_前翅甲_紋7CD.不透明度 = value;
    			前翅_前翅甲_罅線1CD.不透明度 = value;
    			前翅_前翅甲_罅線2CD.不透明度 = value;
    			付根_付根0CD.不透明度 = value;
    			付根_付根1CD.不透明度 = value;
    			付根_付根2CD.不透明度 = value;
    			甲付根CD.不透明度 = value;
    			紋1CD.不透明度 = value;
    			紋2CD.不透明度 = value;
    			欠け1CD.不透明度 = value;
    			欠け2CD.不透明度 = value;
    			欠け3CD.不透明度 = value;
    		}
    	}

    	public double 展開
    	{
    		set
    		{
    			double num = value.Inverse();
    			double num2 = (右 ? (-1.0) : 1.0);
    			X0Y0_前翅_前翅軸_軸1.AngleCont = num2 * -95.0 * num;
    			X0Y0_前翅_前翅軸_軸2.AngleCont = num2 * -28.0 * num;
    			X0Y0_前翅_前翅軸_軸3.AngleCont = num2 * -178.0 * num;
    			X0Y0_前翅_前翅甲_甲1.AngleCont = num2 * -45.0 * num;
    			X0Y0_甲付根.AngleCont = num2 * 6.0 * num;
    			X0Y0_前翅_前翅軸_軸3.SizeXCont = 0.7 + 0.3 * value;
    			X0Y1_前翅_前翅軸_軸1.AngleCont = num2 * -95.0 * num;
    			X0Y1_前翅_前翅軸_軸2.AngleCont = num2 * -28.0 * num;
    			X0Y1_前翅_前翅軸_軸3.AngleCont = num2 * -178.0 * num;
    			X0Y1_前翅_前翅甲_甲1.AngleCont = num2 * -45.0 * num;
    			X0Y1_甲付根.AngleCont = num2 * 6.0 * num;
    			X0Y1_前翅_前翅軸_軸3.SizeXCont = 0.7 + 0.3 * value;
    		}
    	}

    	public JointS 軸1_接続点 => new JointS(Body, X0Y0_付根_付根0, 0);

    	public JointS 軸2_接続点 => new JointS(Body, X0Y0_前翅_前翅軸_軸1, 0);

    	public JointS 軸3_接続点 => new JointS(Body, X0Y0_前翅_前翅軸_軸2, 0);

    	public 前翅_甲(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色, ModeEventDispatcher Med, 前翅_甲D e)
    	{
    		前翅_甲 前翅_甲2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif(Sta.肢左["前翅"][0]);
    		Body = new Difs();
    		Body.Tag = dif.Tag;
    		Body.Add(dif);
    		PartGroup partGroup = Body[0][0];
    		PartGroup pars2 = partGroup["前翅"].ToPars();
    		PartGroup pars3 = pars2["前翅軸"].ToPars();
    		X0Y0_前翅_前翅軸_軸1 = pars3["軸1"].ToPar();
    		X0Y0_前翅_前翅軸_軸2 = pars3["軸2"].ToPar();
    		X0Y0_前翅_前翅軸_軸3 = pars3["軸3"].ToPar();
    		pars3 = pars2["前翅甲"].ToPars();
    		X0Y0_前翅_前翅甲_甲2 = pars3["甲2"].ToPar();
    		X0Y0_前翅_前翅甲_甲1 = pars3["甲1"].ToPar();
    		X0Y0_前翅_前翅甲_紋1 = pars3["紋1"].ToPar();
    		X0Y0_前翅_前翅甲_紋2 = pars3["紋2"].ToPar();
    		X0Y0_前翅_前翅甲_紋3 = pars3["紋3"].ToPar();
    		X0Y0_前翅_前翅甲_紋4 = pars3["紋4"].ToPar();
    		X0Y0_前翅_前翅甲_紋5 = pars3["紋5"].ToPar();
    		X0Y0_前翅_前翅甲_紋6 = pars3["紋6"].ToPar();
    		X0Y0_前翅_前翅甲_紋7 = pars3["紋7"].ToPar();
    		pars2 = partGroup["付根"].ToPars();
    		X0Y0_付根_付根0 = pars2["付根0"].ToPar();
    		X0Y0_付根_付根1 = pars2["付根1"].ToPar();
    		X0Y0_付根_付根2 = pars2["付根2"].ToPar();
    		X0Y0_甲付根 = partGroup["甲付根"].ToPar();
    		X0Y0_紋1 = partGroup["紋1"].ToPar();
    		X0Y0_紋2 = partGroup["紋2"].ToPar();
    		partGroup = Body[0][1];
    		pars2 = partGroup["前翅"].ToPars();
    		pars3 = pars2["前翅軸"].ToPars();
    		X0Y1_前翅_前翅軸_軸1 = pars3["軸1"].ToPar();
    		X0Y1_前翅_前翅軸_軸2 = pars3["軸2"].ToPar();
    		X0Y1_前翅_前翅軸_軸3 = pars3["軸3"].ToPar();
    		X0Y1_前翅_前翅軸_罅線 = pars3["罅線"].ToPar();
    		pars3 = pars2["前翅甲"].ToPars();
    		X0Y1_前翅_前翅甲_甲2 = pars3["甲2"].ToPar();
    		X0Y1_前翅_前翅甲_甲1 = pars3["甲1"].ToPar();
    		X0Y1_前翅_前翅甲_紋1 = pars3["紋1"].ToPar();
    		X0Y1_前翅_前翅甲_紋2 = pars3["紋2"].ToPar();
    		X0Y1_前翅_前翅甲_紋3 = pars3["紋3"].ToPar();
    		X0Y1_前翅_前翅甲_紋4 = pars3["紋4"].ToPar();
    		X0Y1_前翅_前翅甲_紋5 = pars3["紋5"].ToPar();
    		X0Y1_前翅_前翅甲_紋6 = pars3["紋6"].ToPar();
    		X0Y1_前翅_前翅甲_紋7 = pars3["紋7"].ToPar();
    		X0Y1_前翅_前翅甲_罅線1 = pars3["罅線1"].ToPar();
    		X0Y1_前翅_前翅甲_罅線2 = pars3["罅線2"].ToPar();
    		pars2 = partGroup["付根"].ToPars();
    		X0Y1_付根_付根0 = pars2["付根0"].ToPar();
    		X0Y1_付根_付根1 = pars2["付根1"].ToPar();
    		X0Y1_付根_付根2 = pars2["付根2"].ToPar();
    		X0Y1_甲付根 = partGroup["甲付根"].ToPar();
    		X0Y1_紋1 = partGroup["紋1"].ToPar();
    		X0Y1_紋2 = partGroup["紋2"].ToPar();
    		X0Y1_欠け1 = partGroup["欠け1"].ToPar();
    		X0Y1_欠け2 = partGroup["欠け2"].ToPar();
    		X0Y1_欠け3 = partGroup["欠け3"].ToPar();
    		Xasix = false;
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
    		前翅_前翅軸_軸1_表示 = e.前翅_前翅軸_軸1_表示;
    		前翅_前翅軸_軸2_表示 = e.前翅_前翅軸_軸2_表示;
    		前翅_前翅軸_軸3_表示 = e.前翅_前翅軸_軸3_表示;
    		前翅_前翅甲_甲2_表示 = e.前翅_前翅甲_甲2_表示;
    		前翅_前翅甲_甲1_表示 = e.前翅_前翅甲_甲1_表示;
    		前翅_前翅甲_紋1_表示 = e.前翅_前翅甲_紋1_表示;
    		前翅_前翅甲_紋2_表示 = e.前翅_前翅甲_紋2_表示;
    		前翅_前翅甲_紋3_表示 = e.前翅_前翅甲_紋3_表示;
    		前翅_前翅甲_紋4_表示 = e.前翅_前翅甲_紋4_表示;
    		前翅_前翅甲_紋5_表示 = e.前翅_前翅甲_紋5_表示;
    		前翅_前翅甲_紋6_表示 = e.前翅_前翅甲_紋6_表示;
    		前翅_前翅甲_紋7_表示 = e.前翅_前翅甲_紋7_表示;
    		付根_付根0_表示 = e.付根_付根0_表示;
    		付根_付根1_表示 = e.付根_付根1_表示;
    		付根_付根2_表示 = e.付根_付根2_表示;
    		甲付根_表示 = e.甲付根_表示;
    		紋1_表示 = e.紋1_表示;
    		紋2_表示 = e.紋2_表示;
    		前翅_前翅軸_罅線_表示 = e.前翅_前翅軸_罅線_表示;
    		前翅_前翅甲_罅線1_表示 = e.前翅_前翅甲_罅線1_表示;
    		前翅_前翅甲_罅線2_表示 = e.前翅_前翅甲_罅線2_表示;
    		欠け1_表示 = e.欠け1_表示;
    		欠け2_表示 = e.欠け2_表示;
    		欠け3_表示 = e.欠け3_表示;
    		展開 = e.展開;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.軸1_接続.Count > 0)
    		{
    			軸1_接続 = e.軸1_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 前翅_甲2;
    				f.ConnectionType = ConnectionInfo.前翅_甲_軸1_接続;
    				f.接続(前翅_甲2.軸1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.軸2_接続.Count > 0)
    		{
    			軸2_接続 = e.軸2_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 前翅_甲2;
    				f.ConnectionType = ConnectionInfo.前翅_甲_軸2_接続;
    				f.接続(前翅_甲2.軸2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.軸3_接続.Count > 0)
    		{
    			軸3_接続 = e.軸3_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 前翅_甲2;
    				f.ConnectionType = ConnectionInfo.前翅_甲_軸3_接続;
    				f.接続(前翅_甲2.軸3_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_前翅_前翅軸_軸1CP = new ColorP(X0Y0_前翅_前翅軸_軸1, 前翅_前翅軸_軸1CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅軸_軸2CP = new ColorP(X0Y0_前翅_前翅軸_軸2, 前翅_前翅軸_軸2CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅軸_軸3CP = new ColorP(X0Y0_前翅_前翅軸_軸3, 前翅_前翅軸_軸3CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_甲2CP = new ColorP(X0Y0_前翅_前翅甲_甲2, 前翅_前翅甲_甲2CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_甲1CP = new ColorP(X0Y0_前翅_前翅甲_甲1, 前翅_前翅甲_甲1CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_紋1CP = new ColorP(X0Y0_前翅_前翅甲_紋1, 前翅_前翅甲_紋1CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_紋2CP = new ColorP(X0Y0_前翅_前翅甲_紋2, 前翅_前翅甲_紋2CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_紋3CP = new ColorP(X0Y0_前翅_前翅甲_紋3, 前翅_前翅甲_紋3CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_紋4CP = new ColorP(X0Y0_前翅_前翅甲_紋4, 前翅_前翅甲_紋4CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_紋5CP = new ColorP(X0Y0_前翅_前翅甲_紋5, 前翅_前翅甲_紋5CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_紋6CP = new ColorP(X0Y0_前翅_前翅甲_紋6, 前翅_前翅甲_紋6CD, DisUnit, abj: true);
    		X0Y0_前翅_前翅甲_紋7CP = new ColorP(X0Y0_前翅_前翅甲_紋7, 前翅_前翅甲_紋7CD, DisUnit, abj: true);
    		X0Y0_付根_付根0CP = new ColorP(X0Y0_付根_付根0, 付根_付根0CD, DisUnit, abj: true);
    		X0Y0_付根_付根1CP = new ColorP(X0Y0_付根_付根1, 付根_付根1CD, DisUnit, abj: true);
    		X0Y0_付根_付根2CP = new ColorP(X0Y0_付根_付根2, 付根_付根2CD, DisUnit, abj: true);
    		X0Y0_甲付根CP = new ColorP(X0Y0_甲付根, 甲付根CD, DisUnit, abj: true);
    		X0Y0_紋1CP = new ColorP(X0Y0_紋1, 紋1CD, DisUnit, abj: true);
    		X0Y0_紋2CP = new ColorP(X0Y0_紋2, 紋2CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅軸_軸1CP = new ColorP(X0Y1_前翅_前翅軸_軸1, 前翅_前翅軸_軸1CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅軸_軸2CP = new ColorP(X0Y1_前翅_前翅軸_軸2, 前翅_前翅軸_軸2CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅軸_軸3CP = new ColorP(X0Y1_前翅_前翅軸_軸3, 前翅_前翅軸_軸3CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅軸_罅線CP = new ColorP(X0Y1_前翅_前翅軸_罅線, 前翅_前翅軸_罅線CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_甲2CP = new ColorP(X0Y1_前翅_前翅甲_甲2, 前翅_前翅甲_甲2CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_甲1CP = new ColorP(X0Y1_前翅_前翅甲_甲1, 前翅_前翅甲_甲1CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_紋1CP = new ColorP(X0Y1_前翅_前翅甲_紋1, 前翅_前翅甲_紋1CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_紋2CP = new ColorP(X0Y1_前翅_前翅甲_紋2, 前翅_前翅甲_紋2CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_紋3CP = new ColorP(X0Y1_前翅_前翅甲_紋3, 前翅_前翅甲_紋3CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_紋4CP = new ColorP(X0Y1_前翅_前翅甲_紋4, 前翅_前翅甲_紋4CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_紋5CP = new ColorP(X0Y1_前翅_前翅甲_紋5, 前翅_前翅甲_紋5CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_紋6CP = new ColorP(X0Y1_前翅_前翅甲_紋6, 前翅_前翅甲_紋6CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_紋7CP = new ColorP(X0Y1_前翅_前翅甲_紋7, 前翅_前翅甲_紋7CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_罅線1CP = new ColorP(X0Y1_前翅_前翅甲_罅線1, 前翅_前翅甲_罅線1CD, DisUnit, abj: true);
    		X0Y1_前翅_前翅甲_罅線2CP = new ColorP(X0Y1_前翅_前翅甲_罅線2, 前翅_前翅甲_罅線2CD, DisUnit, abj: true);
    		X0Y1_付根_付根0CP = new ColorP(X0Y1_付根_付根0, 付根_付根0CD, DisUnit, abj: true);
    		X0Y1_付根_付根1CP = new ColorP(X0Y1_付根_付根1, 付根_付根1CD, DisUnit, abj: true);
    		X0Y1_付根_付根2CP = new ColorP(X0Y1_付根_付根2, 付根_付根2CD, DisUnit, abj: true);
    		X0Y1_甲付根CP = new ColorP(X0Y1_甲付根, 甲付根CD, DisUnit, abj: true);
    		X0Y1_紋1CP = new ColorP(X0Y1_紋1, 紋1CD, DisUnit, abj: true);
    		X0Y1_紋2CP = new ColorP(X0Y1_紋2, 紋2CD, DisUnit, abj: true);
    		X0Y1_欠け1CP = new ColorP(X0Y1_欠け1, 欠け1CD, DisUnit, abj: true);
    		X0Y1_欠け2CP = new ColorP(X0Y1_欠け2, 欠け2CD, DisUnit, abj: true);
    		X0Y1_欠け3CP = new ColorP(X0Y1_欠け3, 欠け3CD, DisUnit, abj: true);
    		Intensity = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_付根_付根0.AngleBase = num * 21.0;
    		X0Y1_付根_付根0.AngleBase = num * 21.0;
    		X0Y0_前翅_前翅軸_軸1.AngleBase = num * 18.0;
    		X0Y1_前翅_前翅軸_軸1.AngleBase = num * 18.0;
    		X0Y0_前翅_前翅軸_軸2.AngleBase = num * -24.0;
    		X0Y1_前翅_前翅軸_軸2.AngleBase = num * -24.0;
    		X0Y0_前翅_前翅軸_軸3.AngleBase = num * 13.0;
    		X0Y1_前翅_前翅軸_軸3.AngleBase = num * 13.0;
    		X0Y0_前翅_前翅甲_甲1.AngleBase = num * -4.0;
    		X0Y1_前翅_前翅甲_甲1.AngleBase = num * -4.0;
    		X0Y0_甲付根.AngleBase = num * 5.0;
    		X0Y1_甲付根.AngleBase = num * 5.0;
    		Body.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_前翅_前翅軸_軸1CP.Update();
    			X0Y0_前翅_前翅軸_軸2CP.Update();
    			X0Y0_前翅_前翅軸_軸3CP.Update();
    			X0Y0_前翅_前翅甲_甲2CP.Update();
    			X0Y0_前翅_前翅甲_甲1CP.Update();
    			X0Y0_前翅_前翅甲_紋1CP.Update();
    			X0Y0_前翅_前翅甲_紋2CP.Update();
    			X0Y0_前翅_前翅甲_紋3CP.Update();
    			X0Y0_前翅_前翅甲_紋4CP.Update();
    			X0Y0_前翅_前翅甲_紋5CP.Update();
    			X0Y0_前翅_前翅甲_紋6CP.Update();
    			X0Y0_前翅_前翅甲_紋7CP.Update();
    			X0Y0_付根_付根0CP.Update();
    			X0Y0_付根_付根1CP.Update();
    			X0Y0_付根_付根2CP.Update();
    			X0Y0_甲付根CP.Update();
    			X0Y0_紋1CP.Update();
    			X0Y0_紋2CP.Update();
    		}
    		else
    		{
    			X0Y1_前翅_前翅軸_軸1CP.Update();
    			X0Y1_前翅_前翅軸_軸2CP.Update();
    			X0Y1_前翅_前翅軸_軸3CP.Update();
    			X0Y1_前翅_前翅軸_罅線CP.Update();
    			X0Y1_前翅_前翅甲_甲2CP.Update();
    			X0Y1_前翅_前翅甲_甲1CP.Update();
    			X0Y1_前翅_前翅甲_紋1CP.Update();
    			X0Y1_前翅_前翅甲_紋2CP.Update();
    			X0Y1_前翅_前翅甲_紋3CP.Update();
    			X0Y1_前翅_前翅甲_紋4CP.Update();
    			X0Y1_前翅_前翅甲_紋5CP.Update();
    			X0Y1_前翅_前翅甲_紋6CP.Update();
    			X0Y1_前翅_前翅甲_紋7CP.Update();
    			X0Y1_前翅_前翅甲_罅線1CP.Update();
    			X0Y1_前翅_前翅甲_罅線2CP.Update();
    			X0Y1_付根_付根0CP.Update();
    			X0Y1_付根_付根1CP.Update();
    			X0Y1_付根_付根2CP.Update();
    			X0Y1_甲付根CP.Update();
    			X0Y1_紋1CP.Update();
    			X0Y1_紋2CP.Update();
    			X0Y1_欠け1CP.Update();
    			X0Y1_欠け2CP.Update();
    			X0Y1_欠け3CP.Update();
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		前翅_前翅軸_軸1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		前翅_前翅軸_軸2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		前翅_前翅軸_軸3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		前翅_前翅軸_罅線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_前翅甲_甲2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		前翅_前翅甲_甲1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		前翅_前翅甲_紋1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		前翅_前翅甲_紋2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		前翅_前翅甲_紋3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		前翅_前翅甲_紋4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		前翅_前翅甲_紋5CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		前翅_前翅甲_紋6CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		前翅_前翅甲_紋7CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		前翅_前翅甲_罅線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		前翅_前翅甲_罅線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
    		付根_付根0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		付根_付根1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		付根_付根2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		甲付根CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		紋1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		紋2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		欠け1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		欠け2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		欠け3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    	}
    }
}
