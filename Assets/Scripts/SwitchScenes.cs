using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour {
    public GameObject harbingerPanel;
    public GameObject tutorialPanel;
   
	// Use this for initialization
	void Start () {
        if (harbingerPanel != null)
        {
            harbingerPanel.SetActive(false);
        }
        if (tutorialPanel != null)
        {
            tutorialPanel.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ToMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void DisplayHarbingerPanel()
    {
        tutorialPanel.SetActive(false);
        harbingerPanel.SetActive(true);
    }
    public void DisplayTutorialPanel()
    {
        tutorialPanel.SetActive(true);
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
