using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class Game{
	//0 is home 1-5 is its coresponding level
	public int currentLevel;
	public List<Level> levels = new List<Level>();

	public Game (){
		currentLevel = 1;
	}

	public void addLevel(Level newLevel){
		levels.Add (newLevel);
		List<ObSet> listOfObsticals = newLevel.getObSet ();
		foreach(ObSet theObSet in listOfObsticals){
			theObSet.draw ();
		}

	}

	//entering a floor
	public void changeLevel(int newLevel){
		currentLevel = newLevel;
		Debug.Log ("new level: "+ currentLevel);
	}

	//going to the Menu room
	public void goHome(int newLevel){
		currentLevel = 0;
	}

	public void hideBegin(){
		foreach (Level theLevel in levels) {
			foreach (ObSet set in theLevel.getObSet()) {
				set.begHide ();
			}
		}
	}

	public void pressUpButton(){
		List<Tuple> obSetsToDecrease = levels [currentLevel - 1].increase ();
		foreach (Tuple tup in obSetsToDecrease) {
			var obsetToSearch = levels [tup.fst()-1].getObSet ();
			//Check to see if it is the one to turn on
			foreach (ObSet set in obsetToSearch) {
				if (set.getName() == tup.snd()){
					set.hide ();
					break;
				}
			}
		}
	}

	public void pressDownButton(){
		List<Tuple> obSetsToIncrease = levels [currentLevel - 1].decrease ();
		foreach (Tuple tup in obSetsToIncrease) {
			var obsetToSearch = levels [tup.fst()-1].getObSet ();
			//Check to see if it is the one to turn on
			foreach (ObSet set in obsetToSearch) {
				if (set.getName() == tup.snd()){
					set.draw ();
					break;
				}
			}
		}
	}

}


