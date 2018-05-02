using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoctrineManager
{
    public Doctrine selected;
    private int influenceScalar;
    private Demographic[] chosenDemos;
    private List<Demographic> demoPool;
    private Text[] reviews;

    public DoctrineManager(Doctrine aSelected, Demographic[] demographics, Text[] aReviews)
    {
        selected = aSelected;
        reviews = aReviews;
        chosenDemos = new Demographic[4];
        demoPool = new List<Demographic>();
        for (int i = 0; i < demographics.Length; i++)
        {
            demoPool.Add(demographics[i]);
        }
    }

    public void createDoctrine()
    {
        CultController.controller.ShowReviewPanel();
        influenceScalar = Random.Range(50,70);
        chosenDemos[0] = demoPool[Random.Range(0, 7)];
        demoPool.Remove(chosenDemos[0]);
        chosenDemos[1] = demoPool[Random.Range(0, 6)];
        demoPool.Remove(chosenDemos[1]);
        chosenDemos[2] = demoPool[Random.Range(0, 5)];
        demoPool.Remove(chosenDemos[2]);
        chosenDemos[3] = demoPool[Random.Range(0, 4)];
        demoPool.Remove(chosenDemos[3]);

        for (int i = 0; i < chosenDemos.Length; i++)
        {
            int influenceChange = chosenDemos[i].love.points * 2 * influenceScalar + chosenDemos[i].like.points * influenceScalar - chosenDemos[i].dislike.points * influenceScalar;
            reviews[i].text = Reviews.GetReview(chosenDemos[i].name, influenceChange);
            chosenDemos[i].influence += influenceChange;
            if (chosenDemos[i].favoredDoctrine != null && chosenDemos[i].favoredDoctrine == selected)
            {
                CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.name).specialization += influenceChange / 50;
                CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.counterDoctrine).specialization -= influenceChange / 50;
            }
            CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.name).specialization += influenceScalar / 40;
            CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.counterDoctrine).specialization -= influenceScalar / 40;
        }
    }
}
