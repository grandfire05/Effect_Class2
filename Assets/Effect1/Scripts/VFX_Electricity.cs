using System.Collections;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class VFX_Electricity : MonoBehaviour
{
    [SerializeField] GameObject playingParticleObject;
    [SerializeField] AnimationClip playingAnimationClip;
    [SerializeField] float readyDelay;
    [SerializeField] float waitDelay;
    private void Start()
    {
        StartCoroutine(EffectLooping());
    }

    private IEnumerator EffectLooping()
    {
        while (true)
        {
            yield return new WaitForSeconds(readyDelay);
            playingParticleObject.SetActive(true);
            yield return new WaitForSeconds(waitDelay);
            playingParticleObject.SetActive(false);
            yield return new WaitForSeconds(playingAnimationClip.length - readyDelay - waitDelay);
        }
    }
}
