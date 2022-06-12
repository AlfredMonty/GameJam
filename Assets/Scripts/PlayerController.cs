using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rBody; 
    [SerializeField] public float mSpeed = 0.75f; 
    public InputAction pMovement;
    Vector2 mDirection = Vector2.zero;

    private void OnEnable() {
        pMovement.Enable();
    }
    private void OnDisable() {
        pMovement.Disable(); 
    }
    // Update is called once per frame
    void Update() {
        mDirection = pMovement.ReadValue<Vector2>();
    }
    
    private void FixedUpdate() {
        rBody.velocity = new Vector2(mDirection.x * mSpeed, mDirection.y * mSpeed);
    }
}
