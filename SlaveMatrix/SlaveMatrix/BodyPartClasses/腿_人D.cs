using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 腿_人D : 腿D
    {
    	public bool 腿_表示 = true;

    	public bool 筋_表示;

    	public bool 獣性_獣毛1_表示;

    	public bool 獣性_獣毛2_表示;

    	public bool 淫タトゥ_ハート_タトゥ左_表示;

    	public bool 淫タトゥ_ハート_タトゥ右_表示;

    	public bool 淫タトゥ_タトゥ左1_表示;

    	public bool 淫タトゥ_タトゥ右1_表示;

    	public bool 淫タトゥ_タトゥ左2_表示;

    	public bool 淫タトゥ_タトゥ右2_表示;

    	public bool 悪タトゥ1_文字_文字a_枠_表示;

    	public bool 悪タトゥ1_文字_文字a_文字タトゥ1_表示;

    	public bool 悪タトゥ1_文字_文字a_文字タトゥ2_表示;

    	public bool 悪タトゥ1_文字_文字b_枠_表示;

    	public bool 悪タトゥ1_文字_文字b_文字タトゥ1_表示;

    	public bool 悪タトゥ1_文字_文字b_文字タトゥ2_表示;

    	public bool 悪タトゥ1_文字_文字c_枠_表示;

    	public bool 悪タトゥ1_文字_文字c_文字タトゥ1_表示;

    	public bool 悪タトゥ1_文字_文字c_文字タトゥ2_表示;

    	public bool 悪タトゥ1_文字_文字d_枠_表示;

    	public bool 悪タトゥ1_文字_文字d_文字タトゥ1_表示;

    	public bool 悪タトゥ1_文字_文字d_文字タトゥ2_表示;

    	public bool 悪タトゥ1_文字_文字e_枠_表示;

    	public bool 悪タトゥ1_文字_文字e_文字タトゥ1_表示;

    	public bool 悪タトゥ1_文字_文字e_文字タトゥ2_表示;

    	public bool 悪タトゥ1_文字_文字e_文字タトゥ3_表示;

    	public bool 悪タトゥ1_タトゥ1_表示;

    	public bool 悪タトゥ1_タトゥ2_表示;

    	public bool 悪タトゥ2_逆十字_逆十字1_表示;

    	public bool 悪タトゥ2_逆十字_逆十字2_表示;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗4_表示;

    	public bool 紋柄_紋1_表示;

    	public bool 紋柄_紋2_表示;

    	public bool 紋柄_紋3_表示;

    	public bool 紋柄_紋4_表示;

    	public bool 植性_通常_葉3_表示;

    	public bool 植性_通常_葉2_表示;

    	public bool 植性_通常_葉1_表示;

    	public bool 植性_欠損_葉3_表示;

    	public bool 植性_欠損_葉2_表示;

    	public bool 植性_欠損_葉1_表示;

    	public bool 虫性_器官1_表示;

    	public bool 虫性_器官2_表示;

    	public bool 傷I1_表示;

    	public bool 傷I2_表示;

    	public bool 傷I3_表示;

    	public bool 傷I4_表示;

    	public bool 傷X_表示;

    	public bool ハイライト1_表示;

    	public bool ハイライト2_表示;

    	public bool パンスト_表示;

    	public bool ニーハイ_ニーハイ1_表示;

    	public bool ニーハイ_ニーハイ2_表示;

    	public bool ニーハイ_ハイライト_表示;

    	public bool 植性_葉3_表示;

    	public bool 植性_葉2_表示;

    	public bool 植性_葉1_表示;

    	public bool ハイライト表示;

    	public double 筋肉濃度 = 1.0;

    	public double 傷I1濃度 = 1.0;

    	public double 傷I2濃度 = 1.0;

    	public double 傷I3濃度 = 1.0;

    	public double 傷I4濃度 = 1.0;

    	public double 傷X濃度 = 1.0;

    	public double ハイライト濃度 = 1.0;

    	public bool 虫性;

    	public bool スライム;

    	public bool パンスト表示;

    	public bool ニーハイ表示;

    	public 腿_人D()
    	{
    		ThisType = GetType();
    	}

    	public override void Leg接続(EleD e)
    	{
    		Leg_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.腿_人_Leg_接続;
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, 体配色 体配色)
    	{
    		return new 腿_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
