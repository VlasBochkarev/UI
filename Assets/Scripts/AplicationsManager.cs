using UnityEngine;
using UnityEngine.UI;

public class AplicationsManager : MonoBehaviour
{
    public GameObject Telegram;
    public GameObject Instagram;
    public GameObject YouTube;
    public Button OpenYouTubePageButton;
    public Button OpenInstagramPageButton;
    public Button OpenTelegramPageButton;
    public Button CloseYouTubePageButton;
    public Button CloseInstagramPageButton;
    public Button CloseTelegramPageButton;

    private void Start()
    {
        OpenYouTubePageButton.onClick.AddListener(ShowYouTubePage);
        OpenInstagramPageButton.onClick.AddListener(ShowInstagramPage);
        OpenTelegramPageButton.onClick.AddListener(ShowTelegramPage);
        CloseYouTubePageButton.onClick.AddListener(BackToMainMenu);
        CloseInstagramPageButton.onClick.AddListener(BackToMainMenu);
        CloseTelegramPageButton.onClick.AddListener(BackToMainMenu);

    }

    private void BackToMainMenu()
    {
        Telegram.SetActive(false);
        Instagram.SetActive(false);
        YouTube.SetActive(false);
    }

    private void ShowTelegramPage()
    {
        Telegram.SetActive(true);
    }

    private void ShowInstagramPage()
    {
        Instagram.SetActive(true);
    }

    private void ShowYouTubePage()
    {
        YouTube.SetActive(true);
    }
}
