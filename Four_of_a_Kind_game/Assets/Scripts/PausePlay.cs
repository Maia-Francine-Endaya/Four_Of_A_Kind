using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePlay : MonoBehaviour
{

  public AudioSource source;
  public AudioClip clip;
  public void Pause()
  {
    Time.timeScale = 0;
    Debug.Log("Game Paused");
    source.PlayOneShot(clip);
  }

  public void Play()
  {
    Time.timeScale = 1;
    Debug.Log("Game Resumed");
    source.PlayOneShot(clip);
  }

  public void Replay()
  {
    SceneManager.LoadScene("Level_01");
    Time.timeScale = 0;
    Debug.Log("Game Restarted");
    source.PlayOneShot(clip);
  }
}
