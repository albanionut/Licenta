using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudONOFF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Hud()
    {
        if (transform.gameObject.activeSelf==true)
        {
            transform.gameObject.SetActive(false);
        }
        else
        {
            transform.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
