using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //[Header("Parameters")]

    [Header("References")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip coinSound;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip slideSound;

    [Header("RSE")]
    [SerializeField] RSE_PlaySound rsePlayCoinSound;
    [SerializeField] RSE_PlaySound rsePlayJumpSound;
    [SerializeField] RSE_PlaySound rsePlaySlideSound;

    //[Header("RSO")]

    //[Header("SSO")]
    private void OnEnable()
    {
        rsePlayCoinSound.action += PlayCoinSound;
        rsePlayJumpSound.action += PlayJumpSound;
        rsePlaySlideSound.action += PlaySlideSound;
    }
    private void OnDisable()
    {
        rsePlayCoinSound.action -= PlayCoinSound;
        rsePlayJumpSound.action -= PlayJumpSound;
        rsePlaySlideSound.action -= PlaySlideSound;
    }
    private void PlayCoinSound()
    {
        audioSource.PlayOneShot(coinSound);
    }
    private void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }
    private void PlaySlideSound()
    {
        audioSource.PlayOneShot(slideSound);
    }
}