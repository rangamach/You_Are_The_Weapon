using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Transform fire_point;
    [SerializeField] private float magnitude;
    [SerializeField] private BombHandler bomb;
    private Vector3 scale;

    private void Awake()
    {
        scale = new Vector3(11, 11, 11);
    }
    void Update()
    {
        GetMouseInput();
    }

    void GetMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBombOutOfBarrel();
        }
    }

    void ShootBombOutOfBarrel()
    {
        BombHandler bmb = Instantiate(bomb, fire_point.position, fire_point.rotation, this.transform.GetChild(0).transform);
        bmb.transform.localScale = scale;
        bmb.transform.SetParent(null);
        Rigidbody bombrb = bmb.GetComponent<Rigidbody>();
        if(bombrb)
        {
            bombrb.AddForce(fire_point.forward * magnitude * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
