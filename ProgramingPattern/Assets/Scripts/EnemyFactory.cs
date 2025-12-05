using UnityEngine;

//敵の種類
public enum EnemyKind:int
{
    //列挙型にintを継承させることでintの変数のように扱うこともできる
    None = -1,
    [Tooltip("丸形エネミー生成宣言")] Sphere = 0,
    [Tooltip("立方体エネミー生成宣言")] Cube = 1,
    [Tooltip("カプセル型エネミー生成宣言")] Capsule = 2,
}

/// <summary>
/// 敵生成ファクトリー
/// </summary>
public class EnemyFactory : MonoBehaviour 
{
    [Header("丸形エネミープレハブ")]
    [SerializeField] private GameObject sphereEnemy = null;

    [Header("立方体エネミープレハブ")]
    [SerializeField] private GameObject cubeEnemy = null;

    [Header("カプセル型エネミープレハブ")]
    [SerializeField] private GameObject capsuleEnemy = null;

    /// <summary>
    /// エネミーを生成するファクトリーのメソッド　エネミーの種類を指定することでそのエネミーを生成できる
    /// </summary>
    public GameObject CreateEnemy(EnemyKind kind)
    {
        //返却用インスタンス
        GameObject enemyInstance = null; //生成した瞬間は初期化　変数にして返す理由はreturnしている個所をできるだけ少なくしたほうが
        　　　　　　　　　　　　　　　　//いいのと変数にすれば生成したインスタンスにコンポーネントなどをアタッチしたりなど
                        　　　　　　　　//柔軟に対応できるため

        //エネミー別生成メソッド切り替え
        switch (kind) 
        {
            //Sphereが選択されたら丸形エネミーを生成するメソッドを呼び出し返された変数を返すインスタンスとして設定
           case EnemyKind.Sphere: enemyInstance = CreateSphreEnemy(); break;
            //Cubeが選択されたら立方体エネミーを生成するメソッドを呼び出し返された変数を返すインスタンスとして設定
            case EnemyKind.Cube: enemyInstance = CreateCubeEnemy(); break;
            //Capsuleが選択されたらカプセル型エネミーを生成するメソッドを呼び出し返された変数を返すインスタンスとして設定
            case EnemyKind.Capsule: enemyInstance = CreateCapsuleEnemy(); break;
           default:
               Debug.LogError($"想定されていないタイプの生成エネミーの種類が渡されました : [{kind}]は無効なタイプのエネミーです ");
                return null;//インスタンスを生成できないため無駄な処理を減らすためここでメソッドを止めておく
        }

        //生成したインスタンスを返す
        return enemyInstance;
    }

    /// <summary>
    /// 丸形エネミー生成
    /// </summary>
    private GameObject CreateSphreEnemy()
    {
        //生成した丸形エネミーを返す
        return Instantiate(sphereEnemy);
    }

    /// <summary>
    /// 立方体エネミー生成
    /// </summary>
    private GameObject CreateCubeEnemy()
    {
        //生成した立方体エネミーを返す
        return Instantiate(cubeEnemy);
    }

    /// <summary>
    /// カプセル形エネミー生成
    /// </summary>
    private GameObject CreateCapsuleEnemy()
    {
        //生成したカプセル型エネミーを返す
        return Instantiate(capsuleEnemy);
    }

    //参照先がややこしくごちゃごちゃになるのを防ぐため外部から生成するオブジェクトを指定するメソッド以外はprivate
}
