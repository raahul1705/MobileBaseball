using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPath : MonoBehaviour
{
    private float time = 0f;
    public float scale = 0.02f;
    // Parametric Equation

    private void Awake()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!CanDisappear())
            Move();
        else
            RemoveBall();

    }

    void RemoveBall()
    {
        transform.gameObject.SetActive(false);
    }

    bool CanDisappear()
    {
        return transform.position.z < Camera.main.transform.position.z;
    }

    void Move()
    {
        Vector3 motion = new Vector3(xFunction(time), yFunction(time), zFunction(time));
        transform.Translate(motion, Space.Self);
        time += Time.deltaTime;
    }

    float xFunction(float t)
    {
        return 0;//0.07f * Mathf.Cos(5 * Mathf.PI * t);
    }

    float yFunction(float t)
    {
        return 0;//0.07f * Mathf.Sin(5 * Mathf.PI * t);
    }

    float zFunction(float t)
    {
        return -0.1f * t;
    }
}
