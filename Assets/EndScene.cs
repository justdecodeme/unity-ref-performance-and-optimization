using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
  public void RestartGame()
  {
    SceneManager.LoadScene("2. Game");
  }
  public void ExitGame()
  {
    Application.Quit();
  }
}
