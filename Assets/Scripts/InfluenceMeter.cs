using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfluenceMeter : MonoBehaviour {

    public int demoIndex;
    public int maxInfluence;
    private bool locked = false;
	public Text hoverOverLabel;
	public Text hoverOverInfluence;

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
            else if (Mathf.Floor((((float)CultController.controller.demographics[demoIndex].influence) / ((float)maxInfluence)) * 100f) >= 100f)
            {
                locked = true;
            }
        }
		//transform.localScale = Vector3.one - (Vector3.one * (((float)CultController.controller.demographics[demoIndex].influence)/((float)maxInfluence)));
		GetComponent<Image> ().fillAmount = 1f - (((float)CultController.controller.demographics[demoIndex].influence)/((float)maxInfluence));
		if (hoverOverInfluence != null) {
			hoverOverInfluence.text = Mathf.Floor ((((float)CultController.controller.demographics [demoIndex].influence) / ((float)maxInfluence)) * 100f).ToString () + "%";
		}
	}
    
    public bool GetLocked()
    {
        return locked;
    }
	void OnMouseEnter(){
		hoverOverLabel.color = Color.white;
		hoverOverInfluence.color = Color.white;
	}
	void OnMouseExit(){
		hoverOverLabel.color = new Color32 (0, 0, 0, 0);
		hoverOverInfluence.color = new Color32 (0, 0, 0, 0);
	}
}
