using UnityEngine;

/// <summary>
/// 汎用的に使う処理(ここでは引数をそれぞれの用途に合った表記をした文字列に変換するための処理)
/// </summary>
public static class UIUtility
{
    /// <summary>
    /// 3桁ごとに「,」を挿入した文字列を生成するメソッド(インスタンス化しないためstaticをつける)
    /// </summary>
    public static string NumberFormatter(int number)
    {
        //引数を3桁ずるコンマを入れた文字列に変換して返す
        return number.ToString("#,0");
    }

    /// <summary>
    /// 数値をパーセント表示に変更するメソッド(インスタンス化しないためstaticをつける)
    /// </summary>
    public static string ConvertPercent(float ratio)
    {
        //引数を100で割った数値をローカル変数として生成
        float convertRatio = ratio * 100.0f;

        //割った数値を小数点第二位までを表示した文字列にし％を末尾につけた状態の文字列を返す
        return convertRatio.ToString("F2") + "%";
    }
}

//staticはアクセスした瞬間に生成される
