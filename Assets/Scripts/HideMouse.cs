using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMouse : MonoBehaviour
{
    public bool hideMouse = true;
    public bool confineMouse = true;

    // Start is called before the first frame update
    void Start()
    {
        if (hideMouse)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (confineMouse)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hideMouse)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (confineMouse)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
