using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIController : MonoBehaviour {
    public GameObject houseButtonPanel;
    public GameObject doctrinePanel;
    public GameObject sinsPanel;



    void Start () {
        houseButtonPanel.SetActive(false);
        doctrinePanel.SetActive(false);
        sinsPanel.SetActive(false);
    }

    void FixedUpdate () {
       
    }

    public void ShowHousePanel()
    {
        houseButtonPanel.SetActive(true);
    }
    public void HideHousePanel()
    {
        houseButtonPanel.SetActive(false);
    }
    public void ShowDoctrinePanel()
    {
        doctrinePanel.SetActive(true);
    }
    public void HideDoctrinePanel()
    {
        doctrinePanel.SetActive(false);
    }
    public void ShowSinsPanel()
    {
        sinsPanel.SetActive(true);
    }
    public void HideSinsPanel()
    {
        sinsPanel.SetActive(false);
    }
    public void HideAllPanels()
    {
        houseButtonPanel.SetActive(false);
        sinsPanel.SetActive(false);
        doctrinePanel.SetActive(false);
    }



}
