using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject whole_cannon;
    [SerializeField] private GameObject only_barrel;

    [SerializeField] private float rotation_speed;

    private Vector2 mouse_movement;

    private void Start()
    {
        mouse_movement.x = Input.mousePosition.x;
        mouse_movement.y = Input.mousePosition.y;
    }

    void Update()
    {
        CannonTransformHandler();   
    }

    void CannonTransformHandler()
    {
        Rotate();
    }

    void Rotate()
    {
        Vector2 current_mouse_position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 mouse_position_check = current_mouse_position - mouse_movement;
        whole_cannon.transform.Rotate(0, mouse_position_check.x * rotation_speed * Time.deltaTime, 0);
        only_barrel.transform.Rotate(0, mouse_position_check.y * rotation_speed * Time.deltaTime, 0);
        mouse_movement = current_mouse_position;
    }

}
