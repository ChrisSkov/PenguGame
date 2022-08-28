using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PickMeUp : MonoBehaviour
{

    public UnityEvent onPickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
            return;
        onPickUp.Invoke();
        Destroy(transform.parent.gameObject, 0.3f);
    }
}
