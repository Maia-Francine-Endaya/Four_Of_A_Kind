using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float playerSpeed = 2f;

  // Debug Logs
  void OnTriggerEnter(Collider collision)
  {
    Debug.Log("On Collision Enter");
    if (collision.gameObject.tag == "Key")
    {
      Debug.Log("Key Obtained");
    }
  }
}
