using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterMe : MonoBehaviour
{
    [SerializeField] GameObject organs;
    [SerializeField] GameObject bloodVFX;
    [SerializeField] Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBloodAndGore()
    {
        GameObject organsClone = Instantiate(organs, spawnPos.position, spawnPos.rotation);
        GameObject bloodVFXClone = Instantiate(bloodVFX, spawnPos.position, spawnPos.rotation);
    }
}
