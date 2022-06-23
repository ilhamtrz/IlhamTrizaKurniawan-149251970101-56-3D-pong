using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public int playerNo;
    public ScoreManager manager;
    public BallManager ballManager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            BallController ball = collision.GetComponent<BallController>();
            switch (playerNo)
            {
                case 1:
                    manager.AddP1Score(1);
                    break;
                case 2:
                    manager.AddP2Score(1);
                    break;
                case 3:
                    manager.AddP3Score(1);
                    break;
                case 4:
                    manager.AddP4Score(1);
                    break;
            }
            ball.ResetPosition();
        }

    }
}
