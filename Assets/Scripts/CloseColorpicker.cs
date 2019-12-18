using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseColorpicker : MonoBehaviour
{
    public GameObject fcp;
    
    void CloseFcp()
    {
        
        fcp.SetActive(false);
        
    }
}
