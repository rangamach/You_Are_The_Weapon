using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    GameObject whole_cannon;
    GameObject only_barrel;

    [SerializeField] private float rotation_speed;
    
    void Update()
    {
        
    }

    void Move()
    {
        Rotate();
    }

    void Rotate()
    {
        float mouse_y = Input.GetAxis("Mouse X");
    }
}
