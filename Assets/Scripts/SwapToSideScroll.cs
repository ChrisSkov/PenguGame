using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SwapToSideScroll : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera vCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPriorityUp()
    {
        vCam.Priority = 12;
    }

    public void SetPriorityDown()
    {
        vCam.Priority = 8;
    }

    private void OnTriggerEnter(Collider other)
    {
        SetPriorityUp();
    }
}
