using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 goalPosition;

    private Quaternion startRotation;
    private Quaternion goalRotation;

    public Quaternion Rotation
    {
        get
        {
            return transform.rotation;
        }
    }

    public Quaternion HorizontalRotation
    {
        get
        {
            //TODO convert rotation to horizontal rotaion
            return transform.rotation;
        }
    }

    void LateUpdate()
    {
    }

    private void UpdatePosition()
    {
    }

    private void UpdateRotation()
    {
    }
}
