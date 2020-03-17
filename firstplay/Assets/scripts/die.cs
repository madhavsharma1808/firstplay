using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class die : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("die"))
        {
            //SceneManager.LoadScene("first");
            Debug.Log("hello");
        }
    }
}
