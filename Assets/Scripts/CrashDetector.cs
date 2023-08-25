using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSound;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Level")) {
                Debug.Log("You lose!");
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSound);
                Invoke("ReloadScene", reloadDelay);
            }  
    }
     void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
