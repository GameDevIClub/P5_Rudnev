using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChestInentory : InventoryHolder, IInteractable
{
    public UnityAction<IInteractable> OnItneractionComplete { get; set; }

    public void Interact(Interactor interactor, out bool interactSuccessful)
    {
        OnDynamicInventoryDisplayRequested?.Invoke(inventorySystem);
        interactSuccessful = true;
    }

    public void EndInteractaion()
    {

    }
}
