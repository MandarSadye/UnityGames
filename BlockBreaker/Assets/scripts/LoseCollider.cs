using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private GameManager levelmanager;

    private void Start()
    {
        levelmanager = GameObject.FindObjectOfType<GameManager>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Trigger");
        levelmanager.LevelLoad("GameLost");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
    }
}
