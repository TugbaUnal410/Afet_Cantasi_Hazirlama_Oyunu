using UnityEngine;
using UnityEngine.UI;

public class BagSystem : MonoBehaviour
{
    public Slider bagSlider;
    public Image fillImage;

    public static BagSystem instance;

    void Awake()
    {
        instance = this;
    }

    public void AddToBag(int amount)
    {
        bagSlider.value += amount;

        // 🎨 Renk değiştirme
        if (bagSlider.value < 30)
        {
            fillImage.color = Color.red;
        }
        else if (bagSlider.value < 70)
        {
            fillImage.color = Color.yellow;
        }
        else
        {
            fillImage.color = Color.green;
        }
    }
}