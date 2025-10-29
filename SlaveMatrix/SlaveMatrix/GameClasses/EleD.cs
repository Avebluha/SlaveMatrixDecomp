using _2DGAMELIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace SlaveMatrix
{
    [Serializable]
    public class EleD
    {
    	public EleD Par;

    	public ConnectionInfo 接続情報;

    	public bool 欠損;

    	public bool 筋肉;

    	public bool 拘束;

    	public Vector2D 基準B = Dat.Vec2DZero;

    	public Vector2D 基準C = Dat.Vec2DZero;

    	public Vector2D 位置B = Dat.Vec2DZero;

    	public Vector2D 位置C = Dat.Vec2DZero;

    	public double 角度B;

    	public double 角度C;

    	public double 尺度B = 1.0;

    	public double 尺度C = 1.0;

    	public double 尺度XB = 1.0;

    	public double 尺度XC = 1.0;

    	public double 尺度YB = 1.0;

    	public double 尺度YC = 1.0;

    	public double 肥大;

    	public double 身長;

    	public bool 右;

    	public bool 反転X;

    	public bool 反転Y;

    	public double Xv;

    	public double Yv;

    	public int Xi;

    	public int Yi;

    	public 配色指定 配色指定;

    	public double サイズ = 0.5;

    	public double サイズX = 0.5;

    	public double サイズY = 0.5;

    	public bool 表示 = true;

    	public double 濃度 = 1.0;

        //TODO this broke loading saves
        [NonSerialized]
        public Type ThisType;

        //Some how fixes saves (thx GPT) 

        //So how I am understend it (description)
        //This Type is empty on deserialization because Type is not serializable
        //We need just init it after deserialization

        [OnDeserialized]
        private void OnDeserialized(StreamingContext _) => ThisType = GetType();

        public virtual Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return null;
    	}

    	public virtual Ele GetEle(double DisUnit, Med Med, 主人公配色 体配色)
    	{
    		return null;
    	}

    	public bool 傷物処理()
    	{
    		bool flag = false;
    		foreach (FieldInfo item in from e in ThisType.GetFields()
    			where e.Name.EndsWith("_表示") && e.Name.Contains("傷")
    			select e)
    		{
    			bool flag2;
    			item.SetValue(this, flag2 = 0.3.Lot());
    			flag = flag || flag2;
    		}
    		return flag;
    	}

    	public virtual IEnumerable<EleD> EnumEleD()
    	{
    		yield return this;
    		foreach (FieldInfo item in from e in ThisType.GetFields()
    			where e.FieldType.ToString() == Sta.lt
    			select e)
    		{
    			List<EleD> list = (List<EleD>)item.GetValue(this);
    			if (list == null)
    			{
    				continue;
    			}
    			foreach (EleD item2 in list)
    			{
    				foreach (EleD item3 in item2.EnumEleD())
    				{
    					yield return item3;
    				}
    			}
    		}
    	}

    	public EleD Copy()
    	{
    		EleD r = (EleD)Activator.CreateInstance(ThisType);
    		FieldInfo[] fields = ThisType.GetFields();
    		EleD ec;
    		foreach (FieldInfo fieldInfo in fields)
    		{
    			if (fieldInfo.FieldType.ToString() == Sta.lt)
    			{
    				List<EleD> list = (List<EleD>)fieldInfo.GetValue(this);
    				if (list != null)
    				{
    					fieldInfo.SetValue(r, list.Select(delegate(EleD e)
    					{
    						ec = e.Copy();
    						ec.Par = r;
    						return ec;
    					}).ToList());
    				}
    			}
    			else
    			{
    				fieldInfo.SetValue(r, fieldInfo.GetValue(this));
    			}
    		}
    		return r;
    	}

    	public EleD Copy_以下無()
    	{
    		EleD eleD = (EleD)Activator.CreateInstance(ThisType);
    		FieldInfo[] fields = ThisType.GetFields();
    		foreach (FieldInfo fieldInfo in fields)
    		{
    			if (!fieldInfo.Name.Contains("_接続"))
    			{
    				fieldInfo.SetValue(eleD, fieldInfo.GetValue(this));
    			}
    		}
    		return eleD;
    	}

    	public EleD Get逆()
    	{
    		EleD eleD = Copy();
    		foreach (EleD item in eleD.EnumEleD())
    		{
    			item.右 = !item.右;
    			item.角度B = 0.0 - item.角度B;
    			item.角度C = 0.0 - item.角度C;
    		}
    		return eleD;
    	}

    	public IEnumerable<ConnectionInfo> Enum接続情報()
    	{
    		string h = ThisType.Name.Remove(ThisType.Name.Length - 1);
    		FieldInfo[] fields = ThisType.GetFields();
    		foreach (FieldInfo fieldInfo in fields)
    		{
    			if (fieldInfo.Name.Contains("_接続"))
    			{
    				yield return (h + "_" + fieldInfo.Name).To接続情報();
    			}
    		}
    	}

    	public void 接続(ConnectionInfo 接続情報, EleD ed)
    	{
    		string text = ThisType.Name.Remove(ThisType.Name.Length - 1);
            var methodName = 接続情報.ToString().Remove(0, text.Length).Replace("_", "");
            MethodInfo method = ThisType.GetMethod(接続情報.ToString().Remove(0, text.Length).Replace("_", ""));
    		object[] parameters = new EleD[1] { ed };
    		method.Invoke(this, parameters);
    	}

    	public List<EleD> Get接続(ConnectionInfo 接続情報)
    	{
    		return (List<EleD>)ThisType.GetField(接続情報.ToString().Remove(0, ThisType.Name.Length)).GetValue(this);
    	}
    }
}
