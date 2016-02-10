using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
    //attatch script to object with trigger
    public class OtherGameObjectInteractionScript : MonoBehaviour
    {
        //interactswith is the GameObject that is affected by trigger
        public GameObject interactwith;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                //do things to interactswith
                interactwith.GetComponent<Rigidbody2D>().isKinematic = false;
               
            }
        }


    }
}
