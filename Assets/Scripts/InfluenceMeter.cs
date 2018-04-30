using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceMeter : MonoBehaviour {

    public int demoIndex;
    public int maxInfluence;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(((float)CultController.controller.demographics[demoIndex].influence) / ((float)maxInfluence));
        transform.localScale = Vector3.one * (((float)CultController.controller.demographics[demoIndex].influence)/((float)maxInfluence));
	}
}
