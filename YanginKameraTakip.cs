using UnityEngine;

public class YanginKameraTakip : MonoBehaviour
{
    public Transform player;

    // Kameranın oyuncuya göre konumu
    public Vector3 offset = new Vector3(0, 5, -6);

    // Takip yumuşaklığı
    public float smoothSpeed = 5f;

    void Start()
    {
        if (player == null) return;

        // Kamera direkt arkada başlasın
        transform.position = player.position + offset;

        // Oyuncuya baksın
        transform.LookAt(player.position + Vector3.up * 1.5f);
    }

    void LateUpdate()
    {
        if (player == null) return;

        // Hedef pozisyon
        Vector3 targetPosition = player.position + offset;

        // Yumuşak takip
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );

        // Oyuncuya bak
        transform.LookAt(player.position + Vector3.up * 1.5f);
    }
}