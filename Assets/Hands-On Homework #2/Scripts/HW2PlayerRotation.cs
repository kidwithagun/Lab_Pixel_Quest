using UnityEngine;

public class HW2PlayerRotation : MonoBehaviour
{
    private Camera _cam;

    private string CameraName = "Game_Camera";

    private Vector3 _mousePos;

    private void Start()
    {
        _cam = GameObject.Find(CameraName).GetComponent<Camera>();
    }

    private void Update()
    {
        //Get the player's mouse position
        _mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

        //Calculate the difference between the mouse and player positions
        Vector3 pos = _mousePos - transform.position;

        //Calculate the angle difference
        float rotZ = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        //Save the difference into the player's transform rotation
        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90);
    }
}
