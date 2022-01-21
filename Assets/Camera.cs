using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    private float EffectMultiplier;
    public GameObject Camera1;
    private Transform CTransform;
    private Vector3 CameraLast;
    // Start is called before the first frame update
    private void Start()
    {
        CTransform = Camera1.transform;
        CameraLast = CTransform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 deltaMovment = CTransform.position - CameraLast;
        transform.position += deltaMovment * EffectMultiplier;
        CameraLast = CTransform.position;
    }
}
