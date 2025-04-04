using UnityEngine;

public class ObstaclesCollision : MonoBehaviour
{
    //[Header("Parameters")]

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_ShowLoseMenu rseShowLoseMenu;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rseShowLoseMenu.RaiseEvent(true);
        }
    }
}