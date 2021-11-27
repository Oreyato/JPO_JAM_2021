using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAppear : MonoBehaviour
{
    public float speed = 5;
    public float minZPosition = -10;
    public float spawnZPosition = 40;
    public GameObject endTile;

    public List<GameObject> tileList = new List<GameObject>();
    void Start()
    {
        GameObject firstTile = tileList[0];
        Instantiate(firstTile, firstTile.transform.position, firstTile.transform.rotation);

        for (int i = 0; i < 29; i++)
        {
            if (i % 2 == 0)
            {
                int random = Random.Range(0, 10);
                GameObject tile = tileList[random];
                Instantiate(tile, new Vector3(0, 0, 10 + i * 10), tile.transform.rotation);
            }
            else
            {
                Instantiate(firstTile, new Vector3(0, 0, 10 + i * 10), firstTile.transform.rotation);
            }
        }
        Instantiate(endTile, new Vector3(0, 0, 10 + 29 * 10), endTile.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
