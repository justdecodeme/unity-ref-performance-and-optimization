using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
  Rigidbody rb;
  public int ballSpeed = 10;
  public int jumpSpeed = 10;
  bool isGrounded = true;
  public Text coinText;
  private int counter;
  public AudioSource audioSource;
  public AudioClip audioClip;


  void Start()
  {
    rb = GetComponent<Rigidbody>();
    counter = 20;
    coinText.text = "Coins: " + counter;
  }

  void Update()
  {
    float hMove = Input.GetAxis("Horizontal");

    float vMove = Input.GetAxis("Vertical");

    Vector3 ballMove = new Vector3(hMove, 0.0f, vMove);

    rb.AddForce(ballMove * ballSpeed);

    if (Input.GetKey(KeyCode.Space) && isGrounded)
    {
      Vector3 ballJump = new Vector3(0.0f, 6f, 0.0f);
      rb.AddForce(ballJump * jumpSpeed);
    }

    isGrounded = false;
  }

  /* OnCollisionStay is called once per frame for every
  collider/rigidbody that is touching rigidbody/collider. */
  void OnCollisionStay()
  {
    isGrounded = true;
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Coin"))
    {
      other.gameObject.SetActive(false);
      counter = counter - 1;
      coinText.text = "Coins: " + counter;
      audioSource.PlayOneShot(audioClip);
      if (counter == 0)
      {
        SceneManager.LoadScene("3. End");
      }
    }
  }
}
