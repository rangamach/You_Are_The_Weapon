using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject whole_cannon;
    [SerializeField] private GameObject only_barrel;

    [SerializeField] private float rotation_speed;
    [SerializeField] private float move_speed;

    [SerializeField] private Rigidbody rb2d;

    private float mouse_movement;

    private void Start()
    {
        mouse_movement = Input.mousePosition.y;
    }

    void Update()
    {
        CannonTransformHandler();   
    }

    void CannonTransformHandler()
    {
        Rotate();
        Move();
    }

    void Rotate()
    {
        float user_input = Input.GetAxisRaw("Horizontal");
        float current_mouse_y = Input.mousePosition.y;
        float mouse_check = current_mouse_y - mouse_movement;
        whole_cannon.transform.Rotate(0, user_input * rotation_speed * Time.deltaTime, 0);
        only_barrel.transform.Rotate(0, 0, -mouse_check * rotation_speed * Time.deltaTime);
        Vector3 euler = only_barrel.transform.localRotation.eulerAngles;
        if (euler.z < 100 && euler.z > 25)
        {
            euler.z = 25;
            only_barrel.transform.localRotation = Quaternion.Euler(euler);
        }
        if (euler.z > 300)
        {
            euler.z = 359;
            only_barrel.transform.localRotation = Quaternion.Euler(euler);
        }
        mouse_movement = current_mouse_y;
    }

    void Move()
    {
        float user_input = Input.GetAxisRaw("Vertical");
        whole_cannon.transform.Translate(-user_input * Vector3.right * move_speed * Time.deltaTime);
    }
}
