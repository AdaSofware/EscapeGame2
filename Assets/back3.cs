using UnityEngine;
using System.Collections;

public class back3 : MonoBehaviour {
	public int move= 10;
	public float fl = 3.9f;
	public GameObject part1;
	public GameObject text1;
	public bool back1 = false;
	void Start () {
		Vector3 newPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public void OnMouseDown(){
								
		if (back1 == false) {
						back1 = true;
						
			part1.transform.Translate (fl = -1.16f,0.0f, 0.0f);
						GameObject blast;
						blast = Instantiate (text1, text1.transform.position, text1.transform.rotation)as GameObject;
				} else {
			part1.transform.Translate (fl = 1.16f, 0.0f, 0.0f);
			Destroy (GameObject.Find("text1(clone)"));

						back1 = false;

				}
	
				
		}
}