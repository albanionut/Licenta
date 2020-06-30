using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWheel : MonoBehaviour
{

    public void changeScene(){
        SceneManager.LoadScene("Wheel");
    }

    public void changeSceneCarGlass()
    {
        SceneManager.LoadScene("CarGlass");
    }
}
