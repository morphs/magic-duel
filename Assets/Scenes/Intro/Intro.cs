using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Intro : MonoBehaviour {
	public void ChangeScene(string name) {
		Application.LoadLevel(name);
	}

	[SerializeField]
	AudioClip _1;
	[SerializeField]
	AudioClip _2;
	[SerializeField]
	AudioClip _3;
	[SerializeField]
	AudioClip _4;
	[SerializeField]
	AudioClip _5;
	[SerializeField]
	AudioClip _6;

	private int count = 0;
	private float timeStamp = 0;

	void Update () {

		if (Input.GetButton ("Fire1")) {
			if (timeStamp <= Time.time) {
				switch (count) {
				case 0:
					audio.clip = _1;
					break;
				case 1:
					audio.clip = _2;
					break;
				case 2:
					audio.clip = _3;
					GameObject panel = GameObject.Find ("Panel1");
					panel.SetActive (false);
					break;
				case 3:
					audio.clip = _4;
					GameObject panel2 = GameObject.Find ("Panel2");
					panel2.SetActive (false);
					break;
				case 4:
					audio.clip = _5;
					GameObject panel3 = GameObject.Find ("Panel3");
					panel3.SetActive (false);
					break;
				case 5:
					audio.clip = _6;
					break;
				case 6:
					Application.LoadLevel ("Main");
					break;
				}
				count += 1;
				audio.Play ();
				timeStamp = Time.time + 2;
			}


		}
		if (Input.GetKeyDown ("escape")) {
			Application.LoadLevel ("Main");
		}
	}
}
