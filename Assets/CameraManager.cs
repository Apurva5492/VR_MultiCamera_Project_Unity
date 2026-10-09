using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera[] cameras;

    void Start()
    {
        SwitchCamera(0);
    }

    public void SwitchCamera(int cameraIndex)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == cameraIndex);
        }
    }
}
