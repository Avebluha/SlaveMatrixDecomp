using System.Collections.Generic;
using System.Linq;
using System.IO;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public static class GameText
    {
    	private static string[] Race = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "System", "Race.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Attr = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "System", "Attribute.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Comm = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "System", "Common.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Base = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Basement", "Basement.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Trai = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Basement", "Training", "Training.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Targ = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Basement", "Target.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Bles = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Basement", "Blessing.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Offi = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Office", "Office.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Bebt = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Office", "Bebt.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Slav = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Office", "Slave.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Tool = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Office", "Tool.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] OP0 = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "OP0.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] OP1 = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "OP1.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Desc = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "Description.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Firs = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "First office.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Repa1 = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "Repayment1.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Repa2 = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "Repayment2.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] Repa3 = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "Repayment3.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	private static string[] VBle = (from e in Path.Combine(GlobalState.CurrentDirectory, "text", "Event", "Blessing.txt").ReadLines()
    		where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
    		select e).ToArray();

    	public static string アフール => Race[0];

    	public static string アラクネ => Race[1];

    	public static string アリコーン => Race[2];

    	public static string アルラウネ => Race[3];

    	public static string イクテュオケンタウレ => Race[4];

    	public static string ヴィオランテ => Race[5];

    	public static string ウェアウルフ => Race[6];

    	public static string ウェアキャット => Race[7];

    	public static string ウェアスタッグビートル => Race[8];

    	public static string ウェアドラゴンフライ => Race[9];

    	public static string ウェアビートル => Race[10];

    	public static string ウェアフォックス => Race[11];

    	public static string ウェアマンティス => Race[12];

    	public static string ウロボロス => Race[13];

    	public static string エイリアン => Race[14];

    	public static string エキドナ => Race[15];

    	public static string エルフ => Race[16];

    	public static string エンジェル => Race[17];

    	public static string オーグリス => Race[18];

    	public static string オールドスキュラ => Race[19];

    	public static string オールドマーメイド => Race[20];

    	public static string オノケンタウレ => Race[21];

    	public static string カーバンクル => Race[22];

    	public static string カッパ => Race[23];

    	public static string カトブレパス => Race[24];

    	public static string カプラケンタウレ => Race[25];

    	public static string カリュブディス => Race[26];

    	public static string キマイラ => Race[27];

    	public static string ギルタブリル => Race[28];

    	public static string ギルタブルル => Race[29];

    	public static string クラーケン => Race[30];

    	public static string グリフォン => Race[31];

    	public static string コカトリス => Race[32];

    	public static string ゴルゴン => Race[33];

    	public static string サイクロプス => Race[34];

    	public static string サキュバス => Race[35];

    	public static string サンドワーム => Race[36];

    	public static string シーラミア => Race[37];

    	public static string スキュラ => Race[38];

    	public static string スフィンクス => Race[39];

    	public static string スライム => Race[40];

    	public static string セイレーン => Race[41];

    	public static string チータケンタウレ => Race[42];

    	public static string ティグリスケンタウレ => Race[43];

    	public static string デビル => Race[44];

    	public static string デルピヌスケンタウレ => Race[45];

    	public static string ドラコケンタウレ => Race[46];

    	public static string ドラゴニュート => Race[47];

    	public static string ドラゴン => Race[48];

    	public static string ドルフィンマーメイド => Race[49];

    	public static string ドワーフ => Race[50];

    	public static string ハーピー => Race[51];

    	public static string バイコーン => Race[52];

    	public static string バジリスク => Race[53];

    	public static string ハルピュイア => Race[54];

    	public static string パンテーラケンタウレ => Race[55];

    	public static string ヒッポグリフ => Race[56];

    	public static string ヒッポケンタウレ => Race[57];

    	public static string ヒューマン => Race[58];

    	public static string ヒュドラ => Race[59];

    	public static string フェアリー => Race[60];

    	public static string フェニックス => Race[61];

    	public static string ブケンタウレ => Race[62];

    	public static string ペガサス => Race[63];

    	public static string マーメイド => Race[64];

    	public static string ミックス => Race[65];

    	public static string ミノタウロス => Race[66];

    	public static string ムカデジョウロウ => Race[67];

    	public static string モノケロス => Race[68];

    	public static string ユニコーン => Race[69];

    	public static string ラミア => Race[70];

    	public static string リザードマン => Race[71];

    	public static string リュウ => Race[72];

    	public static string リリン => Race[73];

    	public static string レオントケンタウレ => Race[74];

    	public static string ワーム => Race[75];

    	public static string ワイバーン => Race[76];

    	public static string 調教済 => Attr[0];

    	public static string 無毛 => Attr[1];

    	public static string 処女 => Attr[2];

    	public static string 発情 => Attr[3];

    	public static string 妊娠 => Attr[4];

    	public static string 強靭 => Attr[5];

    	public static string 傷物 => Attr[6];

    	public static string オッドアイ => Attr[7];

    	public static string ルチノー => Attr[8];

    	public static string メラニス => Attr[9];

    	public static string アルビノ => Attr[10];

    	public static string はい => Comm[0];

    	public static string いいえ => Comm[1];

    	public static string 所持金 => Comm[2];

    	public static string 借金 => Comm[3];

    	public static string 日目 => Comm[4];

    	public static string 朝 => Comm[5];

    	public static string 昼 => Comm[6];

    	public static string 夜 => Comm[7];

    	public static string 合計売却額 => Comm[8];

    	public static string 種族 => Comm[9];

    	public static string 価格 => Comm[10];

    	public static string 体力 => Comm[11];

    	public static string 感度 => Comm[12];

    	public static string 興奮 => Comm[13];

    	public static string 潤滑 => Comm[14];

    	public static string 緊張 => Comm[15];

    	public static string 羞恥 => Comm[16];

    	public static string 抵抗値 => Comm[17];

    	public static string 魔力濃度 => Comm[18];

    	public static string 欲望度 => Comm[19];

    	public static string 情愛度 => Comm[20];

    	public static string 卑屈度 => Comm[21];

    	public static string 技巧度 => Comm[22];

    	public static string 調教力 => Comm[23];

    	public static string 部位感度合計 => Comm[24];

    	public static string バストサイズ => Comm[25];

    	public static string 一般労働 => Comm[26];

    	public static string 娼婦労働 => Comm[27];

    	public static string 需給 => Comm[28];

    	public static string 売値 => Comm[29];

    	public static string 買値 => Comm[30];

    	public static string 利益 => Comm[31];

    	public static string 戻る => Comm[32];

    	public static string 収容番号 => Comm[33];

    	public static string 所持金が足りません => Comm[34];

    	public static string タイトル画面に戻りますか => Comm[35];

    	public static string セーブ中です => Comm[36];

    	public static string セーブしました => Comm[37];

    	public static string ロード中です => Comm[38];

    	public static string ロードしました => Comm[39];

    	public static string しばらくお待ちください => Comm[40];

    	public static string が妊娠しました => Comm[41];

    	public static string 労働が解除されます => Comm[42];

    	public static string が出産しました => Comm[43];

    	public static string が増殖しました => Comm[44];

    	public static string 収容できないので子は売却されます => Comm[45];

    	public static string 子を奴隷として収容します => Comm[46];

    	public static string プレイヤーの遺伝情報を設定します => Comm[47];

    	public static string 労働利益 => Comm[48];

    	public static string 利子 => Comm[49];

    	public static string 完了 => Comm[50];

    	public static string 肌の色 => Comm[51];

    	public static string 髪の色 => Comm[52];

    	public static string 瞳の色 => Comm[53];

    	public static string 体格 => Comm[54];

    	public static string プレイヤーの遺伝情報を設定してください => Comm[55];

    	public static string 後から変更できます => Comm[56];

    	public static string SlaveMatrix => Comm[57];

    	public static string 事務所 => Base[0];

    	public static string 調教 => Base[1];

    	public static string 対象 => Base[2];

    	public static string 休む => Base[3];

    	public static string 眠る => Base[4];

    	public static string 祝福 => Base[5];

    	public static string チェンジ => Base[6];

    	public static string 他の奴隷がいません => Base[7];

    	public static string 奴隷をランダムに選択します => Base[8];

    	public static string 点6 => Trai[0];

    	public static string の調教が完了しました => Trai[1];

    	public static string から祝福を受けました => Trai[2];

    	public static string 選択 => Trai[3];

    	public static string 持つ => Trai[4];

    	public static string 拘束状態を切換えます => Trai[5];

    	public static string 目隠状態を切換えます => Trai[6];

    	public static string 口枷状態を切換えます => Trai[7];

    	public static string 断面表示を切換えます => Trai[8];

    	public static string 発情状態になります => Trai[9];

    	public static string 撮影しました => Trai[10];

    	public static string 写真はPhotoフォルダに保存されます => Trai[11];

    	public static string 撮影を行います => Trai[12];

    	public static string 調教終了 => Trai[13];

    	public static string 拘束 => Trai[14];

    	public static string 目隠 => Trai[15];

    	public static string 口枷 => Trai[16];

    	public static string XRay => Trai[17];

    	public static string 媚薬 => Trai[18];

    	public static string 媚薬を打ち込んだ => Trai[19];

    	public static string 撮影 => Trai[20];

    	public static string 愛想が悪い => Trai[21];

    	public static string ダブルピースさせますか => Trai[22];

    	public static string 停止 => Trai[23];

    	public static string 作動 => Trai[24];

    	public static string 強さL => Trai[25];

    	public static string 放す => Trai[26];

    	public static string 引抜く => Trai[27];

    	public static string 離す => Trai[28];

    	public static string 押付け => Trai[29];

    	public static string 挿入 => Trai[30];

    	public static string 口腔 => Trai[31];

    	public static string 肛門 => Trai[32];

    	public static string 膣腔 => Trai[33];

    	public static string 出糸 => Trai[34];

    	public static string やめる => Trai[35];

    	public static string 擽り => Trai[36];

    	public static string 剃る => Trai[37];

    	public static string 当てる => Trai[38];

    	public static string 左打 => Trai[39];

    	public static string 右打 => Trai[40];

    	public static string 乳首 => Trai[41];

    	public static string 摘む => Trai[42];

    	public static string 繰る => Trai[43];

    	public static string 動かす => Trai[44];

    	public static string 乳房 => Trai[45];

    	public static string 掴む => Trai[46];

    	public static string 捏ねる => Trai[47];

    	public static string 陰核 => Trai[48];

    	public static string 触れる => Trai[49];

    	public static string 陰唇 => Trai[50];

    	public static string 広げる => Trai[51];

    	public static string 撫でる => Trai[52];

    	public static string マウス切替 => Trai[53];

    	public static string ペニス切替 => Trai[54];

    	public static string 吸引 => Trai[55];

    	public static string 舐る => Trai[56];

    	public static string 開放 => Trai[57];

    	public static string 擦る => Trai[58];

    	public static string 挟ませる => Trai[59];

    	public static string 挟む => Trai[60];

    	public static string やめさせる => Trai[61];

    	public static string 手コキ => Trai[62];

    	public static string 足コキ => Trai[63];

    	public static string 扱く => Trai[64];

    	public static string ハンド切替 => Trai[65];

    	public static string 外す => Trai[66];

    	public static string 装着 => Trai[67];

    	public static string 体力が限界です調教を終了します => Trai[68];

    	public static string 点6ハート => Trai[69];

    	public static string 子 => Targ[0];

    	public static string 親形質1 => Targ[1];

    	public static string 親形質2 => Targ[2];

    	public static string 保守 => Targ[3];

    	public static string 奴隷を保守対象に設定しました => Targ[4];

    	public static string 奴隷の保守設定を解除しました => Targ[5];

    	public static string 奴隷を一般労働に設定しました => Targ[6];

    	public static string 奴隷の一般労働を解除しました => Targ[7];

    	public static string 奴隷を娼婦労働に設定しました => Targ[8];

    	public static string 奴隷の娼婦労働を解除しました => Targ[9];

    	public static string 全一般 => Targ[10];

    	public static string 労働可能な全ての奴隷に一般労働を設定しました => Targ[11];

    	public static string 全娼婦 => Targ[12];

    	public static string 労働可能な全ての奴隷に娼婦労働を設定しました => Targ[13];

    	public static string 全解除 => Targ[14];

    	public static string 労働中の全ての奴隷の労働を解除しました => Targ[15];

    	public static string 売却 => Targ[16];

    	public static string 売却しますか => Targ[17];

    	public static string を売却しました => Targ[18];

    	public static string 売却をキャンセルしました => Targ[19];

    	public static string 全売却 => Targ[20];

    	public static string 保守以外の全ての奴隷を売却しますか => Targ[21];

    	public static string 保守以外の全ての奴隷を売却しました => Targ[22];

    	public static string 全売却をキャンセルしました => Targ[23];

    	public static string 胸施術 => Targ[24];

    	public static string 胸の甲殻を切除しました => Targ[25];

    	public static string 股施術 => Targ[26];

    	public static string 股の => Targ[27];

    	public static string 鱗 => Targ[28];

    	public static string 甲殻 => Targ[29];

    	public static string を切除しました => Targ[30];

    	public static string 淫紋 => Targ[31];

    	public static string 淫紋を刻みました => Targ[32];

    	public static string 衣装 => Targ[33];

    	public static string 衣装を変更しました => Targ[34];

    	public static string 胸の甲殻を切除します => Targ[35];

    	public static string を切除します => Targ[36];

    	public static string 淫紋を刻みます => Targ[37];

    	public static string 衣装を変更します => Targ[38];

    	public static string 奴隷の保守設定を切り替えます => Targ[39];

    	public static string 奴隷の一般労働設定を切り替えます => Targ[40];

    	public static string 奴隷の娼婦労働設定を切り替えます => Targ[41];

    	public static string 奴隷を売却します => Targ[42];

    	public static string 労働可能な全ての奴隷を働かせます => Targ[43];

    	public static string 労働可能な全ての奴隷を娼婦として働かせます => Targ[44];

    	public static string 全ての奴隷の労働を解除します => Targ[45];

    	public static string 保守以外の全ての奴隷を売却します => Targ[46];

    	public static string 対象が設定されていません => Targ[47];

    	public static string 祝福解除 => Bles[0];

    	public static string 祝福を解除しました => Bles[1];

    	public static string から祝福を受けています => Bles[2];

    	public static string 祝福されていません => Bles[3];

    	public static string 購入 => Offi[0];

    	public static string いらっしゃい待っていたわ => Offi[1];

    	public static string 今日はどうしたの => Offi[2];

    	public static string 借 => Bebt[0];

    	public static string 借金可能額以上は無視されます => Bebt[1];

    	public static string 今日はこれ以上借りることが出来ません => Bebt[2];

    	public static string 返 => Bebt[3];

    	public static string 返済可能額以上は無視されます => Bebt[4];

    	public static string 所持金がありません => Bebt[5];

    	public static string 今日借りれる金額はあと => Bebt[6];

    	public static string よ => Bebt[7];

    	public static string 奴隷 => Slav[0];

    	public static string 道具 => Slav[1];

    	public static string ランダム => Slav[2];

    	public static string 鳥系 => Slav[3];

    	public static string 蛇系 => Slav[4];

    	public static string 獣系 => Slav[5];

    	public static string 水系 => Slav[6];

    	public static string 虫系 => Slav[7];

    	public static string 人型 => Slav[8];

    	public static string 幻獣 => Slav[9];

    	public static string 魔獣 => Slav[10];

    	public static string 竜系 => Slav[11];

    	public static string 売り切れです => Slav[12];

    	public static string これ以上奴隷を収容できません => Slav[13];

    	public static string 買える物は何も無い => Tool[0];

    	public static string ﾃﾞｨﾙﾄﾞﾊﾞｲﾌﾞ => Tool[1];

    	public static string ﾉｰﾏﾙﾊﾞｲﾌﾞ => Tool[2];

    	public static string ﾄﾞﾘﾙﾊﾞｲﾌﾞ => Tool[3];

    	public static string ﾃﾞﾝﾏﾊﾞｲﾌﾞ => Tool[4];

    	public static string ｱﾅﾙﾊﾞｲﾌﾞ => Tool[5];

    	public static string 調教鞭 => Tool[6];

    	public static string 羽根箒 => Tool[7];

    	public static string T字剃刀 => Tool[8];

    	public static string 振動ｷｬｯﾌﾟ => Tool[9];

    	public static string ﾋﾟﾝｸﾛｰﾀ => Tool[10];

    	public static string ｱﾅﾙﾊﾟｰﾙ => Tool[11];

    	public static string 目隠帯 => Tool[12];

    	public static string 玉口枷 => Tool[13];

    	public static string カメラ => Tool[14];

    	public static string ﾌﾛｱ増設 => Tool[15];

    	public static string ふざけた値段だ => Tool[16];

    	public static string ペニスを模したバイブ => Tool[17];

    	public static string 刺激は控えめ => Tool[18];

    	public static string 一般的なバイブ => Tool[19];

    	public static string ディルドバイブより刺激が強い => Tool[20];

    	public static string 振動と回転の2つの刺激をもたらすバイブ => Tool[21];

    	public static string 強力な振動のバイブ => Tool[22];

    	public static string 刺激が強い => Tool[23];

    	public static string アナルの調教に適したバイブ => Tool[24];

    	public static string 痛みを与えるための道具 => Tool[25];

    	public static string 緊張を解きほぐすために利用する => Tool[26];

    	public static string 陰毛を剃ることが出来る => Tool[27];

    	public static string 吸着振動するキャップ => Tool[28];

    	public static string 刺激の弱いバイブの一種 => Tool[29];

    	public static string アナルの調教に適した道具 => Tool[30];

    	public static string 奴隷の視界を遮るための道具 => Tool[31];

    	public static string 奴隷の口をふさぐための道具 => Tool[32];

    	public static string 写真を撮影することが出来る => Tool[33];

    	public static string フロアを増設し収容できる奴隷の数を増やす => Tool[34];

    	public static string 点12 => OP0[0];

    	public static string 点9 => OP0[1];

    	public static string 点3 => OP0[2];

    	public static string 闇が揺れる => OP0[3];

    	public static string 身体が現る => OP0[4];

    	public static string 意識が宿る => OP0[5];

    	public static string お目覚めかしら => OP1[0];

    	public static string 話の途中で眠ってしまうんですもの => OP1[1];

    	public static string よっぽど疲れていたのね => OP1[2];

    	public static string 誰って顔をしているわね => OP1[3];

    	public static string うふふ良いわ => OP1[4];

    	public static string もう一度自己紹介をしてあげる => OP1[5];

    	public static string 私の名前はヴィオランテ => OP1[6];

    	public static string ここではヴィオラと呼ばれているわ => OP1[7];

    	public static string それでは話の続きをしましょうか => OP1[8];

    	public static string 今あなたには全部で => OP1[9];

    	public static string の借金が課せられているわ => OP1[10];

    	public static string でも心配しないで => OP1[11];

    	public static string そんなあなたにぴったりなお仕事を紹介してあげる => OP1[12];

    	public static string とっても儲かる素敵なお仕事をね => OP1[13];

    	public static string 点6ハテナ => OP1[14];

    	public static string 光が射す => OP1[15];

    	public static string 目が眩む => OP1[16];

    	public static string 見慣れぬ女が立っている => OP1[17];

    	public static string 良い香りがする => OP1[18];

    	public static string 空気はぬるい => OP1[19];

    	public static string 女は語る => OP1[20];

    	public static string 女は続ける => OP1[21];

    	public static string 女は名乗る => OP1[22];

    	public static string 違和感を覚える => OP1[23];

    	public static string 知らない世界だ => OP1[24];

    	public static string なんて日だ => OP1[25];

    	public static string 話が進む => OP1[26];

    	public static string 事は運ぶ => OP1[27];

    	public static string 安い額ではない => OP1[28];

    	public static string うふふそうよね => OP1[29];

    	public static string 身に覚えはない => OP1[30];

    	public static string 関係ないわここに書いてあるもの => OP1[31];

    	public static string ほらねそうでしょう => OP1[32];

    	public static string ここは地下牢よ => Desc[0];

    	public static string あなたにはこの場所で調教師として働いてもらうわ => Desc[1];

    	public static string 仕事の流れを説明するわね => Desc[2];

    	public static string まず事務所で奴隷を仕入れて頂戴 => Desc[3];

    	public static string 仕入れたら性奴として使えるようにあなたが躾けるの => Desc[4];

    	public static string 躾けた分だけ上乗せされた値段で売れるようになるわ => Desc[5];

    	public static string それと従順になった奴隷に働いてもらうのもいいわね => Desc[6];

    	public static string あと奴隷の転売という手もあるわ => Desc[7];

    	public static string まぁこんなところね簡単でしょう => Desc[8];

    	public static string それでは頑張って頂戴 => Desc[9];

    	public static string 期待しているわ => Desc[10];

    	public static string 冷めた空気が舞い上がる => Desc[11];

    	public static string ヴィオラは語る => Desc[12];

    	public static string 仕事が決まる => Desc[13];

    	public static string 説明が始まる => Desc[14];

    	public static string ヴィオラは続ける => Desc[15];

    	public static string 説明が続く => Desc[16];

    	public static string 説明は続く => Desc[17];

    	public static string 説明が終わる => Desc[18];

    	public static string 奴隷母体の名の下に => Desc[19];

    	public static string 物語は動き出す => Desc[20];

    	public static string どうかしたの => Firs[0];

    	public static string お金がなければ借りればいいじゃない => Firs[1];

    	public static string 借金と返済は事務所つまりここで出来るわ => Firs[2];

    	public static string 借金には1日 => Firs[3];

    	public static string の利子がつくわよ => Firs[4];

    	public static string 良心的よねうふふ => Firs[5];

    	public static string そうそう言い忘れていたけどあなたは調教師として必要な拘束術が使えるようになっているはずよ => Firs[6];

    	public static string 私からは以上よ => Firs[7];

    	public static string 仕事に戻ると良いわ => Firs[8];

    	public static string ヴィオラは佇む => Firs[9];

    	public static string ヴィオラは尋ねる => Firs[10];

    	public static string ヴィオラは返す => Firs[11];

    	public static string 話は続く => Firs[12];

    	public static string 危険な女だ => Firs[13];

    	public static string 話が終わる => Firs[14];

    	public static string 話は終わる => Firs[15];

    	public static string あなたは答える => Firs[16];

    	public static string 嘘おっしゃい無いのは分かっているわ => Firs[17];

    	public static string 金が無い => Firs[18];

    	public static string エクス2 => Firs[19];

    	public static string あなたの鎖は弾け飛ぶ => Firs[20];

    	public static string あらあら今ので利子が上がってしまったわうふふ => Firs[21];

    	public static string っ点3 => Firs[22];

    	public static string エクス1 => Firs[23];

    	public static string 鋼の鎖がヴィオラを縛る => Firs[24];

    	public static string 点3うふふ => Firs[25];

    	public static string 慎重なのは良いことよ => Firs[26];

    	public static string ヴィオラは微笑む => Firs[27];

    	public static string ヴィオラで試す => Firs[28];

    	public static string 仕事には慣れたかしら => Repa1[0];

    	public static string あなたが頑張っているおかげで奴隷の仕入元のハンターと話がまとまったの => Repa1[1];

    	public static string 今後もこの調子で頑張って頂戴 => Repa1[2];

    	public static string ヴィオラが尋ねる => Repa1[3];

    	public static string うふふ => Repa2[0];

    	public static string なかなか順調のようね => Repa2[1];

    	public static string そろそろ奴隷の身嗜みを考えてみてもいいんじゃないかしら => Repa2[2];

    	public static string 身嗜みに手を加えられるように手配しておくわね => Repa2[3];

    	public static string ヴィオラが語る => Repa2[4];

    	public static string まさか本当に完済してくれるとは思わなかったわ => Repa3[0];

    	public static string もうあなたがここに縛られている理由は何もないわね => Repa3[1];

    	public static string だから好きになさい => Repa3[2];

    	public static string そんなこと言わずにもっとゆっくりしていくといいわ => Repa3[3];

    	public static string 別にあなたを帰すときのことを考えてなかったとかそういうことではないのよ => Repa3[4];

    	public static string とにかくご苦労様 => Repa3[5];

    	public static string そしてありがとう調教師 => Repa3[6];

    	public static string あなたを手放すなんてありえないわ => Repa3[7];

    	public static string なんてったって => Repa3[8];

    	public static string もの稼ぎ手ですもの => Repa3[9];

    	public static string お勤めご苦労様 => Repa3[10];

    	public static string あなたは自由だ => Repa3[11];

    	public static string ヴィオラは黙る => Repa3[12];

    	public static string ヴィオラは慌てる => Repa3[13];

    	public static string 弁解は続く => Repa3[14];

    	public static string 物語は終わった => Repa3[15];

    	public static string 余韻が響く => Repa3[16];

    	public static string 余韻に浸る => Repa3[17];

    	public static string え => Repa3[18];

    	public static string 家に帰る => Repa3[19];

    	public static string 祝福してほしいの => VBle[0];

    	public static string そうよね => VBle[1];

    	public static string あなたはがんばったもの => VBle[2];

    	public static string ちゅっ => VBle[3];

    	public static string ヴィオラに頼む => VBle[4];

    	public static string キスされる => VBle[5];

    	public static string ヴィオラに祝福された => VBle[6];

        public static string TranslateState(EmotionType state)
        {
            string result = "";
            switch (state)
            {
                case EmotionType.Denial:
                    result = "denial";
                    break;
                case EmotionType.Humiliation:
                    result = "disgrace";
                    break;
                case EmotionType.Shame:
                    result = "shame";
                    break;
                case EmotionType.Acceptance:
                    result = "acceptance";
                    break;
                case EmotionType.Desire:
                    result = "desire";
                    break;
                case EmotionType.Excitement:
                    result = "excitement";
                    break;
                case EmotionType.余裕:
                    result = "allowance";
                    break;
                case EmotionType.Happiness:
                    result = "happiness";
                    break;
                case EmotionType.Joy:
                    result = "delight";
                    break;
                case EmotionType.Lewd:
                    result = "horny";
                    break;
                case EmotionType.Other:
                    result = "other";
                    break;
            }
            return result;
        }

        public static string TouchTranslation(ContactType part)
        {
            string result = "";
            switch (part)
            {
                case ContactType.none:
                    result = "null ";
                    break;
                case ContactType.Head:
                    result = "head ";
                    break;
                case ContactType.Face:
                    result = "face ";
                    break;
                case ContactType.Ear:
                    result = "ear  ";
                    break;
                case ContactType.Mouth:
                    result = "mouth";
                    break;
                case ContactType.Hair:
                    result = "hair ";
                    break;
                case ContactType.Neck:
                    result = "neck ";
                    break;
                case ContactType.Shoulder:
                    result = "shoul";
                    break;
                case ContactType.Chest:
                    result = "breas";
                    break;
                case ContactType.Milk:
                    result = "nippl";
                    break;
                case ContactType.Side:
                    result = "armpi";
                    break;
                case ContactType.Stomache:
                    result = "belly";
                    break;
                case ContactType.Crotch:
                    result = "crotc";
                    break;
                case ContactType.Sex:
                    result = "sex  ";
                    break;
                case ContactType.Vagina:
                    result = "vag  ";
                    break;
                case ContactType.Nucleus:
                    result = "clit ";
                    break;
                case ContactType.Anal:
                    result = "anus ";
                    break;
                case ContactType.Thread:
                    result = "spinn";
                    break;
                case ContactType.Thigh:
                    result = "thigh";
                    break;
                case ContactType.Feet:
                    result = "feet ";
                    break;
                case ContactType.Hand:
                    result = "hands";
                    break;
                case ContactType.Awareness:
                    result = "t.eye";
                    break;
                case ContactType.Touch:
                    result = "tenta";
                    break;
                case ContactType.Tail:
                    result = "tail ";
                    break;
                case ContactType.Wing:
                    result = "wings";
                    break;
                case ContactType.Fin:
                    result = "fin  ";
                    break;
                case ContactType.Other:
                    result = "other";
                    break;
            }
            return result;
        }
    }

    public class SubInfo
    {
        private ModeEventDispatcher Med;

        private InfoPanel ip;

        private string[] ss;

        private string[] メインフォーム;

        private string[] 調教中継行;

        private string[] 調教中継帰;

        private string[] 休憩;

        private string[] 事務所;

        private string[] 奴隷購入;

        private string[] 日数進行;

        public SubInfo(ModeEventDispatcher Med, InfoPanel ip)
        {
            this.Med = Med;
            this.ip = ip;
            string[] array = Path.Combine(GlobalState.CurrentDirectory, "text", "System", "SubInnfo.txt").FromText().Split(',');
            List<string> list = (from e in array[0].Replace("\r", "").Split('\n')
                                 where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
                                 select e).ToList();
            list.Insert(0, "");
            メインフォーム = list.ToArray();
            list = (from e in array[1].Replace("\r", "").Split('\n')
                    where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
                    select e).ToList();
            list.Insert(0, "");
            調教中継行 = list.ToArray();
            list = (from e in array[2].Replace("\r", "").Split('\n')
                    where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
                    select e).ToList();
            list.Insert(0, "");
            調教中継帰 = list.ToArray();
            list = (from e in array[3].Replace("\r", "").Split('\n')
                    where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
                    select e).ToList();
            list.Insert(0, "");
            休憩 = list.ToArray();
            list = (from e in array[4].Replace("\r", "").Split('\n')
                    where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
                    select e).ToList();
            list.Insert(0, "");
            事務所 = list.ToArray();
            list = (from e in array[5].Replace("\r", "").Split('\n')
                    where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
                    select e).ToList();
            list.Insert(0, "");
            奴隷購入 = list.ToArray();
            list = (from e in array[6].Replace("\r", "").Split('\n')
                    where !string.IsNullOrWhiteSpace(e) && !e.StartsWith("//")
                    select e).ToList();
            list.Insert(0, "");
            日数進行 = list.ToArray();
        }

        public void Set(bool bre)
        {
            if (bre)
            {
                ss = 休憩;
            }
            else
            {
                switch (Med.Mode)
                {
                    case "メインフォーム":
                        ss = メインフォーム;
                        break;
                    case "調教中継行":
                        ss = 調教中継行;
                        break;
                    case "調教中継帰":
                        ss = 調教中継帰;
                        break;
                    case "対象":
                        ss = メインフォーム;
                        break;
                    case "Office":
                        ss = 事務所;
                        break;
                    case "Debt":
                        ss = 事務所;
                        break;
                    case "SlaveShop":
                        ss = 奴隷購入;
                        break;
                    case "StartOfDay":
                        ss = 日数進行;
                        break;
                    default:
                        ss = null;
                        break;
                }
            }
            if (ss != null)
            {
                string text = ss[Rng.XS.Next(1, ss.Length)];
                while (text == ss[0])
                {
                    text = ss[Rng.XS.Next(1, ss.Length)];
                }
                ss[0] = text;
                ip.SubInfo = text;
            }
        }
    }
}
