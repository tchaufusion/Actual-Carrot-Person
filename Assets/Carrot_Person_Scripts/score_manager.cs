using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_manager : MonoBehaviour {

    public int totalCarrots = 0; //Variable for the score
    //public TextMesh totalCarrotsDisplay;
    public UnityEngine.UI.Text totalCarrotsDisplay; //Variable for the text object
    public int carrotsPerTap = 5;

	// Use this for initialization
	void Start () {
        if (totalCarrots == 100)
        {
            totalCarrots = 120;
        }
        Debug.Log(totalCarrots); //How we'll print to the console to check values
	}
	
	// Update is called once per frame
	void Update ()
    {
        totalCarrotsDisplay.text = totalCarrots.ToString(); //Where we set the text
    }
    
    public void onClick()
    {
        totalCarrots = totalCarrots + carrotsPerTap; //Increase totalCarrots variable by carrotsPerTap
        Debug.Log(totalCarrots); //Debug totalCarrots to console
    }
}
