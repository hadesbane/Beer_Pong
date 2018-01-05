using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
    private Rigidbody2D body;
    public float speed;
    public bool rotation;
    public bool coop;
    private bool down; //Stops down movement
    private bool up; //Stops up movement

	// Use this for initialization
	void Start () {
        this.body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        body.velocity = new Vector3(0, 0);
        if (coop)
        {
            
            if (Input.GetKey(KeyCode.W) && !up)
            {
                body.velocity = new Vector2(0, speed);
                down = false;
            }
            else if (Input.GetKey(KeyCode.S) && !down)
            {
                body.velocity = new Vector2(0, -speed);
                up = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                body.velocity = new Vector3(0, body.velocity.y, speed);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                body.velocity = new Vector3(0, body.velocity.y, -speed);
            }
        }
        else{
            if (Input.GetKey(KeyCode.UpArrow) && !up) //if not touching the botto
            {
                body.velocity = new Vector2(0, speed);
                down = false; //Allow down movement since you went up
            }
            else if (Input.GetKey(KeyCode.DownArrow) && !down)
            {
                body.velocity = new Vector2(0, -speed);
                up = false; //Allow up movement since you no longer are touching the top
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                body.velocity = new Vector3(0, body.velocity.y, speed);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                body.velocity = new Vector3(0, body.velocity.y, -speed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject game = collision.gameObject;
        if(game.tag == "Top Border") //If colliding with the top border of the game, do not allow upwards movement
        {
            up = true; 
        }
        else if(game.tag == "Bottom Border") //If colliding with the bottom border of the game, do not allow movement downwards
        {
            down = true;
        }

        if(game.tag == "Ball")
        {
            HitRecorder recorder = game.GetComponent<HitRecorder>();
            if (recorder.GetRecord() != 0)
            {
                game.GetComponent<HitRecorder>().PlayerHit(0);
            }
            //tells recorder that player 1 is now the last hitter on the ball (used for coin abilities)
        }
    }
}
