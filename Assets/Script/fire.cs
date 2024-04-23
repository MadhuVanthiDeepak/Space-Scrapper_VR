using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoints;
    [SerializeField] private float bulletSpeed = 10f;

    public void FireBullet()
    {
      GameObject spawnBullet=  Instantiate(bullet, spawnPoints.position, spawnPoints.rotation);
        spawnBullet.GetComponent<Rigidbody>().velocity = spawnPoints.forward * bulletSpeed;
        Destroy(spawnBullet,5f);
    }
}
