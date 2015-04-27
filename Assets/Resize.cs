using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Resize : MonoBehaviour {
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
		//scale and position the GUI element to draw it at the screen's top left corner
		GUI.matrix = Matrix4x4.TRS(new Vector3(GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
