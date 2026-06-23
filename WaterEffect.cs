using UnityEngine;

public class WaterEffect : MonoBehaviour
{
    public ParticleSystem waterParticle;

    public void ShowWater(Vector3 position)
    {
        waterParticle.transform.position = position;

        waterParticle.Play();
    }
}