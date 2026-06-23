
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KilitYonetici : MonoBehaviour
{
    public Button selButonu;
    public TMP_Text selKilitYazisi;

    public Button heyelanButonu;
    public TMP_Text heyelanKilitYazisi;

    public Button yanginButonu;
    public TMP_Text yanginKilitYazisi;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        // İlk başta kilitli
        selButonu.interactable = false;
        heyelanButonu.interactable = false;
        yanginButonu.interactable = false;

        // SEL AÇILDI MI
        if (PlayerPrefs.GetInt("SelAcik") == 1)
        {
            selButonu.interactable = true;

            if (selKilitYazisi != null)
            {
                selKilitYazisi.gameObject.SetActive(false);
            }
        }

        // HEYELAN AÇILDI MI
        if (PlayerPrefs.GetInt("HeyelanAcik") == 1)
        {
            heyelanButonu.interactable = true;

            if (heyelanKilitYazisi != null)
            {
                heyelanKilitYazisi.gameObject.SetActive(false);
            }
        }

        // YANGIN AÇILDI MI
        if (PlayerPrefs.GetInt("YanginAcik") == 1)
        {
            yanginButonu.interactable = true;

            if (yanginKilitYazisi != null)
            {
                yanginKilitYazisi.gameObject.SetActive(false);
            }
        }
    }
}