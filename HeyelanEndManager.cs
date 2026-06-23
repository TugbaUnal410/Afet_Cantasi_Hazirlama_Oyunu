/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class HeyelanEndManager : MonoBehaviour
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

    // 🌫 Heyelan ambience sesi
    public AudioSource heyelanAudio;

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

        // 🌫 Ambience durdur
        heyelanAudio.Stop();

        // ✅ Başarılı
        if (ScoreManager.score >= 70)
        {
            // 🔥 Yangın kilidini aç
            PlayerPrefs.SetInt("YanginAcik", 1);

            endText.text =
            "Harika iş çıkardın!\n\nHeyelan çantasını büyük ölçüde doğru hazırladın. Şimdi son görev için yangın çantasını hazırlamaya başlayabiliriz.";

            bilgeVoice.clip = successClip;
        }

        // ❌ Başarısız
        else
        {
            endText.text =
            "Biraz daha dikkatli olmalısın.\n\nHeyelan gibi afetlerde temel ihtiyaç malzemeleri büyük önem taşır. Tekrar deneyerek daha dikkatli seçimler yapabilirsin.";

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
/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HeyelanEndManager : MonoBehaviour
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

    // ⛰️ Ortam sesi
    public AudioSource heyelanAudio;

    // 🎯 Oyun Sonu
    public void ShowEnd(bool reachedSafeArea)
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

        // 🔇 Ortam sesini durdur
        heyelanAudio.Stop();

        // 🏁 Güvenli alana ulaştı
        if (reachedSafeArea)
        {
            // ✅ Puan yeterliyse
            if (ScoreManager.score >= 70)
            {
                // 🔥 Yangın sahnesi açılsın
                PlayerPrefs.SetInt("YanginAcik", 1);

                endText.text =
                "Tebrikler!\n\nGüvenli alana ulaşmayı başardın ve olası heyelan için gerekli olabilecek malzemelerin çoğunu doğru topladın.\n\nArtık yangın sahnesine geçebilirsin.";

                bilgeVoice.clip = successClip;
            }

            // ❌ Güvenli alana ulaştı ama puanı düşük
            else
            {
                endText.text =
                "Güvenli alana ulaşmayı başardın.\n\nAncak yeterli doğru malzemeyi toplayamadığın için afet çantan eksik kaldı.\n\nİstersen tekrar deneyebilirsin.";

                bilgeVoice.clip = lowScoreClip;
            }
        }

        // 💀 Güvenli alana ulaşamadı
        else
        {
            endText.text =
            "Güvenli alana ulaşamadın.\n\nDoğru ekipman seçimi ve hızlı hareket etmek hayat kurtarabilir.";

            bilgeVoice.clip = gameOverClip;
        }

        // 🔊 Bilge Dede konuşsun
        bilgeVoice.Play();

        // ⏸ Oyun dursun
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

public class HeyelanEndManager : MonoBehaviour
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

    // ⛰️ Ortam sesi
    public AudioSource heyelanAudio;

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

        if (heyelanAudio != null)
        {
            heyelanAudio.Stop();
        }

        if (reachedSafeArea)
        {
            if (ScoreManager.score >= 70)
            {
                PlayerPrefs.SetInt("YanginAcik", 1);
                PlayerPrefs.Save();

                endText.text =
                "Tebrikler!\nGüvenli alana ulaşmayı başardın ve \nolası heyelan için gerekli olabilecek \nmalzemelerin çoğunu doğru topladın.\nArtık yangın sahnesine geçebilirsin.";

                bilgeVoice.clip = successClip;
            }
            else
            {
                endText.text =
                "Güvenli alana ulaşmayı başardın.\nAncak yeterli doğru malzemeyi toplayamadığın \niçin afet çantan eksik kaldı.\nİstersen tekrar deneyebilirsin.";

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

        Invoke("OyunuDurdur", 0.2f);
    }

    // ⏸ Oyunu durdur
    void OyunuDurdur()
    {
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