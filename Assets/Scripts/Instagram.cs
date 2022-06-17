using UnityEngine;
using UnityEngine.UI;

public class Instagram : MonoBehaviour
{
    public GameObject instagram;
    public Button btnYouTube, back;

    void backToMainMenu()
    {
        instagram.SetActive(false);
    }
    void showInstagramPage()
    {
        instagram.SetActive(true);
    }

    void Start()
    {
        btnYouTube.onClick.AddListener(showInstagramPage);
        back.onClick.AddListener(backToMainMenu);

    }
}
