using UnityEngine;
using UnityEngine.SceneManagement;

public class YanginButon : MonoBehaviour
{
    public void YanginiAc()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Yangin");
    }
}
