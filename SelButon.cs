using UnityEngine;
using UnityEngine.SceneManagement;

public class SelButon : MonoBehaviour
{
    public void SeliAc()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Sel");
    }
}
