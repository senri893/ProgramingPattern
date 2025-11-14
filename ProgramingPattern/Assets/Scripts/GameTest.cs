using UnityEngine;

/// <summary>
/// シングルトン確認用スクリプト
/// </summary>
public class GameTest : MonoBehaviour
{
    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        //Aキーを押したとき
        if (Input.GetKeyDown(KeyCode.A))
        {
            //GameManagerのテスト変数の値を表示
            GameManager.Instance.OutputTestDebugLog();
        }

        //Sキーを押したとき
        if (Input.GetKeyDown(KeyCode.S))
        {
            //GameManagerのテスト変数をインクリメントする(1+する)
            GameManager.Instance.testNumber++;
        }
    }
}
