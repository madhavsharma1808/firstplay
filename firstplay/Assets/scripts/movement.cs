using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float upvelocity = 1f;
    [SerializeField] float rotateleft = 1f;
    [SerializeField] float rotateright = 1f;
    Rigidbody rigidbody;
    AudioSource aud;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        thrust();
        rotate();
    }
    
    public void thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up*upvelocity*Time.deltaTime);
            playaudio();
        }

        else
        {
            aud.Stop();
        }

        
    }

    public void rotate()
    {
        rigidbody.freezeRotation = true;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward*rotateleft*Time.deltaTime);
        }


        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward*rotateright*Time.deltaTime);
        }

        rigidbody.freezeRotation = false;
    }

    public void playaudio()
    {
        if(!aud.isPlaying)
        {
            aud.Play();
        }
  
    }

}
