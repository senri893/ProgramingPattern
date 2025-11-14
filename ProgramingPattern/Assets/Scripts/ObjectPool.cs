using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 汎用オブジェクトプール
/// </summary>
public class ObjectPool<T> where T : Component //(whereはクラスの条件を指定)
{

    //新規プレハブ
    private T prefab = null;

    //プール管理キュー
    private Queue<T> pool = new Queue<T>();

    //生成オブジェクトをまとめる親のトランスフォーム
    private Transform parent = null;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="prefab">生成するオブジェクトのプレハブ</param>
    /// <param name="initialSize">生成数</param>
    /// <param name="parent">親オブジェクトのTransform</param>
    public ObjectPool(T prefab, int initialSize, Transform parent = null)
    {
        //プレハブと親を設定
        this.prefab = prefab;
        this.parent = parent;

        //新規生成
        for(int i = 0;  i < initialSize; i++)
        {
            //渡された数値分オブジェクトを生成
            T obj = CreateNewObject();

            //生成したオブジェクトをキューに登録
            pool.Enqueue(obj);
        }
    }

    /// <summary>
    /// 新規オブジェクト生成
    /// </summary>
    private T CreateNewObject()
    {
        //オブジェクト生成
        T obj = GameObject.Instantiate(prefab,parent);

        //取り出されるまで見えないようにしておく
        obj.gameObject.SetActive(false);

        //生成したオブジェクトの情報を返す
        return obj;
    }

    /// <summary>
    /// オブジェクトを取り出す
    /// </summary>
    /// <returns></returns>
    public T Get()
    {
        //プールにオブジェクトがあればプールから取得
        if(pool.Count > 0)
        {
            //キューから登録を外す
            T obj = pool.Dequeue();

            //取り出されたためそのオブジェクトを可視化
            obj.gameObject.SetActive(true);

            //取り出されたオブジェクトの情報を返す
            return obj;
        }
        else
        {
            //足りない場合は新しく生成する
            return CreateNewObject();
        }
    }

    /// <summary>
    /// オブジェクトを返却する
    /// </summary>
    /// <param name="obj">返却するオブジェクト</param>
    public void Release(T obj)
    {
        //オブジェクトを非アクティブにして再登録する
        obj.gameObject.SetActive(false);

        //返却されたオブジェクトをキューに再び登録
        pool.Enqueue(obj);
    }
}
