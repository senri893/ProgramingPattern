using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 弾管理スクリプト
/// </summary>
public class BulletManager : MonoBehaviour
{
    [Header("プール化するオブジェクトプレハブ")]
    public GameObject bullet = null;

    //オブジェクトプール
    private ObjectPool<Bullet> bulletPool = null;

    //借りているオブジェクト保管用リスト
    private List<Bullet> bulletList = new List<Bullet> ();

    //位置補正用
    private float offsetPosition = 0.0f;

    [Header("弾の生成数")]
    [SerializeField] private int bulletInstantiateCount = 0;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        //弾のプレハブから弾スクリプトの情報を取得し、取得した情報をオブジェクトプールに渡して弾を
        //指定した数分だけ生成する。
        //生成したオブジェクトを自身の子オブジェクトに登録するため自身のTransformも渡す
        bulletPool = new ObjectPool<Bullet>(bullet.GetComponent<Bullet>(),100,transform);
    }

    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        //Fキーを押して一個出現させる
        if(Input.GetKeyDown(KeyCode.F))
        {
            //生成されていた弾オブジェクトをオブジェクトプールから取り出す
            Bullet obj = bulletPool.Get();

            //取り出した弾の位置を補正
            obj.transform.position = new Vector3(offsetPosition,0.0f,0.0f);

            //取り出した弾を弾借用リストに登録
            bulletList.Add(obj);

            //弾の生成位置を変えるために値を足す
            offsetPosition += 1.0f;

            //弾を取り出した際に取り出した数を表す変数に足しておく
            //一つも弾を取り出していないときに古い弾を消さないための処理
            bulletInstantiateCount++;
        }

        //Rキーを押して一番古い弾を消す(弾を一個以上取り出しているときのみ処理)
        if (Input.GetKeyDown(KeyCode.R) && bulletInstantiateCount > 0)
        {
            //オブジェクトプールに一番古い順番に取り出した弾を返却
            bulletPool.Release(bulletList[0]);

            //返却した分の要素値は存在しなくなるためリストの要素を0番目にずらす
            bulletList.RemoveAt(0);

            //生成位置を初期化
            offsetPosition = 0.0f;

            //返却する際に弾の借用値をその分減らしておく
            bulletInstantiateCount--;
        }
    }
}
