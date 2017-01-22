using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

namespace mattatz.TransformControl.Demo {

	public class XYZLabel : MonoBehaviour {

		[SerializeField] Text xLabel;
		[SerializeField] Text yLabel;
		[SerializeField] Text zLabel;

		public void SetXYZ (Vector3 v) {
			SetXYZ(v.x, v.y, v.z);
		}

		public void SetXYZ (float x, float y, float z) {
			xLabel.text = x.ToString("0.00");
			yLabel.text = y.ToString("0.00");
			zLabel.text = z.ToString("0.00");
		}

	}
		
}

