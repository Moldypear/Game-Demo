using UnityEngine;
using System.Collections;

public class AutoShoot : MonoBehaviour {

    /** Shoots based on a set shotInterval that compares against timePassed in the game. **/

    public Transform firepoint;
    public GameObject darts;
    private float timePassed = 0f;
    public int shotInterval = 4;

    void Update()
    {

        timePassed += Time.deltaTime;

        if (timePassed >= shotInterval)
        {
            Instantiate(darts, firepoint.position, firepoint.rotation);
            timePassed = 0;
        }

    }
}
