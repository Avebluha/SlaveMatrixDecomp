using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public struct sep
    {
        public Element Sta;

        public Element Element;

        public ShapePart ShapePart;

        public List<int> Path;

        public Vector2D Pos;
    }

    //three subclasses: one for bukkake, kiss marks, and whip marks
    public class Stamp
    {
    	public ModeEventDispatcher Med;

    	public RenderArea Are;

    	public Character Cha;

    	public Body Bod;

    	protected ElementData ElementData;

    	protected List<sep> sta = new List<sep>();

    	protected const int Max = 33;

    	protected ShapePart p;

    	protected Color2 c2;

    	protected Element he;

    	protected sep sep;

    	public virtual void Draw(RenderArea Are)
    	{
    	}

    	public virtual void Add(Vector2D cp, Color hc)
    	{
    	}

    	public Stamp()
    	{
    	}

    	public Stamp(ModeEventDispatcher Med, RenderArea Are, Character Cha, Body Bod, ElementData ElementData)
    	{
    		this.Med = Med;
    		this.Are = Are;
    		this.Cha = Cha;
    		this.Bod = Bod;
    		this.ElementData = ElementData;
    	}

    	public virtual void Dispose()
    	{
    		foreach (sep stum in sta)
    		{
    			stum.Sta.Dispose();
    		}
    	}

    	public void Clear()
    	{
    		foreach (sep stum in sta)
    		{
    			stum.Sta.Dispose();
    		}
    		sta.Clear();
    	}

    	public void LegClear()
    	{
    		sep[] array = sta.Where((sep e) => e.Element is 腿_人 || e.Element is Leg_人 || e.Element is 足_人).ToArray();
    		for (int i = 0; i < array.Length; i++)
    		{
    			sep item = array[i];
    			item.Sta.Dispose();
    			sta.Remove(item);
    		}
    	}

    	public bool チェック1(Element e)
    	{
    		if (e != null && !(e is 性器) && !(e is 肛門))
    		{
    			return !(e is Neck);
    		}
    		return false;
    	}

    	public bool チェック2(Element e)
    	{
    		if (e != null && !(e is 手_人) && !(e is 性器) && !(e is 肛門))
    		{
    			return !(e is Neck);
    		}
    		return false;
    	}
    }
}
