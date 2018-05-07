using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {
    public GameObject[] panels = new GameObject[3];
    public GameObject harbingerPanel;
    public GameObject tutorialPanel;
    int i = 0;
	// Use this for initialization
	void Start () {
        if (harbingerPanel != null)
        {
            harbingerPanel.SetActive(false);
        }
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
        tutorialPanel.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowTutorial()
    {
        tutorialPanel.SetActive(true);
        panels[i].SetActive(true);
    }

    public void DisplayHarbingerPanel()
    {
        tutorialPanel.SetActive(false);
        harbingerPanel.SetActive(true);
    }

    public void NextPanel()
    {
        if (i >= 2)
        {
            DisplayHarbingerPanel();
        }
        else
        {
            i++;
            panels[i].SetActive(true);
        }
    }
}
