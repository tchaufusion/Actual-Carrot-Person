using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_manager : MonoBehaviour {

    public score_manager score_manager_object;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void upgrade() //Increase carrots per tap by 2 for the cost of 1
    {
        score_manager_object.carrotsPerTap += 2;
        score_manager_object.totalCarrots -= 1;
    }
}
