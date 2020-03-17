using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField] GameObject rocket;
    [SerializeField] GameObject destination;
    [SerializeField] float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag.CompareTo("destination") == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, rocket.transform.position, speed * Time.deltaTime);
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, speed * Time.deltaTime);
        }
    }
}
