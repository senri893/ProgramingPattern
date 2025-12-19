using UnityEngine;

/// <summary>
/// プレイヤーHPバークラス　(プレイヤーの体力の処理はこのクラスのみに書く)
/// </summary>
public class PlayerHpBar : MonoBehaviour, IDamage
{
    [Header("Playerクラス")]
    [SerializeField] private Player player = null;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        //自身をプレイヤーの観察者として登録するためプレイヤー基本クラスのオブザーバー追加メソッドの引数に自身をインターフェース型に暗黙的キャストで渡す
        player.AddDamageObserver(this);        
    }

    /// <summary>
    /// ダメージ処理
    /// </summary>
    /// <param name="currentHp"></param>
    public void Damage(int currentHp)
    {
        //このメソッド内にダメージを受けたときに実行する処理を書く
        Debug.Log("ダメージバー変更");
    }
}
