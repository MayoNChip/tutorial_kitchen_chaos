using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter {
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public event EventHandler OnPlayerGrabbedObject;

    public override void Interact(Player player) {
        Debug.Log(HasKitchenObject());
        if (!HasKitchenObject() && !player.HasKitchenObject()) {
            // player is not carrying anything
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
        else if (HasKitchenObject() && !player.HasKitchenObject()) {
            // player is carrying something
            GetKitchenObject().SetKitchenObjectParent(player);
        }
        else {
            player.GetKitchenObject().SetKitchenObjectParent(this);
        }
    }



}
