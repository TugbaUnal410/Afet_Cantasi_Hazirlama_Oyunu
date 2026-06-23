using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}