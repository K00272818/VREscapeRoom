using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CorrectItem : MonoBehaviour
{

    public GameObject objectToBeDestroyed;
    public GameObject objectToAppear;
    public GameObject correctObject;

    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        GameObject placedObject = interactor.selectTarget.gameObject;

        if (placedObject == correctObject)
        {
            objectToBeDestroyed.SetActive(false);
            objectToAppear.SetActive(true);
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
