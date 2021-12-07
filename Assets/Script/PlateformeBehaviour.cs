using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeBehaviour : MonoBehaviour
{
    private int speedPlatform = 2;
    public static int dir = 0;

    private void Start()
    {
        Destroy(gameObject, 3);
    }
    void Update()
    {
        CameraMovement();
    }

    private void CameraMovement()
    {
        switch (dir)
        {
            case 0:
                transform.position += Vector3.right * Time.deltaTime * speedPlatform;
                break;
            case 1:
                transform.position += Vector3.left * Time.deltaTime * speedPlatform;
                break;
            case 2:
                transform.position += Vector3.up * Time.deltaTime * speedPlatform;
                break;
        }
    }
}
