using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
    public class But1 : But
    {
    	public List<Color> BaseColors = new List<Color>();

    	public List<Color> OverColors = new List<Color>();

    	public List<Color> PushColors = new List<Color>();

    	public List<Color> TextColors = new List<Color>();

    	public But1(ParT ParT, Action<But> Action)
    		: base(ParT, Action)
    	{
    		Setting();
    	}

    	private void Setting()
    	{
    		foreach (Par item in pars.EnumAllPar())
    		{
    			BaseColors.Add(item.GetBrushColor());
    			OverColors.Add(BaseColors.Last().FuncHSV(delegate(Hsv hsv)
    			{
    				hsv.Hue += 30;
    				hsv.Sat -= 30;
    				hsv.Val += 100;
    				return hsv;
    			}));
    			PushColors.Add(OverColors.Last().FuncHSV(delegate(Hsv hsv)
    			{
    				hsv.Hue += 30;
    				hsv.Sat -= 30;
    				hsv.Val += 100;
    				return hsv;
    			}));
    			TextColors.Add(item.IsParT() ? item.ToParT().GetTextColor() : Color.Empty);
    		}
    		Over = delegate
    		{
    			int num4 = 0;
    			foreach (Par item2 in pars.EnumAllPar())
    			{
    				item2.SetBrushColor(OverColors[num4]);
    				if (item2.IsParT())
    				{
    					item2.ToParT().SetTextColor(TextColors[num4].Reverse());
    				}
    				num4++;
    			}
    		};
    		Push = delegate
    		{
    			int num3 = 0;
    			foreach (Par item3 in pars.EnumAllPar())
    			{
    				item3.SetBrushColor(PushColors[num3]);
    				if (item3.IsParT())
    				{
    					item3.ToParT().SetTextColor(TextColors[num3].Reverse());
    				}
    				num3++;
    			}
    		};
    		Release = delegate
    		{
    			int num2 = 0;
    			foreach (Par item4 in pars.EnumAllPar())
    			{
    				item4.SetBrushColor(OverColors[num2]);
    				if (item4.IsParT())
    				{
    					item4.ToParT().SetTextColor(TextColors[num2].Reverse());
    				}
    				num2++;
    			}
    		};
    		Out = delegate
    		{
    			int num = 0;
    			foreach (Par item5 in pars.EnumAllPar())
    			{
    				item5.SetBrushColor(BaseColors[num]);
    				if (item5.IsParT())
    				{
    					item5.ToParT().SetTextColor(TextColors[num]);
    				}
    				num++;
    			}
    		};
    	}
    }
}
