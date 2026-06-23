using UnityEngine;
using UnityEngine.EventSystems;

public class UIButtonEffect : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerClickHandler
{
    private Vector3 originalScale;

    public AudioSource clickSound;

    void Start()
    {
        originalScale = transform.localScale;
    }

    // Mouse üstüne gelince
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = originalScale * 1.1f;
    }

    // Mouse çıkınca
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale;
    }

    // Tıklayınca
    public void OnPointerClick(PointerEventData eventData)
    {
        transform.localScale = originalScale * 0.9f;

        if (clickSound != null)
        {
            clickSound.Play();
        }

        Invoke(nameof(ResetScale), 0.1f);
    }

    void ResetScale()
    {
        transform.localScale = originalScale;
    }
}
