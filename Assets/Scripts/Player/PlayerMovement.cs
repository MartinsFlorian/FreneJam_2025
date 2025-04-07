using System.Collections;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] float moveSpeed;
    [SerializeField] float horizontalMovement;
    [SerializeField] float verticalMovement;
    private bool isJumping = false;
    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_PlaySound rsePlayJumpSound;
    [SerializeField] RSE_PlaySound rsePlaySlideSound;

    //[Header("RSO")]

    //[Header("SSO")]

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(DelayInputHorizontal(horizontalMovement));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(DelayInputHorizontal(-horizontalMovement));
        }
        if (Input.GetKeyDown(KeyCode.Z) && !isJumping)
        {
            isJumping = true;
            StartCoroutine(DelayInputVertical(verticalMovement));
        }
    }
    IEnumerator DelayInputHorizontal(float value)
    {
        yield return new WaitForSeconds(1f);
        rsePlaySlideSound.RaiseEvent();
        transform.position += new Vector3(value, 0, 0);
    }
    IEnumerator DelayInputVertical(float value)
    {
        yield return new WaitForSeconds(1f);
        rsePlayJumpSound.RaiseEvent();
        transform.position += new Vector3(0, value, 0);
        isJumping = false;
    }
}