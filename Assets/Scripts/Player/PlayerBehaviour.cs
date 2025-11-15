using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 3f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GameManager.Instance.inputManager.OnJump += HandleJump;
    }

    private void Update()
    {
        float moveDirection = GameManager.Instance.inputManager.Movement;
        transform.Translate(moveDirection * Time.deltaTime * moveSpeed, 0, 0);
    }

    private void HandleJump()
    {
        rb.linearVelocity += Vector2.up * jumpForce;
    }
}
