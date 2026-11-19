using UnityEngine;

public class SpawnBall : MonoBehaviour
{

    public GameObject _ballPrefab;
    public Transform _ballSpawnPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_ballPrefab, _ballSpawnPos.position, Quaternion.identity);
        }
    }

}
