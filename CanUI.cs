using UnityEngine;

public class HeartUI : MonoBehaviour
{
    public GameObject[] hearts;

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(i < ItemCollect.health);
        }
    }
}