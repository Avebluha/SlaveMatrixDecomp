using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 飛膜_先 : Ele
    {
    	public Par X0Y0_飛膜;

    	public Par X0Y1_飛膜;

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

    	public override double 濃度
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
    			return X0Y0_飛膜.OP[右 ? 5 : 3].Outline;
    		}
    		set
    		{
    			X0Y0_飛膜.OP[右 ? 5 : 3].Outline = value;
    			X0Y1_飛膜.OP[右 ? 39 : 3].Outline = value;
    		}
    	}

    	public 飛膜_先(double DisUnit, 配色指定 配色指定, 体配色 体配色)
    	{
    		ThisType = GetType();
    		Body = new Difs(Sta.腕左["飛膜先"]);
    		Pars pars = Body[0][0];
    		X0Y0_飛膜 = pars["飛膜"].ToPar();
    		pars = Body[0][1];
    		X0Y1_飛膜 = pars["飛膜"].ToPar();
    		Xasix = false;
    		Body.SetJoints();
    		接続根 = new JointD(Body);
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_飛膜CP = new ColorP(X0Y0_飛膜, 飛膜CD, DisUnit, abj: true);
    		X0Y1_飛膜CP = new ColorP(X0Y1_飛膜, 飛膜CD, DisUnit, abj: true);
    	}

    	public void 接続(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, bool カーブ)
    	{
    		if (Body.IndexY == 0)
    		{
    			if (右 || 反転X_ || 反転Y_)
    			{
    				通常接続右(UpperArm, LowerArm, 手, カーブ);
    			}
    			else
    			{
    				通常接続左(UpperArm, LowerArm, 手, カーブ);
    			}
    		}
    		else if (右 || 反転X_ || 反転Y_)
    		{
    			欠損接続右(UpperArm, LowerArm, 手, カーブ);
    		}
    		else
    		{
    			欠損接続左(UpperArm, LowerArm, 手, カーブ);
    		}
    	}

    	private void 通常接続左(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, bool カーブ)
    	{
    		Vector2D value = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
    		Vector2D vector2D = X0Y0_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
    		X0Y0_飛膜.OP[0].ps[0] = value;
    		X0Y0_飛膜.OP[0].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
    		X0Y0_飛膜.OP[0].ps[1] = (X0Y0_飛膜.OP[0].ps[0] + X0Y0_飛膜.OP[0].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[1].ps[0] = X0Y0_飛膜.OP[0].ps[2];
    		X0Y0_飛膜.OP[1].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
    		X0Y0_飛膜.OP[1].ps[1] = (X0Y0_飛膜.OP[1].ps[0] + X0Y0_飛膜.OP[1].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[1].ps[1] += (vector2D - X0Y0_飛膜.OP[1].ps[1]) * 0.3;
    		X0Y0_飛膜.OP[2].ps[0] = X0Y0_飛膜.OP[1].ps[2];
    		if (UpperArm == null)
    		{
    			if (LowerArm == null)
    			{
    				X0Y0_飛膜.OP[2].ps[3] = X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			}
    			else
    			{
    				X0Y0_飛膜.OP[2].ps[3] = X0Y0_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			}
    			Vector2D vector2D2 = (X0Y0_飛膜.OP[2].ps[0] + X0Y0_飛膜.OP[2].ps[3]) * 0.5;
    			X0Y0_飛膜.OP[2].ps[1] = vector2D2 + (X0Y0_飛膜.OP[2].ps[0] - X0Y0_飛膜.OP[2].ps[3]) * 0.8;
    			X0Y0_飛膜.OP[2].ps[2] = vector2D2 + (X0Y0_飛膜.OP[2].ps[0] - X0Y0_飛膜.OP[2].ps[3]) * 0.4;
    			X0Y0_飛膜.OP[2].ps[1] += (vector2D - X0Y0_飛膜.OP[2].ps[1]) * 0.3;
    			X0Y0_飛膜.OP[2].ps[2] += (vector2D - X0Y0_飛膜.OP[2].ps[2]) * 0.3;
    		}
    		else
    		{
    			if (UpperArm.ConnectionType == ConnectionInfo.Shoulder_UpperArm_接続)
    			{
    				X0Y0_飛膜.OP[2].ps[3] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[3].ps[1]));
    			}
    			else
    			{
    				X0Y0_飛膜.OP[2].ps[3] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[3].ps[1].AddY(0.003)));
    			}
    			Vector2D vector2D3 = (X0Y0_飛膜.OP[2].ps[0] + X0Y0_飛膜.OP[2].ps[3]) * 0.5;
    			X0Y0_飛膜.OP[2].ps[1] = (X0Y0_飛膜.OP[2].ps[0] + vector2D3) * 0.5;
    			X0Y0_飛膜.OP[2].ps[2] = (vector2D3 + X0Y0_飛膜.OP[2].ps[3]) * 0.5;
    		}
    		if (LowerArm == null)
    		{
    			Vector2D vector2D4 = X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			X0Y0_飛膜.OP[2].ps[1] += (vector2D4 - X0Y0_飛膜.OP[2].ps[1]) * 0.3;
    			X0Y0_飛膜.OP[2].ps[2] += (vector2D4 - X0Y0_飛膜.OP[2].ps[2]) * 0.3;
    		}
    		else
    		{
    			Vector2D vector2D5 = X0Y0_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			X0Y0_飛膜.OP[2].ps[1] += (vector2D5 - X0Y0_飛膜.OP[2].ps[1]) * 0.3;
    			X0Y0_飛膜.OP[2].ps[2] += (vector2D5 - X0Y0_飛膜.OP[2].ps[2]) * 0.3;
    		}
    		if (UpperArm.ConnectionType != ConnectionInfo.Shoulder_UpperArm_接続)
    		{
    			X0Y0_飛膜.OP[3].ps[0] = X0Y0_飛膜.OP[2].ps[3];
    		}
    		else
    		{
    			X0Y0_飛膜.OP[3].ps[0] = X0Y0_飛膜.OP[2].ps[3].AddY(0.05);
    		}
    		X0Y0_飛膜.OP[3].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0]));
    		X0Y0_飛膜.OP[3].ps[1] = (X0Y0_飛膜.OP[3].ps[0] + X0Y0_飛膜.OP[3].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[3].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - X0Y0_飛膜.OP[3].ps[1]) * 0.07;
    		if (カーブ)
    		{
    			X0Y0_飛膜.OP[3].ps[1] = (X0Y0_飛膜.OP[3].ps[0] + X0Y0_飛膜.OP[3].ps[2]) * 0.5;
    			X0Y0_飛膜.OP[3].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - X0Y0_飛膜.OP[3].ps[1]) * 0.4;
    		}
    		X0Y0_飛膜.OP[4].ps[0] = X0Y0_飛膜.OP[3].ps[2];
    		X0Y0_飛膜.OP[4].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[0].ps[0]));
    		X0Y0_飛膜.OP[4].ps[1] = (X0Y0_飛膜.OP[4].ps[0] + X0Y0_飛膜.OP[4].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[4].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指1.Position) - X0Y0_飛膜.OP[4].ps[1]) * 0.08;
    		X0Y0_飛膜.OP[5].ps[0] = X0Y0_飛膜.OP[4].ps[2];
    		X0Y0_飛膜.OP[5].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[0]));
    		X0Y0_飛膜.OP[5].ps[1] = (X0Y0_飛膜.OP[5].ps[0] + X0Y0_飛膜.OP[5].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[5].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_中指_指1.Position) - X0Y0_飛膜.OP[5].ps[1]) * 0.07;
    		X0Y0_飛膜.OP[6].ps[0] = X0Y0_飛膜.OP[5].ps[2];
    		X0Y0_飛膜.OP[6].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
    		X0Y0_飛膜.OP[6].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[1]));
    		X0Y0_飛膜.OP[7].ps[0] = X0Y0_飛膜.OP[6].ps[2];
    		X0Y0_飛膜.OP[7].ps[2] = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[0]));
    		X0Y0_飛膜.OP[7].ps[1] = (X0Y0_飛膜.OP[7].ps[0] + X0Y0_飛膜.OP[7].ps[2]) * 0.5;
    		X0Y0_飛膜.OP[7].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - X0Y0_飛膜.OP[7].ps[1]) * 0.08;
    		X0Y0_飛膜.OP[8].ps[0] = X0Y0_飛膜.OP[7].ps[2];
    		X0Y0_飛膜.OP[8].ps[2] = value;
    		X0Y0_飛膜.OP[8].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[1]));
    	}

    	private void 通常接続右(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, bool カーブ)
    	{
    		Vector2D value = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
    		Vector2D vector2D = X0Y0_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
    		X0Y0_飛膜.OP[8].ps[2] = value;
    		X0Y0_飛膜.OP[8].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
    		X0Y0_飛膜.OP[8].ps[1] = (X0Y0_飛膜.OP[8].ps[2] + X0Y0_飛膜.OP[8].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[7].ps[2] = X0Y0_飛膜.OP[8].ps[0];
    		X0Y0_飛膜.OP[7].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
    		X0Y0_飛膜.OP[7].ps[1] = (X0Y0_飛膜.OP[7].ps[2] + X0Y0_飛膜.OP[7].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[7].ps[1] += (vector2D - X0Y0_飛膜.OP[7].ps[1]) * 0.3;
    		X0Y0_飛膜.OP[6].ps[3] = X0Y0_飛膜.OP[7].ps[0];
    		if (UpperArm == null)
    		{
    			if (LowerArm == null)
    			{
    				X0Y0_飛膜.OP[6].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			}
    			else
    			{
    				X0Y0_飛膜.OP[6].ps[0] = X0Y0_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			}
    			Vector2D vector2D2 = (X0Y0_飛膜.OP[6].ps[3] + X0Y0_飛膜.OP[6].ps[0]) * 0.5;
    			X0Y0_飛膜.OP[6].ps[2] = vector2D2 + (X0Y0_飛膜.OP[6].ps[3] - X0Y0_飛膜.OP[6].ps[0]) * 0.8;
    			X0Y0_飛膜.OP[6].ps[1] = vector2D2 + (X0Y0_飛膜.OP[6].ps[3] - X0Y0_飛膜.OP[6].ps[0]) * 0.4;
    			X0Y0_飛膜.OP[6].ps[2] += (vector2D - X0Y0_飛膜.OP[6].ps[2]) * 0.3;
    			X0Y0_飛膜.OP[6].ps[1] += (vector2D - X0Y0_飛膜.OP[6].ps[1]) * 0.3;
    		}
    		else
    		{
    			if (UpperArm.ConnectionType == ConnectionInfo.Shoulder_UpperArm_接続)
    			{
    				X0Y0_飛膜.OP[6].ps[0] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[0].ps[4]));
    			}
    			else
    			{
    				X0Y0_飛膜.OP[6].ps[0] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[0].ps[4].AddY(0.003)));
    			}
    			Vector2D vector2D3 = (X0Y0_飛膜.OP[6].ps[3] + X0Y0_飛膜.OP[6].ps[0]) * 0.5;
    			X0Y0_飛膜.OP[6].ps[2] = (X0Y0_飛膜.OP[6].ps[3] + vector2D3) * 0.5;
    			X0Y0_飛膜.OP[6].ps[1] = (vector2D3 + X0Y0_飛膜.OP[6].ps[0]) * 0.5;
    		}
    		if (LowerArm == null)
    		{
    			Vector2D vector2D4 = X0Y0_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			X0Y0_飛膜.OP[6].ps[2] += (vector2D4 - X0Y0_飛膜.OP[6].ps[2]) * 0.3;
    			X0Y0_飛膜.OP[6].ps[1] += (vector2D4 - X0Y0_飛膜.OP[6].ps[1]) * 0.3;
    		}
    		else
    		{
    			Vector2D vector2D5 = X0Y0_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			X0Y0_飛膜.OP[6].ps[2] += (vector2D5 - X0Y0_飛膜.OP[6].ps[2]) * 0.3;
    			X0Y0_飛膜.OP[6].ps[1] += (vector2D5 - X0Y0_飛膜.OP[6].ps[1]) * 0.3;
    		}
    		if (UpperArm.ConnectionType != ConnectionInfo.Shoulder_UpperArm_接続)
    		{
    			X0Y0_飛膜.OP[5].ps[2] = X0Y0_飛膜.OP[6].ps[0];
    		}
    		else
    		{
    			X0Y0_飛膜.OP[5].ps[2] = X0Y0_飛膜.OP[6].ps[0].AddY(0.05);
    		}
    		X0Y0_飛膜.OP[5].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2]));
    		X0Y0_飛膜.OP[5].ps[1] = (X0Y0_飛膜.OP[5].ps[2] + X0Y0_飛膜.OP[5].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[5].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - X0Y0_飛膜.OP[5].ps[1]) * 0.07;
    		if (カーブ)
    		{
    			X0Y0_飛膜.OP[5].ps[1] = (X0Y0_飛膜.OP[5].ps[2] + X0Y0_飛膜.OP[5].ps[0]) * 0.5;
    			X0Y0_飛膜.OP[5].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - X0Y0_飛膜.OP[5].ps[1]) * 0.4;
    		}
    		X0Y0_飛膜.OP[4].ps[2] = X0Y0_飛膜.OP[5].ps[0];
    		X0Y0_飛膜.OP[4].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[2].ps[2]));
    		X0Y0_飛膜.OP[4].ps[1] = (X0Y0_飛膜.OP[4].ps[2] + X0Y0_飛膜.OP[4].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[4].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_薬指_指1.Position) - X0Y0_飛膜.OP[4].ps[1]) * 0.08;
    		X0Y0_飛膜.OP[3].ps[2] = X0Y0_飛膜.OP[4].ps[0];
    		X0Y0_飛膜.OP[3].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[2]));
    		X0Y0_飛膜.OP[3].ps[1] = (X0Y0_飛膜.OP[3].ps[2] + X0Y0_飛膜.OP[3].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[3].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_中指_指1.Position) - X0Y0_飛膜.OP[3].ps[1]) * 0.07;
    		X0Y0_飛膜.OP[2].ps[2] = X0Y0_飛膜.OP[3].ps[0];
    		X0Y0_飛膜.OP[2].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
    		X0Y0_飛膜.OP[2].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[1]));
    		X0Y0_飛膜.OP[1].ps[2] = X0Y0_飛膜.OP[2].ps[0];
    		X0Y0_飛膜.OP[1].ps[0] = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[2]));
    		X0Y0_飛膜.OP[1].ps[1] = (X0Y0_飛膜.OP[1].ps[2] + X0Y0_飛膜.OP[1].ps[0]) * 0.5;
    		X0Y0_飛膜.OP[1].ps[1] += (X0Y0_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - X0Y0_飛膜.OP[1].ps[1]) * 0.08;
    		X0Y0_飛膜.OP[0].ps[2] = X0Y0_飛膜.OP[1].ps[0];
    		X0Y0_飛膜.OP[0].ps[0] = value;
    		X0Y0_飛膜.OP[0].ps[1] = X0Y0_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[1]));
    	}

    	private void 欠損接続左(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, bool カーブ)
    	{
    		Vector2D value = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
    		Vector2D vector2D = X0Y1_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
    		X0Y1_飛膜.OP[0].ps[0] = value;
    		X0Y1_飛膜.OP[0].ps[2] = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
    		X0Y1_飛膜.OP[0].ps[1] = (X0Y1_飛膜.OP[0].ps[0] + X0Y1_飛膜.OP[0].ps[2]) * 0.5;
    		X0Y1_飛膜.OP[1].ps[0] = X0Y1_飛膜.OP[0].ps[2];
    		X0Y1_飛膜.OP[1].ps[2] = X0Y1_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
    		X0Y1_飛膜.OP[1].ps[1] = (X0Y1_飛膜.OP[1].ps[0] + X0Y1_飛膜.OP[1].ps[2]) * 0.5;
    		X0Y1_飛膜.OP[1].ps[1] += (vector2D - X0Y1_飛膜.OP[1].ps[1]) * 0.3;
    		X0Y1_飛膜.OP[2].ps[0] = X0Y1_飛膜.OP[1].ps[2];
    		if (UpperArm == null)
    		{
    			if (LowerArm == null)
    			{
    				X0Y1_飛膜.OP[2].ps[3] = X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			}
    			else
    			{
    				X0Y1_飛膜.OP[2].ps[3] = X0Y1_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			}
    			Vector2D vector2D2 = (X0Y1_飛膜.OP[2].ps[0] + X0Y1_飛膜.OP[2].ps[3]) * 0.5;
    			X0Y1_飛膜.OP[2].ps[1] = vector2D2 + (X0Y1_飛膜.OP[2].ps[0] - X0Y1_飛膜.OP[2].ps[3]) * 0.8;
    			X0Y1_飛膜.OP[2].ps[2] = vector2D2 + (X0Y1_飛膜.OP[2].ps[0] - X0Y1_飛膜.OP[2].ps[3]) * 0.4;
    			X0Y1_飛膜.OP[2].ps[1] += (vector2D - X0Y1_飛膜.OP[2].ps[1]) * 0.3;
    			X0Y1_飛膜.OP[2].ps[2] += (vector2D - X0Y1_飛膜.OP[2].ps[2]) * 0.3;
    		}
    		else
    		{
    			if (UpperArm.ConnectionType == ConnectionInfo.Shoulder_UpperArm_接続)
    			{
    				X0Y1_飛膜.OP[2].ps[3] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[3].ps[1]));
    			}
    			else
    			{
    				X0Y1_飛膜.OP[2].ps[3] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[3].ps[1].AddY(0.003)));
    			}
    			Vector2D vector2D3 = (X0Y1_飛膜.OP[2].ps[0] + X0Y1_飛膜.OP[2].ps[3]) * 0.5;
    			X0Y1_飛膜.OP[2].ps[1] = (X0Y1_飛膜.OP[2].ps[0] + vector2D3) * 0.5;
    			X0Y1_飛膜.OP[2].ps[2] = (vector2D3 + X0Y1_飛膜.OP[2].ps[3]) * 0.5;
    		}
    		if (LowerArm == null)
    		{
    			Vector2D vector2D4 = X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			X0Y1_飛膜.OP[2].ps[1] += (vector2D4 - X0Y1_飛膜.OP[2].ps[1]) * 0.3;
    			X0Y1_飛膜.OP[2].ps[2] += (vector2D4 - X0Y1_飛膜.OP[2].ps[2]) * 0.3;
    		}
    		else
    		{
    			Vector2D vector2D5 = X0Y1_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			X0Y1_飛膜.OP[2].ps[1] += (vector2D5 - X0Y1_飛膜.OP[2].ps[1]) * 0.3;
    			X0Y1_飛膜.OP[2].ps[2] += (vector2D5 - X0Y1_飛膜.OP[2].ps[2]) * 0.3;
    		}
    		if (UpperArm.ConnectionType != ConnectionInfo.Shoulder_UpperArm_接続)
    		{
    			X0Y1_飛膜.OP[3].ps[0] = X0Y1_飛膜.OP[2].ps[3];
    		}
    		else
    		{
    			X0Y1_飛膜.OP[3].ps[0] = X0Y1_飛膜.OP[2].ps[3].AddY(0.05);
    		}
    		X0Y1_飛膜.OP[3].ps[2] = X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[0].ps[0]));
    		X0Y1_飛膜.OP[3].ps[1] = (X0Y1_飛膜.OP[3].ps[0] + X0Y1_飛膜.OP[3].ps[2]) * 0.5;
    		X0Y1_飛膜.OP[3].ps[1] += (X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.Position) - X0Y1_飛膜.OP[3].ps[1]) * 0.85;
    		if (カーブ)
    		{
    			X0Y1_飛膜.OP[3].ps[1] = (X0Y1_飛膜.OP[3].ps[0] + X0Y1_飛膜.OP[3].ps[2]) * 0.5;
    			X0Y1_飛膜.OP[3].ps[1] += (X0Y1_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - X0Y1_飛膜.OP[3].ps[1]) * 0.3;
    		}
    		Vector2D vector2D6 = X0Y1_飛膜.OP[3].ps[2];
    		Vector2D vector2D7 = X0Y1_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[0].ps[0]));
    		Vector2D vector2D8 = (vector2D6 + vector2D7) * 0.5;
    		double num = vector2D6.DistanceSquared(vector2D7);
    		Vector2D vector2D9 = (X0Y1_飛膜.OP[4].ps[0] + X0Y1_飛膜.OP[19].ps[2]) * 0.5;
    		double num2 = X0Y1_飛膜.OP[4].ps[0].DistanceSquared(X0Y1_飛膜.OP[19].ps[2]);
    		Vector2D v = X0Y1_飛膜.OP[11].ps[2] - vector2D9;
    		Vector2D v2 = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position) - vector2D8;
    		double num3 = v.Angle02π(Dat.Vec2DUnitY);
    		MatrixD transform = num3.RotationZ();
    		MatrixD transform2 = (v.Angle02π(v2) - num3).RotationZ();
    		Vector2D vector2D10 = vector2D8 - vector2D9;
    		double num4 = num / num2;
    		double num5 = vector2D9.X - vector2D9.X * num4;
    		for (int i = 0; i < 16; i++)
    		{
    			int index = i + 4;
    			for (int j = 0; j < X0Y1_飛膜.OP[index].ps.Count; j++)
    			{
    				Vector2D coord = X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D9, transform);
    				coord.X = coord.X * num4 + num5;
    				X0Y1_飛膜.OP[index].ps[j] = coord.TransformCoordinateBP(vector2D9, transform2) + vector2D10;
    			}
    		}
    		X0Y1_飛膜.OP[4].ps[0] = vector2D6;
    		X0Y1_飛膜.OP[19].ps[2] = vector2D7;
    		vector2D6 = X0Y1_飛膜.OP[19].ps[2];
    		vector2D7 = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[0]));
    		vector2D8 = (vector2D6 + vector2D7) * 0.5;
    		double num6 = vector2D6.DistanceSquared(vector2D7);
    		vector2D9 = (X0Y1_飛膜.OP[20].ps[0] + X0Y1_飛膜.OP[39].ps[2]) * 0.5;
    		num2 = X0Y1_飛膜.OP[20].ps[0].DistanceSquared(X0Y1_飛膜.OP[39].ps[2]);
    		Vector2D v3 = X0Y1_飛膜.OP[29].ps[2] - vector2D9;
    		v2 = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指2.Position) - vector2D8;
    		num3 = v3.Angle02π(Dat.Vec2DUnitY);
    		transform = num3.RotationZ();
    		transform2 = (v3.Angle02π(v2) - num3).RotationZ();
    		vector2D10 = vector2D8 - vector2D9;
    		num4 = num6 / num2;
    		num5 = vector2D9.X - vector2D9.X * num4;
    		for (int k = 0; k < 20; k++)
    		{
    			int index = k + 20;
    			for (int l = 0; l < X0Y1_飛膜.OP[index].ps.Count; l++)
    			{
    				Vector2D coord = X0Y1_飛膜.OP[index].ps[l].TransformCoordinateBP(vector2D9, transform);
    				coord.X = coord.X * num4 + num5;
    				X0Y1_飛膜.OP[index].ps[l] = coord.TransformCoordinateBP(vector2D9, transform2) + vector2D10;
    			}
    		}
    		X0Y1_飛膜.OP[20].ps[0] = vector2D6;
    		X0Y1_飛膜.OP[39].ps[2] = vector2D7;
    		X0Y1_飛膜.OP[40].ps[0] = vector2D7;
    		X0Y1_飛膜.OP[40].ps[2] = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
    		X0Y1_飛膜.OP[40].ps[1] = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[0].ps[1]));
    		X0Y1_飛膜.OP[41].ps[0] = X0Y1_飛膜.OP[40].ps[2];
    		X0Y1_飛膜.OP[41].ps[2] = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[0]));
    		X0Y1_飛膜.OP[41].ps[1] = (X0Y1_飛膜.OP[41].ps[0] + X0Y1_飛膜.OP[41].ps[2]) * 0.5;
    		X0Y1_飛膜.OP[41].ps[1] += (X0Y1_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - X0Y1_飛膜.OP[41].ps[1]) * 0.08;
    		X0Y1_飛膜.OP[42].ps[0] = X0Y1_飛膜.OP[41].ps[2];
    		X0Y1_飛膜.OP[42].ps[2] = value;
    		X0Y1_飛膜.OP[42].ps[1] = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[0].ps[1]));
    	}

    	private void 欠損接続右(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手, bool カーブ)
    	{
    		Vector2D value = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.Position);
    		Vector2D vector2D = X0Y1_飛膜.ToLocal(手.X0Y0_親指_指1.Position);
    		X0Y1_飛膜.OP[42].ps[2] = value;
    		X0Y1_飛膜.OP[42].ps[0] = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position);
    		X0Y1_飛膜.OP[42].ps[1] = (X0Y1_飛膜.OP[42].ps[2] + X0Y1_飛膜.OP[42].ps[0]) * 0.5;
    		X0Y1_飛膜.OP[41].ps[2] = X0Y1_飛膜.OP[42].ps[0];
    		X0Y1_飛膜.OP[41].ps[0] = X0Y1_飛膜.ToLocal(手.X0Y0_親指_指2.Position);
    		X0Y1_飛膜.OP[41].ps[1] = (X0Y1_飛膜.OP[41].ps[2] + X0Y1_飛膜.OP[41].ps[0]) * 0.5;
    		X0Y1_飛膜.OP[41].ps[1] += (vector2D - X0Y1_飛膜.OP[41].ps[1]) * 0.3;
    		X0Y1_飛膜.OP[40].ps[3] = X0Y1_飛膜.OP[41].ps[0];
    		if (UpperArm == null)
    		{
    			if (LowerArm == null)
    			{
    				X0Y1_飛膜.OP[40].ps[0] = X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			}
    			else
    			{
    				X0Y1_飛膜.OP[40].ps[0] = X0Y1_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			}
    			Vector2D vector2D2 = (X0Y1_飛膜.OP[40].ps[3] + X0Y1_飛膜.OP[40].ps[0]) * 0.5;
    			X0Y1_飛膜.OP[40].ps[2] = vector2D2 + (X0Y1_飛膜.OP[40].ps[3] - X0Y1_飛膜.OP[40].ps[0]) * 0.8;
    			X0Y1_飛膜.OP[40].ps[1] = vector2D2 + (X0Y1_飛膜.OP[40].ps[3] - X0Y1_飛膜.OP[40].ps[0]) * 0.4;
    			X0Y1_飛膜.OP[40].ps[2] += (vector2D - X0Y1_飛膜.OP[40].ps[2]) * 0.3;
    			X0Y1_飛膜.OP[40].ps[1] += (vector2D - X0Y1_飛膜.OP[40].ps[1]) * 0.3;
    		}
    		else
    		{
    			if (UpperArm.ConnectionType == ConnectionInfo.Shoulder_UpperArm_接続)
    			{
    				X0Y1_飛膜.OP[40].ps[0] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[0].ps[4]));
    			}
    			else
    			{
    				X0Y1_飛膜.OP[40].ps[0] = X0Y0_飛膜.ToLocal(UpperArm.X0Y0_獣翼UpperArm.ToGlobal(UpperArm.X0Y0_獣翼UpperArm.OP[0].ps[4].AddY(0.003)));
    			}
    			Vector2D vector2D3 = (X0Y1_飛膜.OP[40].ps[3] + X0Y1_飛膜.OP[40].ps[0]) * 0.5;
    			X0Y1_飛膜.OP[40].ps[2] = (X0Y1_飛膜.OP[40].ps[3] + vector2D3) * 0.5;
    			X0Y1_飛膜.OP[40].ps[1] = (vector2D3 + X0Y1_飛膜.OP[40].ps[0]) * 0.5;
    		}
    		if (LowerArm == null)
    		{
    			Vector2D vector2D4 = X0Y1_飛膜.ToLocal(手.X0Y0_獣翼手.Position);
    			X0Y1_飛膜.OP[40].ps[2] += (vector2D4 - X0Y1_飛膜.OP[40].ps[2]) * 0.3;
    			X0Y1_飛膜.OP[40].ps[1] += (vector2D4 - X0Y1_飛膜.OP[40].ps[1]) * 0.3;
    		}
    		else
    		{
    			Vector2D vector2D5 = X0Y1_飛膜.ToLocal(LowerArm.X0Y0_獣翼LowerArm.Position);
    			X0Y1_飛膜.OP[40].ps[2] += (vector2D5 - X0Y1_飛膜.OP[40].ps[2]) * 0.3;
    			X0Y1_飛膜.OP[40].ps[1] += (vector2D5 - X0Y1_飛膜.OP[40].ps[1]) * 0.3;
    		}
    		if (UpperArm.ConnectionType != ConnectionInfo.Shoulder_UpperArm_接続)
    		{
    			X0Y1_飛膜.OP[39].ps[2] = X0Y1_飛膜.OP[40].ps[0];
    		}
    		else
    		{
    			X0Y1_飛膜.OP[39].ps[2] = X0Y1_飛膜.OP[40].ps[0].AddY(0.05);
    		}
    		X0Y1_飛膜.OP[39].ps[0] = X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.ToGlobal(手.X0Y0_小指_指3.OP[2].ps[2]));
    		X0Y1_飛膜.OP[39].ps[1] = (X0Y1_飛膜.OP[39].ps[2] + X0Y1_飛膜.OP[39].ps[0]) * 0.5;
    		X0Y1_飛膜.OP[39].ps[1] += (X0Y1_飛膜.ToLocal(手.X0Y0_小指_指3.Position) - X0Y1_飛膜.OP[39].ps[1]) * 0.85;
    		if (カーブ)
    		{
    			X0Y1_飛膜.OP[39].ps[1] = (X0Y1_飛膜.OP[39].ps[2] + X0Y1_飛膜.OP[39].ps[0]) * 0.5;
    			X0Y1_飛膜.OP[39].ps[1] += (X0Y1_飛膜.ToLocal(手.X0Y0_小指_指1.ToGlobal(手.X0Y0_小指_指1.JP[0].Joint)) - X0Y1_飛膜.OP[39].ps[1]) * 0.3;
    		}
    		Vector2D vector2D6 = X0Y1_飛膜.OP[39].ps[0];
    		Vector2D vector2D7 = X0Y1_飛膜.ToLocal(手.X0Y0_薬指_指3.ToGlobal(手.X0Y0_薬指_指3.OP[2].ps[2]));
    		Vector2D vector2D8 = (vector2D6 + vector2D7) * 0.5;
    		double num = vector2D6.DistanceSquared(vector2D7);
    		Vector2D vector2D9 = (X0Y1_飛膜.OP[38].ps[2] + X0Y1_飛膜.OP[23].ps[0]) * 0.5;
    		double num2 = X0Y1_飛膜.OP[38].ps[2].DistanceSquared(X0Y1_飛膜.OP[23].ps[0]);
    		Vector2D v = X0Y1_飛膜.OP[31].ps[0] - vector2D9;
    		Vector2D v2 = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指2.Position) - vector2D8;
    		double num3 = v.Angle02π(Dat.Vec2DUnitY);
    		MatrixD transform = num3.RotationZ();
    		MatrixD transform2 = (v.Angle02π(v2) - num3).RotationZ();
    		Vector2D vector2D10 = vector2D8 - vector2D9;
    		double num4 = num / num2;
    		double num5 = vector2D9.X - vector2D9.X * num4;
    		for (int i = 0; i < 16; i++)
    		{
    			int index = 42 - (i + 4);
    			for (int j = 0; j < X0Y1_飛膜.OP[index].ps.Count; j++)
    			{
    				Vector2D coord = X0Y1_飛膜.OP[index].ps[j].TransformCoordinateBP(vector2D9, transform);
    				coord.X = coord.X * num4 + num5;
    				X0Y1_飛膜.OP[index].ps[j] = coord.TransformCoordinateBP(vector2D9, transform2) + vector2D10;
    			}
    		}
    		X0Y1_飛膜.OP[38].ps[2] = vector2D6;
    		X0Y1_飛膜.OP[23].ps[0] = vector2D7;
    		vector2D6 = X0Y1_飛膜.OP[23].ps[0];
    		vector2D7 = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[2]));
    		vector2D8 = (vector2D6 + vector2D7) * 0.5;
    		double num6 = vector2D6.DistanceSquared(vector2D7);
    		vector2D9 = (X0Y1_飛膜.OP[22].ps[2] + X0Y1_飛膜.OP[3].ps[0]) * 0.5;
    		num2 = X0Y1_飛膜.OP[22].ps[2].DistanceSquared(X0Y1_飛膜.OP[3].ps[0]);
    		Vector2D v3 = X0Y1_飛膜.OP[13].ps[0] - vector2D9;
    		v2 = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指2.Position) - vector2D8;
    		num3 = v3.Angle02π(Dat.Vec2DUnitY);
    		transform = num3.RotationZ();
    		transform2 = (v3.Angle02π(v2) - num3).RotationZ();
    		vector2D10 = vector2D8 - vector2D9;
    		num4 = num6 / num2;
    		num5 = vector2D9.X - vector2D9.X * num4;
    		for (int k = 0; k < 20; k++)
    		{
    			int index = 42 - (k + 20);
    			for (int l = 0; l < X0Y1_飛膜.OP[index].ps.Count; l++)
    			{
    				Vector2D coord = X0Y1_飛膜.OP[index].ps[l].TransformCoordinateBP(vector2D9, transform);
    				coord.X = coord.X * num4 + num5;
    				X0Y1_飛膜.OP[index].ps[l] = coord.TransformCoordinateBP(vector2D9, transform2) + vector2D10;
    			}
    		}
    		X0Y1_飛膜.OP[22].ps[2] = vector2D6;
    		X0Y1_飛膜.OP[3].ps[0] = vector2D7;
    		X0Y1_飛膜.OP[2].ps[2] = vector2D7;
    		X0Y1_飛膜.OP[2].ps[0] = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.Position);
    		X0Y1_飛膜.OP[2].ps[1] = X0Y1_飛膜.ToLocal(手.X0Y0_中指_指3.ToGlobal(手.X0Y0_中指_指3.OP[2].ps[1]));
    		X0Y1_飛膜.OP[1].ps[2] = X0Y1_飛膜.OP[2].ps[0];
    		X0Y1_飛膜.OP[1].ps[0] = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[2]));
    		X0Y1_飛膜.OP[1].ps[1] = (X0Y1_飛膜.OP[1].ps[2] + X0Y1_飛膜.OP[1].ps[0]) * 0.5;
    		X0Y1_飛膜.OP[1].ps[1] += (X0Y1_飛膜.ToLocal(手.X0Y0_人指_指1.Position) - X0Y1_飛膜.OP[1].ps[1]) * 0.08;
    		X0Y1_飛膜.OP[0].ps[2] = X0Y1_飛膜.OP[1].ps[0];
    		X0Y1_飛膜.OP[0].ps[0] = value;
    		X0Y1_飛膜.OP[0].ps[1] = X0Y1_飛膜.ToLocal(手.X0Y0_人指_指3.ToGlobal(手.X0Y0_人指_指3.OP[2].ps[1]));
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
    		飛膜CD = new ColorD(ref Col.Black, ref 体配色.膜R);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		飛膜CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		飛膜CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
    	}
    }
}
