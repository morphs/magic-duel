using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class CharacterSelectionMenu : MonoBehaviour {
	
	public Rect windowRect ;
	public Texture ri1;
	public Texture ri2;
	public Image im;
	public PlayerCharacter[] playerCharacters;
	public Rigidbody player1;
	public Rigidbody player2;
	private bool render = true;
	public GameObject playerrb;
	public Object GUIMenu;
	//the GUI scale ratio
	private float guiRatio;
	
	//the screen width
	private float sWidth;
	
	//A vector3 that will be created using the scale ratio
	private Vector3 GUIsF;
	
	//At initialization
	void Awake()
	{
		//get the screen's width
		sWidth = Screen.width;
		//calculate the scale ratio
		guiRatio = sWidth/1920;
		//create a scale Vector3 with the above ratio
		GUIsF = new Vector3(guiRatio,guiRatio,1);
	}

	void OnGUI(){
		if(render ){
			//scale and position the GUI element to draw it at the screen's top left corner
			GUI.matrix = Matrix4x4.TRS(new Vector3(GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);
			windowRect = GUI.ModalWindow(0, windowRect, DoMyWindow, "Choose your team");

		}
		
		
	}
	
	void DoMyWindow(int windowID){
		if(GUI.Button (new Rect(10,40,500,400),ri1)){
			playerCharacters[0]= new PlayerCharacter(1,"Player",true,player1);
			playerCharacters[1]= new PlayerCharacter(2,"Enemy",true,player2);
			Rigidbody t = (Rigidbody) Instantiate(playerCharacters[0].body,transform.position,transform.rotation) ;
			playerrb = t.gameObject;
			ThirdPersonCamera thirdpc = GameObject.FindGameObjectWithTag("MainCamera").AddComponent("ThirdPersonCamera") as ThirdPersonCamera;
			playerrb.AddComponent ("HealthControl");
			GameObject.FindGameObjectWithTag ("Player").GetComponent<HealthControl> ().setCanvasBar(GUIMenu);
			GameObject.FindGameObjectWithTag ("Player").GetComponent<UnityChanControlScriptWithRgidBody> ().setTaichiScript(true);
			thirdpc.smooth = 33f;
			render = false;
			//Setando o pilar amigo e inimigo
			if(GameObject.FindGameObjectWithTag("Pillar1") != null){
				GameObject.FindGameObjectWithTag("Pillar1").tag = "FCrystal";
				GameObject.FindGameObjectWithTag("Pillar2").tag = "ECrystal" ;
			}else{
				playerrb.AddComponent ("Practice");
			}

		}
		if(GUI.Button (new Rect(560,40,500,400),ri2)){
			playerCharacters[0]= new PlayerCharacter(1,"Player",true,player2);
			playerCharacters[1]= new PlayerCharacter(2,"Enemy",true,player1);
			Rigidbody t = (Rigidbody) Instantiate(playerCharacters[0].body,transform.position,transform.rotation) ;
			playerrb = t.gameObject;
			ThirdPersonCamera thirdpc = GameObject.FindGameObjectWithTag("MainCamera").AddComponent("ThirdPersonCamera") as ThirdPersonCamera;
			playerrb.AddComponent ("HealthControl");
			GameObject.FindGameObjectWithTag ("Player").GetComponent<HealthControl> ().setCanvasBar(GUIMenu);
			//player2.a
			thirdpc.smooth = 33f;
			render = false;
			//Setando o pilar amigo e inimigo
			if(GameObject.FindGameObjectWithTag("Pillar1") != null){
				GameObject.FindGameObjectWithTag("Pillar1").tag = "FCrystal";
				GameObject.FindGameObjectWithTag("Pillar2").tag = "ECrystal" ;
			}else{
				playerrb.AddComponent ("Practice");
			}
		}
	}
	// Use this for initialization
	void Start () {
		//scale and position the GUI element to draw it at the screen's top left corner
		GUI.matrix = Matrix4x4.TRS(new Vector3(GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);
		windowRect = new Rect(400,200,1100,500);
		playerCharacters = new PlayerCharacter[20];

		//player
	}
	
	// Update is called once per frame
	void Update () {
		Screen.showCursor = true;
	}
}

public class PlayerCharacter
{
	public int playerID = -1;
	public string name = "Player";
	public bool selected = false;
	public Rigidbody body;
	public PlayerCharacter(int id, string nam, bool sel, Rigidbody rb){
		playerID = id;
		name = nam;
		selected = sel;
		body = rb;
	}
}
