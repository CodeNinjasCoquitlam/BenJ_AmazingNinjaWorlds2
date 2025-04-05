using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject Background;

    void OnTriggerEnter(Collider other)
    {
        Vector3 newCheckpoint = transform.position;
        Background.GetComponent<GameManager>().checkPoint = newCheckpoint;
    }
}