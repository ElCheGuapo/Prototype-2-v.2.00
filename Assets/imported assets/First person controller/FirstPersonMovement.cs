using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    //countdown variables
    float currentTime = 0f;
    float startingTime = 5f;

    //movement variables
    public float speed = 20;
    Vector2 velocity;

    void FixedUpdate()
    {
        //handle movement
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);
    }
}
