using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[RequireComponent(typeof (HealthControl))]
public class MagicCollision : MonoBehaviour {

	public HealthControl healthc;
	void OnCollisionEnter(Collision col){
		Debug.Log (gameObject.ToString());
		print (gameObject.ToString());
		if(col.gameObject.tag =="Player"){
			healthc =  GameObject.FindGameObjectWithTag ("Player").GetComponent<HealthControl> ();

			healthc.damage((float)0.5f);
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