using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(MeshRenderer))]
public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToDrop = 3f;
    MeshRenderer thisMeshRenderer;
    Rigidbody thisRigidbody;

    private void Start()
    {
        thisMeshRenderer = GetComponent<MeshRenderer>();
        thisRigidbody = GetComponent<Rigidbody>();
        thisRigidbody.useGravity = false;
        thisMeshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeToDrop)
        {
            thisRigidbody.useGravity = true;
            thisMeshRenderer.enabled = true;
        }
    }
}
