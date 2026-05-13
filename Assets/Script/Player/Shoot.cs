using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public Transform firePoint;
    public float fireRate;
    float ReadyForNextShot;
    public Animator gunAnimator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > ReadyForNextShot)
            {
                ReadyForNextShot = Time.time + 1f / fireRate;
                shoot();
            }
            shoot();
        }
    }

    void shoot()
    {
        GameObject BulletIns = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        gunAnimator.SetTrigger("Shoot");
        Destroy(BulletIns, 1.5f);
    }
}
