using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public GameObject questionPanel;

    public GameObject currentBox;

    public void CorrectAnswer()
    {
        ScoreManager.AddScore(5);

        questionPanel.SetActive(false);

        if (currentBox != null)
        {
            Destroy(currentBox);
        }

       Time.timeScale = 1f;
       //FindObjectOfType<PlayerMovement>().enabled = true;
    }

    public void WrongAnswer()
    {
        questionPanel.SetActive(false);

        if (currentBox != null)
        {
            Destroy(currentBox);
        }

       Time.timeScale = 1f;
      //FindObjectOfType<PlayerMovement>().enabled = true;
    }
}