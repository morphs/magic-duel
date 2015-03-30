using UnityEngine;
using System.Collections;

public class MagicCollision : MonoBehaviour {

	void onCollisionEnter(Collision col){
		Debug.Log (gameObject.ToString());
		Destroy (gameObject.gameObject,0); 
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
