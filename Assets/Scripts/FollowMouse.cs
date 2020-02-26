using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float speedOfRotation = -5.0f;

    public float distanceFromCamera = 1.0f;
    void Start()
    {

    }
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distanceFromCamera;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(StartRotation());
        }
    }
    private IEnumerator StartRotation()
    {
        transform.Rotate(0, 0, speedOfRotation);
        yield return new WaitForSeconds(0.2f);
        transform.rotation = Quaternion.Euler(2.381f, -98.83401f, -36.157f);
    }
}
