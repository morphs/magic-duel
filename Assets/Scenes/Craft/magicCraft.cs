using UnityEngine;
using System.Collections;

public class magicCraft : MonoBehaviour {


	[SerializeField]
	GUISkin _guiSkin;

	[SerializeField]
	Texture2D _craftMenuBg;

	[SerializeField]
	Texture2D _scrollBg;


	[SerializeField]
	Texture2D _pointsLeft;

	string _magicName = "";

	[SerializeField]
	Texture2D[] mTypes;

	static int _selectedType = 0;

	static float _power = 1.0f;

	static float _size = 1.0f;

	static float _distance = 1.0f;

	static float _velocity = 1.0f;

	[SerializeField]
	Texture2D _ok;

	[SerializeField]
	float _maxPoints = 100.0f;
	
	float _currentPoints = 0.0f;

	[SerializeField]
	float _usedPoints = 0.0f;
	
	float power;
	float size;
	float distance;
	float velocity;

	GUIStyle gs;

	// Use this for initialization
	void Start () {
		_currentPoints = _maxPoints;

		power = _power;
		size = _size;
		distance = _distance;
		velocity = _velocity;

		gs = new GUIStyle ();
		gs.fontSize = 16;
		//load data
		_currentPoints = PlayerPrefs.GetFloat ("Points", 1.0f);
		_magicName = PlayerPrefs.GetString ("Magic Name", "");
		_selectedType = PlayerPrefs.GetInt ("Magic Type", 0);
		_power = PlayerPrefs.GetFloat ("Power", 1.0f);
		_size = PlayerPrefs.GetFloat ("Size", 1.0f);
		_distance = PlayerPrefs.GetFloat ("Distance", 1.0f);
		_velocity = PlayerPrefs.GetFloat ("Velocity", 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{
		GUI.skin = _guiSkin;
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _craftMenuBg);
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _scrollBg);
		GUI.DrawTexture (new Rect (Screen.width/8, Screen.height/18, Screen.width/9, _pointsLeft.height), _pointsLeft);

		//pontos restantes formato xx de max xx
		GUI.Label (new Rect (Screen.width/4, Screen.height/18, 100, 100), "<color=red><size=22>" + Mathf.Round(_currentPoints).ToString() + " / " + _maxPoints.ToString() + "</size></color>");


		//text field para o nome da magia
		_magicName = GUI.TextField(new Rect(Screen.width/7, Screen.height/7 + 10, Screen.width/5, 20), _magicName, 32);
		PlayerPrefs.SetString ("Magic Name", _magicName);


		//tipo de magica
		_selectedType = GUI.SelectionGrid (new Rect (Screen.width/7, 250, 170, 150), _selectedType, mTypes, 1, "CheckBoxStyle");
		PlayerPrefs.SetInt ("Magic Type", _selectedType);



		//horizontal slider para os atributos
		GUI.Label (new Rect (Screen.width / 2 + Screen.width / 7, Screen.height / 5 + 5, Screen.width / 4, 20), "Power",gs); 
		_power = GUI.HorizontalSlider(new Rect(Screen.width/2 + Screen.width/7, Screen.height/5 + 30 , Screen.width/4, 20), _power, 1.0f, 100.0f );
		PlayerPrefs.SetFloat ("Power", _power);

		GUI.Label (new Rect (Screen.width / 2 + Screen.width / 7, Screen.height / 5 + 85, Screen.width / 4, 20), "Size",gs); 
		_size = GUI.HorizontalSlider(new Rect(Screen.width/2 + Screen.width/7, Screen.height/5 + 110 ,Screen.width/4, 20), _size, 1.0f, 100.0f );
		PlayerPrefs.SetFloat ("Size", _size);

		GUI.Label (new Rect (Screen.width / 2 + Screen.width / 7, Screen.height / 5 + + 165, Screen.width / 4, 20), "Distance",gs); 
		_distance = GUI.HorizontalSlider(new Rect(Screen.width/2 + Screen.width/7, Screen.height/5 + 190 ,Screen.width/4, 20), _distance, 1.0f, 100.0f );
		PlayerPrefs.SetFloat ("Distance", _distance);

		GUI.Label (new Rect (Screen.width / 2 + Screen.width / 7, Screen.height / 5 + 245, Screen.width / 4, 20), "Velocity",gs); 
		_velocity = GUI.HorizontalSlider(new Rect(Screen.width/2 + Screen.width/7, Screen.height/5 + 270 ,Screen.width/4, 20), _velocity, 1.0f, 25.0f );
		PlayerPrefs.SetFloat ("Velocity", _velocity);


		//atualiza pontos restantes
		_usedPoints = power + size + distance + velocity;
		if (GUI.Button(new Rect(Screen.width - 30 - _ok.width - 10, Screen.height/5 + 290, _ok.width, _ok.height), _ok))
		{

			float soma = _power + _size + _distance + _velocity;
			if (_usedPoints != soma)
			{
				_currentPoints = _maxPoints - soma;
				_usedPoints = soma;
				power = _power;
				size = _size;
				distance = _distance;
				velocity = _velocity;

				PlayerPrefs.SetFloat("Points", _currentPoints);
			}
		}

		//botao de saida
		if (GUI.Button(new Rect(Screen.width - 30 - _ok.width - 10, Screen.height - 30 - _ok.height - 10, _ok.width, _ok.height), _ok))
		{
			Application.LoadLevel("Craft");
		}
	}
}
