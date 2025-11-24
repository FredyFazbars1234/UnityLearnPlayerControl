using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 20.0f;
   private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward.
        transform.Translate(speed * Time.deltaTime * Vector3.forward * forwardInput);
        // Move the vehicle horizonally.
        transform.Rotate(Vector3.up, angle: turnSpeed * horizontalInput * Time.deltaTime);
    }
}
