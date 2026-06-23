using UnityEngine;
using TMPro;

public class BilgeManager : MonoBehaviour
{
    public GameObject bilgeDede;
    public TextMeshProUGUI bilgeText;

    void Start()
    {
        bilgeDede.SetActive(true);
        bilgeText.enabled = true;

        Invoke("HideAll", 1f);
    }

    void HideAll()
    {
        bilgeDede.SetActive(false);
        bilgeText.enabled = false;
    }
}