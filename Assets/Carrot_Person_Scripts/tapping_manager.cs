using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapping_manager : MonoBehaviour {

    public score_manager sm_object;
    public UnityEngine.GameObject carrot_sprite, clone; //12/20
    public Transform left_b, right_b;   //12/20
    public float y_spawn;

    // Use this for initialization
    void Start()
    {
        y_spawn = carrot_sprite.transform.position.y;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void createClone()  //12/20 
    {
        //Carrots created at original parent's coordinates (at bottom..fix by saving coords at start)
        clone = Instantiate(carrot_sprite); //12/20
        float x_spawn = Random.Range(left_b.transform.position.x, right_b.transform.position.x); //12/20,
        clone.transform.position = new Vector3(x_spawn, y_spawn, 0); //12/20,
        //Set scale of original parent object to 1 in editor //12/20
        //The transform tends to get really weird when parenting an instantiated object originally created without a parent.
    }

    private void OnMouseDown()
    {
        createClone();
        sm_object.totalCarrots++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {/*
        if (collision.gameObject.tag == "Carrot")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<BoxCollider2D>(), false);
        }
        //Prevent collision with tapping area and clones
        //Can disable box collider on carrot for now but
        //carrot will need to collide with face
        */
    }
}
