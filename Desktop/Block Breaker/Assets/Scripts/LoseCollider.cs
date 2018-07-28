using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager LevelManager;
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        LevelManager = GameObject.FindObjectOfType<LevelManager>();
        LevelManager.LoadLevel("Lose Screen");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");

    }
}
