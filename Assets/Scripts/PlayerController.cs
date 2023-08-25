using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float regularSpeed = 15f;
    SurfaceEffector2D surfaceEffector;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RotatePlayer() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb2d.AddTorque(torqueAmount);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rb2d.AddTorque(-torqueAmount);
        }
    }

    void RespondToBoost() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            surfaceEffector.speed =  boostSpeed;
        } else {
            surfaceEffector.speed =  regularSpeed;
        }
    }
}
