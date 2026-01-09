namespace SlaveMatrix
{
    public class 蝙隣接
    {
    	public UpperArm_蝙 UpperArm;

    	public 手_蝙 手;

    	public 蝙隣接(UpperArm_蝙 UpperArm, 手_蝙 手)
    	{
    		this.UpperArm = UpperArm;
    		this.手 = 手;
    	}

    	public void 接続()
    	{
    		UpperArm.飛膜.接続(UpperArm, null, 手, UpperArm.接着());
    		手.飛膜.接続(UpperArm, null, 手, 手.カーブ);
    	}
    }
}
