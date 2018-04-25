using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctrine
{
	public string name;
	public int specialization;
	public Doctrine counterDoctrine;

    public Doctrine(string aName, int anSpecialization, Doctrine aCounterDoctrine){
		name = aName;
		specialization = anSpecialization;
		counterDoctrine = aCounterDoctrine;
	}
}