using UnityEngine;

public class ArrowController : MonoBehaviour
{
   
    private Rigidbody2D arrowRB;
    [SerializeField]
    private float arrowSpeed;
    private Vector2 _arrowDirection;

    public Vector2 ArrowDirection { get => _arrowDirection; set => _arrowDirection = value; }

    [SerializeField] private GameObject arrowImpact;
    [SerializeField] private GameObject arrowBatImpact;
    GameObject enemy;
    private Transform transformArrow;

    private void Awake()
    {
        arrowRB = GetComponent<Rigidbody2D>(); 
        transformArrow = GetComponent<Transform>();
    }
    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        arrowRB.velocity = ArrowDirection * arrowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Instantiate(arrowBatImpact,transformArrow.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        Instantiate(arrowImpact,transformArrow.position,Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
