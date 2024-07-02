using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {
    public Transform prefab;
    public Sprite sprite;
    public string objectName;

    private ClearCounter clearCounter;

    public KitchenObjectSO GetKitchenObjectSO() {
        return this;
    }

    public void SetClearCounter(ClearCounter clearCounter) {
        if (this.clearCounter != null) {
            this.clearCounter.ClearKitchenObject();
        }
    }

    public ClearCounter GetClearCounter() {
        return clearCounter;
    }
}
