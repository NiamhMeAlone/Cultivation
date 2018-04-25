using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultController : MonoBehaviour {

    public GameObject houseButtonPanel, doctrinePanel, sinsPanel;
    public Quality pride, wrath, gluttony, sloth, lust, envy, greed;
    public Demographic farmers, teens, parents, elders, brewers, politicians, doomsayers;
    public Doctrine prophecy, premonition, commandment;
    

    void Start()
    {
        houseButtonPanel.SetActive(false);
        doctrinePanel.SetActive(false);
        sinsPanel.SetActive(false);
        prophecy = new Doctrine("prophecy", 50, premonition);
        premonition = new Doctrine("premonition", 50, commandment);
        commandment = new Doctrine("commandment", 50, prophecy);
        farmers = new Demographic("farmers", 0, gluttony, greed, wrath, null);
        teens = new Demographic("teens", 0, lust, sloth, pride, prophecy);
        parents = new Demographic("parents", 0, envy, wrath, sloth, commandment);
        elders = new Demographic("elders", 0, pride, gluttony, lust, premonition);
        brewers = new Demographic("brewers", 0, sloth, envy, greed, prophecy);
        politicians = new Demographic("politicians", 0, greed, pride, gluttony, commandment);
        doomsayers = new Demographic("doomsayers", 0, wrath, lust, envy, premonition);
    }

    void Update ()
    {
		
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

    public Quality QualityLookup(Quality[] list, string name)
    {
        for (int i = 0;  i < list.Length; i++)
        {
            if (list[i].name.Equals(name))
            {
                return list[i];
            }
        }
        return null;
    }
    public Demographic DemoLookup(Demographic[] list, string name)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].name.Equals(name))
            {
                return list[i];
            }
        }
        return null;
    }

    public Doctrine DoctrineLookup(Doctrine[] list, string name)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].name.Equals(name))
            {
                return list[i];
            }
        }
        return null;
    }
}
