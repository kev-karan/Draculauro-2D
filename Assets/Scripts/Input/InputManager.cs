using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;

    public float Movement => playerControls.Gameplay.Movement.ReadValue<float>();
    public event Action OnJump;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Gameplay.Enable();
        playerControls.Gameplay.Jump.performed += OnJumpPerformed;
    }

    private void OnDisable()
    {
        playerControls.Gameplay.Jump.performed -= OnJumpPerformed;
        playerControls.Gameplay.Disable();
    }

    private void OnJumpPerformed(InputAction.CallbackContext context)
    {
        OnJump?.Invoke();
    }
}
