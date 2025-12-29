using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct ブーツ情報
    {
    	public ブーツ_脚情報 Leg;

    	public ブーツ_足情報 足;

    	public ブーツ色 色;

    	public void SetDefault()
    	{
    		Leg.SetDefault();
    		足.SetDefault();
    		色.SetDefault();
    	}

    	public static ブーツ情報 GetDefault()
    	{
    		ブーツ情報 result = default(ブーツ情報);
    		result.SetDefault();
    		return result;
    	}
    }
}
