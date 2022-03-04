using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
  void Start()
  {
    Debug.Log("RestartScene");
  }
  void OnCollisionEnter()
  {
    Debug.Log("OnTriggerEnter");
    SceneManager.LoadScene("2. Game");
  }
}
