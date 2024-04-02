using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] public ItemsManager itemsManager;
    [SerializeField] private float timeDestroy;
    [SerializeField] private float timecolor = 0.5f;
                     private BoxCollider2D boxColliderItem;
                     private bool playerInItem;
                     private SpriteRenderer color;
                     private float alfaColor = 1f;

    private void Start()
    {
        player = GameObject.Find("Player");
        itemsManager = GameObject.FindObjectOfType<ItemsManager>();
        boxColliderItem = GetComponent<BoxCollider2D>();
    }

    private void Awake()
    {
        color = transform.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Movedor();
    }

    public void Movedor()
        
    {
        if (playerInItem)

        {
            alfaColor -= timecolor * Time.deltaTime;
            transform.Translate(Vector3.up * Time.deltaTime);
            color.color = new Color(1,1,1,alfaColor);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gameObject.CompareTag("ItemHeart"))
        {
            itemsManager.PickCounter();
            playerInItem = true;
            boxColliderItem.enabled = false;
            Destroy(gameObject,timeDestroy);
        }

        if (other.CompareTag("Player") && gameObject.CompareTag("ItemCoinSpin"))
        {
            itemsManager.CoinSpinCounter();
            playerInItem= true;
            boxColliderItem.enabled = false;
            Destroy(gameObject,timeDestroy);
        }

        if (other.CompareTag("Player") && gameObject.CompareTag("ItemCoinShine"))
        {
            itemsManager.CoinShineCounter();
            playerInItem = true;
            boxColliderItem.enabled = false;
            Destroy(gameObject,timeDestroy);
        }
    }
}
