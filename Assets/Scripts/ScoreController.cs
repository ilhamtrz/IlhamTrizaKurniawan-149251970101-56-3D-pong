using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorP1;
    public Text skorP2;
    public Text skorP3;
    public Text skorP4;

    public ScoreManager manager;


    // Update is called once per frame
    private void Update()
    {
        skorP1.text = manager.p1Score.ToString();
        skorP2.text = manager.p2Score.ToString();
        skorP3.text = manager.p3Score.ToString();
        skorP4.text = manager.p4Score.ToString();

    }
}
