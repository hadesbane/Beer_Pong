using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    private int leftScore;
    private int rightScore;
    private int end;

    // Use this for initialization
    void Start()
    {
        this.leftScore = 0;
        this.rightScore = 0;
        this.end = 0;
    }

    public void changeScore(GameObject goal)
    {
        if (goal.tag == "Right Goal")
        {
            rightScore++;
        }
        else if (goal.tag == "Left Goal")
        {
            leftScore++;
        }
    }
}
