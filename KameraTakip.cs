using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public float shakeDuration = 0f;
    public float shakeMagnitude = 0.05f;

    void LateUpdate()
    {
        Vector3 targetPos = player.position + offset;

        // 🌍 Kamera sallanması
        if (shakeDuration > 0)
        {
            targetPos += Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime;
        }

        transform.position = targetPos;
    }

    // 💥 Sallanmayı tetikle
    public void TriggerShake()
    {
        shakeDuration = 0.3f;
    }
}