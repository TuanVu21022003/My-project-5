using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCamera;
    public float zoomSpeed = 1f; // Tốc độ phóng to
    public float maxZoom = 3f; // Khoảng cách tối đa để phóng to

    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private bool isMoving = false;
    void Start()
    {
        originalPosition = mainCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCameraForward()
    {
        if (!isMoving)
        {
            // Tính toán vị trí mục tiêu
            targetPosition = mainCamera.transform.position + mainCamera.transform.forward * 3f;
            // Bắt đầu coroutine để di chuyển Camera
            StartCoroutine(MoveCameraCoroutine());
        }
    }

    IEnumerator MoveCameraCoroutine()
    {
        isMoving = true;
        float t = 0f;
        Vector3 startingPosition = mainCamera.transform.position;

        // Di chuyển Camera từ vị trí hiện tại đến vị trí mục tiêu
        while (t < 1f)
        {
            t += Time.deltaTime * zoomSpeed;
            mainCamera.transform.position = Vector3.Lerp(startingPosition, targetPosition, t);
            yield return null;
        }

        // Đảm bảo Camera không phóng to quá maxZoom
        if ((targetPosition - originalPosition).magnitude > maxZoom)
        {
            mainCamera.transform.position = targetPosition;
        }

        isMoving = false;
    }
}
