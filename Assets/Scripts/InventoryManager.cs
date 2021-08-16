using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private bool isOn = false;

    [SerializeField] private GameObject inventory;
    [SerializeField] private List<ComboInteraction> combosAvailable;

    [SerializeField] private BoolEvent onState;

    public void Awake(){
      setUpInventory();
    }

    public void toggleIsOn(){
      isOn = !isOn;
      onState.Invoke(isOn);
      setComboIsOnState(isOn);
    }

    private void setUpInventory(){
      foreach(Transform item in inventory.transform){
        if(item.TryGetComponent(out ComboInteraction combo))
          combosAvailable.Add(item.GetComponent<ComboInteraction>());
      }
      setComboIsOnState(false);
    }

    private void setComboIsOnState(bool input){
      foreach(ComboInteraction combo in combosAvailable) combo.turnOnOff(input);
    }
}
