using UnityEngine;
using System.Collections;

public class SwingStartScript : MonoBehaviour {

    public float startupDelay = 0f;
    public float swingSpeed = 10f;

	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(startupDelay);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(swingSpeed, GetComponent<Rigidbody2D>().velocity.y));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
