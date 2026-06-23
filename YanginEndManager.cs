/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class YanginEndManager : MonoBehaviour
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

    // 🔥 Yangın ambience sesi
    public AudioSource yanginAudio;

    // 📦 End Panel
    public GameObject endPanel;

    public void ShowEnd()
    {
        Debug.Log("SHOW END CALISTI");
        // 🧓 Bilge Dede oyuncunun önüne gelsin
        bilgeDede.transform.position =
            player.position + new Vector3(0, 0, 3);

        // 📦 Panel aç
        endPanel.SetActive(true);

        // 📝 Yazıyı aç
        endText.gameObject.SetActive(true);

        bilgeDede.SetActive(true);

        tekrarOynaButonu.SetActive(true);

        menuyeDonButonu.SetActive(true);

        // 🔥 Ambience durdur
        yanginAudio.Stop();

        // ✅ Başarılı
        if (ScoreManager.score >= 70)
        {
            endText.text =
            "Tebrikler!\n\nTüm afet görevlerini büyük ölçüde tamamladın.\n\nArtık afetlere karşı çok daha bilinçli ve hazırlıklısın.";

            if (bilgeVoice != null && successClip != null)
            {
                bilgeVoice.clip = successClip;
                bilgeVoice.Play();
            }
        }

        // ❌ Başarısız
        else
        {
            endText.text =
            "Afetlerde doğru malzemeleri seçmek hayat kurtarabilir. \n\n İstersen tekrar oynayarak daha yüksek puan kazanabilirsin.";

            if (bilgeVoice != null && failClip != null)
            {
                bilgeVoice.clip = failClip;
                bilgeVoice.Play();
            }
        }
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

public class YanginEndManager : MonoBehaviour
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

    // 🔥 Ortam sesi
    public AudioSource yanginAudio;

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
        yanginAudio.Stop();

        // 🏁 Güvenli alana ulaştı
        if (reachedSafeArea)
        {
            // ✅ Puan yeterliyse
            if (ScoreManager.score >= 70)
            {
                endText.text =
                "Tebrikler!\n\nGüvenli alana ulaşmayı başardın ve gerekli ekipmanların çoğunu doğru topladın.\n\nTüm afet eğitimlerini başarıyla tamamladın. Artık olası bir afete hazırsın";

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
/*using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class YanginEndManager : MonoBehaviour
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

    // 🔥 Ortam sesi
    public AudioSource yanginAudio;

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
        if (yanginAudio != null)
        {
            yanginAudio.Stop();
        }

        // 🏁 Güvenli alana ulaştı
        if (reachedSafeArea)
        {
            // ✅ Puan yeterliyse
            if (ScoreManager.score >= 70)
            {
                endText.text =
                "Tebrikler!\nGüvenli alana ulaşmayı başardın ve \n gerekli ekipmanların çoğunu doğru topladın.\nTüm afet eğitimlerini başarıyla tamamladın.\n\n Artık olası bir afete hazırsın.";

                bilgeVoice.clip = successClip;
            }

            // ❌ Puan düşük
            else
            {
                endText.text =
                "Güvenli alana ulaşmayı başardın.\nAncak yeterli doğru malzemeyi toplayamadığın \niçin afet çantan eksik kaldı.\nİstersen tekrar deneyebilirsin.";

                bilgeVoice.clip = lowScoreClip;
            }
        }

        // 💀 Güvenli alana ulaşamadı
        else
        {
            endText.text =
            "Güvenli alana ulaşamadın.\nDoğru ekipman seçimi ve hızlı hareket etmek \nhayat kurtarabilir.";

            bilgeVoice.clip = gameOverClip;
        }

        // 🔊 Ses çal
        if (bilgeVoice != null)
        {
            bilgeVoice.Play();
        }

        // ⏸ Oyunu kısa gecikmeyle durdur
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

public class YanginEndManager : MonoBehaviour
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

    // 🔥 Ortam sesi
    public AudioSource yanginAudio;

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

        if (yanginAudio != null)
        {
            yanginAudio.Stop();
        }

        if (reachedSafeArea)
        {
            if (ScoreManager.score >= 70)
            {
                endText.text =
                "Tebrikler!\nGüvenli alana ulaşmayı başardın ve \ngerekli ekipmanların çoğunu doğru topladın.\nTüm afet eğitimlerini başarıyla tamamladın.\n\nArtık olası bir afete hazırsın.";

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
    public void SkorTablosu()
    {
        PlayerPrefs.SetInt(
            "SonPuan",
            ScoreManager.score
        );

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