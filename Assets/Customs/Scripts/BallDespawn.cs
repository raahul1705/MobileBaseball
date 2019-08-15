using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDespawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
