using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{

    public float _bulletSpeed;
    // Update is called once per frame
    void Update()
    {

        transform.position += transform.forward * _bulletSpeed * Time.deltaTime;
    }
}
