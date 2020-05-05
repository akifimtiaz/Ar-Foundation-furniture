using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float scalingSpeed;
    public Vector3 min;
    public Vector3 max;
    Transform Portal;
    public List<Material> myMaterials = new List<Material>();
    private int count=0;
    void Start()
    {
         Portal = this.gameObject.transform;
        GetComponent<Renderer>().material = myMaterials[count];
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;


            scalingSpeed = deltaMagnitudeDiff;


            
            Vector3 newScale = new Vector3();
            newScale.x = Mathf.Clamp(Portal.localScale.x - scalingSpeed, min.x, max.x);
            newScale.y = Mathf.Clamp(Portal.localScale.y - scalingSpeed, min.y, max.y);
            newScale.z = Mathf.Clamp(Portal.localScale.z - scalingSpeed, min.z, max.z);
            Portal.transform.localScale = newScale;

        }
        if (Input.touchCount == 1)
        {
            // GET TOUCH 0
            Touch touch0 = Input.GetTouch(0);

            // APPLY ROTATION
            if (touch0.phase == TouchPhase.Moved)
            {
                Portal.transform.Rotate(0, 0, (-touch0.deltaPosition.x*0.5f));
            }

        }
    }

    public void ChangeMaterial()
    {
        if (count == myMaterials.Count)
        {
            count = -1;
        }
        count += 1;
        GetComponent<Renderer>().material = myMaterials[count];
    }
}
