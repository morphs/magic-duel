using UnityEngine;
using System.Collections;

public class Exit: MonoBehaviour {

	[SerializeField]
	Texture2D _mainBg;
	
	[SerializeField]
	Texture2D _exitBg;

	[SerializeField]
	Texture2D _certeza;

	[SerializeField]
	Texture2D _simButton;

	[SerializeField]
	Texture2D _naoButton;

	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), _mainBg);

		GUI.Box (new Rect (200, 200, Screen.width - 400, Screen.height - 400), "");

		GUI.DrawTexture(new Rect (200, 200, Screen.width - 400, Screen.height - 400), _exitBg);

		GUI.DrawTexture(new Rect (275, 200, Screen.width - 550, Screen.height - 650), _certeza);

		if (GUI.Button (new Rect (370, 500, 120, _simButton.height), _simButton))
		{
			Application.Quit();
		}

		if (GUI.Button (new Rect (575, 500, 120, _naoButton.height), _naoButton))
		{
			Application.LoadLevel("Main");	
		}
	}
}
