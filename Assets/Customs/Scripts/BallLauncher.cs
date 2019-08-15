using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public GameObject ball;
    public bool spawnBall = true;
    bool throwingBall = false;
    public float waitTime = 2f;

    // Update is called once per frame
    void Update()
    {
        if (spawnBall)
        {
            if (!throwingBall)
                StartCoroutine(ThrowBall());
        }
    }

    private IEnumerator ThrowBall()
    {
        throwingBall = true;
        InstantiateBall();
        yield return new WaitForSeconds(waitTime);
        throwingBall = false;
    }

    private void InstantiateBall()
    {
        GameObject inst = ObjectPooler.instance.GetFromPool("Ball", transform.position, transform.rotation);
    }
}
