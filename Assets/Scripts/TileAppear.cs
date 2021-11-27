using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAppear : MonoBehaviour
{
    public float speed = 5;
    public float minZPosition = -10;
    public float spawnZPosition = 40;
    int count = 0;

    public List<GameObject> tileList = new List<GameObject>();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Time.timeSinceLevelLoad%(60*5) == 0)
        {
            int random = Random.Range(0, 10);
            GameObject tile = tileList[random];
            Instantiate(tile, new Vector3(0, 0,10 * count), tile.transform.rotation);
            count++;
        }
    }
}
