using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctrine
{
	public string name;
	public int specialization;
	public string counterDoctrine;

    public Doctrine(string aName, int anSpecialization, string aCounterDoctrine){
		name = aName;
		specialization = anSpecialization;
		counterDoctrine = aCounterDoctrine;
	}
}