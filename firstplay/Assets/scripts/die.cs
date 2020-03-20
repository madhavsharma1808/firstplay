using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class die : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] GameObject gameobject;
    AudioSource audioSource;
    [SerializeField]AudioClip aud2;
    [SerializeField]AudioClip aud3;
    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("die"))
        {
           // audioSource.Stop();
            audioSource.PlayOneShot(aud2);
            //SceneManager.LoadScene("first");
            Debug.Log("yeah");

        }

       if(collision.gameObject.CompareTag("destination"))
        {
            //Invoke("loadscene",1f);
            audioSource.Stop();
            audioSource.PlayOneShot(aud3);
            rigidbody.isKinematic = false;
            Debug.Log("reached");
        }
    }
    void loadscene()
    {
        SceneManager.LoadScene("second");
    }

}
