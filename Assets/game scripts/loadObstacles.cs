using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class loadObstacles : MonoBehaviour {
	/*Ice		1111
	 *Circus	2222 + 1
	 *Bank		3333 + 1  + 2
	 *Cave		4444 + 1  + 22 + 33
	 *Final			 + 11 + 22 + 333 + 444
	 */
	//Ice obstacles
	//Circus obstacles
	//Bank obstacles
	//Cave obstacles
	//Final obstacles

	//Ice obSets
		//1a
		//1b
		//1c
		//1d
	//Circus obSets
		//2a
		//2b
		//2c
		//2d
		//1bm
	//Bank obSets
		//3a
		//3b
		//3c
		//3d
		//1bm
		//2bm
	//Cave obSets
		//4a
		//4b
		//4c
		//4d
		//1am
		//2am
		//2cm
		//3am
		//3bm
	//Final obSets
		//1am
		//1cm
		//2am
		//2bm
		//3am
		//3bm
		//3cm
		//4am
		//4bm
		//4cm


	//Ice Level
	//Circus Level
	//Bank Level
	//Cave Level
	//Final Level


	//TESTING LEVEL

	Game theGame = new Game();
	public void buildSet(){
		//One obstacles
		Obstacle oneCube = new Obstacle("oneCube",0,0,0,GameObject.CreatePrimitive(PrimitiveType.Cube),false);
		Obstacle oneSphere = new Obstacle("oneSphere",0,2,0,GameObject.CreatePrimitive(PrimitiveType.Cube),false);
		Obstacle oneCylinder = new Obstacle("oneCylinder",0,4,0,GameObject.CreatePrimitive(PrimitiveType.Cube),false);
		//Two obstacles
		Obstacle twoCube = new Obstacle("twoCube",2,0,0,GameObject.CreatePrimitive(PrimitiveType.Cube),false);
		Obstacle twoSphere = new Obstacle("twoSphere",2,2,0,GameObject.CreatePrimitive(PrimitiveType.Cube),false);
		Obstacle twoCylinder = new Obstacle("twoCylinder",2,4,0,GameObject.CreatePrimitive(PrimitiveType.Cube),false);
		Obstacle oneMcube2 = new Obstacle("twoSphere",2,6,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);
		Obstacle oneMCylinder2 = new Obstacle("twoCylinder",2,8,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);


		Obstacle oneMCylinder3 = new Obstacle("twoCylinder",4,0,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);
		Obstacle oneMCylinder4 = new Obstacle("twoCylinder",4,2,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);
		Obstacle oneMCylinder5 = new Obstacle("twoCylinder",4,4,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);
		Obstacle oneMCylinder6 = new Obstacle("twoCylinder",4,6,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);
		Obstacle oneMCylinder7 = new Obstacle("twoCylinder",4,8,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);
		Obstacle oneMCylinder8 = new Obstacle("twoCylinder",4,10,0,GameObject.CreatePrimitive(PrimitiveType.Cube),true);

		//One obSets
		//1a
		List<Obstacle> a1 = new List<Obstacle>(new Obstacle[] {oneCube});
		ObSet oneA = new ObSet (a1, "1am", 3, "1am", 2, "1a");
		//1b
		List<Obstacle> b1 = new List<Obstacle>(new Obstacle[] {oneSphere});
		ObSet oneB = new ObSet (b1, "1bm", 3, "1bm", 2, "1b");
		//1c
		List<Obstacle> c1 = new List<Obstacle>(new Obstacle[] {oneCylinder});
		ObSet oneC = new ObSet (c1, "1cm", 3, "", 0, "1c");
		//Two obSets
		//2a
		List<Obstacle> a2 = new List<Obstacle>(new Obstacle[] {twoCube});
		ObSet twoA = new ObSet (a2, "2am", 3, "", 0, "2a");
		//2b
		List<Obstacle> b2 = new List<Obstacle>(new Obstacle[] {twoSphere});
		ObSet twoB = new ObSet (b2, "2bm", 3, "", 0, "2b");
		//2c
		List<Obstacle> c2 = new List<Obstacle>(new Obstacle[] {twoCylinder});
		ObSet twoC = new ObSet (c2, "2cm", 3, "", 0, "2c");
		//1am
		List<Obstacle> a1m = new List<Obstacle>(new Obstacle[] {oneMcube2});
		ObSet oneAm = new ObSet (a1m, "", 0, "", 0, "1am");
		//1bm
		List<Obstacle> b1m = new List<Obstacle>(new Obstacle[] {oneMCylinder2});
		ObSet oneBm = new ObSet (b1m, "", 0, "", 0, "1bm");

		//Three obSets
		//1am
		List<Obstacle> a1m2 = new List<Obstacle>(new Obstacle[] {oneMCylinder3});
		ObSet oneAm2 = new ObSet (a1m2, "", 0, "", 0, "1am");
		//1bm
		List<Obstacle> b1m2 = new List<Obstacle>(new Obstacle[] {oneMCylinder4});
		ObSet oneBm2 = new ObSet (b1m2, "", 0, "", 0, "1bm");
		//1cm
		List<Obstacle> c1m2 = new List<Obstacle>(new Obstacle[] {oneMCylinder5});
		ObSet oneCm2 = new ObSet (c1m2, "", 0, "", 0, "1cm");
		//2am
		List<Obstacle> a2m2 = new List<Obstacle>(new Obstacle[] {oneMCylinder6});
		ObSet twoAm2 = new ObSet (a2m2, "", 0, "", 0, "2am");
		//2bm
		List<Obstacle> b2m2 = new List<Obstacle>(new Obstacle[] {oneMCylinder7});
		ObSet twoBm2 = new ObSet (b2m2, "", 0, "", 0, "2bm");
		//2cm
		List<Obstacle> c2m2 = new List<Obstacle>(new Obstacle[] {oneMCylinder8});
		ObSet twoCm2 = new ObSet (c2m2, "", 0, "", 0, "2cm");

		//One Level
		List<ObSet> levelOneObSets = new List<ObSet>(new ObSet[] {oneA, oneB, oneC });
		Level levelOne = new Level(levelOneObSets,0,0,3);
		//Two Level
		List<ObSet> levelTwoObSets = new List<ObSet>(new ObSet[] {twoA, twoB, twoC, oneAm, oneBm });
		Level levelTwo = new Level (levelTwoObSets, 0, 0,3);
		//Three Level
		List<ObSet> levelThreeObSets = new List<ObSet>(new ObSet[] {oneAm2, oneBm2, oneCm2, twoAm2, twoBm2, twoCm2});
		Level levelThree = new Level (levelThreeObSets, 0, 0,0);

		theGame.addLevel (levelOne);
		theGame.addLevel (levelTwo);
		theGame.addLevel (levelThree);
	}
	void Start () {
		buildSet ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			Debug.Log ("d "); 
			theGame.hideBegin ();
		}

		if (Input.GetKeyDown (KeyCode.Q)) {
			theGame.pressDownButton ();
			//theGame.changeLevel (theGame.currentLevel + 1);
			//increase ();
			Debug.Log ("q "); 
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			theGame.pressUpButton ();
			//theGame.changeLevel (theGame.currentLevel - 1);
			//decrease ();
			Debug.Log ("w "); 
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			if (theGame.currentLevel + 1 <= 3){
				theGame.changeLevel (theGame.currentLevel + 1);
			}
			//increase ();
			Debug.Log ("a "); 
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			if (theGame.currentLevel - 1 >= 0) {
				theGame.changeLevel (theGame.currentLevel - 1);
			}
			//decrease ();
			Debug.Log ("s "); 
		}
	}
}
