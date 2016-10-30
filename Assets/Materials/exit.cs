using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {
	public GameObject anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		anim.transform.position = new Vector3(0.0f,   3.3f, -7f);
		}

}
