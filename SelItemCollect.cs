using UnityEngine;

public class SelItemCollect : MonoBehaviour
{
    public string warningMessage;
    public string successMessage;
    public bool isCorrectItem = true;

    public static int health = 3;
        private void OnTriggerEnter(Collider other)
    {
        // Sadece oyuncu çalıştırsın
        if (!other.CompareTag("Player")) return;

        PlayerMovement player =
            other.GetComponent<PlayerMovement>();

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

            // ❤️ Can azalt
            health--;

            Debug.Log("Can: " + health);

            // 🌊 Su efekti
            WaterEffect water =
                FindObjectOfType<WaterEffect>();

            if (water != null)
            {
               Vector3 waterPos = other.transform.position;
waterPos.y = 1f;

water.ShowWater(waterPos);
            }

            // 🐢 Oyuncuyu yavaşlat
            if (player != null)
            {
                player.SlowDown();
            }

            // 💀 Oyun sonu
            if (health <= 0)
            {
                // 🔥 YENİ MANAGER
                SelEndManager end =
                    FindObjectOfType<SelEndManager>();

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