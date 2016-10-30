﻿using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
	public AudioClip clip;
	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint (clip, transform.position);
	}


		


	// Update is called once per frame
	void Awake () {
	DontDestroyOnLoad(this); 
	}
}
