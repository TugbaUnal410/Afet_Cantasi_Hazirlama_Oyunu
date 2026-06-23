/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    public TextMeshProUGUI endText;
public GameObject endPanel;
    public GameObject bilgeDede;

    public Transform player;
    public AudioSource bilgeVoice;
    public AudioClip successClip;
public AudioClip failClip;
public GameObject tekrarOynaButonu;
public GameObject menuyeDonButonu;
public AudioSource depremAudio;
    public void ShowEnd(false)
    {
        // Bilge Dede oyuncunun önüne gelsin
        bilgeDede.transform.position =
            player.position + new Vector3(0, 0, 3);

        // UI aç
        endPanel.SetActive(true);
        endText.gameObject.SetActive(true);

        bilgeDede.SetActive(true);
        tekrarOynaButonu.SetActive(true);
menuyeDonButonu.SetActive(true);
depremAudio.Stop();
        // ✅ Başarılı
        if (ScoreManager.score >= 70)
        {
            // Sel kilidini aç
            PlayerPrefs.SetInt("SelAcik", 1);

            endText.text =
            "Tebrikler! Deprem çantasını büyük ölçüde doğru hazırladın.Ama hâlâ bazı eksiklerin var.\n\n İstersen tekrar deneyebilir ya da sel çantasını hazırlamaya başlayabilirsin.";

            bilgeVoice.clip = successClip;
        }

        // ❌ Başarısız
        else
        {
            endText.text =
            "Daha dikkatli olmalısın.\n\n Afet çantasına temel ihtiyaç malzemelerini koymayı unutmuş olabilirsin. İstersen tekrar deneyerek daha yüksek puan kazanabilirsin.";

            bilgeVoice.clip = failClip;
        }
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

public class EndManager : MonoBehaviour
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

    // 🌍 Ortam sesi
    public AudioSource depremAudio;

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
        depremAudio.Stop();

        // 🏁 Güvenli alana ulaştı
        if (reachedSafeArea)
        {
            // ✅ Puan yeterli
            if (ScoreManager.score >= 70)
            {
                PlayerPrefs.SetInt("SelAcik", 1);

                endText.text =
                "Tebrikler!\n\nGüvenli alana ulaşmayı başardın ve gerekli malzemelerin çoğunu doğru seçtin.\n\nArtık sel sahnesine geçebilirsin.";

                bilgeVoice.clip = successClip;
            }

            // ❌ Güvenli alana ulaştı ama puan düşük
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

        // ⏸ Oyunu durdur
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
/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
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

    // 🌍 Ortam sesi
    public AudioSource depremAudio;

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
        if (depremAudio != null)
        {
            depremAudio.Stop();
        }

        // 🏁 Güvenli alana ulaştı
        if (reachedSafeArea)
        {
            // ✅ Puan yeterliyse
            if (ScoreManager.score >= 70)
            {
                // 🌊 Sel sahnesini aç
                PlayerPrefs.SetInt("SelAcik", 1);

                // 💾 Kaydet
                PlayerPrefs.Save();

                endText.text =
                "Tebrikler!\nGüvenli alana ulaşmayı başardın \nve gerekli malzemelerin çoğunu doğru seçtin.\nArtık sel sahnesine geçebilirsin.";

                bilgeVoice.clip = successClip;
            }

            // ❌ Güvenli alana ulaştı ama puan düşük
            else
            {
                endText.text =
                "Güvenli alana ulaşmayı başardın.\nAncak yeterli doğru malzemeyi \ntoplayamadığın için afet çantan eksik kaldı.\nİstersen tekrar deneyebilirsin.";

                bilgeVoice.clip = lowScoreClip;
            }
        }

        // 💀 Güvenli alana ulaşamadı
        else
        {
            endText.text =
            "Güvenli alana ulaşamadın.\nDoğru ekipman seçimi ve hızlı \nhareket etmek hayat kurtarabilir.";

            bilgeVoice.clip = gameOverClip;
        }

        // 🔊 Bilge Dede konuşsun
        if (bilgeVoice != null)
        {
            bilgeVoice.Play();
        }

        // ⏸ Oyunu durdur
        Time.timeScale = 0f;
    }

    // 🔄 Tekrar Oyna
    public void TekrarOyna()
    {
          Debug.Log("TEKRAR OYNA BASILDI");
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
        
    }

    // 🏠 Menüye Dön
    public void MenuyeDon()
    {
          Debug.Log("MENÜYE DÖN BASLATILTI");
        Time.timeScale = 1f;

        SceneManager.LoadScene("Menu");
    }
}*/
/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
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

    // 🌍 Ortam sesi
    public AudioSource depremAudio;

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

        if (depremAudio != null)
        {
            depremAudio.Stop();
        }

        if (reachedSafeArea)
        {
            if (ScoreManager.score >= 70)
            {
                PlayerPrefs.SetInt("SelAcik", 1);
                PlayerPrefs.Save();

                endText.text =
                "Tebrikler!\nGüvenli alana ulaşmayı başardın \nve gerekli malzemelerin çoğunu doğru seçtin.\nArtık sel sahnesine geçebilirsin.";

                bilgeVoice.clip = successClip;
            }
            else
            {
                endText.text =
                "Güvenli alana ulaşmayı başardın.\nAncak yeterli doğru malzemeyi \ntoplayamadığın için afet çantan eksik kaldı.\nİstersen tekrar deneyebilirsin.";

                bilgeVoice.clip = lowScoreClip;
            }
        }
        else
        {
            endText.text =
            "Güvenli alana ulaşamadın.\nDoğru ekipman seçimi ve hızlı \nhareket etmek hayat kurtarabilir.";

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
        Debug.Log("TEKRAR OYNA BASILDI");

        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    // 🏠 Menüye Dön
    public void MenuyeDon()
    {
        Debug.Log("MENUYE DON BASILDI");

        Time.timeScale = 1f;

        SceneManager.LoadScene("Menu");
    }

    // 🧪 TEST
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
    }
}*/
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
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

    // 🌍 Ortam sesi
    public AudioSource depremAudio;

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

        if (depremAudio != null)
        {
            depremAudio.Stop();
        }

        if (reachedSafeArea)
        {
            if (ScoreManager.score >= 70)
            {
                PlayerPrefs.SetInt("SelAcik", 1);
                PlayerPrefs.Save();

                endText.text =
                "Tebrikler!\nGüvenli alana ulaşmayı başardın \nve gerekli malzemelerin çoğunu doğru seçtin.\nArtık sel sahnesine geçebilirsin.";

                bilgeVoice.clip = successClip;
            }
            else
            {
                endText.text =
                "Güvenli alana ulaşmayı başardın.\nAncak yeterli doğru malzemeyi \ntoplayamadığın için afet çantan eksik kaldı.\nİstersen tekrar deneyebilirsin.";

                bilgeVoice.clip = lowScoreClip;
            }
        }
        else
        {
            endText.text =
            "Güvenli alana ulaşamadın.\nDoğru ekipman seçimi ve hızlı \nhareket etmek hayat kurtarabilir.";

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
        Debug.Log("TEKRAR OYNA BASILDI");

        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    // 🏆 Skor Tablosu
    // 🏆 Skor Tablosu
public void SkorTablosu()
{
    Debug.Log("SKOR TABLOSU BASILDI");

    PlayerPrefs.SetInt("SonPuan", ScoreManager.score);

    Time.timeScale = 1f;

    SceneManager.LoadScene("ScoreTable");
}
    // 🏠 Menüye Dön
    public void MenuyeDon()
    {
        Debug.Log("MENUYE DON BASILDI");

        Time.timeScale = 1f;

        SceneManager.LoadScene("Menu");
    }

    // 🧪 TEST
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