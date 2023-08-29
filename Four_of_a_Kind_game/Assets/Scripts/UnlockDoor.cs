using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
  public GameObject door;
  public GameObject key;

  public AudioSource source;
  public AudioClip clip;
  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      Destroy(door);
      Destroy(key);

      source.PlayOneShot(clip);
    }
  }
}
