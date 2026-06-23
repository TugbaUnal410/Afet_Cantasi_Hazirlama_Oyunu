using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public bool isCorrectItem = true;

    // ❗ Yanlış eşya açıklaması
    public string warningMessage;
public string successMessage;
    public static int health = 3;

    private void OnTriggerEnter(Collider other)
    {
        // Sadece Player çarpsın
        if (!other.CompareTag("Player")) return;

        PlayerMovement player = other.GetComponent<PlayerMovement>();

        // ✅ DOĞRU EŞYA
        if (isCorrectItem)
        {
            ScoreManager.AddScore(10);
            UyariManager uyari =
    FindObjectOfType<UyariManager>();

if (uyari != null)
{
    uyari.ShowMessage(successMessage);
}
            SoundManager.instance.PlayCorrect();

            // 🎒 Çanta barı artsın
            if (BagSystem.instance != null)
            {
                BagSystem.instance.AddToBag(10);
            }

            // 🚀 Hızlandır
            if (player != null)
            {
                player.SpeedUp();
            }
        }

        // ❌ YANLIŞ EŞYA
        else
        {
            // 📢 Uyarı göster
            UyariManager uyari =
                FindObjectOfType<UyariManager>();

            if (uyari != null)
            {
                uyari.ShowMessage(warningMessage);
            }

            ScoreManager.AddScore(-10);

            SoundManager.instance.PlayWrong();

            // 🎒 Çanta barı azalsın
            if (BagSystem.instance != null)
            {
                BagSystem.instance.AddToBag(-10);
            }

            health--;

            Debug.Log("Can: " + health);

            KameraTakip shake =
                Camera.main.GetComponent<KameraTakip>();

            if (shake != null)
            {
                shake.TriggerShake();
            }

            // 🐢 Oyuncu yavaşlasın
            if (player != null)
            {
                player.SlowDown();
            }

            // 💀 Can bittiyse
            if (health <= 0)
            {
                EndManager end =
                    FindObjectOfType<EndManager>();

                if (end != null)
                {
                    end.ShowEnd(false);
                }

                Time.timeScale = 0f;
            }
        }

        // Eşyayı yok et
        Destroy(gameObject);
    }
}