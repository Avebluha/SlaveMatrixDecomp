using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 長物_鯨 : 半身
    {
    	public Par X0Y0_胴6_胴;

    	public Par X0Y0_胴6_柄;

    	public Par X0Y0_胴6_縦影;

    	public Par X0Y0_胴5_胴;

    	public Par X0Y0_胴5_柄;

    	public Par X0Y0_胴5_縦影;

    	public Par X0Y0_輪2_革;

    	public Par X0Y0_輪2_金具1;

    	public Par X0Y0_輪2_金具2;

    	public Par X0Y0_輪2_金具3;

    	public Par X0Y0_輪2_金具左;

    	public Par X0Y0_輪2_金具右;

    	public Par X0Y0_胴4_胴;

    	public Par X0Y0_胴4_柄;

    	public Par X0Y0_胴4_縦影;

    	public Par X0Y0_胴3_胴;

    	public Par X0Y0_胴3_柄;

    	public Par X0Y0_胴3_縦影;

    	public Par X0Y0_胴2_胴;

    	public Par X0Y0_胴2_柄;

    	public Par X0Y0_胴2_縦影;

    	public Par X0Y0_胴1_胴;

    	public Par X0Y0_胴1_柄;

    	public Par X0Y0_胴1_縦影;

    	public Par X0Y0_輪1_革;

    	public Par X0Y0_輪1_金具1;

    	public Par X0Y0_輪1_金具2;

    	public Par X0Y0_輪1_金具3;

    	public Par X0Y0_輪1_金具左;

    	public Par X0Y0_輪1_金具右;

    	public ColorD 胴6_胴CD;

    	public ColorD 胴6_柄CD;

    	public ColorD 胴6_縦影CD;

    	public ColorD 胴5_胴CD;

    	public ColorD 胴5_柄CD;

    	public ColorD 胴5_縦影CD;

    	public ColorD 胴4_胴CD;

    	public ColorD 胴4_柄CD;

    	public ColorD 胴4_縦影CD;

    	public ColorD 胴3_胴CD;

    	public ColorD 胴3_柄CD;

    	public ColorD 胴3_縦影CD;

    	public ColorD 胴2_胴CD;

    	public ColorD 胴2_柄CD;

    	public ColorD 胴2_縦影CD;

    	public ColorD 胴1_胴CD;

    	public ColorD 胴1_柄CD;

    	public ColorD 胴1_縦影CD;

    	public ColorD 輪1_革CD;

    	public ColorD 輪1_金具1CD;

    	public ColorD 輪1_金具2CD;

    	public ColorD 輪1_金具3CD;

    	public ColorD 輪1_金具左CD;

    	public ColorD 輪1_金具右CD;

    	public ColorD 輪2_革CD;

    	public ColorD 輪2_金具1CD;

    	public ColorD 輪2_金具2CD;

    	public ColorD 輪2_金具3CD;

    	public ColorD 輪2_金具左CD;

    	public ColorD 輪2_金具右CD;

    	public ColorP X0Y0_胴6_胴CP;

    	public ColorP X0Y0_胴6_柄CP;

    	public ColorP X0Y0_胴6_縦影CP;

    	public ColorP X0Y0_胴5_胴CP;

    	public ColorP X0Y0_胴5_柄CP;

    	public ColorP X0Y0_胴5_縦影CP;

    	public ColorP X0Y0_輪2_革CP;

    	public ColorP X0Y0_輪2_金具1CP;

    	public ColorP X0Y0_輪2_金具2CP;

    	public ColorP X0Y0_輪2_金具3CP;

    	public ColorP X0Y0_輪2_金具左CP;

    	public ColorP X0Y0_輪2_金具右CP;

    	public ColorP X0Y0_胴4_胴CP;

    	public ColorP X0Y0_胴4_柄CP;

    	public ColorP X0Y0_胴4_縦影CP;

    	public ColorP X0Y0_胴3_胴CP;

    	public ColorP X0Y0_胴3_柄CP;

    	public ColorP X0Y0_胴3_縦影CP;

    	public ColorP X0Y0_胴2_胴CP;

    	public ColorP X0Y0_胴2_柄CP;

    	public ColorP X0Y0_胴2_縦影CP;

    	public ColorP X0Y0_胴1_胴CP;

    	public ColorP X0Y0_胴1_柄CP;

    	public ColorP X0Y0_胴1_縦影CP;

    	public ColorP X0Y0_輪1_革CP;

    	public ColorP X0Y0_輪1_金具1CP;

    	public ColorP X0Y0_輪1_金具2CP;

    	public ColorP X0Y0_輪1_金具3CP;

    	public ColorP X0Y0_輪1_金具左CP;

    	public ColorP X0Y0_輪1_金具右CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

    	public 拘束鎖 鎖3;

    	public 拘束鎖 鎖4;

    	public Ele[] 左0_接続;

    	public Ele[] 右0_接続;

    	public Ele[] 左1_接続;

    	public Ele[] 右1_接続;

    	public Ele[] 左2_接続;

    	public Ele[] 右2_接続;

    	public Ele[] 左3_接続;

    	public Ele[] 右3_接続;

    	public Ele[] 左4_接続;

    	public Ele[] 右4_接続;

    	public Ele[] 左5_接続;

    	public Ele[] 右5_接続;

    	public Ele[] 左6_接続;

    	public Ele[] 右6_接続;

    	public Ele[] 尾_接続;

    	private Par[] Pars;

    	private Vector2D[] mm;

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
    			輪1表示 = value;
    			輪2表示 = value;
    		}
    	}

    	public bool 胴6_表示
    	{
    		get
    		{
    			return X0Y0_胴6_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴6_胴.Dra = value;
    			X0Y0_胴6_胴.Hit = value;
    		}
    	}

    	public bool 胴6_柄_表示
    	{
    		get
    		{
    			return X0Y0_胴6_柄.Dra;
    		}
    		set
    		{
    			X0Y0_胴6_柄.Dra = value;
    			X0Y0_胴6_柄.Hit = value;
    		}
    	}

    	public bool 胴6_縦影_表示
    	{
    		get
    		{
    			return X0Y0_胴6_縦影.Dra;
    		}
    		set
    		{
    			X0Y0_胴6_縦影.Dra = value;
    			X0Y0_胴6_縦影.Hit = value;
    		}
    	}

    	public bool 胴5_表示
    	{
    		get
    		{
    			return X0Y0_胴5_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴5_胴.Dra = value;
    			X0Y0_胴5_胴.Hit = value;
    		}
    	}

    	public bool 胴5_柄_表示
    	{
    		get
    		{
    			return X0Y0_胴5_柄.Dra;
    		}
    		set
    		{
    			X0Y0_胴5_柄.Dra = value;
    			X0Y0_胴5_柄.Hit = value;
    		}
    	}

    	public bool 胴5_縦影_表示
    	{
    		get
    		{
    			return X0Y0_胴5_縦影.Dra;
    		}
    		set
    		{
    			X0Y0_胴5_縦影.Dra = value;
    			X0Y0_胴5_縦影.Hit = value;
    		}
    	}

    	public bool 輪2_革_表示
    	{
    		get
    		{
    			return X0Y0_輪2_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_革.Dra = value;
    			X0Y0_輪2_革.Hit = value;
    		}
    	}

    	public bool 輪2_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具1.Dra = value;
    			X0Y0_輪2_金具1.Hit = value;
    		}
    	}

    	public bool 輪2_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具2.Dra = value;
    			X0Y0_輪2_金具2.Hit = value;
    		}
    	}

    	public bool 輪2_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具3.Dra = value;
    			X0Y0_輪2_金具3.Hit = value;
    		}
    	}

    	public bool 輪2_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具左.Dra = value;
    			X0Y0_輪2_金具左.Hit = value;
    		}
    	}

    	public bool 輪2_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具右.Dra = value;
    			X0Y0_輪2_金具右.Hit = value;
    		}
    	}

    	public bool 胴4_表示
    	{
    		get
    		{
    			return X0Y0_胴4_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴4_胴.Dra = value;
    			X0Y0_胴4_胴.Hit = value;
    		}
    	}

    	public bool 胴4_柄_表示
    	{
    		get
    		{
    			return X0Y0_胴4_柄.Dra;
    		}
    		set
    		{
    			X0Y0_胴4_柄.Dra = value;
    			X0Y0_胴4_柄.Hit = value;
    		}
    	}

    	public bool 胴4_縦影_表示
    	{
    		get
    		{
    			return X0Y0_胴4_縦影.Dra;
    		}
    		set
    		{
    			X0Y0_胴4_縦影.Dra = value;
    			X0Y0_胴4_縦影.Hit = value;
    		}
    	}

    	public bool 胴3_表示
    	{
    		get
    		{
    			return X0Y0_胴3_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴3_胴.Dra = value;
    			X0Y0_胴3_胴.Hit = value;
    		}
    	}

    	public bool 胴3_柄_表示
    	{
    		get
    		{
    			return X0Y0_胴3_柄.Dra;
    		}
    		set
    		{
    			X0Y0_胴3_柄.Dra = value;
    			X0Y0_胴3_柄.Hit = value;
    		}
    	}

    	public bool 胴3_縦影_表示
    	{
    		get
    		{
    			return X0Y0_胴3_縦影.Dra;
    		}
    		set
    		{
    			X0Y0_胴3_縦影.Dra = value;
    			X0Y0_胴3_縦影.Hit = value;
    		}
    	}

    	public bool 胴2_表示
    	{
    		get
    		{
    			return X0Y0_胴2_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴2_胴.Dra = value;
    			X0Y0_胴2_胴.Hit = value;
    		}
    	}

    	public bool 胴2_柄_表示
    	{
    		get
    		{
    			return X0Y0_胴2_柄.Dra;
    		}
    		set
    		{
    			X0Y0_胴2_柄.Dra = value;
    			X0Y0_胴2_柄.Hit = value;
    		}
    	}

    	public bool 胴2_縦影_表示
    	{
    		get
    		{
    			return X0Y0_胴2_縦影.Dra;
    		}
    		set
    		{
    			X0Y0_胴2_縦影.Dra = value;
    			X0Y0_胴2_縦影.Hit = value;
    		}
    	}

    	public bool 胴1_表示
    	{
    		get
    		{
    			return X0Y0_胴1_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴1_胴.Dra = value;
    			X0Y0_胴1_胴.Hit = value;
    		}
    	}

    	public bool 胴1_柄_表示
    	{
    		get
    		{
    			return X0Y0_胴1_柄.Dra;
    		}
    		set
    		{
    			X0Y0_胴1_柄.Dra = value;
    			X0Y0_胴1_柄.Hit = value;
    		}
    	}

    	public bool 胴1_縦影_表示
    	{
    		get
    		{
    			return X0Y0_胴1_縦影.Dra;
    		}
    		set
    		{
    			X0Y0_胴1_縦影.Dra = value;
    			X0Y0_胴1_縦影.Hit = value;
    		}
    	}

    	public bool 輪1_革_表示
    	{
    		get
    		{
    			return X0Y0_輪1_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_革.Dra = value;
    			X0Y0_輪1_革.Hit = value;
    		}
    	}

    	public bool 輪1_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具1.Dra = value;
    			X0Y0_輪1_金具1.Hit = value;
    		}
    	}

    	public bool 輪1_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具2.Dra = value;
    			X0Y0_輪1_金具2.Hit = value;
    		}
    	}

    	public bool 輪1_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具3.Dra = value;
    			X0Y0_輪1_金具3.Hit = value;
    		}
    	}

    	public bool 輪1_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具左.Dra = value;
    			X0Y0_輪1_金具左.Hit = value;
    		}
    	}

    	public bool 輪1_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具右.Dra = value;
    			X0Y0_輪1_金具右.Hit = value;
    		}
    	}

    	public bool 輪1表示
    	{
    		get
    		{
    			return 輪1_革_表示;
    		}
    		set
    		{
    			輪1_革_表示 = value;
    			輪1_金具1_表示 = value;
    			輪1_金具2_表示 = value;
    			輪1_金具3_表示 = value;
    			輪1_金具左_表示 = value;
    			輪1_金具右_表示 = value;
    		}
    	}

    	public bool 輪2表示
    	{
    		get
    		{
    			return 輪2_革_表示;
    		}
    		set
    		{
    			輪2_革_表示 = value;
    			輪2_金具1_表示 = value;
    			輪2_金具2_表示 = value;
    			輪2_金具3_表示 = value;
    			輪2_金具左_表示 = value;
    			輪2_金具右_表示 = value;
    		}
    	}

    	public bool 鎖表示
    	{
    		get
    		{
    			return 鎖1.表示;
    		}
    		set
    		{
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    			鎖3.表示 = value;
    			鎖4.表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 胴6_表示;
    		}
    		set
    		{
    			胴6_表示 = value;
    			胴6_柄_表示 = value;
    			胴6_縦影_表示 = value;
    			胴5_表示 = value;
    			胴5_柄_表示 = value;
    			胴5_縦影_表示 = value;
    			輪2_革_表示 = value;
    			輪2_金具1_表示 = value;
    			輪2_金具2_表示 = value;
    			輪2_金具3_表示 = value;
    			輪2_金具左_表示 = value;
    			輪2_金具右_表示 = value;
    			胴4_表示 = value;
    			胴4_柄_表示 = value;
    			胴4_縦影_表示 = value;
    			胴3_表示 = value;
    			胴3_柄_表示 = value;
    			胴3_縦影_表示 = value;
    			胴2_表示 = value;
    			胴2_柄_表示 = value;
    			胴2_縦影_表示 = value;
    			胴1_表示 = value;
    			胴1_柄_表示 = value;
    			胴1_縦影_表示 = value;
    			輪1_革_表示 = value;
    			輪1_金具1_表示 = value;
    			輪1_金具2_表示 = value;
    			輪1_金具3_表示 = value;
    			輪1_金具左_表示 = value;
    			輪1_金具右_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    			鎖3.表示 = value;
    			鎖4.表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 胴6_胴CD.不透明度;
    		}
    		set
    		{
    			胴6_胴CD.不透明度 = value;
    			胴6_柄CD.不透明度 = value;
    			胴6_縦影CD.不透明度 = value;
    			胴5_胴CD.不透明度 = value;
    			胴5_柄CD.不透明度 = value;
    			胴5_縦影CD.不透明度 = value;
    			胴4_胴CD.不透明度 = value;
    			胴4_柄CD.不透明度 = value;
    			胴4_縦影CD.不透明度 = value;
    			胴3_胴CD.不透明度 = value;
    			胴3_柄CD.不透明度 = value;
    			胴3_縦影CD.不透明度 = value;
    			胴2_胴CD.不透明度 = value;
    			胴2_柄CD.不透明度 = value;
    			胴2_縦影CD.不透明度 = value;
    			胴1_胴CD.不透明度 = value;
    			胴1_柄CD.不透明度 = value;
    			胴1_縦影CD.不透明度 = value;
    			輪1_革CD.不透明度 = value;
    			輪1_金具1CD.不透明度 = value;
    			輪1_金具2CD.不透明度 = value;
    			輪1_金具3CD.不透明度 = value;
    			輪1_金具左CD.不透明度 = value;
    			輪1_金具右CD.不透明度 = value;
    			輪2_革CD.不透明度 = value;
    			輪2_金具1CD.不透明度 = value;
    			輪2_金具2CD.不透明度 = value;
    			輪2_金具3CD.不透明度 = value;
    			輪2_金具左CD.不透明度 = value;
    			輪2_金具右CD.不透明度 = value;
    		}
    	}

    	public bool 柄
    	{
    		get
    		{
    			return 胴6_柄_表示;
    		}
    		set
    		{
    			胴6_柄_表示 = value;
    			胴5_柄_表示 = value;
    			胴4_柄_表示 = value;
    			胴3_柄_表示 = value;
    			胴2_柄_表示 = value;
    			胴1_柄_表示 = value;
    		}
    	}

    	public bool 縦影
    	{
    		get
    		{
    			return 胴6_縦影_表示;
    		}
    		set
    		{
    			胴6_縦影_表示 = value;
    			胴5_縦影_表示 = value;
    			胴4_縦影_表示 = value;
    			胴3_縦影_表示 = value;
    			胴2_縦影_表示 = value;
    			胴1_縦影_表示 = value;
    		}
    	}

    	public override double サイズY
    	{
    		get
    		{
    			return サイズY_;
    		}
    		set
    		{
    			サイズY_ = value;
    		}
    	}

    	public JointS 左0_接続点 => new JointS(本体, X0Y0_胴1_胴, 4);

    	public JointS 右0_接続点 => new JointS(本体, X0Y0_胴1_胴, 5);

    	public JointS 左1_接続点 => new JointS(本体, X0Y0_胴1_胴, 2);

    	public JointS 右1_接続点 => new JointS(本体, X0Y0_胴1_胴, 3);

    	public JointS 左2_接続点 => new JointS(本体, X0Y0_胴2_胴, 2);

    	public JointS 右2_接続点 => new JointS(本体, X0Y0_胴2_胴, 3);

    	public JointS 左3_接続点 => new JointS(本体, X0Y0_胴3_胴, 2);

    	public JointS 右3_接続点 => new JointS(本体, X0Y0_胴3_胴, 3);

    	public JointS 左4_接続点 => new JointS(本体, X0Y0_胴4_胴, 2);

    	public JointS 右4_接続点 => new JointS(本体, X0Y0_胴4_胴, 3);

    	public JointS 左5_接続点 => new JointS(本体, X0Y0_胴5_胴, 2);

    	public JointS 右5_接続点 => new JointS(本体, X0Y0_胴5_胴, 3);

    	public JointS 左6_接続点 => new JointS(本体, X0Y0_胴6_胴, 2);

    	public JointS 右6_接続点 => new JointS(本体, X0Y0_胴6_胴, 3);

    	public JointS 尾_接続点 => new JointS(本体, X0Y0_胴6_胴, 1);

    	public JointS 鎖1_接続点 => new JointS(本体, X0Y0_輪1_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(本体, X0Y0_輪1_金具右, 0);

    	public JointS 鎖3_接続点 => new JointS(本体, X0Y0_輪2_金具左, 0);

    	public JointS 鎖4_接続点 => new JointS(本体, X0Y0_輪2_金具右, 0);

    	public 長物_鯨(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 長物_鯨D e)
    	{
    		長物_鯨 長物_鯨2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "鯨";
    		dif.Add(new Pars(Sta.半身["長物"][0][1]));
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		Pars pars2 = pars["胴6"].ToPars();
    		X0Y0_胴6_胴 = pars2["胴"].ToPar();
    		X0Y0_胴6_柄 = pars2["柄"].ToPar();
    		X0Y0_胴6_縦影 = pars2["縦影"].ToPar();
    		pars2 = pars["胴5"].ToPars();
    		X0Y0_胴5_胴 = pars2["Torso"].ToPar();
    		X0Y0_胴5_柄 = pars2["柄"].ToPar();
    		X0Y0_胴5_縦影 = pars2["縦影"].ToPar();
    		pars2 = pars["輪2"].ToPars();
    		X0Y0_輪2_革 = pars2["革"].ToPar();
    		X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
    		pars2 = pars["胴4"].ToPars();
    		X0Y0_胴4_胴 = pars2["胴"].ToPar();
    		X0Y0_胴4_柄 = pars2["柄"].ToPar();
    		X0Y0_胴4_縦影 = pars2["縦影"].ToPar();
    		pars2 = pars["胴3"].ToPars();
    		X0Y0_胴3_胴 = pars2["胴"].ToPar();
    		X0Y0_胴3_柄 = pars2["柄"].ToPar();
    		X0Y0_胴3_縦影 = pars2["縦影"].ToPar();
    		pars2 = pars["胴2"].ToPars();
    		X0Y0_胴2_胴 = pars2["胴"].ToPar();
    		X0Y0_胴2_柄 = pars2["柄"].ToPar();
    		X0Y0_胴2_縦影 = pars2["縦影"].ToPar();
    		pars2 = pars["胴1"].ToPars();
    		X0Y0_胴1_胴 = pars2["胴"].ToPar();
    		X0Y0_胴1_柄 = pars2["柄"].ToPar();
    		X0Y0_胴1_縦影 = pars2["縦影"].ToPar();
    		pars2 = pars["輪1"].ToPars();
    		X0Y0_輪1_革 = pars2["革"].ToPar();
    		X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
    		本体.SetJoints();
    		接続根 = new JointD(本体);
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
    		胴6_表示 = e.胴6_表示;
    		胴6_柄_表示 = e.胴6_柄_表示;
    		胴6_縦影_表示 = e.胴6_縦影_表示;
    		胴5_表示 = e.胴5_表示;
    		胴5_柄_表示 = e.胴5_柄_表示;
    		胴5_縦影_表示 = e.胴5_縦影_表示;
    		輪2_革_表示 = e.輪2_革_表示;
    		輪2_金具1_表示 = e.輪2_金具1_表示;
    		輪2_金具2_表示 = e.輪2_金具2_表示;
    		輪2_金具3_表示 = e.輪2_金具3_表示;
    		輪2_金具左_表示 = e.輪2_金具左_表示;
    		輪2_金具右_表示 = e.輪2_金具右_表示;
    		胴4_表示 = e.胴4_表示;
    		胴4_柄_表示 = e.胴4_柄_表示;
    		胴4_縦影_表示 = e.胴4_縦影_表示;
    		胴3_表示 = e.胴3_表示;
    		胴3_柄_表示 = e.胴3_柄_表示;
    		胴3_縦影_表示 = e.胴3_縦影_表示;
    		胴2_表示 = e.胴2_表示;
    		胴2_柄_表示 = e.胴2_柄_表示;
    		胴2_縦影_表示 = e.胴2_縦影_表示;
    		胴1_表示 = e.胴1_表示;
    		胴1_柄_表示 = e.胴1_柄_表示;
    		胴1_縦影_表示 = e.胴1_縦影_表示;
    		輪1_革_表示 = e.輪1_革_表示;
    		輪1_金具1_表示 = e.輪1_金具1_表示;
    		輪1_金具2_表示 = e.輪1_金具2_表示;
    		輪1_金具3_表示 = e.輪1_金具3_表示;
    		輪1_金具左_表示 = e.輪1_金具左_表示;
    		輪1_金具右_表示 = e.輪1_金具右_表示;
    		輪1表示 = e.輪1表示;
    		輪2表示 = e.輪2表示;
    		柄 = e.柄;
    		縦影 = e.縦影;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.左0_接続.Count > 0)
    		{
    			左0_接続 = e.左0_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_左0_接続;
    				f.接続(長物_鯨2.左0_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右0_接続.Count > 0)
    		{
    			右0_接続 = e.右0_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_右0_接続;
    				f.接続(長物_鯨2.右0_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左1_接続.Count > 0)
    		{
    			左1_接続 = e.左1_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_左1_接続;
    				f.接続(長物_鯨2.左1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右1_接続.Count > 0)
    		{
    			右1_接続 = e.右1_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_右1_接続;
    				f.接続(長物_鯨2.右1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左2_接続.Count > 0)
    		{
    			左2_接続 = e.左2_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_左2_接続;
    				f.接続(長物_鯨2.左2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右2_接続.Count > 0)
    		{
    			右2_接続 = e.右2_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_右2_接続;
    				f.接続(長物_鯨2.右2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左3_接続.Count > 0)
    		{
    			左3_接続 = e.左3_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_左3_接続;
    				f.接続(長物_鯨2.左3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右3_接続.Count > 0)
    		{
    			右3_接続 = e.右3_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_右3_接続;
    				f.接続(長物_鯨2.右3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左4_接続.Count > 0)
    		{
    			左4_接続 = e.左4_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_左4_接続;
    				f.接続(長物_鯨2.左4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右4_接続.Count > 0)
    		{
    			右4_接続 = e.右4_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_右4_接続;
    				f.接続(長物_鯨2.右4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左5_接続.Count > 0)
    		{
    			左5_接続 = e.左5_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_左5_接続;
    				f.接続(長物_鯨2.左5_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右5_接続.Count > 0)
    		{
    			右5_接続 = e.右5_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_右5_接続;
    				f.接続(長物_鯨2.右5_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.左6_接続.Count > 0)
    		{
    			左6_接続 = e.左6_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_左6_接続;
    				f.接続(長物_鯨2.左6_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.右6_接続.Count > 0)
    		{
    			右6_接続 = e.右6_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_右6_接続;
    				f.接続(長物_鯨2.右6_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.尾_接続.Count > 0)
    		{
    			尾_接続 = e.尾_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 長物_鯨2;
    				f.ConnectionType = ConnectionInfo.長物_鯨_尾_接続;
    				f.接続(長物_鯨2.尾_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new Par[6] { X0Y0_胴6_胴, X0Y0_胴5_胴, X0Y0_胴4_胴, X0Y0_胴3_胴, X0Y0_胴2_胴, X0Y0_胴1_胴 };
    		X0Y0_胴6_胴CP = new ColorP(X0Y0_胴6_胴, 胴6_胴CD, DisUnit, abj: true);
    		X0Y0_胴6_柄CP = new ColorP(X0Y0_胴6_柄, 胴6_柄CD, DisUnit, abj: true);
    		X0Y0_胴6_縦影CP = new ColorP(X0Y0_胴6_縦影, 胴6_縦影CD, DisUnit, abj: true);
    		X0Y0_胴5_胴CP = new ColorP(X0Y0_胴5_胴, 胴5_胴CD, DisUnit, abj: true);
    		X0Y0_胴5_柄CP = new ColorP(X0Y0_胴5_柄, 胴5_柄CD, DisUnit, abj: true);
    		X0Y0_胴5_縦影CP = new ColorP(X0Y0_胴5_縦影, 胴5_縦影CD, DisUnit, abj: true);
    		X0Y0_輪2_革CP = new ColorP(X0Y0_輪2_革, 輪2_革CD, DisUnit, abj: true);
    		X0Y0_輪2_金具1CP = new ColorP(X0Y0_輪2_金具1, 輪2_金具1CD, DisUnit, abj: true);
    		X0Y0_輪2_金具2CP = new ColorP(X0Y0_輪2_金具2, 輪2_金具2CD, DisUnit, abj: true);
    		X0Y0_輪2_金具3CP = new ColorP(X0Y0_輪2_金具3, 輪2_金具3CD, DisUnit, abj: true);
    		X0Y0_輪2_金具左CP = new ColorP(X0Y0_輪2_金具左, 輪2_金具左CD, DisUnit, abj: true);
    		X0Y0_輪2_金具右CP = new ColorP(X0Y0_輪2_金具右, 輪2_金具右CD, DisUnit, abj: true);
    		X0Y0_胴4_胴CP = new ColorP(X0Y0_胴4_胴, 胴4_胴CD, DisUnit, abj: true);
    		X0Y0_胴4_柄CP = new ColorP(X0Y0_胴4_柄, 胴4_柄CD, DisUnit, abj: true);
    		X0Y0_胴4_縦影CP = new ColorP(X0Y0_胴4_縦影, 胴4_縦影CD, DisUnit, abj: true);
    		X0Y0_胴3_胴CP = new ColorP(X0Y0_胴3_胴, 胴3_胴CD, DisUnit, abj: true);
    		X0Y0_胴3_柄CP = new ColorP(X0Y0_胴3_柄, 胴3_柄CD, DisUnit, abj: true);
    		X0Y0_胴3_縦影CP = new ColorP(X0Y0_胴3_縦影, 胴3_縦影CD, DisUnit, abj: true);
    		X0Y0_胴2_胴CP = new ColorP(X0Y0_胴2_胴, 胴2_胴CD, DisUnit, abj: true);
    		X0Y0_胴2_柄CP = new ColorP(X0Y0_胴2_柄, 胴2_柄CD, DisUnit, abj: true);
    		X0Y0_胴2_縦影CP = new ColorP(X0Y0_胴2_縦影, 胴2_縦影CD, DisUnit, abj: true);
    		X0Y0_胴1_胴CP = new ColorP(X0Y0_胴1_胴, 胴1_胴CD, DisUnit, abj: true);
    		X0Y0_胴1_柄CP = new ColorP(X0Y0_胴1_柄, 胴1_柄CD, DisUnit, abj: true);
    		X0Y0_胴1_縦影CP = new ColorP(X0Y0_胴1_縦影, 胴1_縦影CD, DisUnit, abj: true);
    		X0Y0_輪1_革CP = new ColorP(X0Y0_輪1_革, 輪1_革CD, DisUnit, abj: true);
    		X0Y0_輪1_金具1CP = new ColorP(X0Y0_輪1_金具1, 輪1_金具1CD, DisUnit, abj: true);
    		X0Y0_輪1_金具2CP = new ColorP(X0Y0_輪1_金具2, 輪1_金具2CD, DisUnit, abj: true);
    		X0Y0_輪1_金具3CP = new ColorP(X0Y0_輪1_金具3, 輪1_金具3CD, DisUnit, abj: true);
    		X0Y0_輪1_金具左CP = new ColorP(X0Y0_輪1_金具左, 輪1_金具左CD, DisUnit, abj: true);
    		X0Y0_輪1_金具右CP = new ColorP(X0Y0_輪1_金具右, 輪1_金具右CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖3 = new 拘束鎖(DisUnit, 右, 配色指定, 体配色, Xasix);
    		鎖4 = new 拘束鎖(DisUnit, !右, 配色指定, 体配色, Xasix);
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		鎖3.接続(鎖3_接続点);
    		鎖4.接続(鎖4_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B += num;
    		鎖2.角度B -= num;
    		鎖3.角度B += num;
    		鎖4.角度B -= num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(RenderArea Are)
    	{
    		Are.Draw(X0Y0_胴6_胴);
    		Are.Draw(X0Y0_胴6_柄);
    		Are.Draw(X0Y0_胴6_縦影);
    		Are.Draw(X0Y0_胴5_胴);
    		Are.Draw(X0Y0_胴5_柄);
    		Are.Draw(X0Y0_胴5_縦影);
    		Are.Draw(X0Y0_胴4_胴);
    		Are.Draw(X0Y0_胴4_柄);
    		Are.Draw(X0Y0_胴4_縦影);
    		Are.Draw(X0Y0_胴3_胴);
    		Are.Draw(X0Y0_胴3_柄);
    		Are.Draw(X0Y0_胴3_縦影);
    		Are.Draw(X0Y0_胴2_胴);
    		Are.Draw(X0Y0_胴2_柄);
    		Are.Draw(X0Y0_胴2_縦影);
    		Are.Draw(X0Y0_胴1_胴);
    		Are.Draw(X0Y0_胴1_柄);
    		Are.Draw(X0Y0_胴1_縦影);
    		Are.Draw(X0Y0_輪1_革);
    		Are.Draw(X0Y0_輪1_金具1);
    		Are.Draw(X0Y0_輪1_金具2);
    		Are.Draw(X0Y0_輪1_金具3);
    		Are.Draw(X0Y0_輪1_金具左);
    		Are.Draw(X0Y0_輪1_金具右);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    		鎖3.Dispose();
    		鎖4.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		double maxAngle = 25.0;
    		X0Y0_胴6_胴.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_胴5_胴.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_胴4_胴.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_胴3_胴.AngleBase = maxAngle.GetRanAngle();
    		本体.JoinPAall();
    	}

    	public IEnumerable<Par> 軸列挙()
    	{
    		yield return X0Y0_胴3_胴;
    		yield return X0Y0_胴4_胴;
    		yield return X0Y0_胴5_胴;
    		yield return X0Y0_胴6_胴;
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_輪2_革 && p != X0Y0_輪2_金具1 && p != X0Y0_輪2_金具2 && p != X0Y0_輪2_金具3 && p != X0Y0_輪2_金具左 && p != X0Y0_輪2_金具右 && p != X0Y0_輪1_革 && p != X0Y0_輪1_金具1 && p != X0Y0_輪1_金具2 && p != X0Y0_輪1_金具3 && p != X0Y0_輪1_金具左)
    		{
    			return p == X0Y0_輪1_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		Pars.GetMiY_MaY(out mm);
    		X0Y0_胴6_胴CP.Update(mm);
    		X0Y0_胴6_柄CP.Update(mm);
    		X0Y0_胴6_縦影CP.Update(mm);
    		X0Y0_胴5_胴CP.Update(mm);
    		X0Y0_胴5_柄CP.Update(mm);
    		X0Y0_胴5_縦影CP.Update(mm);
    		X0Y0_輪2_革CP.Update();
    		X0Y0_輪2_金具1CP.Update();
    		X0Y0_輪2_金具2CP.Update();
    		X0Y0_輪2_金具3CP.Update();
    		X0Y0_輪2_金具左CP.Update();
    		X0Y0_輪2_金具右CP.Update();
    		X0Y0_胴4_胴CP.Update(mm);
    		X0Y0_胴4_柄CP.Update(mm);
    		X0Y0_胴4_縦影CP.Update(mm);
    		X0Y0_胴3_胴CP.Update(mm);
    		X0Y0_胴3_柄CP.Update(mm);
    		X0Y0_胴3_縦影CP.Update(mm);
    		X0Y0_胴2_胴CP.Update(mm);
    		X0Y0_胴2_柄CP.Update(mm);
    		X0Y0_胴2_縦影CP.Update(mm);
    		X0Y0_胴1_胴CP.Update(mm);
    		X0Y0_胴1_柄CP.Update(mm);
    		X0Y0_胴1_縦影CP.Update(mm);
    		X0Y0_輪1_革CP.Update();
    		X0Y0_輪1_金具1CP.Update();
    		X0Y0_輪1_金具2CP.Update();
    		X0Y0_輪1_金具3CP.Update();
    		X0Y0_輪1_金具左CP.Update();
    		X0Y0_輪1_金具右CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖3.接続PA();
    		鎖4.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    		鎖3.色更新();
    		鎖4.色更新();
    	}

    	public override void 色更新(Vector2D[] mm)
    	{
    		X0Y0_胴6_胴CP.Update(mm);
    		X0Y0_胴6_柄CP.Update(mm);
    		X0Y0_胴6_縦影CP.Update(mm);
    		X0Y0_胴5_胴CP.Update(mm);
    		X0Y0_胴5_柄CP.Update(mm);
    		X0Y0_胴5_縦影CP.Update(mm);
    		X0Y0_輪2_革CP.Update();
    		X0Y0_輪2_金具1CP.Update();
    		X0Y0_輪2_金具2CP.Update();
    		X0Y0_輪2_金具3CP.Update();
    		X0Y0_輪2_金具左CP.Update();
    		X0Y0_輪2_金具右CP.Update();
    		X0Y0_胴4_胴CP.Update(mm);
    		X0Y0_胴4_柄CP.Update(mm);
    		X0Y0_胴4_縦影CP.Update(mm);
    		X0Y0_胴3_胴CP.Update(mm);
    		X0Y0_胴3_柄CP.Update(mm);
    		X0Y0_胴3_縦影CP.Update(mm);
    		X0Y0_胴2_胴CP.Update(mm);
    		X0Y0_胴2_柄CP.Update(mm);
    		X0Y0_胴2_縦影CP.Update(mm);
    		X0Y0_胴1_胴CP.Update(mm);
    		X0Y0_胴1_柄CP.Update(mm);
    		X0Y0_胴1_縦影CP.Update(mm);
    		X0Y0_輪1_革CP.Update();
    		X0Y0_輪1_金具1CP.Update();
    		X0Y0_輪1_金具2CP.Update();
    		X0Y0_輪1_金具3CP.Update();
    		X0Y0_輪1_金具左CP.Update();
    		X0Y0_輪1_金具右CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖3.接続PA();
    		鎖4.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    		鎖3.色更新();
    		鎖4.色更新();
    	}

    	private void 配色(体配色 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		胴6_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴6_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		Color2 色 = new Color2(ref 体配色.体1O.Col2, ref Col.Empty);
    		胴6_縦影CD = new ColorD(ref Col.Black, ref 色);
    		胴5_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴5_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴5_縦影CD = new ColorD(ref Col.Black, ref 色);
    		胴4_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴4_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴4_縦影CD = new ColorD(ref Col.Black, ref 色);
    		胴3_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴3_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴3_縦影CD = new ColorD(ref Col.Black, ref 色);
    		胴2_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴2_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴2_縦影CD = new ColorD(ref Col.Black, ref 色);
    		胴1_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴1_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴1_縦影CD = new ColorD(ref Col.Black, ref 色);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		胴6_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴6_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴6_縦影CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴5_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴5_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴5_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴4_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴4_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴4_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴3_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴3_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴3_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴2_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴2_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴2_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴1_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴1_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴1_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		胴6_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴6_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴6_縦影CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴5_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴5_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴5_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴4_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴4_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴4_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴3_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴3_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴3_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴2_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴2_柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		胴2_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		胴1_胴CD = new ColorD(ref Col.Black, ref 体配色.体1O);
    		胴1_柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    		胴1_縦影CD = new ColorD(ref Col.Black, ref 胴6_縦影CD.c2);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	public void 輪1配色(拘束具色 配色)
    	{
    		輪1_革CD.色 = 配色.革部色;
    		輪1_金具1CD.色 = 配色.金具色;
    		輪1_金具2CD.色 = 輪1_金具1CD.色;
    		輪1_金具3CD.色 = 輪1_金具1CD.色;
    		輪1_金具左CD.色 = 輪1_金具1CD.色;
    		輪1_金具右CD.色 = 輪1_金具1CD.色;
    	}

    	public void 輪2配色(拘束具色 配色)
    	{
    		輪2_革CD.色 = 配色.革部色;
    		輪2_金具1CD.色 = 配色.金具色;
    		輪2_金具2CD.色 = 輪2_金具1CD.色;
    		輪2_金具3CD.色 = 輪2_金具1CD.色;
    		輪2_金具左CD.色 = 輪2_金具1CD.色;
    		輪2_金具右CD.色 = 輪2_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    		鎖3.配色鎖(配色);
    		鎖4.配色鎖(配色);
    	}
    }
}
