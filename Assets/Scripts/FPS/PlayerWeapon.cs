using TMPro;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    //[Header("Gun Settings")]
    //public GameObject _bullet;
    //public Transform _spawnPos;
    //public float fireRate = 0.2f;
    //private float nextFireTime;

    public GameObject _bulletPrefab;
    public Transform _spawnPos;
    public float _fireRate;
    float _nxtTimeFire;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && Time.time > _nxtTimeFire)
        {
            Shoot();
            _nxtTimeFire = Time.time + _fireRate;
        }
    }
    public void Shoot()
    {
        GameObject bullet = Instantiate(_bulletPrefab, _spawnPos.position,_spawnPos.rotation);
    }
    //void Update()
    //{
    //    // Hold left mouse button to shoot
    //    if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
    //    {
    //        Shoot();
    //        nextFireTime = Time.time + fireRate;
    //    }
    //}

    //public void Shoot()
    //{
    //    GameObject bullet = Instantiate(_bullet, _spawnPos.position, _spawnPos.rotation);
    //}
}
