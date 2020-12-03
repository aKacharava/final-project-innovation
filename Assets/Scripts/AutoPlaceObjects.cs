using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class AutoPlaceObjects : MonoBehaviour
{
    ///ARRaycastManager raycastManager;
    [SerializeField]
    ARPlaneManager arPlaneManager;

    [SerializeField]
    GameObject spawnedObject;

    private void Awake()
    {
        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneUpdate;
    }

    private void PlaneUpdate(ARPlanesChangedEventArgs args)
    {
        if (args.added != null)
        {
            ARPlane arPlane = args.added[0];
            Instantiate(spawnedObject, arPlane.transform.position, Quaternion.identity);
        }
    }
}