using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    private CustomInput input;
    private Vector2 movVector;
    private PlayerShoot shoot;

    [HideInInspector]
    public Vector2 MovVector { get { return movVector; } }

    private void Awake()
    {
        AwakeMetod();
    }

    private void AwakeMetod()
    {
        input = new CustomInput();
        shoot = GetComponent<PlayerShoot>();
    }

    private void OnEnable()
    {
        input.Enable();
        input.Player.Mov.performed += OnMovementPerformed;
        input.Player.Mov.canceled += OnMovementCanceled;
        input.Player.Shoot.performed += OnShootPerformed;
        input.Player.SpecialShoot.performed += OnSpecialShootPerformed;
    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.Mov.performed -= OnMovementPerformed;
        input.Player.Mov.canceled -= OnMovementCanceled;
        input.Player.Shoot.performed -= OnShootPerformed;
        input.Player.SpecialShoot.performed -= OnSpecialShootPerformed;
    }

    private void OnMovementPerformed(InputAction.CallbackContext value)
    {
        movVector = value.ReadValue<Vector2>();
    }

    private void OnMovementCanceled (InputAction.CallbackContext value)
    {
        movVector = Vector2.zero;
    }

    private void OnShootPerformed(InputAction.CallbackContext context)
    {
        shoot.Shoot();
    }
    private void OnSpecialShootPerformed(InputAction.CallbackContext context)
    {
        shoot.SpecialShoot();
    }

}
