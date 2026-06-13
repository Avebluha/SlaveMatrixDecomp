using System;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix
{
    [Serializable]
    public class 足_人D : 足D
    {
    	public bool ヒール0_靴底_表示;

    	public bool ヒール0_ヒール_表示;

    	public bool サンダル0_靴底_表示;

    	public bool サンダル0_踵_表示;

    	public bool ナース0_靴底_表示;

    	public bool ナース0_踵_表示;

    	public bool ブーツ0_靴底_表示;

    	public bool ブーツ0_ヒール_表示;

    	public bool アーマ0_靴底_表示;

    	public bool アーマ0_踵_表示;

    	public bool 足_表示 = true;

    	public bool 小指_小指1_表示 = true;

    	public bool 小指_小指2_表示 = true;

    	public bool 小指_小指3_表示 = true;

    	public bool 薬指_水掻_表示;

    	public bool 薬指_薬指1_表示 = true;

    	public bool 薬指_薬指2_表示 = true;

    	public bool 薬指_薬指3_表示 = true;

    	public bool 中指_水掻_表示;

    	public bool 中指_中指1_表示 = true;

    	public bool 中指_中指2_表示 = true;

    	public bool 中指_中指3_表示 = true;

    	public bool 人指_人指1_表示 = true;

    	public bool 人指_人指2_表示 = true;

    	public bool 人指_人指3_表示 = true;

    	public bool 人指_水掻_表示;

    	public bool 親指_親指2_表示 = true;

    	public bool 親指_親指3_表示 = true;

    	public bool 親指_水掻_表示;

    	public bool 悪タトゥ_五芒星_円1_表示;

    	public bool 悪タトゥ_五芒星_円2_表示;

    	public bool 悪タトゥ_五芒星_星_表示;

    	public bool 悪タトゥ_五芒星_五角形_表示;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗4_表示;

    	public bool 竜性_鱗5_表示;

    	public bool パンスト_パンスト1_表示;

    	public bool パンスト_パンスト2_表示;

    	public bool ソックス_ソックス1_表示;

    	public bool ソックス_ソックス2_表示;

    	public bool ヒール1_バンプ_表示;

    	public bool ヒール1_ストラップ_ストラップ_表示;

    	public bool ヒール1_ストラップ_金具1_金具1_表示;

    	public bool ヒール1_ストラップ_金具1_金具2_表示;

    	public bool ヒール1_ストラップ_金具1_金具3_表示;

    	public bool ヒール1_ストラップ_金具1_金具4_表示;

    	public bool ヒール1_ストラップ_金具2_金具1_表示;

    	public bool ヒール1_ストラップ_金具2_金具2_表示;

    	public bool ヒール1_ストラップ_金具2_金具3_表示;

    	public bool ヒール1_ストラップ_金具2_金具4_表示;

    	public bool ヒール1_ハイライト_表示;

    	public bool サンダル1_ストラップ3_表示;

    	public bool サンダル1_ストラップ2_表示;

    	public bool サンダル1_ストラップ4_表示;

    	public bool サンダル1_ストラップ1_表示;

    	public bool ナース1_ストラップ3_ストラップ_表示;

    	public bool ナース1_ストラップ3_縁1_表示;

    	public bool ナース1_ストラップ3_縁2_表示;

    	public bool ナース1_ストラップ2_ストラップ_表示;

    	public bool ナース1_ストラップ2_縁1_表示;

    	public bool ナース1_ストラップ2_縁2_表示;

    	public bool ナース1_ストラップ1_ストラップ_表示;

    	public bool ナース1_ストラップ1_縁1_表示;

    	public bool ナース1_ストラップ1_縁2_表示;

    	public bool ブーツ1_タン_表示;

    	public bool ブーツ1_バンプ_バンプ_表示;

    	public bool ブーツ1_バンプ_縁_縁1_表示;

    	public bool ブーツ1_バンプ_縁_縁2_表示;

    	public bool ブーツ1_バンプ_縁_縁3_表示;

    	public bool ブーツ1_バンプ_縁_縁4_表示;

    	public bool ブーツ1_ハイライト_表示;

    	public bool ブーツ1_柄_表示;

    	public bool ブーツ1_紐_紐1_紐下_金具上_金具_表示;

    	public bool ブーツ1_紐_紐1_紐下_金具上_穴_表示;

    	public bool ブーツ1_紐_紐1_紐下_紐_表示;

    	public bool ブーツ1_紐_紐1_紐上_金具上_金具_表示;

    	public bool ブーツ1_紐_紐1_紐上_金具上_穴_表示;

    	public bool ブーツ1_紐_紐1_紐上_紐_表示;

    	public bool ブーツ1_紐_紐2_紐下_金具上_金具_表示;

    	public bool ブーツ1_紐_紐2_紐下_金具上_穴_表示;

    	public bool ブーツ1_紐_紐2_紐下_紐_表示;

    	public bool ブーツ1_紐_紐2_紐上_金具上_金具_表示;

    	public bool ブーツ1_紐_紐2_紐上_金具上_穴_表示;

    	public bool ブーツ1_紐_紐2_紐上_紐_表示;

    	public bool ブーツ1_紐_紐3_紐下_金具上_金具_表示;

    	public bool ブーツ1_紐_紐3_紐下_金具上_穴_表示;

    	public bool ブーツ1_紐_紐3_紐下_紐_表示;

    	public bool ブーツ1_紐_紐3_紐上_金具上_金具_表示;

    	public bool ブーツ1_紐_紐3_紐上_金具上_穴_表示;

    	public bool ブーツ1_紐_紐3_紐上_紐_表示;

    	public bool ブーツ1_紐_紐4_紐下_金具上_金具_表示;

    	public bool ブーツ1_紐_紐4_紐下_金具上_穴_表示;

    	public bool ブーツ1_紐_紐4_紐下_紐_表示;

    	public bool ブーツ1_紐_紐4_紐上_金具上_金具_表示;

    	public bool ブーツ1_紐_紐4_紐上_金具上_穴_表示;

    	public bool ブーツ1_紐_紐4_紐上_紐_表示;

    	public bool ブーツ1_紐_紐5_金具1_金具_表示;

    	public bool ブーツ1_紐_紐5_金具1_穴_表示;

    	public bool ブーツ1_紐_紐5_金具2_金具_表示;

    	public bool ブーツ1_紐_紐5_金具2_穴_表示;

    	public bool ブーツ1_紐_紐5_紐_表示;

    	public bool アーマ1_鉄靴1_表示;

    	public bool アーマ1_鉄靴2_表示;

    	public bool アーマ1_鉄靴3_表示;

    	public bool ナース1_ストラップ4_ストラップ_表示;

    	public bool ナース1_ストラップ4_縁1_表示;

    	public bool ナース1_ストラップ4_縁2_表示;

    	public double 鋭爪;

    	public bool 虫性;

    	public bool 虫足;

    	public bool ヒール表示;

    	public bool サンダル表示;

    	public bool ナース表示;

    	public bool ブーツ表示;

    	public bool メイル表示;

    	public bool パンスト表示;

    	public bool ニーハイ表示;

    	public 足_人D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, ModeEventDispatcher Med, BodyColorSet 体配色)
    	{
    		return new 足_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
