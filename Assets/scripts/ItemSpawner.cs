using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    [SerializeField]
    private float minX;
    [SerializeField]
    private float minY;
    [SerializeField]
    private float maxX;
    [SerializeField]
    private float maxY;

    [SerializeField]
    private GameObject coinReference;
    [SerializeField]
    private GameObject pistolReference;

    private GameObject coin;
    private GameObject pistol;

    // private float minposX;
    //  private float minposY;
    private float posX;
    private float posY;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoin());
        StartCoroutine(SpawnPistol());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnCoin() //spwaning coins in random localisation
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            coin = Instantiate(coinReference);

            posX = Random.Range(minX, maxX);
            posY = Random.Range(minY, maxY);

            coin.transform.position = new Vector3(posX, posY, coin.transform.position.z);


        }
    }

    IEnumerator SpawnPistol() //spwaning pistols in random localisation
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10, 20));

            pistol = Instantiate(pistolReference);

            posX = Random.Range(minX, maxX);
            posY = Random.Range(minY, maxY);

            pistol.transform.position = new Vector3(posX, posY, coin.transform.position.z);


        }
    }
}
