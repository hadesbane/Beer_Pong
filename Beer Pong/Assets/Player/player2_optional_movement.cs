using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_optional_movement : MonoBehaviour {

    private Rigidbody2D body;
    public float speed;
    public bool rotation;
    public bool coop;

    // Use this for initialization
    void Start()
    {
        this.body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (coop)
        {
            body.velocity = new Vector3(0, 0);
            if (Input.GetKey(KeyCode.UpArrow))
            {
                body.velocity = new Vector2(0, speed);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                body.velocity = new Vector2(0, -speed);
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
}
