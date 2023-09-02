using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame()
  {
    SceneManager.LoadScene("Level_01");
    Time.timeScale = 0;
    //Debug.Log("Game Started");
  }

  public void ReadInstructions()
  {
    SceneManager.LoadScene("Instructions");
  }

  public void BackToMenu()
  {
    SceneManager.LoadScene("Main_Menu");
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
