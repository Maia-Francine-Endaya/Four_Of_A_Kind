using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  // For button sound effects
  public AudioSource source;
  public AudioClip clip;

  public void PlayGame()
  {
    SceneManager.LoadScene("Level_01");
    Time.timeScale = 0;
    //Debug.Log("Game Started");

    source.PlayOneShot(clip);
  }

  public void ReadInstructions()
  {
    SceneManager.LoadScene("Instructions");

    source.PlayOneShot(clip);
  }

  public void BackToMenu()
  {
    SceneManager.LoadScene("Main_Menu");

    source.PlayOneShot(clip);
  }

  public void QuitGame()
  {
    Application.Quit();

    source.PlayOneShot(clip);
  }
}
