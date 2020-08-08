using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Mover : MonoBehaviour {

    public float SpinSpeed = 30f;
    public float MotionMagnitude = 0.1f;
    public bool DoSpin = false;
    public bool DoMove = false;
 	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(DoSpin)
        gameObject.transform.Rotate(0, SpinSpeed* Time.deltaTime, 0);
        if(DoMove)
        transform.Translate(Vector3.up* MotionMagnitude * Mathf.Cos(Time.timeSinceLevelLoad));

    }
}
