using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctrineManager
{
    public Doctrine selected;
    private int influenceScalar;
    private Demographic[] chosenDemos;
    private List<Demographic> demoPool;

    public DoctrineManager(Doctrine aSelected, Demographic[] demographics)
    {
        selected = aSelected;
        chosenDemos = new Demographic[4];
        demoPool = new List<Demographic>();
        for (int i = 0; i < demographics.Length; i++)
        {
            demoPool.Add(demographics[i]);
        }
    }

    public void createDoctrine()
    {
        influenceScalar = Random.Range(50,70);
        chosenDemos[0] = demoPool[Random.Range(0, 6)];
        demoPool.Remove(chosenDemos[0]);
        chosenDemos[1] = demoPool[Random.Range(0, 5)];
        demoPool.Remove(chosenDemos[1]);
        chosenDemos[2] = demoPool[Random.Range(0, 4)];
        demoPool.Remove(chosenDemos[2]);
        chosenDemos[3] = demoPool[Random.Range(0, 3)];
        demoPool.Remove(chosenDemos[3]);

        foreach(Demographic d in chosenDemos)
        {
            int influenceChange = d.love.points * 2 * influenceScalar + d.like.points * influenceScalar - d.dislike.points * influenceScalar;
            d.influence += influenceChange;
            if (d.influence < 0)
            {
                d.influence = 0;
            }
            if (d.favoredDoctrine != null && d.favoredDoctrine == selected)
            {
                CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.name).specialization += influenceChange / 60;
                CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.counterDoctrine).specialization -= influenceChange / 60;
            }
            CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.name).specialization += influenceScalar / 40;
            CultController.controller.DoctrineLookup(CultController.controller.doctrines, selected.counterDoctrine).specialization -= influenceScalar / 40;
        }
    }
}
