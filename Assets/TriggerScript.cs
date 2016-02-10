using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

    public class TriggerScript : MonoBehaviour{


    public Transform firepoint;//Create an empty GameObject named firepoint and place it where the projectile should leave from. Place it in the Script while in the inspector.
    public GameObject darts; //Create whatever GameObject you want as a projectile and put it into the script here. Place it in the Script while in the inspector.
    private float timePassed = 0f;
    public int shotInterval = 4;

    void Start(){
        timePassed = shotInterval; //Added so that all triggers are active once the game starts.
    }

    void Update()
    {

        timePassed += Time.deltaTime;

    }


    
        private void OnTriggerEnter2D(Collider2D other)
        {
            if ((other.tag == "Player") && (timePassed >= shotInterval))
            {
            Instantiate(darts, firepoint.position, firepoint.rotation);// Lastly, change 'darts' to the same GameObject that you instantiated above.
            timePassed = 0;
            
        }
        }

    }