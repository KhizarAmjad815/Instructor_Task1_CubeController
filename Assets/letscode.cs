using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letscode : MonoBehaviour
{
    public Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello change");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(scaleChange);

        transform.localScale += scaleChange;
    }
}
