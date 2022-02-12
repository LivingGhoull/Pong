using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] BallPoint bp;
    [SerializeField] float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        AddStartingForce();
    }

    public void AddStartingForce(){
        float x = Random.value < 0.5f ? -1f: 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x,y);
        rb.AddForce(direction * speed);
    }

    public void AddForce(Vector2 force){
        rb.AddForce(force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        bp.pointGained(other, this.gameObject);  
    }

    public void test(){
        Debug.Log("test");
    }
}
