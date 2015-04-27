using UnityEngine;
using System.Collections;

public class Practice : MonoBehaviour {

	public bool enemyType;
	// Use this for initialization
	void Start () {

		Rigidbody enemy = (Rigidbody) Instantiate(GameObject.FindWithTag("MainCamera").GetComponent<CharacterSelectionMenu>().playerCharacters[1].body,new Vector3(1005f,1.0f,400f),transform.rotation) ;
		GameObject.FindGameObjectWithTag ("FPoints").SetActive (false);
		Destroy (enemy.GetComponent<UnityChanControlScriptWithRgidBody> ());
		Destroy (enemy.GetComponentInChildren<MagicSkills> ());
		enemy.tag = "Enemy";
		enemy.isKinematic = true;
		//enemy.transform.
		//enemy.
		//enemy.animation.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
