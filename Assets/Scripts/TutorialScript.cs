using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {
    public GameObject[] panels = new GameObject[7]; 
    int i = 0;
	// Use this for initialization
	void Start () {
        panels[0].SetActive(true);
        for (int i = 1; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
    public void NextPanel()
    {
        panels[i].SetActive(false);
        panels[i + 1].SetActive(true);
        i++;
    }
               

}
