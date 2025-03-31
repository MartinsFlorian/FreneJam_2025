using UnityEngine;

public class ShowPause : MonoBehaviour
{
    //[Header("Parameters")]

    [Header("References")]
    [SerializeField] GameObject pauseMenuContent;

    [Header("RSE")]
    [SerializeField] RSE_ShowPauseMenu RSE_ShowPauseMenu;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnEnable()
    {
        RSE_ShowPauseMenu.action += ShowPauseMenu;
    }
    private void OnDisable()
    {
        RSE_ShowPauseMenu.action -= ShowPauseMenu;
    }
    private void ShowPauseMenu(bool activate)
    {
        pauseMenuContent.SetActive(activate);
        if (activate)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}