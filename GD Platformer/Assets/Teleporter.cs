using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Teleporter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                other.transform.position = new Vector2(0, 3);
                other.attachedRigidbody.velocity = Vector2.zero;
            }
        }
    }
}