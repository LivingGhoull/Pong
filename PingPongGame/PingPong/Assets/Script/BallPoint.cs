using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallPoint : MonoBehaviour
{   
    [SerializeField] TextMeshProUGUI[] goalUi;
    [SerializeField] GameObject ball;

    public void pointGained(Collision2D hit, GameObject ball) {
        if(hit.gameObject.tag == "AiGoal"){
            int point = int.Parse(goalUi[1].text);
            goalUi[0].text = (point + 1).ToString();
            restartBall(ball);
        }
        else if(hit.gameObject.tag == "PlayerGoal"){
            int point = int.Parse(goalUi[1].text);
            goalUi[1].text = (point + 1).ToString();
            restartBall(ball);
        }
    }

    public void restartBall(GameObject ball){
        ball.transform.position = new Vector3(0,0,0);
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        
        Ball sBall = ball.GetComponent<Ball>();  
        sBall.AddStartingForce();
    }
   
}
