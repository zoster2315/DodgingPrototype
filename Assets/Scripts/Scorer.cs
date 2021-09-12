using UnityEngine;

public class Scorer : MonoBehaviour
{
    int HitCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit") && !collision.gameObject.CompareTag("Ground"))
        {
            HitCount++;
            Debug.LogFormat("Bumped something {0} times!", HitCount);
        }
    }
}
