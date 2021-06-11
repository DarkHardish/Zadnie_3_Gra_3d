using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody Bullet;
    public Transform firePlace;
    public float power;
    private Rigidbody projectile;
    private bool fire;



    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            projectile = Instantiate(Bullet, firePlace.position, transform.rotation);
            fire = true;
        }
    }

    private void FixedUpdate()
    {
        if (fire)
        {
            projectile.velocity = transform.TransformDirection(Vector3.forward * power);
            fire = false;
            Destroy(projectile.gameObject, 3);
        }
    }


}
