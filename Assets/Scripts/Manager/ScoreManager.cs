using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //[Header("Parameters")]

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_AddScore rseAddScore;
    [SerializeField] RSE_UpdateScoreText rseUpdateScoreText;

    [Header("RSO")]
    [SerializeField] RSO_PlayerScore rsoPlayerScore;

    //[Header("SSO")]

    private void OnEnable()
    {
        rseAddScore.action += AddPlayerScore;
    }
    private void OnDisable()
    {
        rseAddScore.action -= AddPlayerScore;
    }
    private void Start()
    {
        rsoPlayerScore.Value = 0;
    }
    private void AddPlayerScore(int value)
    {
        rsoPlayerScore.Value += value;
        rseUpdateScoreText.RaiseEvent();
    }
}