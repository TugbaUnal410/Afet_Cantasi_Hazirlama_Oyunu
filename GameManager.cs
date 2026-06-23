using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int health = 3;

    void Awake()
    {
        Time.timeScale = 1f; // 🔥 EN KRİTİK: oyun başlarken açılır
    }

    public static void DecreaseHealth()
    {
        health--;

        Debug.Log("Can: " + health);

        if (health <= 0)
        {
            Debug.Log("OYUN DURDU");
            Time.timeScale = 0f;
        }
    }
}