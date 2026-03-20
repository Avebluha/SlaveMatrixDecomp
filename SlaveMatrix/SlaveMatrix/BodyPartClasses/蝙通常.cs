namespace SlaveMatrix
{
    public class 蝙通常
    {
    	public UpperArm_蝙 UpperArm;

    	public LowerArm_蝙 LowerArm;

    	public 手_蝙 手;

    	public 蝙通常(UpperArm_蝙 UpperArm, LowerArm_蝙 LowerArm, 手_蝙 手)
    	{
    		this.UpperArm = UpperArm;
    		this.LowerArm = LowerArm;
    		this.手 = 手;
    	}

    	public void 接続()
    	{
    		UpperArm.飛膜.接続(UpperArm, LowerArm, 手, UpperArm.接着());
    		手.飛膜.接続(UpperArm, LowerArm, 手, 手.カーブ);
    	}
    }
}
