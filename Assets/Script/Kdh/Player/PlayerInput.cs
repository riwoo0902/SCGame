using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerInput : MonoBehaviour
{
    public Vector2 moveDir { get; private set; }

    public void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
    }
}
