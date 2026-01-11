using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 頭色更新
    {
    	public Head 頭;

    	private Ele[] 瞼;

    	private Vector2D[] mm;

    	public 頭色更新(Head 頭, 単瞼 単瞼, 双瞼 瞼左, 双瞼 瞼右, 縦瞼 額瞼, 頬瞼 頬左, 頬瞼 頬右)
    	{
    		this.頭 = 頭;
    		瞼 = EnumNoNull(単瞼, 瞼左, 瞼右, 額瞼, 頬左, 頬右).ToArray();
    	}

    	private IEnumerable<Ele> EnumNoNull(単瞼 単瞼, 双瞼 瞼左, 双瞼 瞼右, 縦瞼 額瞼, 頬瞼 頬左, 頬瞼 頬右)
    	{
    		if (瞼 != null)
    		{
    			yield return 単瞼;
    		}
    		if (瞼左 != null)
    		{
    			yield return 瞼左;
    		}
    		if (瞼右 != null)
    		{
    			yield return 瞼右;
    		}
    		if (額瞼 != null)
    		{
    			yield return 額瞼;
    		}
    		if (頬左 != null)
    		{
    			yield return 頬左;
    		}
    		if (頬右 != null)
    		{
    			yield return 頬右;
    		}
    	}

    	public void 色更新()
    	{
    		頭.X0Y0_Head.GetMiY_MaY(out mm);
    		頭.色更新(mm);
    		Ele[] array = 瞼;
    		for (int i = 0; i < array.Length; i++)
    		{
    			array[i].色更新(mm);
    		}
    	}

    	public bool Contains(Ele e)
    	{
    		if (e != 頭)
    		{
    			return 瞼.Contains(e);
    		}
    		return true;
    	}
    }
}
