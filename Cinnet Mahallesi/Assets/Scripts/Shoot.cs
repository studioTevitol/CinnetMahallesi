using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public void Fire()
    {
        Debug.Log("shoot");
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
