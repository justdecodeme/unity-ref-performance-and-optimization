using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
  public Transform gunPoint;

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      GameObject bulletObject = PoolManager.Instance.GetBullet();
      bulletObject.transform.position = gunPoint.transform.position;
    }
  }
}
