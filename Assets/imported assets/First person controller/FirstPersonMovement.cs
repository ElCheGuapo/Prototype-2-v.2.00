using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    //countdown variables
    float currentTime = 0f;
    float startingTime = 5f;

    public Rigidbody rigidBody;

    //movement variables
    public float speed = 20;
    Vector3 velocity = new Vector3();

    void FixedUpdate()
    {
        //handle movement
        velocity.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        // transform.Translate(velocity.x, 0, velocity.y);
        rigidBody.velocity = velocity * 100;

    }
}
