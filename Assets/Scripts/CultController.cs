using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CultController : MonoBehaviour {

    public GameObject houseButtonPanel, doctrinePanel, sinsPanel, reviewPanel;
    public Quality pride, wrath, gluttony, sloth, lust, envy, greed;
    public Demographic[] demographics;
    public Doctrine[] doctrines;
    public Text[] reviews;
    public InfluenceMeter[] meters;
    public static CultController controller;
    public static DoctrineManager doctrineManager;
    

    void Start()
    {
        houseButtonPanel.SetActive(false);
        doctrinePanel.SetActive(false);
        sinsPanel.SetActive(false);
        reviewPanel.SetActive(false);
        doctrines = new Doctrine[3];
        doctrines[0] = new Doctrine("Commandment", 50, "Revelation");
        doctrines[1] = new Doctrine("Premonition", 50, "Commandment");
        doctrines[2] = new Doctrine("Revelation", 50, "Premonition");
        demographics = new Demographic[7];
        demographics[0] = new Demographic("Farmers", 0, gluttony, greed, wrath, null);
        demographics[1] = new Demographic("Teens", 0, lust, sloth, pride, doctrines[0]);
        demographics[2] = new Demographic("Parents", 0, envy, wrath, sloth, doctrines[2]);
        demographics[3] = new Demographic("Elders", 0, pride, gluttony, lust, doctrines[1]);
        demographics[4] = new Demographic("Brewers", 0, sloth, envy, greed, doctrines[0]);
        demographics[5] = new Demographic("Politicians", 0, greed, pride, gluttony, doctrines[2]);
        demographics[6] = new Demographic("Preppers", 0, wrath, lust, envy, doctrines[1]);
        doctrineManager = new DoctrineManager(doctrines[0], demographics, reviews);
        controller = this;
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (Demographic d in controller.demographics)
            {
                print(d.name + ": " + d.influence);
            }
            foreach (Doctrine d in controller.doctrines)
            {
                print(d.name + ": " + d.specialization);
            }
        }
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

    public void ShowReviewPanel()
    {
        reviewPanel.SetActive(true);
    }

    public void HideReviewPanel()
    {
        reviewPanel.SetActive(false);
    }

    public void HideAllPanels()
    {
        houseButtonPanel.SetActive(false);
        sinsPanel.SetActive(false);
        doctrinePanel.SetActive(false);
        reviewPanel.SetActive(false);
    }

    public void SelectProphecy()
    {
        doctrineManager = new DoctrineManager(doctrines[0], demographics, reviews);
        ResetSins();
        ShowSinsPanel();
        HideDoctrinePanel();
    }

    public void SelectPremonition()
    {
        doctrineManager = new DoctrineManager(doctrines[1], demographics, reviews);
        ResetSins();
        ShowSinsPanel();
        HideDoctrinePanel();
    }

    public void SelectCommandment()
    {
        doctrineManager = new DoctrineManager(doctrines[2], demographics, reviews);
        ResetSins();
        ShowSinsPanel();
        HideDoctrinePanel();
    }

    public void EnterDoctrine()
    {
        doctrineManager.createDoctrine();
        HideSinsPanel();
        CheckWin();
    }

    public void CheckWin()
    {
        bool won = true;
        foreach (InfluenceMeter i in meters)
        {
            if (!i.GetLocked())
            {
                won = false;
            }
        }
        if (won)
        {
            SceneManager.LoadScene("YouWin");
        }
    }

    public void ResetSins()
    {
        pride.ResetPoints();
        wrath.ResetPoints();
        gluttony.ResetPoints();
        sloth.ResetPoints();
        lust.ResetPoints();
        envy.ResetPoints();
        greed.ResetPoints();
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
    /*
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
    */
}
