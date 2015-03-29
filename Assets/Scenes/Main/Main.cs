using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

  public void ChangeScene(string name) {
    Application.LoadLevel(name);
  }
  
	[SerializeField]
	Texture2D _mainBg;

	[SerializeField]
	Texture2D _craftButton;

	[SerializeField]
	Texture2D _battleButton;

	[SerializeField]
	Texture2D _practiceButton;
	
	[SerializeField]
	Texture2D _optionsButton;

	[SerializeField]
	Texture2D _exitButton;


	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), _mainBg);

		if (GUI.Button(new Rect(50, 250, 270, _craftButton.height), _craftButton))
		{
			Application.LoadLevel("Craft");
		}

		if (GUI.Button(new Rect(50, 250 + _battleButton.height + 10, 270, _battleButton.height), _battleButton))
		{
			Application.LoadLevel("Battle");
		}

		if (GUI.Button(new Rect(50, 250 + (2 * _practiceButton.height) + 20, 270, _practiceButton.height), _practiceButton))
		{
			//Application.LoadLevel("practice");
		}

		if (GUI.Button(new Rect(50, 250 + (3 * _optionsButton.height) + 30, 270, _optionsButton.height), _optionsButton))
		{
			//Application.LoadLevel("options");
		}

		if (GUI.Button(new Rect(50, 250 + (4 * _exitButton.height) + 40, 270, _exitButton.height), _exitButton))
		{
			Application.LoadLevel("Exit");
		}
	}
}
