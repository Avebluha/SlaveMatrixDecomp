using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
    public class ScreenSwitch
    {
    	private bool flag;

    	private Color OnColor = Color.Red;

    	private List<Color> colors;

    	public bool Flag => flag;

    	public ScreenSwitch(Color OnColor)
    	{
    		this.OnColor = OnColor;
    	}

    	public void OnOff(ButtonBase ButtonBase)
    	{
    		Button but = (Button)ButtonBase;
    		if (!flag)
    		{
    			flag = true;
    			if (colors == null)
    			{
    				colors = new List<Color>(but.BaseColors);
    			}
    			int i;
    			for (i = 0; i < but.BaseColors.Count; i++)
    			{
    				but.BaseColors[i] = OnColor;
    				but.OverColors[i] = but.BaseColors[i].FuncHSV(delegate(Hsv hsv)
    				{
    					hsv.Hue += 30;
    					hsv.Sat -= 30;
    					hsv.Val += 100;
    					return hsv;
    				});
    				but.PushColors[i] = but.OverColors[i].FuncHSV(delegate(Hsv hsv)
    				{
    					hsv.Hue += 30;
    					hsv.Sat -= 30;
    					hsv.Val += 100;
    					return hsv;
    				});
    			}
    			i = 0;
    			{
    				foreach (ShapePart item in but.PartGroup.EnumAllPar())
    				{
    					item.SetBrushColor(but.OverColors[i]);
    					i++;
    				}
    				return;
    			}
    		}
    		flag = false;
    		if (colors != null)
    		{
    			but.BaseColors = colors;
    			colors = null;
    		}
    		int j;
    		for (j = 0; j < but.BaseColors.Count; j++)
    		{
    			but.OverColors[j] = but.BaseColors[j].FuncHSV(delegate(Hsv hsv)
    			{
    				hsv.Hue += 30;
    				hsv.Sat -= 30;
    				hsv.Val += 100;
    				return hsv;
    			});
    			but.PushColors[j] = but.OverColors[j].FuncHSV(delegate(Hsv hsv)
    			{
    				hsv.Hue += 30;
    				hsv.Sat -= 30;
    				hsv.Val += 100;
    				return hsv;
    			});
    		}
    		j = 0;
    		foreach (ShapePart item2 in but.PartGroup.EnumAllPar())
    		{
    			item2.SetBrushColor(but.OverColors[j]);
    			j++;
    		}
    	}

    	public void SetFlag(ButtonBase ButtonBase, bool On)
    	{
    		Button but = (Button)ButtonBase;
    		if (On)
    		{
    			flag = true;
    			if (colors == null)
    			{
    				colors = new List<Color>(but.BaseColors);
    			}
    			int i;
    			for (i = 0; i < but.BaseColors.Count; i++)
    			{
    				but.BaseColors[i] = OnColor;
    				but.OverColors[i] = but.BaseColors[i].FuncHSV(delegate(Hsv hsv)
    				{
    					hsv.Hue += 30;
    					hsv.Sat -= 30;
    					hsv.Val += 100;
    					return hsv;
    				});
    				but.PushColors[i] = but.OverColors[i].FuncHSV(delegate(Hsv hsv)
    				{
    					hsv.Hue += 30;
    					hsv.Sat -= 30;
    					hsv.Val += 100;
    					return hsv;
    				});
    			}
    			i = 0;
    			{
    				foreach (ShapePart item in but.PartGroup.EnumAllPar())
    				{
    					item.SetBrushColor(but.BaseColors[i]);
    					i++;
    				}
    				return;
    			}
    		}
    		flag = false;
    		if (colors != null)
    		{
    			but.BaseColors = colors;
    			colors = null;
    		}
    		int j;
    		for (j = 0; j < but.BaseColors.Count; j++)
    		{
    			but.OverColors[j] = but.BaseColors[j].FuncHSV(delegate(Hsv hsv)
    			{
    				hsv.Hue += 30;
    				hsv.Sat -= 30;
    				hsv.Val += 100;
    				return hsv;
    			});
    			but.PushColors[j] = but.OverColors[j].FuncHSV(delegate(Hsv hsv)
    			{
    				hsv.Hue += 30;
    				hsv.Sat -= 30;
    				hsv.Val += 100;
    				return hsv;
    			});
    		}
    		j = 0;
    		foreach (ShapePart item2 in but.PartGroup.EnumAllPar())
    		{
    			item2.SetBrushColor(but.BaseColors[j]);
    			j++;
    		}
    	}
    }
}
