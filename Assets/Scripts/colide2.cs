using UnityEngine;
using System.Collections;

public class colide2 : MonoBehaviour {


	void OnTriggerEnter(Collider other)
	{
		
		GameObject thePlayer = GameObject.Find("GameController");
		Gamecontroller playerScript = thePlayer.GetComponent<Gamecontroller>();
		

			if(PlayerPrefs.GetInt("HighScore") < playerScript.score)
			{
				playerScript.SaveHighScore ();
			PlayerPrefs.SetInt("HighScore",playerScript.score);
		
		}else{
			PlayerPrefs.SetInt("HighScore",playerScript.score);
			playerScript.SaveHighScore ();
		}
		

		playerScript.SaveScore ();
		Application.LoadLevel("EMIT03");


	}

}

