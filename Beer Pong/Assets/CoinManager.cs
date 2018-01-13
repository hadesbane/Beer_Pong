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

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject ball = collision.gameObject;
        this.gameObject.SetActive(false);
        coin.Effect(record.GetRecord());
    }
}