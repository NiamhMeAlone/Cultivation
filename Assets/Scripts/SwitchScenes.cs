using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
        
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
        SceneManager.LoadScene("DetmarsonTestScene");
    }
    public void SelectCat()
    {
        CultController.controller.harbinger = "Cat'thulu";
        ToMain();
    }

    public void SelectSuzy()
    {
        CultController.controller.harbinger = "Little Suzy";
        ToMain();
    }

    public void SelectTop()
    {
        CultController.controller.harbinger = "The Great Big Top";
        ToMain();
    }

    public void SelectCherub()
    {
        CultController.controller.harbinger = "Beelzebaby";
        ToMain();
    }

    public void SelectHand()
    {
        CultController.controller.harbinger = "Big Hand";
        ToMain();
    }
    
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}