using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 10.0f;
    public float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        FixedUpdate(VerticalInput);
    }

    // Update is called once per frame
    void FixedUpdate(float verticalInput)
    {
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(rotationSpeed * Time.deltaTime * verticalInput * Vector3.right);
    }
}
