using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    private Ball_Spawn ballSpawn;
    public ScoreKeeper score;

	// Use this for initialization
	void Start () {
        this.ballSpawn = GameObject.FindWithTag("Ball").GetComponent<Ball_Spawn>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball"){
            //score.changeScore(this.gameObject);
            this.ballSpawn.respawn = true;

        }
    }
}
