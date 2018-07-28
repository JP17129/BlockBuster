using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool autoPlay = false;
    private bool hasStarted = false;
    private Ball ball;
    public float minX, maxX;
    // Use this for initialization
    void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (autoPlay == false)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();
        }

        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
        }

    }

    void AutoPlay()
    {
        Vector3 ballPos = ball.transform.position;
        Vector3 paddlePos = new Vector3(7.99f, this.transform.position.y, 0f);
        paddlePos.x = Mathf.Clamp(ballPos.x, minX, maxX);
        this.transform.position = paddlePos;
    }

    void MoveWithMouse()
    {
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        Vector3 paddlePos = new Vector3(7.99f, this.transform.position.y, 0f);
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
        this.transform.position = paddlePos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (hasStarted)
        {
            GetComponent<AudioSource>().Play();

        }
    }
}
