/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SelEndManager : MonoBehaviour
{
    public TextMeshProUGUI endText;

    public GameObject bilgeDede;

    public Transform player;

    // 🔄 Butonlar
    public GameObject tekrarOynaButonu;
    public GameObject menuyeDonButonu;

    // 🎵 Bilge Dede Sesleri
    public AudioSource bilgeVoice;

    public AudioClip successClip;
    public AudioClip failClip;

    // 🌊 Sel ambience sesi
    public AudioSource selAudio;

    // 📦 End Panel
    public GameObject endPanel;

    public void ShowEnd()
    {
        // 🧓 Bilge Dede oyuncunun önüne gelsin
        bilgeDede.transform.position =
            player.position + new Vector3(0, 0, 3);

        // 📦 Panel aç
        endPanel.SetActive(true);
        endText.gameObject.SetActive(true);
        bilgeDede.SetActive(true);

        tekrarOynaButonu.SetActive(true);

        menuyeDonButonu.SetActive(true);

        // 🌊 Ambience durdur
        selAudio.Stop();

        // ✅ Başarılı
        if (ScoreManager.score >= 70)
        {
            // ⛰️ Heyelan kilidini aç
            PlayerPrefs.SetInt("HeyelanAcik", 1);

            endText.text =
            "Tebrikler!\n\nSel çantasını büyük ölçüde doğru hazırladın.\n\nAma hâlâ dikkat etmen gereken bazı noktalar var. İstersen tekrar deneyebilir ya da heyelan çantasını hazırlamaya başlayabilirsin.";

            bilgeVoice.clip = successClip;
        }

        // ❌ Başarısız
        else
        {
            endText.text =
            "Daha dikkatli olmalısın.\n\nSel sırasında ihtiyaç duyulabilecek temel malzemeleri seçmeye çalış. İstersen tekrar deneyerek daha yüksek puan kazanabilirsin.";

            bilgeVoice.clip = failClip;
        }

        // 🔊 Bilge Dede konuşsun
        bilgeVoice.Play();
    }

    // 🔄 Tekrar Oyna
    public void TekrarOyna()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    // 🏠 Menüye Dön
    public void MenuyeDon()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Menu");
    }
}*/
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SelEndManager : MonoBehaviour
{
    public TextMeshProUGUI endText;

    public GameObject endPanel;

    public GameObject bilgeDede;

    public Transform player;

    // 🎵 Bilge Dede sesi
    public AudioSource bilgeVoice;

    // 🎵 Sesler
    public AudioClip successClip;

    public AudioClip lowScoreClip;

    public AudioClip gameOverClip;

    // 🔘 Butonlar
    public GameObject tekrarOynaButonu;

    public GameObject menuyeDonButonu;

    // 🌊 Ortam sesi
    public AudioSource selAudio;

    // 🎯 Oyun Sonu
    public void ShowEnd(bool reachedSafeArea)
    {
        bilgeDede.transform.position =
            player.position + new Vector3(0, 0, 3);

        endPanel.SetActive(true);

        endText.gameObject.SetActive(true);

        bilgeDede.SetActive(true);

        tekrarOynaButonu.SetActive(true);

        menuyeDonButonu.SetActive(true);

        if (selAudio != null)
        {
            selAudio.Stop();
        }

        if (reachedSafeArea)
        {
            if (ScoreManager.score >= 70)
            {
                PlayerPrefs.SetInt("HeyelanAcik", 1);
                PlayerPrefs.Save();

                endText.text =
                "Tebrikler!\nGüvenli alana ulaşmayı başardın ve \nsel sırasında gerekli olabilecek malzemelerin \nçoğunu doğru topladın.\nArtık heyelan sahnesine geçebilirsin.";

                bilgeVoice.clip = successClip;
            }
            else
            {
                endText.text =
                "Güvenli alana ulaşmayı başardın.\n\nAncak yeterli doğru malzemeyi toplayamadığın \n\niçin afet çantan eksik kaldı.\n\nİstersen tekrar deneyebilirsin.";

                bilgeVoice.clip = lowScoreClip;
            }
        }
        else
        {
            endText.text =
            "Güvenli alana ulaşamadın.\nDoğru ekipman seçimi ve \nhızlı hareket etmek hayat kurtarabilir.";

            bilgeVoice.clip = gameOverClip;
        }

        if (bilgeVoice != null)
        {
            bilgeVoice.Play();
        }

        Time.timeScale = 0f;
    }

    // 🔄 Tekrar Oyna
    public void TekrarOyna()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    // 🏆 Skor Tablosu
    public void SkorTablosu()
    {
        PlayerPrefs.SetInt(
            "SonPuan",
            ScoreManager.score
        );

        Time.timeScale = 1f;

        SceneManager.LoadScene(
            "ScoreTable"
        );
    }

    // 🏠 Menüye Dön
    public void MenuyeDon()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Menu");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R BASILDI");
            TekrarOyna();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("M BASILDI");
            MenuyeDon();
        }
        if (Input.GetKeyDown(KeyCode.S)) { Debug.Log("S BASILDI"); SkorTablosu(); }
    }
}