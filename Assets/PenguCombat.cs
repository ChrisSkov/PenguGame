using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguCombat : MonoBehaviour
{
    [SerializeField] public int basicAttackDamage = 20;
    [SerializeField] GameObject overlapCone;
    public bool resetCone = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (resetCone)
        {
            overlapCone.SetActive(false);
            resetCone = false;
        }
    }

    public void AttackAnimEvent()
    {
        overlapCone.SetActive(true);
    }


}
