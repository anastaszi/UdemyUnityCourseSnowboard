using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float reloadDelay = 2f;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("You win!");
            Invoke("ReloadScene", reloadDelay);
        }      
    }

    void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
