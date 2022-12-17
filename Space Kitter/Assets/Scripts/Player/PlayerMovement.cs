using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    //Movement
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    
    //Score
    public int score = 0;
    public TMP_Text scoreText;

    //Health
    public GameObject player;
    public GameObject gameOverScreen;

    public int health = 10;
    public int maxHealth = 10;

    void Start()
    {
        health = maxHealth;
        gameOverScreen.SetActive(false);
    }

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -0.2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        UpdateScore();
    }

    //Tag
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectable")
        {
            Destroy(other.gameObject);
            score += 10;
        }

        //Player die
        if (other.tag == "OutBounds")
        {
            Debug.Log("We're Out Of Bounds");
            gameOverScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    //UI
    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    //Hit
    public void Damage(int damageMultiplier)
    {
        health -= damageMultiplier;
        if (health <= 0)
        {
            gameOverScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
