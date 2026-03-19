using UnityEngine;

/// <summary>
/// Moves the player horizontally using Transform
/// and restricts movement using Clamp.
/// </summary>
public class PlayerMovementByTransformWithLimits : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;

    [Header("Limits")]
    [SerializeField] private float minX = -8f;
    [SerializeField] private float maxX = 8f;

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

        // Movimiento normal
        transform.position += movement * moveSpeed * Time.deltaTime;

        // Aplicar límites
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);

        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
