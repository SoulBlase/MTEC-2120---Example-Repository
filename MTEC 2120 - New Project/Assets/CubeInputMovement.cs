using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInputMovement : MonoBehaviour
{
    private GameObject[,] Cubes;

    public GameObject CubeBlock;

    // Start is called before the first frame update
    void Start()
    {
        Cubes = new GameObject[5, 5];
        PostionOffset = new Vector3[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Cubes[i, j] = Instantiate(CubeBlock, new Vector3(2, 5, 0), Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Cubes[i, j].transform.position = new Vector3(Cubes[i, j].transform.position.x,Mathf.Sin(Time.time)
                    + PostionOffset[i,j].y, 0);
            }
        }
    }
}
