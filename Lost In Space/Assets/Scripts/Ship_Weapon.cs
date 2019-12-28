using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Weapon : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shootingPosition;

    public float bulletRatio;
    float shootingTime;

    // Start is called before the first frame update
    void Start()
    {
        shootingTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        shootingTime += Time.deltaTime;

        if(Input.GetButton("Fire1"))
        {
            if(shootingTime >= bulletRatio)
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, shootingPosition.transform.position, shootingPosition.transform.rotation);
        shootingTime = 0f;
    }
}
