using UnityEngine;

public class PlayerMovementMainmenu : MonoBehaviour
{
    [SerializeField] private float jumpPower = 16f; // Renamed from "jumpingPower"

    [SerializeField] private Rigidbody2D playerRigidbody; // Renamed from "rb"
    [SerializeField] private Transform groundCheckTransform; // Renamed from "groundCheck"
    [SerializeField] private LayerMask groundCollisionLayer; // Renamed from "groundLayer"

    void Update()
    {
        // Only allow jumping
        if (Input.GetButtonDown("Jump") && IsPlayerGrounded())
        {
            playerRigidbody.velocity = new Vector2(0f, jumpPower); // Apply jump force
        }

        if (Input.GetButtonUp("Jump") && playerRigidbody.velocity.y > 0f)
        {
            playerRigidbody.velocity = new Vector2(0f, playerRigidbody.velocity.y * 0.5f); // Shorten jump
        }
    }

    private void FixedUpdate()
    {
        // Prevent horizontal movement by ensuring x-velocity is always 0
        playerRigidbody.velocity = new Vector2(0f, playerRigidbody.velocity.y);

        // Handle falling below a certain height if needed
        if (playerRigidbody.position.y < -8f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }

    private bool IsPlayerGrounded() // Check if the player is on the ground
    {
        return Physics2D.OverlapCircle(groundCheckTransform.position, 0.2f, groundCollisionLayer);
    }
}
