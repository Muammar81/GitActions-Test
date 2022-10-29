using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5;

    private void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        var movement = new Vector2(x, y);
        transform.Translate(speed * movement.normalized * Time.deltaTime);
    }
}