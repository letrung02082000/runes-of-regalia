using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
  public AudioClip[] destroyNoise;

  public void PlayRandomDestroyNoise()
  {
    int clipToPlay = Random.Range(0, destroyNoise.Length);
    AudioSource.PlayClipAtPoint(destroyNoise[clipToPlay], transform.position);
  }

}
