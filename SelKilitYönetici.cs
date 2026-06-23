using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelKilitYonetici : MonoBehaviour
{
    // ⛰️ Heyelan
    public Button heyelanButonu;

    public TMP_Text heyelanKilitYazisi;

    void Start()
    {
        // Başlangıçta kilitli
        heyelanButonu.interactable = false;

        // Eğer heyelan açıldıysa
        if (PlayerPrefs.GetInt("HeyelanAcik") == 1)
        {
            HeyelanKilidiniAc();
        }
    }

    // ⛰️ Heyelan kilidini aç
    public void HeyelanKilidiniAc()
    {
        heyelanButonu.interactable = true;

        // Buton rengini normale döndür
        heyelanButonu.image.color = Color.white;

        // Kilit yazısını kaldır
        if (heyelanKilitYazisi != null)
        {
            heyelanKilitYazisi.gameObject.SetActive(false);
        }
    }
}