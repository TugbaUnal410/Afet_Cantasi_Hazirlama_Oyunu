using UnityEngine;

public class OyunSifirlayici : MonoBehaviour
{
    void Start()
    {
        // Puan sıfırla
        ScoreManager.score = 0;

        // Can sıfırla
        ItemCollect.health = 3;
        SelItemCollect.health = 3;
        HeyelanItemCollect.health = 3;
        YanginItemCollect.health = 3;

        // Çanta barı sıfırla
        if (BagSystem.instance != null)
        {
            BagSystem.instance.bagSlider.value = 0;
        }

        // Oyunu normal hız yap
        Time.timeScale = 1f;
    }
}