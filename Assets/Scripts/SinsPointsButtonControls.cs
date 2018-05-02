using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinsPointsButtonControls : MonoBehaviour {
    public Text pointsDisplay;
    public int points = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pointsDisplay.text = points.ToString();
	}
    public void AddPoint()
    {
        points++;
    }
    public void MinusPoint()
    {
        points--;
        if (points < 0)
        {
            points = 0;
        }
    }
}
