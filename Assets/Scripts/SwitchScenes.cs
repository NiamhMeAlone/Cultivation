using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour {
    public GameObject harbingerPanel;
   
	// Use this for initialization
	void Start () {
        harbingerPanel.SetActive(false);
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
    public void DisplayPanel()
    {
        harbingerPanel.SetActive(true);
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
