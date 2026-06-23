using UnityEngine;

public class YanginItemCollect : MonoBehaviour
{
    public bool isCorrectItem = true;
    public string successMessage;
    public string warningMessage;
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

            if (BagSystem.instance != null)
            {
                BagSystem.instance.AddToBag(-10);
            }

            health--;

            Debug.Log("Can: " + health);

            // 🔥 YANGIN EFEKTİ
            FireEffect fire = FindObjectOfType<FireEffect>();

            if (fire != null)
            {
                Vector3 firePos = other.transform.position;
                firePos.y = 1f;

                fire.ShowFire(firePos);
            }

            // 🐢 Oyuncu yavaşlasın
            if (player != null)
            {
                player.SlowDown();
            }

            // 💀 Can bittiyse
            if (health <= 0)
            {
                YanginEndManager end = FindObjectOfType<YanginEndManager>();

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
