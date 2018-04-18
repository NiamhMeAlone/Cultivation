using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultController : MonoBehaviour {

    public GameObject houseButtonPanel;

	void Start () {
        houseButtonPanel.SetActive(false);
	}
	
	void Update () {
		
	}

    public void ShowHousePanel()
    {
        houseButtonPanel.SetActive(true);
    }

    public void HideAllPanels()
    {
        houseButtonPanel.SetActive(false);
    }
}
