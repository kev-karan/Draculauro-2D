using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 3f;

    private Rigidbody2D rb;
    private IsGroundedChecker isGroundedChecker;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isGroundedChecker = GetComponent<IsGroundedChecker>();
    }

    private void Start()
    {
        GameManager.Instance.inputManager.OnJump += HandleJump;
    }

    private void Update()
    {
        float moveDirection = GameManager.Instance.inputManager.Movement;
        Vector2 vectorMoveDirection = new Vector2(moveDirection * moveSpeed, rb.linearVelocity.y);
        rb.linearVelocity = vectorMoveDirection;
    }

    private void HandleJump()
    {
        if (!isGroundedChecker.IsGrounded()) return;
        rb.linearVelocity += Vector2.up * jumpForce;
    }
}
