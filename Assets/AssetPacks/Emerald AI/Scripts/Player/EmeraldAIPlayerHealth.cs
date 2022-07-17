using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using EmeraldAI.CharacterController;

namespace EmeraldAI.Example
{
    /// <summary>
    /// An example health script that the EmeraldAIPlayerDamage script calls.
    /// Various events can be created and used to cause damage to a 3rd party character controllers via the inspector.
    /// You can also edit the EmeraldAIPlayerDamage script directly and add custom functions.
    /// </summary>
    public class EmeraldAIPlayerHealth : MonoBehaviour
    {
        public Image healthOrbImage;
        public float CurrentHealth = 100; [Space]
        public UnityEvent DamageEvent;
        public UnityEvent DeathEvent;
        public GameObject bloodPrefab;
        public Transform bloodPos;

        public Text healthText;
        [HideInInspector]
        public float StartingHealth;

        private void Start()
        {
            StartingHealth = CurrentHealth;
            healthOrbImage.fillAmount = StartingHealth;
            UpdateHPText();
        }

        public void DamagePlayer(int DamageAmount)
        {
            CurrentHealth -= DamageAmount;
            DamageEvent.Invoke();

            if (CurrentHealth <= 0)
            {
                PlayerDeath();
            }
            float newHealth = CurrentHealth / StartingHealth;
            healthOrbImage.fillAmount = newHealth;

        }

        public void PlayerDeath()
        {
            DeathEvent.Invoke();
        }

        public void SpawnBlood()
        {
            GameObject clone = Instantiate(bloodPrefab, bloodPos.position, bloodPos.rotation);
            Destroy(clone, 0.4f);
        }

        public void UpdateHPText()
        {
            healthText.text = CurrentHealth.ToString() + "/" + StartingHealth.ToString();
        }
    }
}
