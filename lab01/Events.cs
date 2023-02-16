// Docs: https://docs.unity3d.com/560/Documentation/Manual/EventFunctions.html
// https://docs.unity3d.com/Manual/class-MonoBehaviour.html




using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

void Update() {
    float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * distance);
}


void FixedUpdate() {
    Vector3 force = transform.forward * driveForce * Input.GetAxis("Vertical");
    rigidbody.AddForce(force);
}


void LateUpdate() {
    Camera.main.transform.LookAt(target.transform);
}



void OnGUI() {
    GUI.Label(labelRect, "Game Over");
}




void OnCollisionEnter(otherObj: Collision) {
    if (otherObj.tag == "Arrow") {
        ApplyDamage(10);
    }
}
}