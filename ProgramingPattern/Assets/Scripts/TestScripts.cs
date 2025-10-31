using UnityEngine;

/// <summary>
/// コンソールログに文字列を表示するクラス
/// </summary>
public class TestScripts : MonoBehaviour
{
    /// <summary>
    /// ゲーム開始時に処理
    /// </summary>
    private void Start()
    {
        //int型のローカル変数に数値を代入して三桁ずつコンマを入れる文字列を生成するメソッドに引数として代入
        int a = 123456789;
        //帰ってきた文字列をローカル変数に保持
        string b = UIUtility.NumberFormatter(a);

        //float型のローカル変数に数値を代入してパーセント表示にするメソッドに代入
        float c = 0.45286f;
        //帰ってきた文字列をローカル変数に保持
        string d = UIUtility.ConvertPercent(c);

        //コンソールにログとして先ほどの文字列のローカル変数を表示
        Debug.Log($"3桁ずつ,を入れた数字 : {b}");
        Debug.Log($"パーセントに直した数字 : {d}");
    }
}
