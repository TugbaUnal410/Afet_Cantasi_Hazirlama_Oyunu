using UnityEngine;

public class FireEffect : MonoBehaviour
{
    public ParticleSystem fireParticle;

    public void ShowFire(Vector3 position)
    {
        fireParticle.transform.position = position;

        fireParticle.Play();
    }
}