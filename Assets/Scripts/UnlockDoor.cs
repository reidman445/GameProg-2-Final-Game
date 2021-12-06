using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject GameObject;

    public GameObject GameObject2;
    public AudioSource audioSource;

    
       

    private void OnTriggerEnter(Collider c) => Collide(c.gameObject);
        private void OnCollisionEnter(Collision c) => Collide(c.gameObject);

        /**
         * @author Brenton Hauth
         * @date 12/07/20
         * <summary>
         * Handles all collisions from Colliders
         * </summary>
         */
        private void Collide(GameObject o) {
            if (o.tag == "Player") {
                // TODO: Trigger fade out
                Destroy(this.GameObject);
                Destroy(this.GameObject2);
                audioSource.Play();

            }
        }

}
