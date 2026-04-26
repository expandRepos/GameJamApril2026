using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
    public float moveSpeed = 500;
    public Vector2 moveDir;

    public Rigidbody rb;
    private float movementThreshold = 0.1f; // Threshold to consider the Rigidbody as moving


    public void FixedUpdate()
    {
        rb.AddForce(moveDir * moveSpeed * Time.fixedDeltaTime);
    }

    public bool IsMoving()
    {
        return rb.linearVelocity.magnitude > movementThreshold;
    }

    public void Stop()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        moveDir = Vector3.zero;
    }
}

