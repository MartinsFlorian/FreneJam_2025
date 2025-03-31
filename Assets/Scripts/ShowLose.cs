using UnityEngine;

public class ShowLose : MonoBehaviour
{
    //[Header("Parameters")]

    [Header("References")]
    [SerializeField] GameObject loseMenuContent;

    [Header("RSE")]
    [SerializeField] RSE_ShowLoseMenu RSE_ShowLoseMenu;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnEnable()
    {
        RSE_ShowLoseMenu.action += ShowLoseMenu;
    }
    private void OnDisable()
    {
        RSE_ShowLoseMenu.action -= ShowLoseMenu;
    }
    private void ShowLoseMenu(bool activate)
    {
        loseMenuContent.SetActive(activate);
        Time.timeScale = 0f;
    }
}