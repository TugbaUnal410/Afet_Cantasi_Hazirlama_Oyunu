using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource audioSource;

    public AudioClip correctSound;

    public AudioClip wrongSound;

    void Awake()
    {
        instance = this;
    }

    // ✅ Doğru ses
    public void PlayCorrect()
    {
        audioSource.PlayOneShot(correctSound);
    }

    // ❌ Yanlış ses
    public void PlayWrong()
    {
        audioSource.PlayOneShot(wrongSound);
    }
}