using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    [SerializeField] float upvelocity = 1f;
    [SerializeField] float rotateleft = 1f;
    [SerializeField] float rotateright = 1f;
    Rigidbody rigidbody1;
    Rigidbody rigidbody2;
    [SerializeField] GameObject gameobject;
    AudioSource audioSource;
    [SerializeField] AudioClip aud1;
    [SerializeField] AudioClip aud2;
    [SerializeField] AudioClip aud3;

    [SerializeField] ParticleSystem Ef1;
    [SerializeField] ParticleSystem Ef2;
    [SerializeField] ParticleSystem Ef3;

    public enum State { Alive, Dying, Transcending };
    State state = State.Alive;

    void Start()
    {
         


    rigidbody1 = GetComponent<Rigidbody>();
      
        rigidbody2 = gameObject.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.Alive)
        {
            thrust();
            rotate();
        }
    }
    
    public void thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up*upvelocity*Time.deltaTime);
            audioSource.PlayOneShot(aud1);
            Ef1.Play();
        } 
       
        else
        {
            audioSource.Stop();
            Ef1.Stop();
        }

        
    }

    public void rotate()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward*rotateleft*Time.deltaTime);
        }


        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward*rotateright*Time.deltaTime);
        }

        GetComponent<Rigidbody>().freezeRotation = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
            if (state != State.Alive) { return; }

        if (collision.gameObject.CompareTag("die"))
        {
            
            audioSource.Stop();
            audioSource.PlayOneShot(aud2);
            Ef2.Play();
           
            Debug.Log("yeah");
            state = State.Dying;
            //SceneManager.LoadScene("first");
        }

        if (collision.gameObject.CompareTag("destination"))
        {
            
            audioSource.Stop();
            audioSource.PlayOneShot(aud3);
            Ef3.Play();
            Debug.Log("reached");
            state = State.Transcending;
            Invoke("loadscene",1f);
        }
    }
    void loadscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void playaudio()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.Play();
        }
  
    }

}
