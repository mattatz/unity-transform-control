using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mattatz.TransformControl.Demo {

	public class TransformDisplay : MonoBehaviour {

		[SerializeField] Transform target;
		[SerializeField] XYZLabel positionLabel;
		[SerializeField] XYZLabel rotationLabel;
		[SerializeField] XYZLabel scaleLabel;

		void Update () {
			positionLabel.SetXYZ(target.transform.position);
			rotationLabel.SetXYZ(target.transform.rotation.eulerAngles);
			scaleLabel.SetXYZ(target.transform.localScale);
		}

	}
		
}

