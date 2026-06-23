/*using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float sideSpeed = 10f;
public Animator animasyon;
    void Update()
    {
        if (Time.timeScale == 0f) return;
        // oyun durduysa hareket yok
        if (Time.timeScale == 0f) return;

        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        float moveX = 0f;
        if (Input.GetKey(KeyCode.LeftArrow)) moveX = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) moveX = 1f;

        
        transform.Translate(new Vector3(moveX * sideSpeed * Time.deltaTime, 0, 0));
        animasyon.SetFloat("speed", 1f);
    }

    public void SlowDown()
    {
        StopAllCoroutines();
        StartCoroutine(SlowRoutine());
    }

    IEnumerator SlowRoutine()
    {
        float originalSpeed = forwardSpeed;

        forwardSpeed = originalSpeed * 0.6f;

        yield return new WaitForSeconds(1.5f);

        forwardSpeed = originalSpeed;
    }
}*/
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float sideSpeed = 10f;

    public Animator animasyon;

    void Update()
    {
        if (Time.timeScale == 0f) return;

        // İleri hareket
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Sağ-Sol hareket
        float moveX = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
            moveX = -1f;

        if (Input.GetKey(KeyCode.RightArrow))
            moveX = 1f;

        transform.Translate(
            new Vector3(moveX * sideSpeed * Time.deltaTime, 0, 0)
        );

        // Koşma animasyonu
        animasyon.SetFloat("speed", 0.7f);
    }

    // ❌ Yanlış eşya
    public void SlowDown()
    {
        StopAllCoroutines();
        StartCoroutine(SlowRoutine());
    }

    IEnumerator SlowRoutine()
    {
        float originalSpeed = 10f;

        forwardSpeed = originalSpeed * 0.6f;

        yield return new WaitForSeconds(1.5f);

        forwardSpeed = originalSpeed;
    }

    // ✅ Doğru eşya
    public void SpeedUp()
    {
        StopAllCoroutines();
        StartCoroutine(SpeedRoutine());
    }

    IEnumerator SpeedRoutine()
    {
        float originalSpeed = 10f;

        forwardSpeed = originalSpeed * 1.4f;

        yield return new WaitForSeconds(1.5f);

        forwardSpeed = originalSpeed;
    }
}