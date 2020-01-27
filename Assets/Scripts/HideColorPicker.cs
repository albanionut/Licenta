using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideColorPicker : MonoBehaviour
{
    public GameObject go;

    public void goActiv()
    {
        if(go.transform.localScale == new Vector3(1, 1, 1))
        {
            go.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            go.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
