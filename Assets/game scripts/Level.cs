using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class Level{
	//1 is the lowest, 4 is the highest
	public int state;
	private int states;
	public int startCoordx = 0;
	public int startCoordy = 0;


	List<ObSet> obsticales = new List<ObSet>();
	

	public Level (List<ObSet> newObsticales, int startX, int startY, int newStates){
		startCoordx = startX;
		startCoordy = startY;
		obsticales = newObsticales;
		states = newStates;
		state = newStates;
	}

	public List<Tuple> increase(){
		if( state < states){
			state++;
			obsticales [state - 1].draw ();
			Debug.Log ("increase to:" + state);
			return obsticales [state - 1].getMoveTos ();
		}
		return new List<Tuple>();
	}

	public List<Tuple> decrease(){
		if( state >= 1){
			obsticales [state - 1].hide ();
			state--;
			Debug.Log ("decrease to:" + state);
			return obsticales [state].getMoveTos ();
		}
		return new List<Tuple>();
	}
	public List<ObSet> getObSet(){
		return obsticales;
	}

}
