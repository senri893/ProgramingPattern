using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// ダメージオブザーバー用インターフェース
/// </summary>
public interface IDamage 
{
    //ダメージを受けるメソッドをインターフェースで指定
    void Damage(int currentHp);
}

/// <summary>
/// プレイヤー基本クラス　(基本クラス自体には細かい処理は書かない)
/// </summary>
public class Player : MonoBehaviour
{
    //ダメージメソッド呼び出し用オブザーバー
    private List<IDamage> damageObserver = new List<IDamage>();

    //プレイヤーHP
    private int hp = 0;

    
    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        //hpは50に設定
        hp = 50;
    }

    /// <summary>
    /// ダメージオブザーバーの追加
    /// </summary>
    /// <param name="iDamage"></param>
    public void AddDamageObserver(IDamage iDamage)
    {
        //引数として渡された観察者をオブザーバーのリストに追加
        damageObserver.Add(iDamage);
    }

    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        //テスト : Dキーでダメージを受ける
        if(Input.GetKeyDown(KeyCode.D))
        {
            //仮で10ダメージ入れる形
            ReceiveDamage(10);
        }
    }

    /// <summary>
    /// ダメージを受けた時の処理
    /// </summary>
    /// <param name="damage"></param>
    private void ReceiveDamage(int damage)
    {
        //ダメージを受けた際観察者のダメージ処理メソッドをリストに格納された分実行するためのループ開始
        foreach(var observer in damageObserver)
        {
            observer.Damage(damage);
        }
    }
}
