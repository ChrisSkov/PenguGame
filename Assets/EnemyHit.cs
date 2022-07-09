using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI;
public class EnemyHit : MonoBehaviour
{
    PenguCombat combat;
    public Transform playerTransform;
    public int ragdollforce = 100;
    // Start is called before the first frame update
    void Start()
    {
        combat = GetComponentInParent<PenguCombat>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EmeraldAISystem>() != null)
        {
            other.gameObject.GetComponent<EmeraldAISystem>().Damage(combat.basicAttackDamage, EmeraldAISystem.TargetType.Player, playerTransform, ragdollforce);
        }
        combat.resetCone = true;
    }
}


