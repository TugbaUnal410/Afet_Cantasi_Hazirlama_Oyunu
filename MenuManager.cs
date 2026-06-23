using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // 🎵 Bilge Dede sesi
    public AudioSource bilgeVoice;

    void Start()
    {
        //PlayerPrefs.DeleteAll();

        // İlk kez oyun açıldı mı?
        if (PlayerPrefs.GetInt("GameInitialized", 0) == 0)
        {
            // İlk başta sadece deprem açık olsun
            PlayerPrefs.SetInt("SelAcik", 0);

            PlayerPrefs.SetInt("HeyelanAcik", 0);

            PlayerPrefs.SetInt("YanginAcik", 0);

            PlayerPrefs.SetInt("GameInitialized", 1);

            PlayerPrefs.Save();
        }

        // Bilge Dede sadece ilk girişte konuşsun
        if (PlayerPrefs.GetInt("IntroPlayed", 0) == 0)
        {
            if (bilgeVoice != null)
            {
                bilgeVoice.Play();
            }

            PlayerPrefs.SetInt("IntroPlayed", 1);

            PlayerPrefs.Save();
        }
    }

    // 🌍 Deprem
    public void StartGame()
    {
        SceneManager.LoadScene("Deprem");
    }

    // 🌊 Sel
    public void SelGame()
    {
        SceneManager.LoadScene("Sel");
    }

    // ⛰️ Heyelan
    public void HeyelanGame()
    {
        SceneManager.LoadScene("Heyelan");
    }

    // 🔥 Yangın
    public void YanginGame()
    {
        SceneManager.LoadScene("Yangin");
    }

    // 🚪 Oyundan Çık
    public void OyundanCik()
    {
        Debug.Log("OYUN KAPATILDI");

        Application.Quit();
    }
}
