/*using UnityEngine;

public class QuestionBox : MonoBehaviour
{
    public GameObject questionPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            questionPanel.SetActive(true);

            QuestionManager qm =
                questionPanel.GetComponent<QuestionManager>();

            if (qm != null)
            {
                qm.currentBox = gameObject;
            }

            Time.timeScale = 0f;
        }
    }
}
*/
using UnityEngine;

public class QuestionBox : MonoBehaviour
{
    public GameObject questionPanel;

    private bool used = false;

    private Collider boxCollider;

    void Start()
    {
        boxCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (used) return;

        used = true;

        // 🚫 Trigger tekrar çalışmasın
        boxCollider.enabled = false;

        questionPanel.SetActive(true);

        QuestionManager qm =
            questionPanel.GetComponent<QuestionManager>();

        if (qm != null)
        {
            qm.currentBox = gameObject;
        }

        // ⏸ Oyunu durdur
        Time.timeScale = 0f;
        //other.GetComponent<PlayerMovement>().enabled = false;
    }
}