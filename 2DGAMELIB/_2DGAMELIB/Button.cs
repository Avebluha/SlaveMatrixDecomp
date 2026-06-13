using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
    public class Button : ButtonBase
    {
    	public List<Color> BaseColors = new List<Color>();

    	public List<Color> OverColors = new List<Color>();

    	public List<Color> PushColors = new List<Color>();

    	public List<Color> TextColors = new List<Color>();

    	public Button(ShapePartT ShapePartT, Action<ButtonBase> Action)
    		: base(ShapePartT, Action)
    	{
    		Setting();
    	}

    	private void Setting()
    	{
    		foreach (ShapePart item in partGroup.EnumAllPar())
    		{
    			BaseColors.Add(item.BrushColor);
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
    			TextColors.Add(item.IsParT() ? item.ToParT().TextColor : Color.Empty);
    		}
    		Over = delegate
    		{
    			int num4 = 0;
    			foreach (ShapePart item2 in partGroup.EnumAllPar())
    			{
    				item2.BrushColor = OverColors[num4];
    				if (item2.IsParT())
    				{
    					item2.ToParT().TextColor = TextColors[num4].Reverse();
    				}
    				num4++;
    			}
    		};
    		Push = delegate
    		{
    			int num3 = 0;
    			foreach (ShapePart item3 in partGroup.EnumAllPar())
    			{
    				item3.BrushColor = PushColors[num3];
    				if (item3.IsParT())
    				{
    					item3.ToParT().TextColor = TextColors[num3].Reverse();
    				}
    				num3++;
    			}
    		};
    		Release = delegate
    		{
    			int num2 = 0;
    			foreach (ShapePart item4 in partGroup.EnumAllPar())
    			{
    				item4.BrushColor = OverColors[num2];
    				if (item4.IsParT())
    				{
    					item4.ToParT().TextColor = TextColors[num2].Reverse();
    				}
    				num2++;
    			}
    		};
    		Out = delegate
    		{
    			int num = 0;
    			foreach (ShapePart item5 in partGroup.EnumAllPar())
    			{
    				item5.BrushColor = BaseColors[num];
    				if (item5.IsParT())
    				{
    					item5.ToParT().TextColor = TextColors[num];
    				}
    				num++;
    			}
    		};
    	}
    }
}
