using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private PlayerInput playerInput;
    private float canmove = 1;
    private void Awake()
    {
        GameEvent.quizTimeEnd += MoveStart;
        GameEvent.quizStart += MoveStop;
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>(); // PlayerInput 컴포넌트 참조
       
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 moveDir = playerInput.moveDir; // 입력 가져오기
        rb.linearVelocity = moveDir * moveSpeed * canmove;     // 속도 적용
    }

    private void MoveStop()
    {
        canmove = 0;
    }
    private void MoveStart()
    {
        canmove = 1;
    }
    public void MoveSpeedZero()
    {
        moveSpeed = 0;
    }
    public void MoveSpeed()
    {
        moveSpeed = 5;
    }

}
