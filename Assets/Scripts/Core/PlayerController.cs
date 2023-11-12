using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;
    private Rigidbody2D _rb;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    private void Awake() 
    {    
        playerControls = new PlayerControls();
        _rb = GetComponent<Rigidbody2D>();
    }
    
    private void OnMove(InputValue inputValue)
    {   
        _rb.velocity = inputValue.Get<Vector2>() * moveSpeed;
    }

}
