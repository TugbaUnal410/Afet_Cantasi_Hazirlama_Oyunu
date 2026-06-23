using UnityEngine;

public class DustEffect : MonoBehaviour
{
    public ParticleSystem dustParticle;

    public void ShowDust(Vector3 position)
    {
        dustParticle.transform.position = position;

        dustParticle.Play();
    }
}
