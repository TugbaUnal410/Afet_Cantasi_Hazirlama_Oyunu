using UnityEngine;

public class SelFinishLine : MonoBehaviour
{
    private bool finished = false;

    private void OnTriggerEnter(Collider other)
    {
        // 🎮 Sadece Player
        if (!other.CompareTag("Player")) return;

        // ❌ Bir kez çalışsın
        if (finished) return;

        finished = true;

        Debug.Log("Sel finish çalıştı");

        SelEndManager end =
            FindObjectOfType<SelEndManager>();

        if (end != null)
        {
            // ✅ Güvenli alana ulaştı
            end.ShowEnd(true);
        }
    }
}
