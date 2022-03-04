using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
  public GameObject bulletPrefab;
  public Transform gunPointZ;

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Vector3 gunPos = gunPointZ.position;
      //   Instantiate(bulletPrefab, new Vector3(2.0F, 0, 0), Quaternion.identity);
      Instantiate(bulletPrefab, gunPos, Quaternion.identity);
    }
  }
}
