using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectSpawn;
    private PlacementIndicator placementIndicator;
    GameObject obj;


    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();

    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            obj = Instantiate(objectSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
            Destroy(placementIndicator.gameObject);
        }    

    }

    public void Scale()
    {
        obj.transform.localScale = obj.transform.localScale * 2;
    }


}
