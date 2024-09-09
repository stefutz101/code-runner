using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectBoxes : MonoBehaviour
{

    public CharacterControll run;
    
    public GameObject[] puzzles;
    //public Camera camera;
    public Transform posCamera;

    public GameObject quiz;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Box")
        {
           
           run.inainte = 0f;
           Destroy(other.gameObject);
            //int rand = Random.Range(0, 2);
            //puzzles[rand].SetActive(true);
            SceneManager.LoadScene(2);
        }
    }
}
