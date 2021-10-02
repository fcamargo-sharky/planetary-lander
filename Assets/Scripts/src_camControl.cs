using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_camControl : MonoBehaviour
{
    public GameObject terceraCam, segundaCam, camAterrizaje, libreCam;
    int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        cambios();
    }

    public void cambios()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            counter++;
            switch (counter)
            {
                case 1:
                    terceraCam.SetActive(false);
                    camAterrizaje.SetActive(false);
                    libreCam.SetActive(false);
                    segundaCam.SetActive(true);
                    break;
                case 2:
                    terceraCam.SetActive(false);
                    camAterrizaje.SetActive(false);
                    libreCam.SetActive(true);
                    segundaCam.SetActive(false);
                    break;
                case 3:
                    terceraCam.SetActive(false);
                    camAterrizaje.SetActive(true);
                    libreCam.SetActive(false);
                    segundaCam.SetActive(false);
                    break;
                case 4:
                    terceraCam.SetActive(true);
                    camAterrizaje.SetActive(false);
                    libreCam.SetActive(false);
                    segundaCam.SetActive(false);
                    break;
                case 5:
                    counter = 1;
                    break;
            }
        }
    }
}
