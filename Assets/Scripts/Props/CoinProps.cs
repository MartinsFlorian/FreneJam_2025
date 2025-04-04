using UnityEngine;

public class CoinProps : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] int coinScore;

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_AddScore rseAddSore;

    //[Header("RSO")]

    //[Header("SSO")]

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rseAddSore.RaiseEvent(coinScore);
            Destroy(gameObject);
        }
    }
}