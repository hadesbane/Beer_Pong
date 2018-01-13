using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Limiter : MonoBehaviour {
    public float maxSpeed;
    private Rigidbody2D body;
    private float currY;

	// Use this for initialization
	void Start () {
        this.body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        this.currY = this.body.velocity.y;
		if(this.body.velocity.x > maxSpeed)
        {
            this.body.velocity = new Vector3(maxSpeed, this.body.velocity.y);
        }
        else if(this.body.velocity.x < -maxSpeed)
        {
            this.body.velocity = new Vector3(-maxSpeed, this.body.velocity.y); 
        }
	}
}
