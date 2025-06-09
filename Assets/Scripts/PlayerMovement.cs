using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private AudioSource jumpaudio, dead;

    // Animator reference
    [SerializeField] private Animator animator;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        // Update Animator parameter based on horizontal input
        animator.SetBool("ismoving", horizontal != 0);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            jumpaudio.Play();
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if (rb.position.y < -8f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
        if (rb.position.y < -6f)
        {
            dead.Play();
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    public void Moveleft()
    {
        rb.velocity = new Vector2(-1f * speed, rb.velocity.y);
    }
    public void MoveRight()
    {
        rb.velocity = new Vector2(1f * speed, rb.velocity.y);
    }
}
