using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject can;
    private new Vector3 startPos;
    private bool isDetected;

    void Start()
    {
        startPos = can.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDetected)
        {
            can.transform.position = startPos;
            isDetected = false;
        }
    }

    public void Change()
    {
        isDetected = true;
    }
}
