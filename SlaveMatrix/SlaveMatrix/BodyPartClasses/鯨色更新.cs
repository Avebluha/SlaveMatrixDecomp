using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    public class 鯨色更新
    {
    	public 長物_鯨 長物;

    	public 尾_鯨 尾;

    	private Par[] 鯨;

    	private Vector2D[] 鯨m;

    	public 鯨色更新(長物_鯨 長物, 尾_鯨 尾)
    	{
    		this.長物 = 長物;
    		this.尾 = 尾;
    		鯨 = new Par[40]
    		{
    			長物.X0Y0_Torso6_Torso, 長物.X0Y0_Torso5_Torso, 長物.X0Y0_Torso4_Torso, 長物.X0Y0_Torso3_Torso, 長物.X0Y0_Torso2_Torso, 長物.X0Y0_Torso1_Torso, 尾.X0Y0_尾33_尾, 尾.X0Y0_尾32_尾, 尾.X0Y0_尾31_尾, 尾.X0Y0_尾30_尾,
    			尾.X0Y0_尾29_尾, 尾.X0Y0_尾28_尾, 尾.X0Y0_尾27_尾, 尾.X0Y0_尾26_尾, 尾.X0Y0_尾25_尾, 尾.X0Y0_尾24_尾, 尾.X0Y0_尾23_尾, 尾.X0Y0_尾22_尾, 尾.X0Y0_尾21_尾, 尾.X0Y0_尾20_尾,
    			尾.X0Y0_尾19_尾, 尾.X0Y0_尾18_尾, 尾.X0Y0_尾17_尾, 尾.X0Y0_尾16_尾, 尾.X0Y0_尾15_尾, 尾.X0Y0_尾14_尾, 尾.X0Y0_尾13_尾, 尾.X0Y0_尾12_尾, 尾.X0Y0_尾11_尾, 尾.X0Y0_尾10_尾,
    			尾.X0Y0_尾9_尾, 尾.X0Y0_尾8_尾, 尾.X0Y0_尾7_尾, 尾.X0Y0_尾6_尾, 尾.X0Y0_尾5_尾, 尾.X0Y0_尾4_尾, 尾.X0Y0_尾3_尾, 尾.X0Y0_尾2_尾, 尾.X0Y0_尾1_尾, 尾.X0Y0_尾0_尾
    		};
    	}

    	public void 色更新()
    	{
    		鯨.GetMiY_MaY(out 鯨m);
    		長物.色更新(鯨m);
    		尾.色更新(鯨m);
    	}

    	public bool Contains(Ele e)
    	{
    		if (長物 != e)
    		{
    			return 尾 == e;
    		}
    		return true;
    	}
    }
}
