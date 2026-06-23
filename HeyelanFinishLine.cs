using UnityEngine;

public class HeyelanFinishLine : MonoBehaviour
{
    private bool finished = false;

    private void OnTriggerEnter(Collider other)
    {
        // 🎮 Sadece Player
        if (!other.CompareTag("Player")) return;

        // ❌ Bir kez çalışsın
        if (finished) return;

        finished = true;

        Debug.Log("Heyelan finish çalıştı");

        HeyelanEndManager end =
            FindObjectOfType<HeyelanEndManager>();

        if (end != null)
        {
            // ✅ Güvenli alana ulaştı
            end.ShowEnd(true);
        }
    }
}
