using UnityEngine;

public class DestroyPins : MonoBehaviour
{
    public ScoreManager _scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _scoreManager.AddScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            _scoreManager.AddScore();
            Destroy(gameObject);
        }
    }
}
