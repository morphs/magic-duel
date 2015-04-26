using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof (UnityChanControlScriptWithRgidBody))]
public class HealthControl : MonoBehaviour {

	public static float health = 0;
	public UnityChanControlScriptWithRgidBody script;
	private Image im;
	// Use this for initialization
	void Start () {
	 im = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (health != 0) {
			script =  GameObject.FindGameObjectWithTag ("Player").GetComponent<UnityChanControlScriptWithRgidBody> ();
			script.OnDamage (health);
			im.fillAmount -= health;
		
			if (im.fillAmount <= 0) {
				Debug.Log ("Death");
				//
				//Vector3 last_Position = GameObject.FindWithTag("Player").transform.position;
				Vector3 last_Position = new Vector3 ((float)-22.995, (float)6.348, (float)(-45.62));
			} else {
				health = 0;
			}
		}
	}
	public float GetHealth(){
		return health;
	}

	public void damage(float h){
		health = h;

	}
}
