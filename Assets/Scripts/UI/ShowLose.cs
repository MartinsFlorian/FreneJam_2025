using TMPro;
using UnityEngine;

public class ShowLose : MonoBehaviour
{
    //[Header("Parameters")]

    [Header("References")]
    [SerializeField] GameObject loseMenuContent;
    [SerializeField] TextMeshProUGUI scoreText;

    [Header("RSE")]
    [SerializeField] RSE_ShowLoseMenu rseShowLoseMenu;

    [Header("RSO")]
    [SerializeField] RSO_PlayerScore rsoPlayerScore;

    //[Header("SSO")]
    private void OnEnable()
    {
        rseShowLoseMenu.action += ShowLoseMenu;
    }
    private void OnDisable()
    {
        rseShowLoseMenu.action -= ShowLoseMenu;
    }
    private void ShowLoseMenu(bool activate)
    {
        scoreText.text = $"Final Score: {rsoPlayerScore.Value}";
        loseMenuContent.SetActive(activate);
        Time.timeScale = 0f;
    }
}