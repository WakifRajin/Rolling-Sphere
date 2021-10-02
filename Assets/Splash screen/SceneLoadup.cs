using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadup : MonoBehaviour
{ 
    public float wait_time = 5f;

    void Start()
    {
        StartCoroutine(waitfor());
    }

    IEnumerator waitfor()
    {
        yield return new WaitForSeconds(wait_time);

        SceneManager.LoadScene("StartMenu");
    }
   
}
