using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpecMeter : MonoBehaviour
{
    public int docIndex;
    public int maxSpec;
    public SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1, ((float)CultController.controller.doctrines[docIndex].specialization) / ((float)maxSpec), 1);
        transform.localPosition = new Vector3(0, -.5f + (transform.localScale.y/2), 0);
        if (CultController.controller.doctrines[docIndex].specialization > 80)
        {
            spriteRenderer.color = new Color(.4f, .9f, .4f);
        }
        else if (CultController.controller.doctrines[docIndex].specialization < 20)
        {
            spriteRenderer.color = new Color(.9f, .4f, .4f);
        }
        else
        {
            spriteRenderer.color = new Color(1f, 1f, 1f);
        }
        if ((float)CultController.controller.doctrines[docIndex].specialization >= 100)
        {
            SceneManager.LoadScene("High" + CultController.controller.doctrines[docIndex].name);
        }
        else if ((float)CultController.controller.doctrines[docIndex].specialization <= 0)
        {
            SceneManager.LoadScene("Low" + CultController.controller.doctrines[docIndex].name);
        }
    }
}