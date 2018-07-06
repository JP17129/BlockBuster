using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    public static MusicPlayer Instance;

    private void Awake()
        {
        Debug.Log("Music Player Awake " + GetInstanceID());
        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    
    public void Start () { //Use this for initalization***
        Debug.Log("Music Player Initiated " + GetInstanceID());
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
