using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PDJControll : MonoBehaviour {

    private Rigidbody2D rb;
    private float velocidade;
    private Vector2 forcaPulo;
    private bool podePular;

    void Start(){
        velocidade = 5.0f;
        forcaPulo = new Vector2(0.0f, 450.0f);
        podePular = true;
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update(){
        float mHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (mHorizontal * velocidade, rb.velocity.y);
     
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            if (podePular) {
                podePular = false;
                rb.AddForce(forcaPulo);
            }
        }
         
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "PermitePular") {
            podePular = true;
        }
        
    }


}
