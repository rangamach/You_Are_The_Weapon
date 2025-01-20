using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemyShooting : MonoBehaviour
{

    [SerializeField]private GameObject bulletPrefab;
    [SerializeField] private Transform gunTip;
    [SerializeField] private float bulletSpeed;

    private bool isEnemyAlive;
    private bool isShooting;

    

    [SerializeField]private float delayShoot;


    // Start is called before the first frame update
    void Start()
    {
        
        isEnemyAlive = true;
        isShooting = true;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyShooting();
    }

    void EnemyShooting()
    {
        if (isEnemyAlive == true && isShooting == true)
        {

            if (bulletPrefab != null)
            {
                GameObject bullet = Instantiate(bulletPrefab, gunTip.position, gunTip.rotation);
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(Vector3.forward *bulletSpeed, ForceMode.Impulse);
                isShooting = false;
                StartCoroutine(NextBullet(delayShoot));
            }
            
        }
    }

    private IEnumerator NextBullet(float delayShoot)
    {
        yield return new WaitForSeconds(delayShoot);
        isShooting = true;

    }
}
