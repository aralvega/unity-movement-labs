using UnityEngine;

/// <summary>
/// Moves the player horizontally by changing its Transform directly.
/// This is a kinematic movement example used for learning purposes.
/// </summary>
public class PlayerMovementByTransform : MonoBehaviour
{
    [Tooltip("Movement speed in units per second.")]
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
