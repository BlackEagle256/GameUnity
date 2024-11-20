using UnityEngine;

public class SimplePlayerControl : MonoBehaviour
{
    public float speed = 1000; // سرعت حرکت
    private Rigidbody rigidBody;
    private Vector3 newVelocity;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // دریافت ورودی حرکت
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        newVelocity = new Vector3(xMove, 0, zMove);
    }

    void FixedUpdate()
    {
        // اعمال حرکت به جسم
        rigidBody.velocity = newVelocity;
    }
}
