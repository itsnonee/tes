using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnKeyPress : MonoBehaviour
{
    public List<AudioSource> audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource[0].Play();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            audioSource[1].Play();
        }
    }
}
