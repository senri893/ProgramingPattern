using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// プレイヤーイメージのカラーを管理するクラス
/// </summary>
public class PlayerColor : MonoBehaviour
{
    [Header("プレイヤーとなるイメージ")]
    [SerializeField] private Image playerImage = null;

    /// <summary>
    /// プレイヤーイメージの色を変更する
    /// </summary>
    public void ChangeColor(Color color)
    {
        //引数を元にプレイヤーのイメージ色を変更
        playerImage.color = color;
    }
}
