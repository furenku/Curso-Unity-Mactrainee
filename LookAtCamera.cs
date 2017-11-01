using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : CameraScript {

	void LateUpdate() {
		transform.LookAt(target.transform);
	}

}
