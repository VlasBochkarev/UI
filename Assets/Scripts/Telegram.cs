using UnityEngine;
using UnityEngine.UI;

public class Telegram : MonoBehaviour
{
    public GameObject telegram;
    public Button btnYouTube, back;

    void backToMainMenu()
    {
        telegram.SetActive(false);
    }
    void showTelegramPage()
    {
        telegram.SetActive(true);
    }

    void Start()
    {
        btnYouTube.onClick.AddListener(showTelegramPage);
        back.onClick.AddListener(backToMainMenu);

    }
}
