using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public Transform firePoint;
    public float coolDown;
    private bool canShoot = true;
    public GameObject bulletPrefab;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && GameManager.obj.gameReady && canShoot == true)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject bullet = ObjectPooling.instance.GetPooledObject();
        if(bullet != null)
        {
            bullet.transform.position = firePoint.position;
            bullet.SetActive(true);
        }
        AudioManager.obj.playShot();
        canShoot = false;
        StartCoroutine(TimeShoot());
    }

    IEnumerator TimeShoot()
    {
        yield return new WaitForSeconds(coolDown);
        canShoot = true;
    }
}
