    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private InputActionMap playerControls;
    public float moveSpeed;
    [HideInInspector] public float auxSpeed;
    private Rigidbody2D _rigidbody;
    Vector2 movementValue;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        auxSpeed = moveSpeed;
        playerControls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //movementValue = playerControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = movementValue * moveSpeed;
    }
}
