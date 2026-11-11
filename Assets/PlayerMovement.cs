using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHor = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHor, 0 , moveVer) * moveSpeed * Time.deltaTime;

        movement = transform.TransformDirection(movement);

        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
