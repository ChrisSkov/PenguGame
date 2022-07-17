using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SwapToRegularCam : MonoBehaviour
{
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
        playerCam.Priority = 12;
    }

    public void SetPriorityDown()
    {
        playerCam.Priority = 8;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!playerCam.gameObject.activeSelf)
            {
                foreach (GameObject virtualCam in GameObject.FindGameObjectsWithTag("CineCam"))
                {
                    virtualCam.SetActive(false);
                }
                playerCam.gameObject.SetActive(true);
            }
        }
    }
}
