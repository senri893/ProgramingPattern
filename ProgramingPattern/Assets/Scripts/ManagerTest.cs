using UnityEngine;

/// <summary>
/// UIManager動作確認クラス
/// </summary>
public class ManagerTest : MonoBehaviour
{
    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        //プレイヤー名変更
        InGameUIManager.Instance.SetPlayerName("tanaka tarou");
        
        //プレイヤーカラー変更
        InGameUIManager.Instance.ChangeColor(Color.blue);
        //SingletonMonoBehaviour継承しているためクラスごとにインスタンスを保持しなくても呼び出せる
    }
}
