using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class TorsoSkinD : ElementData
    {
    	public bool 植タトゥ_タトゥ花左_表示;

    	public bool 植タトゥ_タトゥ花右_表示;

    	public bool 植タトゥ_タトゥ花_表示;

    	public bool 植タトゥ_タトゥ茎_表示;

    	public bool 植タトゥ_タトゥ葉左_表示;

    	public bool 植タトゥ_タトゥ葉右_表示;

    	public TorsoSkinD()
    	{
    		ThisType = GetType();
    	}

    	public override Element GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new TorsoSkin(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
