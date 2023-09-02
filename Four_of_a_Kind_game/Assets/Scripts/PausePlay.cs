using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    SceneManager.LoadScene("Level_01");
    Time.timeScale = 0;
    Debug.Log("Game Restarted");
  }
}
