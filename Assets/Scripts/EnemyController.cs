using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject arrowImpact;

    void Start()
    {
       player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (arrowImpact && gameObject.CompareTag("Enemy") && (!other.CompareTag("Player")))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Player") && gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Prototype");
        }
    }
}
