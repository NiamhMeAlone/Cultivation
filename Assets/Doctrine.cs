using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctrine
{
	public string name;
	public float influence;
	public string counterDoctrine;
	public string[] favoredDemographics;

	public Doctrine(string aName, float anInfluence, string aCounterDoctrine, string[] aFavoredDemographics){
		name = aName;
		influence = anInfluence;
		counterDoctrine = aCounterDoctrine;
		favoredDemographics = aFavoredDemographics;
	}
}