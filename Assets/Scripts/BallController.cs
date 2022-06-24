using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    
    private Rigidbody rig;
    private Vector3 initPos;
    private Vector3 initSpeed;
    public BallManager manager;
    /*public Vector3 areaMin;
    public Vector3 areaMax;*/
    private bool outOfArea;

    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
        initPos = gameObject.transform.position;
        initSpeed = speed;
        outOfArea = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Paddle" || collision.gameObject.tag == "Corner")
        {
            if (rig.velocity.magnitude < maxSpeed)
            {
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
        else if(collision.gameObject.tag == "Floor")
        {
            rig.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }

    public void ResetPosition()
    {
        manager.RemoveBall(gameObject);
    }

}
