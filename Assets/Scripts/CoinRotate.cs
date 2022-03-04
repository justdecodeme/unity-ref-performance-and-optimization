using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
  Vector3 rotateSpeed;

  void Update()
  {
    rotateSpeed = new Vector3(45, 0, 0);

    transform.Rotate(rotateSpeed * Time.deltaTime);
  }
}
