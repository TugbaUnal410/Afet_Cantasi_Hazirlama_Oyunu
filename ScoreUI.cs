/*using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    [Header("Süre")]
    public float timeLeft = 60f;

    [Header("End Object")]
    public GameObject endManagerObject;

    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded) return;

        scoreText.text = "Puan: " + ScoreManager.score;

        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            timeLeft = 0;
        }

        timeText.text = "Süre: " + Mathf.CeilToInt(timeLeft);

        // 🔴 Son 10 saniye
        if (timeLeft <= 10)
        {
            timeText.color = Color.red;
        }

        // ⌛ Süre bitti
        if (timeLeft <= 0)
        {
            gameEnded = true;

            if (endManagerObject != null)
            {
                endManagerObject.SendMessage("ShowEnd");
                
            }

            Time.timeScale = 0f;
        }
    }
}*/
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI timeText;

    [Header("Süre")]
    public float timeLeft = 60f;

    [Header("End Object")]
    public GameObject endManagerObject;

    private bool gameEnded = false;

    void Update()
    {
        // 🎮 Oyun bittiyse dur
        if (gameEnded) return;

        // ⭐ Skor yazısı
        scoreText.text =
            "Puan: " + ScoreManager.score;

        // ⏰ Süre azalt
        timeLeft -= Time.deltaTime;

        // ⛔ Negatif olmasın
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }

        // 🕒 Süre yazısı
        timeText.text =
            "Süre: " + Mathf.CeilToInt(timeLeft);

        // 🔴 Son 10 saniye
        if (timeLeft <= 10)
        {
            timeText.color = Color.red;
        }

        // ⌛ Süre bittiyse
        if (timeLeft <= 0)
        {
            gameEnded = true;

            // 🎯 Heyelan EndManager al
            HeyelanEndManager end =
                endManagerObject.GetComponent<HeyelanEndManager>();

            // 💀 Güvenli alana ulaşamadı
            if (end != null)
            {
                end.ShowEnd(false);
            }
        }
    }
}