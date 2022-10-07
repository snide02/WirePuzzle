using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject startWaypoint;
    public GameObject endWaypoint;

    public float desiredDuration;
    public float elapsedTime;

    public bool move = false;

    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveCamera();
    }

    public void moveCamera()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;
        transform.position = Vector3.Lerp(startWaypoint.transform.position, endWaypoint.transform.position, curve.Evaluate(percentageComplete));
    }
}
