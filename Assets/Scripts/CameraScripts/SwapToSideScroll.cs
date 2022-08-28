using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SwapToSideScroll : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera vCam;
    [SerializeField] CinemachineFreeLook playerCam;
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
        if (other.gameObject.CompareTag("Player"))
        {
            playerCam.gameObject.SetActive(false);

            foreach (GameObject virtualCam in GameObject.FindGameObjectsWithTag("CineCam"))
            {
                virtualCam.SetActive(false);
            }

            vCam.gameObject.SetActive(true);
        }
    }
}
