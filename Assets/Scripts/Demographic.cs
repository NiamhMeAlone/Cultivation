using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demographic
{
	public string name;
	public int influence;
    public Quality love, like, dislike;
    public Doctrine favoredDoctrine;

	public Demographic(string aName, int anInfluence, Quality aLove, Quality aLike, Quality aDislike, Doctrine aDoctrine){
		name = aName;
		influence = anInfluence;
		love = aLove;
		like = aLike;
		dislike = aDislike;
        favoredDoctrine = aDoctrine;
	}
}