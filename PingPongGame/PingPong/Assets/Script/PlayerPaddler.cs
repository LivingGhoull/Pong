using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddler : Paddle
{
   Vector2 dirction;

   void Update()
   {
       if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
           dirction = Vector2.up;
       } 
       else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
           dirction = Vector2.down;
       } 
       else {
           dirction = Vector2.zero;
       }
   }

   void FixedUpdate()
   {
       if (dirction.sqrMagnitude !=  0) {
           rb.AddForce(dirction * speed);
       }
   }
}
