using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class face_mover : MonoBehaviour {

    public Transform left_boundary, right_boundary;
    public int spriteWalkSpeed = 0;
    public bool bounce = false; //If bounce is false then move left, if bounce is true move right

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();	
	}

    void Movement()
    {
        //only move if the game object is active and if it's less than generation point
        if (bounce == false)
        {
            if (gameObject.activeSelf && transform.position.x > left_boundary.position.x) //move left
            {
                transform.Translate(Vector2.up * spriteWalkSpeed * Time.deltaTime);

            }
            if (gameObject.activeSelf && transform.position.x <= left_boundary.position.x)
            {
                bounce = true;
            }
        } else {
            if (gameObject.activeSelf && transform.position.x < right_boundary.position.x) //move left
            {
                transform.Translate(Vector2.down * spriteWalkSpeed * Time.deltaTime);
            }
            if (gameObject.activeSelf && transform.position.x >= right_boundary.position.x)
            {
                bounce = false;
            }
        }
    }
}
