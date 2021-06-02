using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we add the next line so that we can find the classes associated with ARFoundation
using UnityEngine.XR.ARFoundation;

public class SpawnItems : MonoBehaviour
{
    //now we declare the variables
    //reference to the ARRaycastManager in the inspector, which will handle the raycasting
    //towards the trackable features. 
    public ARRaycastManager m_ARRaycastManager;

    //prefab for the spawnedObject (we will have to create a list of objects - because of the furniture options)
    public GameObject m_spawnableObjectPrefab;

    //pose: representation of a position and a rotation in 3D Space
    Pose m_placementPose;

    //a temporary variable to hold the recently spawned object
    GameObject m_spawnedObject = null;

    // Start is called before the first frame update
    void Start()
    {
        //we set the value of spawnedObject to null 
        m_spawnedObject = null;
    }

    // Update is called once per frame
    void Update()
    {
        //we will start to implement the functionality for the spawning of objects
        //we will check for touch input, if there arent any, we will return 
        if (Input.touchCount == 0)
            return;

        //if there is a touch event then get the touch position
        var touchPt = Input.GetTouch(0).position;

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        //do a raycast using the ARRaycastManager to get the hits
        //raycast against trackables (detected features in the physical environment)
        //when they do not have presence in the physics world 
        m_ARRaycastManager.Raycast(touchPt, hits);
        if (hits.Count == 0)
            return;

        m_placementPose = hits[0].pose;
        //if there is a hit with trackable features, then we keep the reference to the Pose
        if(Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //we call the spawn function 
            Spawn(m_placementPose.position);
        }
        //if there is a TouchPhase.Moved event and the spawnedObject is not null then reposition the
        //object based on user touch input
        else if (Input.GetTouch(0).phase == TouchPhase.Moved && m_spawnedObject != null)
        {
            //move the object
            m_spawnedObject.transform.position = m_placementPose.position;
        }
        //if the TouchPhase has ended, then resent the m_spawnedObject to null so that we can 
        //handle a new spawned object
        if(Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            m_spawnedObject = null;
        }
    }

    //now we will implement the spawn method 
    void Spawn(Vector3 position)
    {
        m_spawnedObject = Instantiate(m_spawnableObjectPrefab, position, Quaternion.identity);
    }
}
