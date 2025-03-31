using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    //[Header("Parameters")]

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_QuitGame RSE_QuitGame;
    [SerializeField] RSE_RestartGame RSE_RestartGame;
    [SerializeField] RSE_ShowPauseMenu RSE_ShowPauseMenu;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnEnable()
    {
        RSE_QuitGame.action += QuitGame;
        RSE_RestartGame.action += RestartGame;
    }
    private void OnDisable()
    {
        RSE_QuitGame.action -= QuitGame;
        RSE_RestartGame.action -= RestartGame;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            RSE_ShowPauseMenu.RaiseEvent(true);
        }
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    private void QuitGame()
    {
        Application.Quit();
    }
}