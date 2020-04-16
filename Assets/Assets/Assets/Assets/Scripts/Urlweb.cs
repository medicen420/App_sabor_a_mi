using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Urlweb : MonoBehaviour
{
    public string googlemaps;
    public string facebook;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ubicacion()
    {
        Application.OpenURL(googlemaps);
    }
    public void facebookpersonal()
    {
        Application.OpenURL(facebook);
    }
    
}
