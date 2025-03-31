using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    //[Header("Parameters")]

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_QuitGame RSE_QuitGame;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnEnable()
    {
        RSE_QuitGame.action += QuitGame;
    }
    private void OnDisable()
    {
        RSE_QuitGame.action -= QuitGame;
    }
    private void QuitGame()
    {
        Application.Quit();
    }
}