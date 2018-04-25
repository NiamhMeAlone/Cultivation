using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quality : MonoBehaviour
{
    public Text pointsDisplay;
    public string sin;
    public int points = 0;
    public static int pointsRemaining = 10;

    void Start()
    {
        pointsDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsDisplay.text = points.ToString();
    }
    public void AddPoint()
    {
        if (pointsRemaining > 0)
        {
            points++;
            pointsRemaining--;
        } 
    }
    public void MinusPoint()
    {
        if (points > 0)
        {
            points--;
            pointsRemaining++;
        }
    }

    public void ResetPoints()
    {
        points = 0;
    }
}