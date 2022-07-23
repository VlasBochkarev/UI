using UnityEngine;
using UnityEngine.UI;

public class OpenMenu : MonoBehaviour
{
    public GameObject ShowMenuPage;
    public Button ShowMenuPageButton;
    public Button CloseMenuPageButton;

    private Animator MyAnimator;
    private readonly int _showMenuHash = Animator.StringToHash("isShowMenu");

    private void Start()
    {
        MyAnimator = GetComponent<Animator>();
        ShowMenuPageButton.onClick.AddListener(ShowMenu);
        CloseMenuPageButton.onClick.AddListener(CloseMenu);
    }

    private void ShowMenu()
    {
        MyAnimator.SetBool(_showMenuHash, true);
    }

    private void CloseMenu()
    {
        MyAnimator.SetBool("isShowMenu", false);
    }
}

