using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    [SerializeField] float bounceStrength;
    

    void OnCollisionEnter2D(Collision2D other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball != null) {
            Vector2 normal = other.GetContact(0).normal;
            ball.AddForce(-normal * bounceStrength);
        }
    }
}
