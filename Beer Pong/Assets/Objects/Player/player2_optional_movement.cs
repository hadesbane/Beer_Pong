using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_optional_movement : MonoBehaviour {

    private Rigidbody2D body;
    public float speed;
    public bool rotation;
    public bool coop;

    private bool down; //Stops downward movement
    private bool up; //Stops upward movement

    // Use this for initialization
    void Start()
    {
        this.body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.velocity = new Vector2(0, 0);
        if (coop)
        {
            if (Input.GetKey(KeyCode.UpArrow) && !up)
            {
                body.velocity = new Vector2(0, speed);
                down = false;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && !down)
            { 
                body.velocity = new Vector2(0, -speed);
                up = false;
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
        if (game.tag == "Top Border") //If colliding with the top border of the game, do not allow upwards movement
        {
            up = true;
        }
        else if (game.tag == "Bottom Border") //If colliding with the bottom border of the game, do not allow movement downwards
        {
            down = true;
        }

        if(game.tag == "Ball")
        {
            HitRecorder record = game.GetComponent<HitRecorder>();
            if (record.GetRecord() != 1)
            {
                game.GetComponent<HitRecorder>().PlayerHit(1);
            }
                //changes the recorder to have player 2 last hitting the ball
        }
    }
}
