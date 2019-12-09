using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour {
     [SerializeField]
	private float _laserSpeed=30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// speed up the laser beam
		transform.Translate(Vector3.up *_laserSpeed * Time.deltaTime);

		// destory the game object
		if(transform.position.y>8)
		{
			Destroy(this.gameObject);
		}

		
	}
}
