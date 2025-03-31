using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //[Header("Parameters")]

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_ShowLoseMenu RSE_ShowLoseMenu;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            RSE_ShowLoseMenu.RaiseEvent(true);
        }
    }
}