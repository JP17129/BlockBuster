using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public AudioClip crack;
    public Sprite[] HitSprites;
    public int maxHits;
    private int timesHit;
    private int spriteIndex;
    private LevelManager LevelManager;
    public static int breakableCount = 0;
    private bool isBreakable;
    public GameObject dust;
    // Use this for initialization
    void Start () {
        isBreakable = (this.tag == "Breakable");
        //keeping track of breakable bricks
        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }
        LevelManager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;
        spriteIndex = maxHits;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    
        
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(crack, transform.position);
        if (isBreakable)
        {
            HandleHits(); 
        }
    }

    void HandleHits()
    {
        timesHit++;
        spriteIndex--;
        if (timesHit >= maxHits)
        {
            Instantiate(dust, gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            breakableCount--;
            LevelManager.BrickDestroyed();
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = HitSprites[spriteIndex - 1];
        }

    }

    void SimulateWin()
    {
        LevelManager.LoadNextLevel();
    }
}
