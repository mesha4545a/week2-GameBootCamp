using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeLevels : MonoBehaviour
{
    [SerializeField] private string nextLevel;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(nextLevel);
            }
    }

}

