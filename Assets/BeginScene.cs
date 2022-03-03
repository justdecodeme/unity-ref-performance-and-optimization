using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginScene : MonoBehaviour
{
  public void StartGame()
  {
    SceneManager.LoadScene("2. Game");
  }
}
