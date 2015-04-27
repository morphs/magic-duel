﻿using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class Magic4Control : MonoBehaviour {
	public string magicname;
	public string magictype;
	public float power;
	public float size;
	public float distance;
	public float velocity;
	
	public static Magic4Control control;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Awake(){
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}
	}
	public void Save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/magic4Info.dat");
		MagicData mdata = new MagicData ();
		mdata.power = power;
		mdata.distance = distance;
		mdata.size = size;
		mdata.velocity = velocity;
		mdata.magicname = magicname;
		mdata.magictype = magictype;
		bf.Serialize (file, mdata);
		file.Close ();
	}
	
	public void Load(){
		if(File.Exists(Application.persistentDataPath + "/magic4Info.dat")){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open (Application.persistentDataPath + "/magic4Info.dat", FileMode.Open);
			MagicData mdata = (MagicData) bf.Deserialize(file);
			file.Close();
			power = mdata.power;
			distance = mdata.distance;
			size = mdata.size;
			velocity = mdata.velocity;
			magicname = mdata.magicname;
			magictype = mdata.magictype;
		}
	}
}