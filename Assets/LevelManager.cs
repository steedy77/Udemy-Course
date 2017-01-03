using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadlevel(string name){
		Application.LoadLevel(name);
	}

	public void QuitRequest () {
	}
}
