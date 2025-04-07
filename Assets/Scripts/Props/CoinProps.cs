using UnityEngine;

public class CoinProps : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] int coinScore;

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_AddScore rseAddSore;
    [SerializeField] RSE_PlaySound rseCoinSound;

    //[Header("RSO")]

    //[Header("SSO")]

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rseCoinSound.RaiseEvent();
            rseAddSore.RaiseEvent(coinScore);
            Destroy(gameObject);
        }
    }
}