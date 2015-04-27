using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[RequireComponent(typeof (HealthControl))]
public class MagicCollision : MonoBehaviour {

	public HealthControl healthc;
	void OnCollisionEnter(Collision col){
		Debug.Log (gameObject.ToString());
		print (gameObject.ToString());
		if(col.gameObject.tag =="Enemy"){
			healthc =  GameObject.FindGameObjectWithTag ("Enemy").GetComponent<HealthControl> ();

			healthc.damage((float)0.5f);
			//Image im = GetComponent<Image>();
			Destroy (gameObject.gameObject,0);
		}else if(col.gameObject.tag =="ECrystal"){
			string texto =  GameObject.FindGameObjectWithTag ("EPoints").GetComponent<Text>().text;
			float temp = float.Parse(texto)-(float)0.5f;
			GameObject.FindGameObjectWithTag ("EPoints").GetComponent<Text>().text=""+ temp;
			Destroy (gameObject.gameObject,0);
		}


	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}