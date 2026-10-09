using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public CameraManager cameraManager;
    public int cameraNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cameraManager.SwitchCamera(cameraNumber);
        }
    }
}