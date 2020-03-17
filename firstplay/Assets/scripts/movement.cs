using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
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
        movedirection();
    }
    
    public void movedirection()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up);
            playaudio();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
    }
    public void playaudio()
    {
        if(!aud.isPlaying)
        {
            aud.Play();
        }
        else
        {
            aud.Stop();
        }
    }

}
