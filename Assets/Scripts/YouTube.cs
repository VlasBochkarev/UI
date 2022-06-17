using UnityEngine;
using UnityEngine.UI;

public class YouTube : MonoBehaviour
{
    public GameObject youTube;
    public Button btnYouTube, back;

    void backToMainMenu()
    {
        youTube.SetActive(false);
    }
    void showYouTubePage()
    {
        youTube.SetActive(true);
    }

    void Start()
    {
        btnYouTube.onClick.AddListener(showYouTubePage);
        back.onClick.AddListener(backToMainMenu);
        
    }

 
}
