using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform PlayerTransform;
    private void Update()
    {
        transform.position = new Vector3(PlayerTransform.position.x, 0, transform.position.z);
    }
}
