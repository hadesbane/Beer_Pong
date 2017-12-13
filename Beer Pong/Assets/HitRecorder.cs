using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//meant for the tracking of which player has hit the ball last
//and then can be used to give abilities to the players
public class HitRecorder : MonoBehaviour {
    private int player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetRecord()
    {
        return player;
    }

    //changes the record of who last hit the ball
    public void PlayerHit(int player)
    {
        this.player = player;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {

        }
    }
}
