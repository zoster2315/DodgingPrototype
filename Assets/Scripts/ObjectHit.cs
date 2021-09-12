using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ObjectHit : MonoBehaviour
{
    [SerializeField] string PlayerTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(PlayerTag))
        {
            //Debug.LogFormat("{0} bumpt into the wholl", PlayerTag);
            var meshRender = GetComponent<MeshRenderer>();
            meshRender.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
