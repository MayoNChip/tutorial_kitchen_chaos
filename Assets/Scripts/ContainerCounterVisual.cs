using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounterAnimator : MonoBehaviour {
    // Start is called before the first frame update

    private const string OPEN_CLOSE = "OpenClose";
    [SerializeField] private ContainerCounter ContainerCounter;
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Start() {
        ContainerCounter.OnPlayerGrabbedObject += ContainerCounter_OnPlayerGrabbedObject;
    }

    private void ContainerCounter_OnPlayerGrabbedObject(object sender, System.EventArgs e) {
        animator.SetTrigger(OPEN_CLOSE);
    }
}
