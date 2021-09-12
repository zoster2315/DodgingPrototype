using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rottationSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rottationSpeed * Time.deltaTime);
    }
}
