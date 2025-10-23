using UnityEngine;
using UnityEngine.InputSystem;

public class ListenPlayerInput : MonoBehaviour
{
    public PlayerInput playerInput;
    private InputActionMap playerMap;
    private InputActionMap uiMap;

    public InputActionReference jumpActionRef;
    public InputActionReference moveActionRef;
    private Vector2 moveInput;


    void OnEnable()
    {
        jumpActionRef.action.performed += TryToJump;
        jumpActionRef.action.canceled += StopJump;
    }

    void OnDisable()
    {
        jumpActionRef.action.performed -= TryToJump;
        jumpActionRef.action.canceled -= StopJump;
        playerMap.Disable();
    }

    void TryToJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump!!");
    }

    void StopJump(InputAction.CallbackContext context)
    {
        Debug.Log("Stop Jumping..");
    }

    void Start()
    {
        playerMap = playerInput.actions.FindActionMap("Player");
        uiMap = playerInput.actions.FindActionMap("UI");
        playerMap.Enable();
    }

    void Update()
    {
        moveInput = moveActionRef.action.ReadValue<Vector2>();
        Debug.Log(moveInput);
    }
}
