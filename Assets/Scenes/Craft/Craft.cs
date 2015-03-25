using UnityEngine;
using System.Collections;

public class Craft : MonoBehaviour {

	[SerializeField]
	Texture2D _craftMenuBg;

	[SerializeField]
	Texture2D _craftSubTitle;

	[SerializeField]
	Texture2D _create;

	[SerializeField]
	Texture2D _edit;

	[SerializeField]
	Texture2D _delete;

	[SerializeField]
	Texture2D _ok;


	void OnGUI()
	{

		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _craftMenuBg);

		GUI.DrawTexture(new Rect(Screen.width - _craftSubTitle.width -20, 20, _craftSubTitle.width, _craftSubTitle.height), _craftSubTitle);

		if (GUI.Button(new Rect(Screen.width - 50 - _create.width - 10, 150, _create.width, _create.height), _create))
		{

		}

		if (GUI.Button(new Rect(Screen.width - 50 - _edit.width - 10, 150 + _edit.height + 20, _edit.width, _edit.height), _edit))
		{
			
		}

		if (GUI.Button(new Rect(Screen.width - 50 - _delete.width - 10, 150 + (2* _delete.height) + 20 + 20, _delete.width, _delete.height), _delete))
		{
			
		}

		if (GUI.Button(new Rect(Screen.width - 30 - _ok.width - 10, Screen.height - 30 - _ok.height - 10, _ok.width, _ok.height), _ok))
		{
			Application.LoadLevel("Main");
		}
	}
}
