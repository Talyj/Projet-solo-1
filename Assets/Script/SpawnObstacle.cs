using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    private float xPos, yPos, zPos = 0;
    private float cpt = 0;
    
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    cpt -= Time.deltaTime;
    //    if(cpt <= 0)
    //    {
    //        Spawn();
    //        cpt = 0.5f;
    //    }
    //}

    public void Spawn()
    {
        cpt -= Time.deltaTime;
        if (cpt <= 0)
        {
            xPos = Random.Range((float)-1.4, (float)1.4);
            yPos = Random.Range((float)-0.3, (float).7);
            zPos = Random.Range((float)-1.5, (float)1.36);
            var value = Random.Range(0, 3);
            if (xPos > 0 && yPos > 0)
            {
                PlateformeBehaviour.dir = 1;
            }
            else if (xPos < 0 && yPos > 0)
            {
                PlateformeBehaviour.dir = 0;
            }
            else
            {
                PlateformeBehaviour.dir = 2;
            }
            Instantiate(obstacles[value], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            cpt = 0.5f;
        }
    }
}
