using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 0 || collision.gameObject.layer == 3)
        {
            Debug.Log("hit cannon");
            Destroy(this.gameObject);
        }
    }
}
