using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ARController : MonoBehaviour
{
    [SerializeField] private ARRaycastManager raycastManager;
    [SerializeField] private GameObject objectToPlace;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount <= 0) return;
        var touch = Input.GetTouch(index: 0);
        if (touch.phase != TouchPhase.Began) return;
        if (!raycastManager.Raycast(touch.position, hits, trackableTypes: TrackableType.PlaneWithinPolygon)) return;
        var hitpose = hits[0].pose;
        Instantiate(objectToPlace, hitpose.position, hitpose.rotation);
    }
}