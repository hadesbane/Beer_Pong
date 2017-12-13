using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Trying to get the ball to spawn, will send it to the left or right
//Problem is that there are way to many balls spawning

public class Ball_Spawn : MonoBehaviour {
    public bool respawn;
    public Rigidbody2D ballPrefab;
    public float speed;
    public int multiball;

    // Use this for initialization
    void Start() {
        this.respawn = true;
    }

    // Update is called once per frame

    void Update() {
        if (respawn)
        {
            Rigidbody2D ball = ballSpawn();
           
        }
        respawn = false;
	}

    Rigidbody2D ballSpawn()
    {
        var ballSpawn = GameObject.Find("Ballspawn").transform;

        Rigidbody2D ball = Instantiate(this.ballPrefab, ballSpawn.position, ballSpawn.rotation) as Rigidbody2D;
        // sets the starting position to the top of the middle of the game

        ball.velocity = addVelocity();
        return ball;
    }

    Vector2 addVelocity()
    {
        Vector2 vec;
        bool directionBinary = (Random.value < 0.5f) ? true : false; // True, ball goes right, false, it goes left
        if (directionBinary) 
        {
            vec = new Vector2(this.speed, this.speed);
            //Random x speed sent to the right (positive)
        }
        else
        {
            vec = new Vector2(-this.speed, this.speed);
        }
        return vec;
    }
}
