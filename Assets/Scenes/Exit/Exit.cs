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

	private float telaX;
	private float telaY;

	void OnGUI()
	{
		telaX = Screen.width/2;
		telaY = Screen.height/2;

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), _mainBg);

		//GUI.Box (new Rect (telaX/2, telaY/2, Screen.width/2, Screen.height/2), "");

		GUI.DrawTexture(new Rect (telaX/2, telaY/2, Screen.width/2, Screen.height/2), _exitBg);

		GUI.DrawTexture(new Rect (telaX - (Screen.width - 550)/2, telaY/2, Screen.width - 550, Screen.height - 650), _certeza);

		if (GUI.Button (new Rect (telaX - (3*_simButton.width)/2, telaY + _simButton.height, _simButton.width - 5, _simButton.height), _simButton))
		{
			Application.Quit();
		}

		if (GUI.Button (new Rect (telaX + _naoButton.width/2, telaY + _naoButton.height, _naoButton.width - 5, _naoButton.height), _naoButton))
		{
			Application.LoadLevel("Main");	
		}
	}
}
