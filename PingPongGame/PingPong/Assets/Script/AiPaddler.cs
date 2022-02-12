using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPaddler : Paddle
{
    
    [SerializeField] Rigidbody2D ball;

    void FixedUpdate()
    {
        if (ball.velocity.x < 0) {
            if (ball.position.y > transform.position.y) {
                rb.AddForce(Vector2.up * speed);
            }
            else if (ball.position.y < transform.position.y ) {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else {
            if (transform.position.y > 0f) {
                rb.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0f){
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
