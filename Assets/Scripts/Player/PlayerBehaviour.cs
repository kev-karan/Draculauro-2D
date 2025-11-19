using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 3f;
    [SerializeField] private float coyoteTime = 0.2f;

    private Rigidbody2D rb;
    private IsGroundedChecker isGroundedChecker;
    private InputManager input;

    private float coyoteTimeCounter;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isGroundedChecker = GetComponent<IsGroundedChecker>();
        input = GetComponent<InputManager>();
    }

    private void Start()
    {
        input.OnJump += HandleJump;
    }

    private void Update()
    {
        if (isGroundedChecker.IsGrounded())
        {
            coyoteTimeCounter = coyoteTime;
        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }

        float moveDirection = input.Movement;
        Vector2 move = new Vector2(moveDirection * moveSpeed, rb.linearVelocity.y);
        rb.linearVelocity = move;
    }

    private void HandleJump()
    {
        if (coyoteTimeCounter <= 0f) return;

        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

        coyoteTimeCounter = 0f;
    }
}
