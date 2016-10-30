using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[System.Serializable]
public class Gamecontroller : MonoBehaviour {
	public int z0 = 0;
	public int y;
	public int x;
	public int blue = 0 ;
	public int green = 0 ;
	public int yellow = 0 ;
	public int score = 0;
	public int HighScore1 = 0;
	public int bonusTime;
	public GameObject other;
	public float timer;
	public Text guiTexT;
	public Text guiTextScore;
	public Text Highscore;
	public GameObject prefab;
	public GameObject prefabred;
	public GameObject prefabblue;
	public GameObject prefabgreen;
	public GameObject prefabyellow;
	public bool destroyBox = false;
	//public static Gamecontroller Instance;

	public GameObject Bonus;
	public GameObject bonusT;
	public GameObject  restart;
	// Use this for initialization
	void Start () {
		PlaceCubeblue();
		PlaceCubegreen();
	
        if (PlayerPrefs.HasKey("score"))
        { 
	    score = PlayerPrefs.GetInt("score");
            guiTextScore.text = score.ToString();
        }


        //HighScore = PlayerPrefs.GetInt("score");

        if (PlayerPrefs.HasKey ("HighScore")) {
			HighScore1= PlayerPrefs.GetInt("HighScore");
		}		

		Highscore.text = HighScore1.ToString();	

	}
	IEnumerator TestCoroutine(){
		yield return new WaitForSeconds(2);
		Application.LoadLevel(Application.loadedLevel);
		}

	void Update()
	{
		SaveScore ();

				//Debug.Log (other.blue);
				timer -= Time.deltaTime; // I need timer which from a particular time goes to zero
				guiTexT.text = timer.ToString ("00");
				
		if (timer <= 0) {
			guiTexT.text = timer.ToString ();
			score = 0;
			 PlayerPrefs.SetInt("score",score);
			TestCoroutine();
			Application.LoadLevel(Application.loadedLevel);
            
		}
			

				if (blue >= 3) {
						timer += bonusTime;
						blue = 0;
			GameObject blast;
			blast = Instantiate (bonusT, Bonus.transform.position, bonusT.transform.rotation)as GameObject;


				}
				if (green >= 1) {
						timer -= bonusTime;
						green = 0;
						//GameObject blast;
						//blast = Instantiate (bonusT, Bonus.transform.position, Bonus.transform.rotation)as GameObject;
			
				}
		
	
	if (yellow >= 1) {
		timer += bonusTime;
		yellow = 0;
		//GameObject blast;
		//blast = Instantiate (bonusT, Bonus.transform.position, Bonus.transform.rotation)as GameObject;
		
	}
		}

	
	public void SaveScore(){
		
		PlayerPrefs.SetInt ("score", score);
	}
	public void SaveHighScore(){

		if(score >= HighScore1)
		PlayerPrefs.SetInt ("HighScore", score);
        else
        {
            PlayerPrefs.SetInt("HighScore", HighScore1);
        } 
	}
	void Awake(){

			
		}

		

	public void Blue()
	{
		blue ++;
	}

	
	public void PlaceCubegreen()
	{
		for (int i = 0; i < 100; i++) {
						float roll = Random.Range (1, 4);
			//Debug.Log (roll);
						if (roll == 1) {
								Instantiate (prefabgreen, new Vector3 (0, 0, i * 5.0F), Quaternion.identity);
						}
						if (roll == 2) {	
								Instantiate (prefabgreen, new Vector3 (-2, 3, i * 5.0F), Quaternion.identity);
						}
						if (roll == 3) {
								Instantiate (prefabyellow, new Vector3 (2, 3, i * 5.0F), Quaternion.identity);
						}
				}
		}

		public void PlaceCubeblue()
		{
			for (int i = 0; i < 100; i++) {
						float roll2 = Random.Range (1, 4);
			//Debug.Log (roll2);
						if (roll2 == 1) {	
								Instantiate (prefabblue, new Vector3 (0, 0, i * 5.0F), Quaternion.identity);
						}
						if (roll2 == 2) {
								Instantiate (prefabblue, new Vector3 (2, 3, i * 5.0F), Quaternion.identity);
						}
						if (roll2 == 3) {
								Instantiate (prefabyellow, new Vector3 (0, 5.5f, i * 5.0F), Quaternion.identity);
						}
				}
			
		}
}


/*public void Rand()
{
float roll = Random.Range (1, 2);
		Debug.Log (roll);
				if (roll == 1) {
		
			PlaceCubeblue();
				
	}
				if (roll == 2) {

			PlaceCubegreen();

		}
}
}

public void Rand1()
	{
	float roll2 = Random.Range (1, 2);
		Debug.Log (roll2);
	if (roll2 == 1) {
			PlaceCubegreen();
					}
	if (roll2 == 2) {
						
		PlaceCubeblue();
					}

			
}
public void Rand2()
	{
				float roll3 = Random.Range (1, 2);
		Debug.Log (roll3);
				if (roll3 == 1) {
		PlaceCubegreen();
				
				}


				if (roll3 == 2) {
			PlaceCubeblue();
						}	             
}
		
public void Rand3(){
		float roll4 = Random.Range(1,2);
			Debug.Log (roll4);
	 if (roll4 == 1) {
		PlaceCubegreen();
					 }
	if (roll4 == 2) {
	    PlaceCubeblue();
			}
	  }
}




public void PlaceCubes()
	{
		for (int i = 0; i < 50; i++) {
			Instantiate (prefab, new Vector3 (0, 0, i * 5.0F), Quaternion.identity);
		
				}
	}

	public void PlaceCubegreen()
	{
		for (int j = 0; j < 50; j++) {
			Instantiate (prefabred, new Vector3 (0, 5.5f, j * 5.0F), Quaternion.identity);
			
		}
	}
}
	public void PlaceCubered()
	{
		for (int k = 0; k < 50; k++) {
			Instantiate (prefabblue, new Vector3 (2, 3, k * 5.0F), Quaternion.identity);
			
		}
	}

public void PlaceCubeblue()
	{
		for (int l = 0; l < 50; l++) {
			Instantiate (prefabgreen, new Vector3 (-2, 3, l * 5.0F), Quaternion.identity);
			




}*/