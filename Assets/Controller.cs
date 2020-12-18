using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {


    public Rigidbody2D BallRigidBody2D;

    private void Awake() {
        Application.targetFrameRate = 60;
    }

    private void Start() {
        BallRigidBody2D.AddForce(new Vector2(1f, 10f), ForceMode2D.Impulse);
    }

}
