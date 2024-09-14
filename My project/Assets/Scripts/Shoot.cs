using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform bulletPoint;   
    public float bulletSpeed = 80f; 
    public AudioClip gunSound;      

    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(bulletPoint.forward * bulletSpeed, ForceMode.Impulse);
        }
        audioSource.PlayOneShot(gunSound);
        Destroy(bullet, 1.5f);
    }
}
