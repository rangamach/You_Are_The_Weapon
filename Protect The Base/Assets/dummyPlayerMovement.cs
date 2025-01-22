using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyPlayerMovement : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;

    public float playerSpeed;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 Xposition = transform.position;
        Xposition.x += horizontalInput * playerSpeed * Time.deltaTime;
        transform.position = Xposition;

        Vector3 Zposition = transform.position;
        Zposition.z += verticalInput * playerSpeed * Time.deltaTime;
        transform.position = Zposition;
    }
}
