using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CorrectCandleCell : MonoBehaviour
{

    public GameObject bars;
    public GameObject correctCandle;

    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        // Get the object that was placed on the socket
        GameObject placedObject = interactor.selectTarget.gameObject;

        // Check if the placed object is the correct candle
        if (placedObject == correctCandle)
        {
            // Hide the bars object
            bars.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
