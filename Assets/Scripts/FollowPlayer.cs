using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 cameraOffset;
    private Vector3 backOffset = new Vector3(0, 5, -7);
    private Vector3 frontOffset = new Vector3(0, 2, 1);
    private bool frontCamera = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CheckForCameraModeChange();
        SetToPlayerPosition();   
    }

    private void CheckForCameraModeChange()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            frontCamera = !frontCamera;
        }
    }

    private void SetToPlayerPosition()
    {
        SetCameraOffset();
        transform.position = player.transform.position + cameraOffset;
    }

    private void SetCameraOffset()
    {
        if (frontCamera)
        {
            cameraOffset = frontOffset;
        }
        else
        {
            cameraOffset = backOffset;
        }
    }
}
