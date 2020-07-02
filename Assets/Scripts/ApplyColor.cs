using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ApplyColor : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    [SerializeField]
    private Material[] materials;
    private Color flxColor;


    private int randomInt;
    public Image previewColorPicker;

    public void ChangeColor()
    {
        randomInt = Random.Range(0, materials.Length - 1);
        
  
    }

    private void Update()
    {
        if (flxColor!=fcp.color)
        {
        
            try
            {
                materials[randomInt].color = fcp.color;
               
                Debug.Log("Change color to " + gameObject.name);
                flxColor = fcp.color;
            }
            catch { Debug.Log("Catch"); }
            

        }
        previewColorPicker.color = materials[randomInt].color;
        materials[randomInt].SetFloat("_Metallic", fcp.sliderValueMetallic);
        materials[randomInt].SetFloat("_Glossiness", fcp.sliderValueSmoothness);


    }
    private void Start()
    {
        //flxColor = fcp.color;
        materials = transform.GetComponentInChildren<MeshRenderer>().materials;

    }
 


    

}
