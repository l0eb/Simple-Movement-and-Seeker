using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour {

    public Transform TargetTransform;
    public float speed = 7;
    void Update() {
        Vector3 Displacement = TargetTransform.position - transform.position;
        Vector3 Direction = Displacement.normalized;
        Vector3 velocity = Direction * speed;
        float distance = Displacement.magnitude;
        if (distance > 1.5f) {
            transform.Translate(velocity * Time.deltaTime);
        }
    }
}
