using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

void OnTriggerEnter2D(Collider2D other) {
 if (other.gameObject.CompareTag("Level")) {
     Debug.Log("You lose!");
     SceneManager.LoadScene("Level1");
 }  
}
}
