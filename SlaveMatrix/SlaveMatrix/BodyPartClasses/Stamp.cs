using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public struct sep
    {
        public Ele Sta;

        public Ele Ele;

        public Par Par;

        public List<int> Path;

        public Vector2D Pos;
    }

    //three subclasses: one for bukkake, kiss marks, and whip marks
    public class Stamp
    {
    	public Med Med;

    	public RenderArea Are;

    	public Cha Cha;

    	public Bod Bod;

    	protected EleD EleD;

    	protected List<sep> sta = new List<sep>();

    	protected const int Max = 33;

    	protected Par p;

    	protected Color2 c2;

    	protected Ele he;

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

    	public Stamp(Med Med, RenderArea Are, Cha Cha, Bod Bod, EleD EleD)
    	{
    		this.Med = Med;
    		this.Are = Are;
    		this.Cha = Cha;
    		this.Bod = Bod;
    		this.EleD = EleD;
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

    	public void 脚Clear()
    	{
    		sep[] array = sta.Where((sep e) => e.Ele is 腿_人 || e.Ele is 脚_人 || e.Ele is 足_人).ToArray();
    		for (int i = 0; i < array.Length; i++)
    		{
    			sep item = array[i];
    			item.Sta.Dispose();
    			sta.Remove(item);
    		}
    	}

    	public bool チェック1(Ele e)
    	{
    		if (e != null && !(e is 性器) && !(e is 肛門))
    		{
    			return !(e is Neck);
    		}
    		return false;
    	}

    	public bool チェック2(Ele e)
    	{
    		if (e != null && !(e is 手_人) && !(e is 性器) && !(e is 肛門))
    		{
    			return !(e is Neck);
    		}
    		return false;
    	}
    }
}
