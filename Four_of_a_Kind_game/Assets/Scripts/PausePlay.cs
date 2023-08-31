using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePlay : MonoBehaviour
{
  public void Pause()
  {
    Time.timeScale = 0;
    Debug.Log("Game Paused");
  }

  public void Play()
  {
    Time.timeScale = 1;
    Debug.Log("Game Resumed");
  }

  public void Replay()
  {
    //TO DO: PUT CODE HERE
  }
}
