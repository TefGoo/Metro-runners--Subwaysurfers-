using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject Tile3;
    public GameObject Tile4;
    public GameObject StartTile;

    private float Index = 0;

    private void Start()
    {
        GameObject StartPlane = Instantiate(StartTile, transform);
        StartPlane.transform.position = new Vector3(7, 0, 0);
        GameObject StartPlane2 = Instantiate(StartTile, transform);
        StartPlane2.transform.position = new Vector3(-1, 0, 0);
        GameObject StartPlane3 = Instantiate(StartTile, transform);
        StartPlane3.transform.position = new Vector3(-9, 0, 0);
    }

    private void Update()
    {
        gameObject.transform.position += new Vector3(4 * Time.deltaTime, 0, 0);

        if (transform.position.x >= Index)
        {
            int RandomInt1 = Random.Range(0, 4);

            if (RandomInt1 == 0)
            {
                GameObject TempTile1 = Instantiate(Tile1, transform);
                TempTile1.transform.position = new Vector3(-16, 0, 0);
            }
            else if (RandomInt1 == 1)
            {
                GameObject TempTile1 = Instantiate(Tile2, transform);
                TempTile1.transform.position = new Vector3(-16, 0, 0);
            }
            else if (RandomInt1 == 2)
            {
                GameObject TempTile1 = Instantiate(Tile3, transform);
                TempTile1.transform.position = new Vector3(-16, 0, 0);
            }
            else if (RandomInt1 == 3)
            {
                GameObject TempTile1 = Instantiate(Tile4, transform);
                TempTile1.transform.position = new Vector3(-16, 0, 0);
            }

            int RandomInt2 = Random.Range(0, 4);

            if (RandomInt2 == 0)
            {
                GameObject TempTile2 = Instantiate(Tile1, transform);
                TempTile2.transform.position = new Vector3(-24, 0, 0);
            }
            else if (RandomInt2 == 1)
            {
                GameObject TempTile2 = Instantiate(Tile2, transform);
                TempTile2.transform.position = new Vector3(-24, 0, 0);
            }
            else if (RandomInt2 == 2)
            {
                GameObject TempTile2 = Instantiate(Tile3, transform);
                TempTile2.transform.position = new Vector3(-24, 0, 0);
            }
            else if (RandomInt2 == 3)
            {
                GameObject TempTile2 = Instantiate(Tile4, transform);
                TempTile2.transform.position = new Vector3(-24, 0, 0);
            }

            Index = Index + 15.95f;
        }
    }
}