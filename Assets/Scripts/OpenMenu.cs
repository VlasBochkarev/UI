using UnityEngine;
using UnityEngine.UI;

public class OpenMenu : MonoBehaviour
{
    public GameObject showMenu;
    public Button show, close;

    private Animator animator;

    void ShowMenu()
    {
        animator.SetBool("isShowMenu", true);
    }
    void CloseMenu()
    {
        animator.SetBool("isShowMenu", false);
    }



    private void Start()
    {
        animator = GetComponent<Animator>();
        Button btnShow = show.GetComponent<Button>();
        Button btnClose = close.GetComponent<Button>();
        btnShow.onClick.AddListener(ShowMenu);
        btnClose.onClick.AddListener(CloseMenu);
    }


}

