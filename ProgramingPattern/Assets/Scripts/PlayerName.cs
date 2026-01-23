using TMPro;
using UnityEngine;

/// <summary>
/// プレイヤー名を表示するクラス
/// </summary>
public class PlayerName : MonoBehaviour
{
    [Header("プレイヤー名テキストフィールド")]
    [SerializeField] private TMP_Text playerNameTextField = null;

    /// <summary>
    /// プレイヤー名設定
    /// </summary>
    public void SetPlayerName(string name)
    {
        //引数を元にプレイヤー名を変更
        playerNameTextField.text = name;
    }
}
