using UnityEngine;
using System.Collections;

public class ApplyColor : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    public Material material;

    void Update()
    {
        material.color = fcp.color;

    }
}
