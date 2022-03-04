using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
  public float bulletSpeed = 8f;
  public float lifeDuration = 3f;
  private float lifeTimer;

  void OnEnable()
  {
    lifeTimer = lifeDuration;
  }

  void Update()
  {
    transform.position += transform.up * bulletSpeed * Time.deltaTime;

    lifeTimer -= Time.deltaTime;

    if (lifeTimer <= 0)
    {
      gameObject.SetActive(false);
    }
  }
}
