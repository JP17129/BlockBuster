using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    
       public void LoadLevel(string name)
        {
        Brick.breakableCount = 0;
            Debug.Log("Level load requested for: " + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest()
    {
        Debug.Log("The user wishes to quit the game.");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Brick.breakableCount = 0;
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void BrickDestroyed()
    {
        if (Brick.breakableCount <= 0)
            {
            LoadNextLevel();
        }
    }

}
