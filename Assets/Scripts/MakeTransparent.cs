using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeTransparent : MonoBehaviour
{
    public GameObject geamu;
    private Material materialGeam;
    public Text procent;
    // Start is called before the first frame update
    void Start()
    {
        materialGeam = transform.GetComponentInChildren<MeshRenderer>().material;

        
    }

    void ChangeAlpha(Material mat , float alphaLevel  )
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaLevel);
        mat.SetColor("_Color", newColor);

    }

    public void ChangeAlphaOnValueChange(Slider slider)
    {
        ChangeAlpha(materialGeam, slider.value);
        procent.text = String.Format("{0:0}", slider.value * 100) + "%";

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
