/*using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private bool finished = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger çalıştı");

        if (!other.CompareTag("Player")) return;


        if (finished) return;
 Debug.Log("Finish çalıştı");

        finished = true;

        EndManager end =
            FindObjectOfType<EndManager>();

        if (end != null)
        {
            end.ShowEnd(true);
        }
    }
}*/
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private bool finished = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bir şey değdi: " + other.name);

        if (!other.CompareTag("Player"))
        {
            Debug.Log("Player değil");
            return;
        }

        Debug.Log("PLAYER ALGILANDI");

        if (finished) return;

        finished = true;

        EndManager end =
            FindObjectOfType<EndManager>();

        if (end != null)
        {
            end.ShowEnd(true);
        }
    }
}