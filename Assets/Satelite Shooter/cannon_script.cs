using UnityEngine;

public class cannon_script : MonoBehaviour
{
    public float trackingSpeed = 5.0f; // Adjust this value to control tracking speed.

    private void Update()
    {
        // Get the mouse position in screen coordinates.
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position from screen space to world space.
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Calculate the direction from the object to the mouse position.
        Vector3 targetDirection = worldMousePosition - transform.position;

        // Calculate the angle in degrees.
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

        // Rotate the object to face the mouse direction.
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle-90));
    }
}
