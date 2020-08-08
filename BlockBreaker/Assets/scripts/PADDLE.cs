using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PADDLE : MonoBehaviour {
    private float mousePosInBlocks = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);

        mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        if (mousePosInBlocks < 0) mousePosInBlocks = 0;
        if (mousePosInBlocks > 16) mousePosInBlocks = 16;
        //print(mousePosInBlocks);
        paddlePos.x = Mathf.Clamp(mousePosInBlocks,0.5f,15.5f);
        paddlePos.y = 1f;
        this.transform.position = paddlePos;
	}
}
