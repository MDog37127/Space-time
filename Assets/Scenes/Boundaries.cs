using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 Screenn;
    public Camera MainCamera;
    private float Width;
    private float Height;
    // Start is called before the first frame update
    void Start()
    {
        Screenn = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, Screenn.x, Screenn.x * -1);
        viewPos.y = Mathf.Clamp(viewPos.y, Screenn.y, Screenn.y * -1);
        transform.position = viewPos;
    }
}
