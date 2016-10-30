using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public int blue = 0;
	public GameObject other;
	public int bonustime;
	public GameObject bonusS;
    public AudioClip clip;

    void Start()
	{

	}

	public void OnMouseDown(){
		GameObject copLights = GameObject.Find("GameController");
		Gamecontroller targetScript = copLights.GetComponent<Gamecontroller>();
		targetScript.blue += 1;
		targetScript.timer += bonustime;
		targetScript.destroyBox  = true;
		Score ();
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy (gameObject);

	}
	public void Score(){
		GameObject copLights = GameObject.Find("GameController");
		Gamecontroller targetScript = copLights.GetComponent<Gamecontroller>();
		if (targetScript.destroyBox = true) {

			targetScript.score += 20;
			targetScript.guiTextScore.text = targetScript.score.ToString ();
			targetScript.destroyBox = false;
			GameObject blast;
			blast = Instantiate (bonusS, gameObject.transform.position, bonusS.transform.rotation)as GameObject;
				}
		}
}

