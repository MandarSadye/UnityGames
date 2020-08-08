using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
    public static int breakableCount = 0;
    public AudioClip Crack;
    private bool isBreakable; 
    private int timesHit;
    public Sprite[] hitprites;
    private GameManager levelManager;
	// Use this for initialization
	void Start () {
        isBreakable =(this.tag == "Breakable");
        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<GameManager>();
	}

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //AudioSource.PlayClipAtPoint(Crack, transform.position);
        
        if (isBreakable)
        {
            Handlehits();
        }
    }
    private void Handlehits()
    {
        timesHit++;
        int maxHits = hitprites.Length + 1;
        print(timesHit);
        if (timesHit >= maxHits)
        {
            breakableCount--;
            print(breakableCount);
            levelManager.brickDistroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }
    private void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitprites[spriteIndex];
        }
    }
    // Update is called once per frame
    void Update () {
		
	}


}
