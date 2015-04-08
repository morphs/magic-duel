using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MagicCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		Debug.Log (gameObject.ToString());
		print (gameObject.ToString());
		if(col.gameObject.tag =="Player"){
			HealthControl.damage((float)0.1f);
			//Image im = GetComponent<Image>();

		}

		Destroy (gameObject.gameObject,0);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}