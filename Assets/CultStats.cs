using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultStats : MonoBehaviour {
	
	//List of Cult Stats

	//Shrine Level
	public int shrineLv;


	//Doctrines:
	public Dictionary<string, Doctrine> dictOfDoctrines;

	public string[] doctrineNames;
	public float[] doctrineInfluences;
	public string[] doctrineCounterDoctrines;
	public string[] doctrineFavoredDemo1;
	public string[] doctrineFavoredDemo2;

	//Qualities:
	public Dictionary<string, Quality> dictOfQualities;

	public string[] qualityNames;
	public float[] qualityInfluences;

	//Demographics:
	public Dictionary<string, Demographic> dictOfDemographics;

	public string[] demographicNames;
	public float[] demographicInfluences;
	public string[] demographicLoves;
	public string[] demographicLikes;
	public string[] demographicDislikes;
	public Demographic aDemographic;

	void Start () {

		//Creating the demographic dictionary

		dictOfDoctrines = new Dictionary<string, Doctrine> (3);

		string[] doct1demos = new string[2];
		string[] doct2demos = new string[2];
		string[] doct3demos = new string[2];

		doct1demos [0] = doctrineFavoredDemo1[0];
		doct1demos [1] = doctrineFavoredDemo2[0];
		doct2demos [0] = doctrineFavoredDemo1[1];
		doct2demos [1] = doctrineFavoredDemo2[1];
		doct3demos [0] = doctrineFavoredDemo1[2];
		doct3demos [1] = doctrineFavoredDemo2[2];

		Doctrine doct1 = new Doctrine (doctrineNames [0], doctrineInfluences [0], doctrineCounterDoctrines [0], doct1demos);
		Doctrine doct2 = new Doctrine (doctrineNames [1], doctrineInfluences [1], doctrineCounterDoctrines [1], doct2demos);
		Doctrine doct3 = new Doctrine (doctrineNames [2], doctrineInfluences [2], doctrineCounterDoctrines [2], doct3demos);

		dictOfDoctrines.Add (doctrineNames [0], doct1);
		dictOfDoctrines.Add (doctrineNames [1], doct2);
		dictOfDoctrines.Add (doctrineNames [2], doct3);

		//Creating the demographic dictionary

		dictOfQualities = new Dictionary<string, Quality> (7);

		Quality qual1 = new Quality (qualityNames [0], qualityInfluences [0]);
		Quality qual2 = new Quality (qualityNames [1], qualityInfluences [1]);
		Quality qual3 = new Quality (qualityNames [2], qualityInfluences [2]);
		Quality qual4 = new Quality (qualityNames [3], qualityInfluences [3]);
		Quality qual5 = new Quality (qualityNames [4], qualityInfluences [4]);
		Quality qual6 = new Quality (qualityNames [5], qualityInfluences [5]);
		Quality qual7 = new Quality (qualityNames [6], qualityInfluences [6]);

		dictOfQualities.Add (qualityNames [0], qual1);
		dictOfQualities.Add (qualityNames [1], qual2);
		dictOfQualities.Add (qualityNames [2], qual3);
		dictOfQualities.Add (qualityNames [3], qual4);
		dictOfQualities.Add (qualityNames [4], qual5);
		dictOfQualities.Add (qualityNames [5], qual6);
		dictOfQualities.Add (qualityNames [6], qual7);

		//Creating the demographic dictionary
		dictOfDemographics = new Dictionary<string, Demographic>(7);

		Demographic demo1 = new Demographic (demographicNames [0], demographicInfluences [0], demographicLoves [0], demographicLikes [0], demographicDislikes [0]);
		Demographic demo2 = new Demographic (demographicNames [1], demographicInfluences [1], demographicLoves [1], demographicLikes [1], demographicDislikes [1]);
		Demographic demo3 = new Demographic (demographicNames [2], demographicInfluences [2], demographicLoves [2], demographicLikes [2], demographicDislikes [2]);
		Demographic demo4 = new Demographic (demographicNames [3], demographicInfluences [3], demographicLoves [3], demographicLikes [3], demographicDislikes [3]);
		Demographic demo5 = new Demographic (demographicNames [4], demographicInfluences [4], demographicLoves [4], demographicLikes [4], demographicDislikes [4]);
		Demographic demo6 = new Demographic (demographicNames [5], demographicInfluences [5], demographicLoves [5], demographicLikes [5], demographicDislikes [5]);
		Demographic demo7 = new Demographic (demographicNames [6], demographicInfluences [6], demographicLoves [6], demographicLikes [6], demographicDislikes [6]);

		dictOfDemographics.Add (demographicNames [0], demo1);
		dictOfDemographics.Add (demographicNames [1], demo2);
		dictOfDemographics.Add (demographicNames [2], demo3);
		dictOfDemographics.Add (demographicNames [3], demo4);
		dictOfDemographics.Add (demographicNames [4], demo5);
		dictOfDemographics.Add (demographicNames [5], demo6);
		dictOfDemographics.Add (demographicNames [6], demo7);

		ShowStats ();

	}

	void ShowStats(){
		Debug.Log ("[DOCTRINES]" + "\n");
		foreach (var kvp in dictOfDoctrines) {
			Debug.Log (kvp.Key + ": " + kvp.Value.name + ", " + kvp.Value.influence + ", " + kvp.Value.counterDoctrine + ", " + kvp.Value.favoredDemographics[0] + ", " + kvp.Value.favoredDemographics[1] + "\n");
		}
		Debug.Log ("[QUALITIES]" + "\n");
		foreach (var kvp in dictOfQualities) {
			Debug.Log (kvp.Key + ": " + kvp.Value.name + ", " + kvp.Value.influence + "\n");
		}
		Debug.Log ("[DEMOGRAPHICS]" + "\n");
		foreach (var kvp in dictOfDemographics){
			Debug.Log (kvp.Key + ": " + kvp.Value.name + ", " + kvp.Value.influence + ", " + kvp.Value.love + ", " + kvp.Value.like + ", " + kvp.Value.dislike + "\n");
		}
	}

}
