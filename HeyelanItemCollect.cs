using UnityEngine;

public class HeyelanItemCollect : MonoBehaviour
{
    public string warningMessage;
    public string successMessage;
    public bool isCorrectItem = true;
    public static int health = 3;

    private void OnTriggerEnter(Collider other)
    {
        // Sadece Player çarpsın
        if (!other.CompareTag("Player")) return;

        PlayerMovement player = other.GetComponent<PlayerMovement>();

        // ✅ DOĞRU EŞYA
        if (isCorrectItem)
        {
            UyariManager uyari =
    FindObjectOfType<UyariManager>();

if (uyari != null)
{
    uyari.ShowMessage(successMessage);
}
            ScoreManager.AddScore(10);
             SoundManager.instance.PlayCorrect();
            // 🎒 Çanta barı artsın
            if (BagSystem.instance != null)
            {
                BagSystem.instance.AddToBag(10);
            }
            if (player != null)
{
    player.SpeedUp();
}
        }

        // ❌ YANLIŞ EŞYA
        else
        {
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

            // 🌫 TOZ EFEKTİ
            DustEffect dust = FindObjectOfType<DustEffect>();

            if (dust != null)
            {
               Vector3 dustPos = other.transform.position;
dustPos.y = 1f;

dust.ShowDust(dustPos);
            }

            // 🐢 Oyuncu yavaşlasın
            if (player != null)
            {
                player.SlowDown();
            }

            // 💀 Can bittiyse
            if (health <= 0)
            {
                HeyelanEndManager end = FindObjectOfType<HeyelanEndManager>();

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