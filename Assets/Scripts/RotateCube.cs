using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float rotationAngle = 3.0f;
    bool r;
    // Start is called before the first frame update
    void Start()
    {
        r = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (r)
        {
            transform.Rotate(0,rotationAngle, 0);
        }
    }

    private void OnRotate()
    {
        Debug.Log("R appui");
        if (r)
        {
            r = false;
        }
        else
        {
            r = true;
        }
    }
}
