using UnityEngine;

public class ShowGame : MonoBehaviour
{
    //[Header("Parameters")]

    [Header("References")]
    [SerializeField] GameObject gameContent;

    [Header("RSE")]
    [SerializeField] RSE_ShowGame RSE_ShowGame;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnEnable()
    {
        RSE_ShowGame.action += ShowGameContent;
    }
    private void OnDisable()
    {
        RSE_ShowGame.action -= ShowGameContent;
    }
    private void ShowGameContent(bool activate)
    {
        gameContent.SetActive(activate);
    }
}