using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterMotor motor;
    private InputAction moveAction;

    private void Awake()
    {
        motor = GetComponent<CharacterMotor>();
        moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        if (!moveAction.IsPressed())
        {
            motor.Stop();
            return;
        }

        Vector3 move = moveAction.ReadValue<Vector2>();
        motor.moveDir = new Vector2(move.x, move.y).normalized;
    }
}

