using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float jumpForce;
    public bool isGrounded;

    public GameObject deathUI;


    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
   

        //Takes care of Jumping
        if(Input.GetButtonDown("Jump") && isGrounded){
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
        if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("ground")){
            if(isGrounded == false) isGrounded = true;
        }
        if(col.gameObject.CompareTag("Obstacle")){
            Die();
        }
    }

    private void Die(){
        Time.timeScale = 0;
        deathUI.SetActive(true);
    }
}
