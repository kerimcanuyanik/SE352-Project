using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public Transform LookAt;
    public Transform CamTransform;

    private Camera cam;
    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 5.0f;
    private float sensivityY = 1.0f;
    private const float yAngleMin = 0.0f;
    private const float yAngleMax = 45.0f;

	// Use this for initialization
	void Start () {

        CamTransform = transform;
        cam = Camera.main;
	}

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, yAngleMin, yAngleMax);
    }

    private void LateUpdate()
    {
        Vector3 direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        CamTransform.position = LookAt.position + (rotation * direction);
        CamTransform.LookAt(LookAt.position);
    }


}
