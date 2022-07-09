using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{

    [SerializeField] GameObject fartCloud;
    [SerializeField] Transform effectSpawnTransform;
    [SerializeField] PenguCombat combat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnFartCloud()
    {
        GameObject clone = Instantiate(fartCloud, effectSpawnTransform.position, effectSpawnTransform.rotation);
        Destroy(clone, 0.5f);
    }

    public void BasicAttackAnimEvent()
    {
        combat.AttackAnimEvent();
    }
}
