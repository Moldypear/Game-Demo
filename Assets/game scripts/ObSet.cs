using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

//a collection of obstacles that can be added / removed with ease
public class ObSet{
	public string name;
	public string moveTo1Name;
	public string moveTo2Name;
	public int moveTo1Level;
	public int moveTo2Level;
	List<Obstacle> obsticales = new List<Obstacle>();

	public ObSet (List<Obstacle> newObSet, string newMoveTo1, int oneLvl, string newMoveTo2, int twoLvl, string newName){
		name = newName;
		obsticales = newObSet;
		moveTo1Name = newMoveTo1;
		moveTo1Level = oneLvl;
		moveTo2Name = newMoveTo2;
		moveTo2Level = twoLvl;
	}

	//show full set
	public void draw(){
		foreach (Obstacle singleObstical in obsticales){
			singleObstical.draw ();
		}

	}

	//remove full set
	public void hide(){
		foreach (Obstacle singleObstical in obsticales){
			singleObstical.hide ();
		}
	}
	public void begHide(){
		foreach (Obstacle singleObstical in obsticales){
			singleObstical.begHide ();
		}
	}

	public string getName(){
		return name;
	}
	public List<Tuple> getMoveTos(){
		List<Tuple> ret = new List<Tuple>();
		var newTuple = new Tuple (moveTo1Level, moveTo1Name);
		ret.Add (newTuple);
		if (moveTo2Name != "") {
			newTuple = new Tuple (moveTo2Level, moveTo2Name);
			ret.Add (newTuple);
		}
		return ret;
	}
}

