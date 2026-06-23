using UnityEngine;

public class YanginFinishLine : MonoBehaviour
{
    private bool finished = false;

    private void OnTriggerEnter(Collider other)
    {
        // 🎮 Sadece Player
        if (!other.CompareTag("Player")) return;

        // ❌ Bir kez çalışsın
        if (finished) return;

        finished = true;

        Debug.Log("Yangın finish çalıştı");

        YanginEndManager end =
            FindObjectOfType<YanginEndManager>();

        if (end != null)
        {
            // ✅ Güvenli alana ulaştı
            end.ShowEnd(true);
        }
    }
}