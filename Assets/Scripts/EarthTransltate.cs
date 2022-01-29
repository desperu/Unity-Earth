using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthTransltate : MonoBehaviour
{

    public Vector3 position;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = position;
    }
}
