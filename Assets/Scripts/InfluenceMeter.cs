using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceMeter : MonoBehaviour {

    public int demoIndex;
    public int maxInfluence;
    private bool locked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (locked)
        {
            CultController.controller.demographics[demoIndex].influence = maxInfluence;
        }
        else
        {
            if (CultController.controller.demographics[demoIndex].influence < 0)
            {
                CultController.controller.demographics[demoIndex].influence = 0;
            }
            else if (CultController.controller.demographics[demoIndex].influence >= maxInfluence)
            {
                locked = true;
            }
        }
        transform.localScale = Vector3.one * (((float)CultController.controller.demographics[demoIndex].influence)/((float)maxInfluence));
	}
    
    public bool GetLocked()
    {
        return locked;
    }
}
