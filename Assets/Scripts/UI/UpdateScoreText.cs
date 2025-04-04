using TMPro;
using UnityEngine;

public class UpdateScoreText : MonoBehaviour
{
    //[Header("Parameters")]

    [Header("References")]
    [SerializeField] TextMeshProUGUI scoreText;

    [Header("RSE")]
    [SerializeField] RSE_UpdateScoreText rseUpdateScoreText;

    [Header("RSO")]
    [SerializeField] RSO_PlayerScore rsoPlayerScore;

    //[Header("SSO")]
    private void OnEnable()
    {
        rseUpdateScoreText.action += UpdateText;
    }
    private void OnDisable()
    {
        rseUpdateScoreText.action -= UpdateText;
    }
    private void Start()
    {
        UpdateText();
    }
    private void UpdateText()
    {
        scoreText.text = $"Score: {rsoPlayerScore.Value}";
    }
}