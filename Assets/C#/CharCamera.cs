using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCamera : MonoBehaviour
{
    [SerializeField] private Transform person;
    private Transform cameraTransform;

    private void Awake()
    {
        cameraTransform = GetComponent<Transform>();
    }
    private void Update()
    {

        FolowCamera();
    }
    private void FolowCamera()
    {
        cameraTransform.position = Vector2.Lerp(cameraTransform.position, person.position, Time.deltaTime);
        cameraTransform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, -10);
    }
}
