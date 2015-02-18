using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

  public void ChangeScene(string name) {
    Application.LoadLevel(name);
  }

  // Use this for initialization
  void Start() {
  }

  // Update is called once per frame
  void Update() {
  }
}
