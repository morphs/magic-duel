using UnityEngine;
using System.Collections;

public class MagicSkills : MonoBehaviour {

	public Rigidbody magic1;
	public Rigidbody magic2;
	public Rigidbody magic3;
	public Rigidbody magic4;
	int speed = 20;
	float cd1 = 5;
	float cd2 = 5;
	float cd3 = 5;
	float cd4 = 5;

	float timeStamp1 = 0;
	float timeStamp2 = 0;
	float timeStamp3 = 0;
	float timeStamp4 = 0;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		//Se for a magia 1 
		if (Input.GetButton("Slot1")){

			if(timeStamp1 <=Time.time){
				Rigidbody clone = (Rigidbody) Instantiate(magic1,transform.position,transform.rotation);
				clone.AddForce(new Vector3(0,0,speed));
				Destroy(clone.gameObject,3);
			 	timeStamp1 = Time.time + cd1;

			}

		}
		//Se for a magia 2
		if (Input.GetButton("Slot2")){
			if(timeStamp2 <=Time.time){
				Rigidbody clone = (Rigidbody) Instantiate(magic2,transform.position,transform.rotation);
				clone.AddForce(new Vector3(0,0,speed));
				Destroy(clone.gameObject,3);
				timeStamp2 = Time.time + cd1;
				
			}
		}
		//Se for a magia 3
		if (Input.GetButton("Slot3")){
			if(timeStamp3 <=Time.time){
				Rigidbody clone = (Rigidbody) Instantiate(magic3,transform.position,transform.rotation);
				clone.velocity = transform.TransformDirection(new Vector3(0,0,speed));
				Destroy(clone.gameObject,3);
				timeStamp3 = Time.time + cd1;
				
			}
		}
		//Se for a magia 4
		if (Input.GetButton("Slot4")){
			if(timeStamp4 <=Time.time){
				Rigidbody clone = (Rigidbody) Instantiate(magic4,transform.position,transform.rotation);
				clone.AddForce(new Vector3(0,0,speed));
				Destroy(clone.gameObject,3);
				timeStamp4 = Time.time + cd1;
				
			}
		}

	}
}
