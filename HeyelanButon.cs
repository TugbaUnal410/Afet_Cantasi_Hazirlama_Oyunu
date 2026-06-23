using UnityEngine;
using UnityEngine.SceneManagement;

public class HeyelanButon : MonoBehaviour
{
    public void HeyelaniAc()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Heyelan");
    }
}
