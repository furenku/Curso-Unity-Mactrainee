using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCamera : CameraScript {

    Vector3 offset;

		void Awake() {
			offset = transform.position - target.transform.position;
		}

		void LateUpdate() {
	    Vector3 desiredPosition = target.transform.position + offset;
	    transform.position = desiredPosition;
		}

    // void LateUpdate() {
    //     Vector3 desiredPosition = target.transform.position + offset;
    //     Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
    //     transform.position = position;
		//
    //     transform.LookAt(target.transform.position);
    // }

}
