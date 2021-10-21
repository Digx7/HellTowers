// Digx7
// Acts as a health system for what ever you want
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectHealth : MonoBehaviour {

    [Header("Health")]
    [Tooltip("This is the objects current health")]
    [SerializeField] private int currentHealth = 100;

    [Tooltip("This is the objects players health")]
    [SerializeField] private int maxHealth = 100;

    [Tooltip("This is the objects players health.  If the current health ever equals this the player will die")]
    [SerializeField] private int minHealth = 0;

    [SerializeField] private bool isInvincible = false;

    [Tooltip("List all the GameObject tags of objects that can alter the health of this gameObject")]
    [SerializeField] private List<string> tagsThatCanAffectObjectsHealth;

    [Header("Events")]
    [SerializeField] private IntEvent healthIncrease;

    [SerializeField] private IntEvent healthDecrease;
    [SerializeField] private UnityEvent objectDeath;

    [SerializeField] private IntEvent _maxHealth;
    [SerializeField] private IntEvent _currentHealth;

    // --- Main ------------------------------------------------------

    public void Awake(){
      _maxHealth.Invoke(maxHealth);
      _currentHealth.Invoke(currentHealth);
    }

    // Sets the currentHealth to the given input
    public void setCurrentHealth(int input) {
        currentHealth = input;
        Debug.Log("The objects currentHealth was set to " + input);
    }

    public bool canThisObjectDamageMe(Collision col) {
        foreach (string _tag in tagsThatCanAffectObjectsHealth) {
            if (col.gameObject.tag == _tag) return true;
        }
        return false;
    }

    public bool canThisObjectDamageMe_Collider(Collider col) {
        foreach (string _tag in tagsThatCanAffectObjectsHealth) {
            if (col.gameObject.tag == _tag) return true;
        }
        return false;
    }

    // Adds the given input to the currentHealth
    public void updateCurrentHealth(int input) {
        if(!isInvincible) {
          currentHealth += input;
          Debug.Log("Something changed the objects currentHealth by " + input + " units");

          if (input > 0) healthIncrease.Invoke(currentHealth);
          if (input < 0) healthDecrease.Invoke(currentHealth);

          if (isObjectDead()) Death();
        }
    }

    // Returns true if the currentHealth is less than or equal to the minHealth
    public bool isObjectDead() {
        if (currentHealth <= minHealth) return true;
        else return false;
    }

    public void setIsInvincible(bool input) {
      isInvincible = input;
    }

    // Will kill the player
    public void Death() {
      objectDeath.Invoke();
      Debug.Log("Object has died");
    }

    public void ResetHealth() {
      currentHealth = maxHealth;
    }

    // --- Collisions --------------------------------------------

    public void OnCollisionEnter(Collision col) {
        Debug.Log("Object touched something");

        if (col.gameObject.GetComponent<HealthChange>() != null && canThisObjectDamageMe(col)) {
            //updateCurrentHealth(col.gameObject.GetComponent<HealthChange>().units);
        } else {
            Debug.Log("This object does not have a damage script attached");
        }
    }

    // Triggers when the player collides with a trigger
    public void OnTriggerEnter(Collider col) {
        Debug.Log("Object touched something");

        if (col.gameObject.GetComponent<HealthChange>() != null && canThisObjectDamageMe_Collider(col)) {
            //updateCurrentHealth(col.gameObject.GetComponent<HealthChange>().units);
            if (isObjectDead()) Death();
        } else {
            Debug.Log("This object does not have a damage script attached");
        }
    }
}
