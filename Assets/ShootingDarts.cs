using UnityEngine;
using System.Collections;

public class ShootingDarts : MonoBehaviour {


    /** Created a basic projectile that destroys itself after a set amount of time has passed. Can be changed in Unity. **/
    public float speed = 10f;
    private float timePassed = 0f;
    public float removeInterval = 1f;
    public string fireDirection = "right";


	void Start () {
    }

	void Update () {

        if(timePassed >= removeInterval)
        {
            Destroy(gameObject);
        }
            timePassed += Time.deltaTime;
        if(fireDirection == "right") {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        if(fireDirection == "left")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }
        if(fireDirection == "up")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        if(fireDirection == "down")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
            
	}
}
