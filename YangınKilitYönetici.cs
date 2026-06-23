using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YanginKilitYonetici : MonoBehaviour
{
    // 🔥 Yangın
    public Button yanginButonu;

    public TMP_Text yanginKilitYazisi;

    void Start()
    {
        // Başlangıçta kilitli
        yanginButonu.interactable = false;

        // Eğer yangın açıldıysa
        if (PlayerPrefs.GetInt("YanginAcik") == 1)
        {
            YanginKilidiniAc();
        }
    }

    // 🔥 Yangın kilidini aç
    public void YanginKilidiniAc()
    {
        yanginButonu.interactable = true;

        // Buton rengini normale döndür
        yanginButonu.image.color = Color.white;

        // Kilit yazısını kaldır
        if (yanginKilitYazisi != null)
        {
            yanginKilitYazisi.gameObject.SetActive(false);
        }
    }
}
