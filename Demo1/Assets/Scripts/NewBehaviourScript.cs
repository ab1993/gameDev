using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

     // we use the underscore before variable to diff that, this var is a private var
	private int _pylaerSpeed=5;
	// create a game object of laser
	[SerializeField]
	private GameObject laserPreFab;

	// Use this for initialization
	void Start () {

		// you need to take a component and just call the methods on that component
		transform.position = new Vector3 (0,0,0);
		//transform.rotation= new Vector3 (1,0,0);
		
	}
	
	// Update is called once 60 per frame/sec
	void Update () {
		
		calculateMovement();

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(laserPreFab, transform.position + new Vector3(0,0.8f,0),Quaternion.identity);
		}
	}
	
	void calculateMovement()
	{
     // this is the 
		float horizontalInput=Input.GetAxis("Horizontal");
		float verticalInput=Input.GetAxis("Vertical");

		//transform.Translate(Vector3.forward * Time.deltaTime);
		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		transform.Translate(Vector3.right * horizontalInput * _pylaerSpeed * Time.deltaTime);
		transform.Translate(Vector3.up * verticalInput * _pylaerSpeed * Time.deltaTime);
		
		//transform.Translate(new Vector3(0,1,0));

       if(transform.position.y>3)
	   {
		   transform.position= new Vector3(0,0,0);
	   }
	   else if(transform.position.y<=-3)
	   {
		   transform.position = new Vector3(0,0,0);
	   }

	   if(transform.position.x<=-7)
	   {
		   transform.position= new Vector3(0,0,0);
	   }
	   else if(transform.position.x>=7)
	   {
		   transform.position= new Vector3(0,0,0);
	   }
	} 
}
