using UnityEngine;
using System.Collections;

public class CharacterSelection : MonoBehaviour {

	public PlayerCharacter[] playerCharacters;
	public int selectedCharacter =-1;
 	
	public void setSelectedCharacter(int pos){
		selectedCharacter = pos;
	}

	void OnGUI() {

	}
	//
	//Dar kill e fazer o spawn
	//Deixar o player escolher o time e matar ou nao?
	/*http://jhenrique.me/post/56843591844/tutorial-unity3d-character-selection
	 * http://www.paladinstudios.com/2013/07/10/how-to-create-an-online-multiplayer-game-with-unity/
5
You'll want to set up a class that contains information about both the prefab to spawn and any GUIContent associated with the character. The simplest example would be:

//JS
var selectionScreenProfile : GUIContent;
var characterToSpawn : GameObject;
Store a bunch of these in some collection (like an Array).

In your GUI, you'll need to keep track of which player has selected which player, which you can do by keeping an int for each player. So your GUI script may start out something like...

var characterProfiles : CharacterProfile[] //Presuming the script above is named CharacterProfile.js var numberOfPlayers : int = 1;

private var playerSelections : int[];

function Awake () { playerSelections = new int[numberOfPlayers]; }

I don't know how your character selection screen input is supposed to work, but you simply change the number associated with whichever player selected a character, ie, for player 1:

playerSelections[0] = 5
Assuming player 1 selected the fifth character in characterProfiles. In the GUI, you'd draw a box around (or in some other way distinguish) the profile when it's drawn. When you're ready to move on to the actual game stage, you'll need a record of whichever characters the player has selected. So let's add this to the top of the script:

public static var selectedPlayers : CharacterProfile[];
And change Awake to say

function Awake () {
    playerSelections = new int[numberOfPlayers];
    selectedPlayers = new CharacterProfile[numberOfPlayers];
}
And just before you load the fight scene, record those selections:

for (var i : int = 0; i < numberOfPlayers; i++)
{
    selectedPlayers[i] = characterProfiles[playerSelections[i]];
}
When the fightScene loads, have some script get the players and instantiate them (presuming your character selection scene GUI script is CharacterSelection.js:

function Start ()
{
    for (var i : int = 0; i < CharacterSelection.selectedPlayers.length ; i++)
    {
        GameObject.Instantiate (CharacterSelection.selectedPlayers[i], spawnPosition, spawnRotation);
        //Do any other setup associated with player creation.
    }
}
	 * 
	 * 
	 * 
	 * 
	 * 
	 * */
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public class PlayerCharacter
{
	public int playerID = -1;
	public string name = "Player";
	public bool selected = false;
}