using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCouterVisual : MonoBehaviour {

    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] gameObjectsArray;
    private void Start() {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e) {
        if (e.selectedCounter == baseCounter) {
            Show();
        }
        else {
            Hide();
        }
    }

    private void Show() {
        foreach (GameObject visual in gameObjectsArray) {
            visual.SetActive(true);
        }
    }
    private void Hide() {
        foreach (GameObject visual in gameObjectsArray) {
            visual.SetActive(false);
        }
    }
}
