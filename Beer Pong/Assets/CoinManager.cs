using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private HitRecorder record;
    public CoinClass coin;

    // Use this for initialization
    void Start()
    {
        this.record = GetComponent<HitRecorder>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ball = collision.gameObject;
        if (ball.tag == "Ball")
        {
            Rigidbody2D rigid = ball.GetComponent<Rigidbody2D>();
            this.CoinCollect(ball.gameObject, rigid.velocity);
        }
    }

    private void CoinCollect(GameObject ball, Vector2 velocity)
    {
        ball.GetComponent<Rigidbody2D>().velocity = velocity;
        coin.Effect(record.GetRecord());
    }
}