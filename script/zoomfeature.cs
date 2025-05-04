using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlanetInteraction : MonoBehaviour
{
    public GameObject planetPrefab;
    private GameObject placedPlanet;

    private bool isMarked = false;
    private float previousPinchDistance = 0f;

    private ARRaycastManager arRaycastManager;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake()
    {
        arRaycastManager = FindObjectOfType<ARRaycastManager>();
    }

    void Update()
    {
        HandleTapToPlace();
        HandlePinchToZoom();
    }

    void HandleTapToPlace()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began && !isMarked)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;

            if (arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;

                if (placedPlanet == null)
                {
                    placedPlanet = Instantiate(planetPrefab, hitPose.position, hitPose.rotation);
                }
                else
                {
                    placedPlanet.transform.position = hitPose.position;
                }

                isMarked = true; // Lock the placement
            }
        }
    }

    void HandlePinchToZoom()
    {
        if (!isMarked || placedPlanet == null) return;

        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            float currentDistance = Vector2.Distance(touch0.position, touch1.position);

            if (previousPinchDistance == 0)
            {
                previousPinchDistance = currentDistance;
                return;
            }

            float delta = currentDistance - previousPinchDistance;
            float scaleFactor = 0.001f;

            Vector3 newScale = placedPlanet.transform.localScale + Vector3.one * delta * scaleFactor;
            newScale = Vector3.Max(Vector3.one * 0.1f, Vector3.Min(newScale, Vector3.one * 5f));

            placedPlanet.transform.localScale = newScale;
            previousPinchDistance = currentDistance;
        }
        else
        {
            previousPinchDistance = 0f;
        }
    }
}

