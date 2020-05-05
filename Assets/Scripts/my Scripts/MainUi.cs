using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void Chair()
    {
        SceneManager.LoadScene("Chair");
    }

    public void Frame()
    {
        SceneManager.LoadScene("Frame");
    }
}
