using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent {

    [SerializeField] private Transform counterTopPoint;

    private KitchenObject kitchenObject;


    public virtual void Interact(Player player) {
        Debug.LogError("BaseCounter.Interact() was not implemented");
    }

    public void ClearKitchenObject() {
        kitchenObject = null;
    }

    public Transform GetKitchenObjectFollowTransform() {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject) {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject() {
        return kitchenObject;
    }

    public bool HasKitchenObject() {
        return kitchenObject != null;
    }

}
