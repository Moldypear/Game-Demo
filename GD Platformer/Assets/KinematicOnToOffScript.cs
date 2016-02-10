using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class KinematicOnToOffScript : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
}
