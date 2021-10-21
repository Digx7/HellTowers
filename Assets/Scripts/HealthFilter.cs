// Digx7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthFilter : MonoBehaviour
{
    [SerializeField] private int lethalModifier = 1;
    [SerializeField] private int angerModifier = 1;
    [SerializeField] private int hoplessModifier = 1;
    [SerializeField] private int insecureModifier = 1;
    [SerializeField] private int frustratedModifier = 1;
    [SerializeField] private int calmModifier = 1;
    [SerializeField] private int reassureModifier = 1;
    [SerializeField] private int complimentModifier = 1;
    [SerializeField] private int silenceModifier = 1;

    [SerializeField] private IntEvent AmountToChangeHealthBy;

    public void ProcessHealthChange(Collision2D col){
      if(col.gameObject.GetComponent<HealthChange>() != null) AmountToChangeHealthBy.Invoke(calculateDamage(col.gameObject.GetComponent<HealthChange>()));
    }

    public void ProcessHealthChange(Collider2D col){
      if(col.gameObject.GetComponent<HealthChange>() != null) AmountToChangeHealthBy.Invoke(calculateDamage(col.gameObject.GetComponent<HealthChange>()));
    }

    private int calculateDamage(HealthChange input){
      int output = 0;
      output += input.lethalDamage * lethalModifier;
      output += input.angerDamage * angerModifier;
      output += input.hoplessDamage * hoplessModifier;
      output += input.insecureDamage * insecureModifier;
      output += input.frustratedDamage * frustratedModifier;
      output += input.calmDamage * calmModifier;
      output += input.reassureDamage * reassureModifier;
      output += input.complimentDamage * complimentModifier;
      output += input.silenceDamage * silenceModifier;
      return output;
    }

}
