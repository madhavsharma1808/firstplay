using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class die : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] GameObject gameobject;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("die"))
        {
            //SceneManager.LoadScene("first");
        }

       if(collision.gameObject.CompareTag("destination"))
        {
            //Invoke("loadscene",1f);
            rigidbody.isKinematic = false;
            Debug.Log("reached");
        }
    }
    void loadscene()
    {
        SceneManager.LoadScene("second");
    }

}
