using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demographic
{
	public string name;
	public float influence;
	public string love;
	public string like;
	public string dislike;

	public Demographic(string aName, float anInfluence, string aLove, string aLike, string aDislike){
		name = aName;
		influence = anInfluence;
		love = aLove;
		like = aLike;
		dislike = aDislike;
	}
}