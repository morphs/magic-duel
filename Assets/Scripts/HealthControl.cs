using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof (UnityChanControlScriptWithRgidBody))]
public class HealthControl : MonoBehaviour {

	public float health;
	public UnityChanControlScriptWithRgidBody script;
	private GameObject canvasBar ;
	private Object temp;
	private Image imBarHealth;
	public void setCanvasBar(Object go){
		this.temp = go;
		canvasBar = Instantiate (temp) as GameObject;
	}
	// Use this for initialization
	//----------------------------------------------setar o tipo de fill
	void Start () {
		health = 0;

		imBarHealth = GameObject.FindGameObjectWithTag ("Health").GetComponent<Image>();
//		imHealth = canvasBar.AddComponent("Image") as Image;
		//imMana = canvasBar.AddComponent("Image") as Image;
		//imBarHealth = canvasBar.AddComponent("Image") as Image;
		//imBarHealth.type = Image.Type.Filled;
		//imBarHealth.fillMethod = Image.FillMethod.Horizontal;
		//imBarHealth.transform.position = new Vector3 (255,289,293);
		//imBarHealth.fillOrigin = 
		//print (imBarHealth.tag);
		//imBarMana = canvasBar.AddComponent("Image") as Image;
		//imIcone = canvasBar.AddComponent("Image") as Image;


		//imBarHealth.renderer.enabled = true;
		//print(imBarHealth.IsActive);

	}

	void OnGUI(){
		//imBarHealth.sprite = Resources.Load ("/Imports/barra") as Sprite;
	}
	
	// Update is called once per frame
	void Update () {


		if (health != 0) {
			script =  GameObject.FindGameObjectWithTag ("Player").GetComponent<UnityChanControlScriptWithRgidBody> ();
			script.OnDamage (health);
			imBarHealth.fillAmount -= health;
		
			if (imBarHealth.fillAmount <= 0) {

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
