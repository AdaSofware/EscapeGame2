using UnityEngine;
using System.Collections;

public class destroyGreen : MonoBehaviour {
	
	public GameObject other;
	public float timer;
    public GameObject bonusA;
    public AudioClip clip;

    void Start()
	{

	}

	public void OnMouseDown(){
		GameObject copLights = GameObject.Find("GameController");
		Gamecontroller targetScript = copLights.GetComponent<Gamecontroller>();
		targetScript.green += 1;
		timer -= Time.deltaTime;
		ScoreG ();
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy (gameObject);

	
	}
	public void ScoreG(){
		GameObject copLights = GameObject.Find("GameController");
		Gamecontroller targetScript = copLights.GetComponent<Gamecontroller>();
		if (targetScript.destroyBox = true) {
			
			targetScript.score += 50;
			targetScript.guiTextScore.text = targetScript.score.ToString ();
            targetScript.SaveHighScore();
            targetScript.Highscore.text = targetScript.HighScore1.ToString();
            targetScript.destroyBox = false;
			GameObject blast;
			blast = Instantiate (bonusA, gameObject.transform.position, bonusA.transform.rotation)as GameObject;
		}
	}
}

