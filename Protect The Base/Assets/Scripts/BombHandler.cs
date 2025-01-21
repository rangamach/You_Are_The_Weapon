using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 0 || collision.gameObject.layer == 6)
        {
            Destroy(this.gameObject);
        }
    }
}
