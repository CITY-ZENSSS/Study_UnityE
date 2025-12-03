using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;

    public void SetContent(string title, string content) // ÆË¾÷ ³»¿ë ¼³Á¤
    {
        titleText.text = title;
        contentText.text = content;
    }


    public void ClosePopup() // ÆË¾÷ ´Ý±â
    {
        Destroy(gameObject);
    }
}
// 