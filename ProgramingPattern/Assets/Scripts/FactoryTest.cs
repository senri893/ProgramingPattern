using UnityEngine;

/// <summary>
/// ファクトリーにエネミーを生成させるためのクラス
/// </summary>
public class FactoryTest : MonoBehaviour
{
    [Header("エネミーファクトリー")]
    [SerializeField] private EnemyFactory enemyFactory = null;

    //座標移動用オフセット
    private float positionOffset = 0.0f;

    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        //Zキーを押したときに丸形エネミーを生成する
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //GameObject型のenemy変数を生成しエネミーファクトリーに丸形エネミーを指定し生成させたものを代入
            GameObject enemy = enemyFactory.CreateEnemy(EnemyKind.Sphere);
            //生成したエネミーの位置補正
            SetEnemyPosition(enemy);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            //Xキーを押したときに直方体エネミーを生成する
            //GameObject型のenemy変数を生成しエネミーファクトリーに立方体エネミーを指定し生成させたものを代入
            GameObject enemy = enemyFactory.CreateEnemy(EnemyKind.Cube);
            //生成したエネミーの位置補正
            SetEnemyPosition(enemy);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            //Cキーを押したときにカプセル型エネミーを生成する
            //GameObject型のenemy変数を生成しエネミーファクトリーにカプセル型エネミーを指定し生成させたものを代入
            GameObject enemy = enemyFactory.CreateEnemy(EnemyKind.Capsule);
            //生成したエネミーの位置補正
            SetEnemyPosition(enemy);
        }
    }

    /// <summary>
    /// エネミーを少しずつずらして配置する
    /// </summary>
    private void SetEnemyPosition(GameObject enemy)
    {
        enemy.transform.position = new Vector3(positionOffset, 0.0f, 0.0f);
        //呼び出されるごとに位置を変えたいためオフセットに値を足す
        positionOffset += 1.0f;
    }
}
