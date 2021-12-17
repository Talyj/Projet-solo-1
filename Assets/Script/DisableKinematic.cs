using UnityEngine;

public class DisableKinematic : MonoBehaviour
{
    [SerializeField] private GameObject[] cans;

    public void Disable(){
        foreach (var can in cans)
        {
            can.GetComponent<Rigidbody>().isKinematic = false;
        }

    }
}
