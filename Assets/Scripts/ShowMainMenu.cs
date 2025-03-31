using UnityEngine;

public class ShowMainMenu : MonoBehaviour
{
    //[Header("Parameters")]

    [Header("References")]
    [SerializeField] GameObject mainMenuContent;

    [Header("RSE")]
    [SerializeField] RSE_ShowMainMenu RSE_ShowMainMenu;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnEnable()
    {
        RSE_ShowMainMenu.action += ShowMainMenuContent;
    }
    private void OnDisable()
    {
        RSE_ShowMainMenu.action -= ShowMainMenuContent;
    }
    private void ShowMainMenuContent(bool activate)
    {
        mainMenuContent.SetActive(activate);
    }
}