using UnityEngine;

/// <summary>
/// ゲーム管理クラス [このコンポーネントをゲームシーンに一つのみアタッチしなければならない]
/// </summary>
public class GameManager : SingletonMonoBehaviour<GameManager>　//シングルトンとして扱うためシングルトン親クラスを継承　Monobehaviourは継承した時点で含まれているためこのスクリプトはゲームオブジェクトにアタッチ可能
{
    [Header("テスト用変数")]
    public int testNumber = 0;

    /// <summary>
    /// テスト用変数の中に何の値が入っているかをコンソールに表示
    /// </summary>
    public void OutputTestDebugLog()
    {
        Debug.Log($"現在設定されているテスト変数 : {testNumber}");//$は文字列補間モードの宣言
    }

}
