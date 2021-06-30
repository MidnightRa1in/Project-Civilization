using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private Camera camera;

    [SerializeField]
    private SpriteRenderer mapRenderer;

    [SerializeField]
    private float zoomStep, minCamSize, maxCamSize;

    private Vector3 dragOriginPos;
    private Vector3 cameraOriPos;
    private float mapMinX, mapMaxX, mapMinY, mapMaxY;
    private float cameraOriSize;
    private int zoomOpt;

    // Start is called before the first frame update
    private void Awake()
    {
        zoomOpt = 1;
        cameraOriPos = camera.transform.position;
        cameraOriSize = camera.orthographicSize;
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;

        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
    }


    // Update is called once per frame
    private void Update()
    {
        if (camera.orthographicSize < 95)
            Move();
       // ZoomCamera();
    }

    public void ZoomIn()
    {
        float newSize = camera.orthographicSize - zoomStep;

        camera.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
    }

    public void ZoomOut()
    {
        camera.transform.position = cameraOriPos;
        camera.orthographicSize = cameraOriSize;
    }

    public void ZoomCamera()
    {
        if (zoomOpt < 0)
        {
            ZoomOut();
        }

        else if (zoomOpt > 0)
        {
            ZoomIn();
        }

        zoomOpt *= -1;
    }

    private Vector3 ClampCamera(Vector3 targetPos)
    {
        float camHeight = camera.orthographicSize;
        float camWidth = camera.orthographicSize * camera.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;

        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPos.x, minX, maxX);
        float newY = Mathf.Clamp(targetPos.y, minY, maxY);

        return new Vector3(newX, newY, targetPos.z);
    }

    private void Move()
    {
        if (Input.GetMouseButtonDown(0))
            dragOriginPos = camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Vector3 diff = dragOriginPos - camera.ScreenToWorldPoint(Input.mousePosition);

            camera.transform.position = ClampCamera(camera.transform.position + diff);
        }
    }

}
