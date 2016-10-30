using UnityEngine;
using System.Collections;

public class Mover1 : MonoBehaviour {

	public GameObject other;
	private Vector3 offset;
	public Vector3 TellCamNextLocation  = new Vector3(0, 0, 0);

	public int speed;
	void Update ()
	{

		transform.position += Vector3.forward * Time.deltaTime * speed;
	}
	/*void OnTriggerEnter(Collider other)
	{

		MoveCamera ();
	}
	void MoveCamera() 
	{
		// directly move the Main Camera
		Camera.mainCamera.transform.position = TellCamNextLocation;
	}
	*/
}