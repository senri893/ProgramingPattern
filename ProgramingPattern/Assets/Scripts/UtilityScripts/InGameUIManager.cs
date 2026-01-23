using UnityEngine;

/// <summary>
/// ゲームシーン中のUIを完了するクラス
/// </summary>
public class InGameUIManager : SingletonMonoBehaviour<InGameUIManager>
{
    [Header("プレイヤーカラークラス")]
    [SerializeField] private PlayerColor playerColor = null;

    [Header("プレイヤー名クラス")]
    [SerializeField] private PlayerName playerName = null;

    /// <summary>
    /// プレイヤーの色を変更する
    /// </summary>
    public void ChangeColor(Color color)
    {
        //プレイヤーカラークラスに引数のカラーを渡して呼び出す
        playerColor.ChangeColor(color);
    }

    /// <summary>
    /// プレイヤー名の変更
    /// </summary>
    public void SetPlayerName(string name)
    {
        //プレイヤー名クラスに引数の文字列を渡して呼び出す
        playerName.SetPlayerName(name);
    }
}

//Managerクラスに入れておけば必要な処理をいちいちクラスを検索する手間が省けて
//参照元も分かりやすいためリファクタリングもしやすくなる利点がある
//Managerとなるクラスは各用途ごと使い分けるのが適切
//処理を一つのクラスにまとめるのではなく機能ごとにクラスを作り分けることが実用
//Managerのクラスはラッパークラス(包む)とも呼ぶ
//Managerのクラス自体には処理を書かずメソッドを呼び出すのが普通