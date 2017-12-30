using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Limiter : MonoBehaviour {
    public float maxSpeed;
    private Rigidbody2D body;

	// Use this for initialization
	void Start () {
        this.body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(this.body.velocity.x > maxSpeed)
        {
            this.body.velocity = new Vector3(maxSpeed, this.body.velocity.y);
        }
        else if(this.body.velocity.y < -maxSpeed)
        {
            this.body.velocity = new Vector3(-maxSpeed, this.body.velocity.y); 
        }
	}
}
