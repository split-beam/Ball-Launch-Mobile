using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class BallHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D currentBallRigidBody;

    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(!Touchscreen.current.primaryTouch.press.isPressed)
        {
            currentBallRigidBody.isKinematic = false;
            return; 
        }

        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();

        Vector3 worldPosistion =  mainCamera.ScreenToWorldPoint(touchPosition);

        currentBallRigidBody.position = worldPosistion;

        currentBallRigidBody.isKinematic = true;
    }
}
