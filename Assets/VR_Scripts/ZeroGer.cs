using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGer : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision obj)
    {
        obj.collider.attachedRigidbody.useGravity = false;
    }
}
