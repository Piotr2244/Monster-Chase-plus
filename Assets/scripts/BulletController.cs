using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
    }

    private void Update()
    {
        if (transform.localScale.x > 0)
        {
            transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime * 6 * 3;
        }
        else if (transform.localScale.x < 0)
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime * 6 * 3;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(ENEMY_TAG))
        {
     
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(GROUND_TAG))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
           
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
