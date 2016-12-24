using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int Max = 1000;
	int Min = 1;
	int guess = 500;
	
		// Use this for initialization
	void Start () {
		Max = Max + 1;

		print ("Welcome to Number Wizard");
	  	print ("Pick a number in your head");

		print ("The highest number you can pick is " + Max);
		print ("The lowest number you can pick is " + Min);

		print ("Is the number higher or lower than" + guess);
		print ("Up = higher, Down = lower, Enter = Equal");





	} 
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.UpArrow)){
			Min = guess;
			guess = (Min + Max)/2;
			print ("higher or lower than " + guess);
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			Max = guess;
			guess = (Min + Max)/2;
			print ("higher or lower than "+ guess);
		}else if(Input.GetKeyDown(KeyCode.Return)){
			print("I Won!");
		}
	  }
}