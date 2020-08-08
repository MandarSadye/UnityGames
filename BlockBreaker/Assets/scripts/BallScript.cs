using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public AudioClip boing;
    private PADDLE paddle;
    public Vector2 ballPush = new Vector2(2f, 10f);
    private bool hasStarted = false;
    private Vector3 PaddleToBallVector;
	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<PADDLE>();
        PaddleToBallVector = this.transform.position - paddle.transform.position;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
            print(tweak);
            GameObject.FindObjectOfType<Rigidbody2D>().velocity += new Vector2(0,0);
            //AudioSource.PlayClipAtPoint(boing, transform.position);
        }
    }
    // Update is called once per frame
    void Update () {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + PaddleToBallVector;
        
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            //print("mouse clicked..Launch Ball");
            this.GetComponent<Rigidbody2D>().velocity = ballPush;
        }
        }
	}
}
