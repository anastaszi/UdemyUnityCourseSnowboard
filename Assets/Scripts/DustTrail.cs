using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem collisionEffect;
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Level")) {
            collisionEffect.Play();
        }
    }
   void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Level")) {
            Debug.Log("Collision exit");
            collisionEffect.Stop();
        }
    }
}
