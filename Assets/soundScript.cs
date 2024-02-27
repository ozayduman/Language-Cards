using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class soundScript : MonoBehaviour
{

    public GameObject buttonObject;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
        buttonObject = GameObject.Find("butterflySoundBtn");
        
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
       
        audioSource = buttonObject.GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        audioSource.Play();
        Debug.Log("button pressed");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //audioSource.Stop();
        Debug.Log("button released");
    }

}
