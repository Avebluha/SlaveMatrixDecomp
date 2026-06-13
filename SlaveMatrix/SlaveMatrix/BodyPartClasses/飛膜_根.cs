using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 飛膜_根 : Element
    {
    	public ShapePart X0Y0_飛膜;

    	public ShapePart X0Y1_飛膜;

    	public ColorD 飛膜CD;

    	public ColorP X0Y0_飛膜CP;

    	public ColorP X0Y1_飛膜CP;

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

    	public bool 飛膜_表示
    	{
    		get
    		{
    			return X0Y0_飛膜.Dra;
    		}
    		set
    		{
    			X0Y0_飛膜.Dra = value;
    			X0Y1_飛膜.Dra = value;
    			X0Y0_飛膜.Hit = value;
    			X0Y1_飛膜.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 飛膜_表示;
    		}
    		set
    		{
    			飛膜_表示 = value;
    		}
    	}

    	public override double Intensity
    	{
    		get
    		{
    			return 飛膜CD.不透明度;
    		}
    		set
    		{
    			飛膜CD.不透明度 = value;
    		}
    	}

    	public bool 接部_外線
    	{
    		get
    		{
    			return X0Y0_飛膜.OP[(!右) ? 3 : 0].Outline;
    		}
    		set
    		{
    			X0Y0_飛膜.OP[(!右) ? 3 : 0].Outline = value;
    			X0Y1_飛膜.OP[(!右) ? 10 : 0].Outline = value;
    		}
    	}

    	public 飛膜_根(double DisUnit, 配色指定 配色指定, BodyColorSet 体配色)
    	{
    		ThisType = GetType();
    		Body = new VariantGrid(Sta.腕左["飛膜根"]);
    		PartGroup partGroup = Body[0][0];
    		X0Y0_飛膜 = partGroup["飛膜"].ToPar();
    		partGroup = Body[0][1];
    		X0Y1_飛膜 = partGroup["飛膜"].ToPar();
    		Xasix = false;
    		Body.SetJoints();
    		接続根 = new JointD(Body);
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_飛膜CP = new ColorP(X0Y0_飛膜, 飛膜CD, DisUnit, abj: true);
    		X0Y1_飛膜CP = new ColorP(X0Y1_飛膜, 飛膜CD, DisUnit, abj: true);
    	}

    	public void 接続(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, Vector2D 接着点)
    	{
    		if (Body.IndexY == 0)
    		{
    			if (右 || 反転X_ || 反転Y_)
    			{
    				通常接続右(UpperArm, LowerArm, 手, 接着点);
    			}
    			else
    			{
    				通常接続左(UpperArm, LowerArm, 手, 接着点);
    			}
    		}
    		else if (右 || 反転X_ || 反転Y_)
    		{
    			欠損接続右(UpperArm, LowerArm, 手, 接着点);
    		}
    		else
    		{
    			欠損接続左(UpperArm, LowerArm, 手, 接着点);
    		}
    	}

    	private void 通常接続左(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, Vector2D 接着点)
    	{
    		Vector2D vector2D = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.JP[0].Joint));
    		Vector2D vector2D2 = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[3].ps[1]));
    		X0Y0_飛膜.OP[0].ps[0] = vector2D;
    		X0Y0_飛膜.OP[0].ps[2] = vector2D2;
    		X0Y0_飛膜.OP[0].ps[1] = (X0Y0_飛膜.OP[0].ps[0] + X0Y0_飛膜.OP[0].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[1].ps[0] = X0Y0_飛膜.OP[0].ps[2];
    		X0Y0_飛膜.OP[1].ps[2] = X0Y0_飛膜.ToLocal(接着点);
    		X0Y0_飛膜.OP[1].ps[1] = (X0Y0_飛膜.OP[1].ps[0] + X0Y0_飛膜.OP[1].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[2].ps[0] = X0Y0_飛膜.OP[1].ps[2];
    		if (手 == null)
    		{
    			if (LowerArm == null)
    			{
    				X0Y0_飛膜.OP[2].ps[2] = vector2D;
    				X0Y0_飛膜.OP[2].ps[1] = (X0Y0_飛膜.OP[2].ps[0] + X0Y0_飛膜.OP[2].ps[2]) * 0.5;
    				Vector2D vector2D3;
    				X0Y0_飛膜.OP[2].ps[1] += (vector2D3 = (vector2D2 - X0Y0_飛膜.OP[2].ps[1]) * 0.2);
    			}
    			else
    			{
    				X0Y0_飛膜.OP[2].ps[2] = X0Y0_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.ToGlobal(LowerArm.X0Y0_獣翼LowerArm.JP[0].Joint));
    				X0Y0_飛膜.OP[2].ps[1] = (X0Y0_飛膜.OP[2].ps[0] + X0Y0_飛膜.OP[2].ps[2]) * 0.5;
    				Vector2D vector2D3;
    				X0Y0_飛膜.OP[2].ps[1] += (vector2D3 = (vector2D - X0Y0_飛膜.OP[2].ps[1]) * 0.2);
    			}
    			X0Y0_飛膜.OP[3].ps[0] = X0Y0_飛膜.OP[2].ps[2];
    			X0Y0_飛膜.OP[3].ps[2] = vector2D;
    			X0Y0_飛膜.OP[3].ps[1] = (X0Y0_飛膜.OP[3].ps[0] + X0Y0_飛膜.OP[3].ps[2]) * 0.5;
    		}
    		else
    		{
    			X0Y0_飛膜.OP[2].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0]));
    			X0Y0_飛膜.OP[2].ps[1] = (X0Y0_飛膜.OP[2].ps[0] + X0Y0_飛膜.OP[2].ps[2]) * 0.5;
    			Vector2D vector2D3;
    			X0Y0_飛膜.OP[2].ps[1] += (vector2D3 = (X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.Position) - X0Y0_飛膜.OP[2].ps[1]) * 0.1);
    			X0Y0_飛膜.OP[3].ps[0] = X0Y0_飛膜.OP[2].ps[2];
    			X0Y0_飛膜.OP[3].ps[2] = vector2D;
    			X0Y0_飛膜.OP[3].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
    		}
    	}

    	private void 通常接続右(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, Vector2D 接着点)
    	{
    		Vector2D vector2D = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.JP[0].Joint));
    		Vector2D vector2D2 = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[0].ps[4]));
    		X0Y0_飛膜.OP[3].ps[2] = vector2D;
    		X0Y0_飛膜.OP[3].ps[0] = vector2D2;
    		X0Y0_飛膜.OP[3].ps[1] = (X0Y0_飛膜.OP[3].ps[2] + X0Y0_飛膜.OP[3].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[2].ps[2] = X0Y0_飛膜.OP[3].ps[0];
    		X0Y0_飛膜.OP[2].ps[0] = X0Y0_飛膜.ToLocal(接着点);
    		X0Y0_飛膜.OP[2].ps[1] = (X0Y0_飛膜.OP[2].ps[2] + X0Y0_飛膜.OP[2].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[1].ps[2] = X0Y0_飛膜.OP[2].ps[0];
    		if (手 == null)
    		{
    			if (LowerArm == null)
    			{
    				X0Y0_飛膜.OP[1].ps[0] = vector2D;
    				X0Y0_飛膜.OP[1].ps[1] = (X0Y0_飛膜.OP[1].ps[2] + X0Y0_飛膜.OP[1].ps[0]) * 0.5;
    				Vector2D vector2D3;
    				X0Y0_飛膜.OP[1].ps[1] += (vector2D3 = (vector2D2 - X0Y0_飛膜.OP[1].ps[1]) * 0.2);
    			}
    			else
    			{
    				X0Y0_飛膜.OP[1].ps[0] = X0Y0_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.ToGlobal(LowerArm.X0Y0_獣翼LowerArm.JP[0].Joint));
    				X0Y0_飛膜.OP[1].ps[1] = (X0Y0_飛膜.OP[1].ps[2] + X0Y0_飛膜.OP[1].ps[0]) * 0.5;
    				Vector2D vector2D3;
    				X0Y0_飛膜.OP[1].ps[1] += (vector2D3 = (vector2D - X0Y0_飛膜.OP[1].ps[1]) * 0.2);
    			}
    			X0Y0_飛膜.OP[0].ps[2] = X0Y0_飛膜.OP[1].ps[0];
    			X0Y0_飛膜.OP[0].ps[0] = vector2D;
    			X0Y0_飛膜.OP[0].ps[1] = (X0Y0_飛膜.OP[0].ps[2] + X0Y0_飛膜.OP[0].ps[0]) * 0.5;
    		}
    		else
    		{
    			X0Y0_飛膜.OP[1].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2]));
    			X0Y0_飛膜.OP[1].ps[1] = (X0Y0_飛膜.OP[1].ps[2] + X0Y0_飛膜.OP[1].ps[0]) * 0.5;
    			Vector2D vector2D3;
    			X0Y0_飛膜.OP[1].ps[1] += (vector2D3 = (X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.Position) - X0Y0_飛膜.OP[1].ps[1]) * 0.1);
    			X0Y0_飛膜.OP[0].ps[2] = X0Y0_飛膜.OP[1].ps[0];
    			X0Y0_飛膜.OP[0].ps[0] = vector2D;
    			X0Y0_飛膜.OP[0].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
    		}
    	}

    	private void 欠損接続左(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, Vector2D 接着点)
    	{
    		Vector2D vector2D = X0Y1_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.JP[0].Joint));
    		Vector2D value = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[3].ps[1]));
    		X0Y1_飛膜.OP[0].ps[0] = vector2D;
    		X0Y1_飛膜.OP[0].ps[2] = value;
    		X0Y1_飛膜.OP[0].ps[1] = (X0Y1_飛膜.OP[0].ps[0] + X0Y1_飛膜.OP[0].ps[2]) * 0.5;
    		X0Y1_飛膜.OP[1].ps[0] = X0Y1_飛膜.OP[0].ps[2];
    		X0Y1_飛膜.OP[1].ps[2] = X0Y1_飛膜.ToLocal(接着点);
    		X0Y1_飛膜.OP[1].ps[1] = (X0Y1_飛膜.OP[1].ps[0] + X0Y1_飛膜.OP[1].ps[2]) * 0.5;
    		Vector2D vector2D2 = X0Y1_飛膜.OP[1].ps[2];
    		Vector2D vector2D3 = ((手 != null) ? X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0])) : ((LowerArm == null) ? vector2D : X0Y1_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.ToGlobal(LowerArm.X0Y0_獣翼LowerArm.JP[0].Joint))));
    		Vector2D vector2D4 = (vector2D2 + vector2D3) * 0.5;
    		Vector2D v = vector2D2 - vector2D3;
    		double num = v.LengthSquared();
    		Vector2D vector2D5 = (X0Y1_飛膜.OP[2].ps[0] + X0Y1_飛膜.OP[9].ps[2]) * 0.5;
    		Vector2D v2 = X0Y1_飛膜.OP[2].ps[0] - X0Y1_飛膜.OP[9].ps[2];
    		double num2 = v2.LengthSquared();
    		double num3 = v2.Angle02π(DataConsts.Vec2DUnitX);
    		QuaternionD rotation = num3.RotationZQ();
    		QuaternionD rotation2 = (v2.Angle02π(v) - num3).RotationZQ();
    		double num4 = num / num2;
    		double num5 = vector2D5.X - vector2D5.X * num4;
    		Vector2D vector2D6 = vector2D4 - vector2D5;
    		for (int i = 0; i < 8; i++)
    		{
    			int index = i + 2;
    			for (int j = 0; j < X0Y1_飛膜.OP[index].ps.Count; j++)
    			{
    				Vector2D coord = X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D5, rotation);
    				coord.X = coord.X * num4 + num5;
    				X0Y1_飛膜.OP[index].ps[j] = coord.TransformCoordinateBP(vector2D5, rotation2) + vector2D6;
    			}
    		}
    		X0Y1_飛膜.OP[2].ps[0] = vector2D2;
    		X0Y1_飛膜.OP[9].ps[2] = vector2D3;
    		X0Y1_飛膜.OP[10].ps[0] = vector2D3;
    		X0Y1_飛膜.OP[10].ps[2] = vector2D;
    		if (手 == null)
    		{
    			X0Y1_飛膜.OP[10].ps[1] = (X0Y1_飛膜.OP[10].ps[0] + X0Y1_飛膜.OP[10].ps[2]) * 0.5;
    		}
    		else
    		{
    			X0Y1_飛膜.OP[10].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
    		}
    	}

    	private void 欠損接続右(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, Vector2D 接着点)
    	{
    		Vector2D vector2D = X0Y1_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.JP[0].Joint));
    		Vector2D value = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[0].ps[4]));
    		X0Y1_飛膜.OP[10].ps[2] = vector2D;
    		X0Y1_飛膜.OP[10].ps[0] = value;
    		X0Y1_飛膜.OP[10].ps[1] = (X0Y1_飛膜.OP[10].ps[2] + X0Y1_飛膜.OP[10].ps[0]) * 0.5;
    		X0Y1_飛膜.OP[9].ps[2] = X0Y1_飛膜.OP[10].ps[0];
    		X0Y1_飛膜.OP[9].ps[0] = X0Y1_飛膜.ToLocal(接着点);
    		X0Y1_飛膜.OP[9].ps[1] = (X0Y1_飛膜.OP[9].ps[2] + X0Y1_飛膜.OP[9].ps[0]) * 0.5;
    		Vector2D vector2D2 = X0Y1_飛膜.OP[9].ps[0];
    		Vector2D vector2D3 = ((手 != null) ? X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2])) : ((LowerArm == null) ? vector2D : X0Y1_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.ToGlobal(LowerArm.X0Y0_獣翼LowerArm.JP[0].Joint))));
    		Vector2D vector2D4 = (vector2D2 + vector2D3) * 0.5;
    		Vector2D v = vector2D2 - vector2D3;
    		double num = v.LengthSquared();
    		Vector2D vector2D5 = (X0Y1_飛膜.OP[8].ps[2] + X0Y1_飛膜.OP[1].ps[0]) * 0.5;
    		Vector2D v2 = X0Y1_飛膜.OP[8].ps[2] - X0Y1_飛膜.OP[1].ps[0];
    		double num2 = v2.LengthSquared();
    		double num3 = v2.Angle02π(-DataConsts.Vec2DUnitX);
    		QuaternionD rotation = num3.RotationZQ();
    		QuaternionD rotation2 = (v2.Angle02π(v) - num3).RotationZQ();
    		double num4 = num / num2;
    		double num5 = vector2D5.X - vector2D5.X * num4;
    		Vector2D vector2D6 = vector2D4 - vector2D5;
    		for (int i = 0; i < 8; i++)
    		{
    			int index = 10 - (i + 2);
    			for (int j = 0; j < X0Y1_飛膜.OP[index].ps.Count; j++)
    			{
    				Vector2D coord = X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D5, rotation);
    				coord.X = coord.X * num4 + num5;
    				X0Y1_飛膜.OP[index].ps[j] = coord.TransformCoordinateBP(vector2D5, rotation2) + vector2D6;
    			}
    		}
    		X0Y1_飛膜.OP[8].ps[2] = vector2D2;
    		X0Y1_飛膜.OP[1].ps[0] = vector2D3;
    		X0Y1_飛膜.OP[0].ps[2] = vector2D3;
    		X0Y1_飛膜.OP[0].ps[0] = vector2D;
    		if (手 == null)
    		{
    			X0Y1_飛膜.OP[0].ps[1] = (X0Y1_飛膜.OP[0].ps[2] + X0Y1_飛膜.OP[0].ps[0]) * 0.5;
    		}
    		else
    		{
    			X0Y1_飛膜.OP[0].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指2.Position);
    		}
    	}

    	public override void 色更新()
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_飛膜CP.Update();
    		}
    		else
    		{
    			X0Y1_飛膜CP.Update();
    		}
    	}

    	public override void 色更新(Vector2D[] mm)
    	{
    		if (Body.IndexY == 0)
    		{
    			X0Y0_飛膜CP.Update(mm);
    		}
    		else
    		{
    			X0Y1_飛膜CP.Update(mm);
    		}
    	}

    	private void 配色(BodyColorSet 体配色)
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

    	private void 配色N0(BodyColorSet 体配色)
    	{
    		飛膜CD = new ColorD(ref Col.Black, ref 体配色.膜R);
    	}

    	private void 配色T0(BodyColorSet 体配色)
    	{
    		飛膜CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    	}

    	private void 配色T1(BodyColorSet 体配色)
    	{
    		飛膜CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    	}
    }
}
