using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class Obstacle{
	public string name;
	public int xCoord;
	public int yCoord;
	public int zCoord;
	public GameObject physicalObject;
	public bool drawn = true;
	public bool begDraw; 
	public Obstacle (string newName, int newX, int newY, int newZ, GameObject obj, bool hidee){
		name = newName;
		xCoord = newX;
		yCoord = newY;
		zCoord = newZ;
		physicalObject = obj;
		physicalObject.transform.position = new Vector3(xCoord, yCoord, zCoord);
		begDraw = !hidee;
		drawn = !hidee;
	}
	public void draw(){
		physicalObject.GetComponent<Renderer> ().enabled = true;
	}
	public void hide(){
		physicalObject.GetComponent<Renderer> ().enabled = false;
	}
	public void begHide(){
		physicalObject.GetComponent<Renderer> ().enabled = begDraw;
	}
}

