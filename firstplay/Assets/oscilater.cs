using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscilater : MonoBehaviour
{
    [Range(0, 1)] [SerializeField] float position;
    [SerializeField] Vector3 location;
    Vector3 startingposition;
    float tempfactor;
    [SerializeField] float period = 2f;
    float cycles;


    private void Start()
    {
        startingposition = transform.position;
    }

    private void Update()
    {
        cycles = Time.time / period;
        const float tau= Mathf.PI * 2;
        tempfactor = Mathf.Sin(tau * cycles);
        position = (tempfactor / 2f) + 0.5f;
        transform.position =startingposition + location * position;
    }

   
 
}
