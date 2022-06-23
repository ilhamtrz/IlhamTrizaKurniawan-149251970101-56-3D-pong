using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public bool isVertical;
    public bool isEliminated;
    public KeyCode moveRight, moveLeft;

    private Vector3 initPos;
    private Rigidbody player_rig;

    // Start is called before the first frame update
    void Start()
    {
        player_rig = GetComponent<Rigidbody>();
        isEliminated = false;
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedRight = Input.GetKey(this.moveRight);
        bool pressedLeft = Input.GetKey(this.moveLeft);

        if (!isEliminated)
        {
            if (isVertical)
            {
                if (pressedRight)
                {
                    player_rig.velocity = Vector3.forward * speed;
                }

                if (pressedLeft)
                {
                    player_rig.velocity = Vector3.back * speed;
                }

                if (!pressedRight && !pressedLeft)
                {
                    player_rig.velocity = Vector3.zero;
                }
            }
            else
            {
                if (pressedRight)
                {
                    player_rig.velocity = Vector3.right * speed;
                }

                if (pressedLeft)
                {
                    player_rig.velocity = Vector3.left * speed;
                }

                if (!pressedRight && !pressedLeft)
                {
                    player_rig.velocity = Vector3.zero;
                }
            }
        }
        else
        {
            transform.position = new Vector3(initPos.x, initPos.y, initPos.z);
            transform.localScale = new Vector3(70, transform.localScale.y, transform.localScale.z);
            player_rig.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}

