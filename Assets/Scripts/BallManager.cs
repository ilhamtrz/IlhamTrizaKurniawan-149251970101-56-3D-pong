using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxBallAmount;
    public int spawnInterval;
    public GameObject ballTemplate;
    public Vector3 areaMax;
    public Vector3 areaMin;

    public List<Transform> spawnAreaList;

    private List<GameObject> ballList;
    private float timer;

    private void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            GenerateBall();
            timer -= spawnInterval;
        }
        if(ballList.Count != 0)
        {
            //checkBallArea();
            Debug.Log("masuk");
        }
        
    }
    public void GenerateBall()
    {
        int randomIndex = Random.Range(0, spawnAreaList.Count);
        GenerateBall(new Vector3(spawnAreaList[randomIndex].position.x, spawnAreaList[randomIndex].position.y, spawnAreaList[randomIndex].position.z), randomIndex);

     
    }
    public void GenerateBall(Vector3 position, int index)
    {
        if (ballList.Count >= maxBallAmount)
        {
            //StartCoroutine(BallTimer());
            return;
        }
        GameObject ball = Instantiate(ballTemplate,
            new Vector3(position.x, position.y, position.z),
            Quaternion.identity, spawnArea);
        ball.SetActive(true);

        switch (index)
        {
            case 0:
                ball.GetComponent<BallController>().speed = new Vector3(-15, 0, 30);
                break;
            case 1:
                ball.GetComponent<BallController>().speed = new Vector3(30, 0, 15);
                break;
            case 2:
                ball.GetComponent<BallController>().speed = new Vector3(15, 0, -30);
                break;

            case 3:
                ball.GetComponent<BallController>().speed = new Vector3(-30, 0, -15);
                break;
        }

        ballList.Add(ball);
    }
    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }
    
}
