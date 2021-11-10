using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateBall : MonoBehaviour
{
    public Rigidbody ballRb;
    public Transform throwPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThrowBall()
    {
        Instantiate(ballPrefab, throwPos, Quaternion.Euler);
    }
}
