using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mattatz.TransformControl.Demo {

	public class TransformControlUI : MonoBehaviour {

		[SerializeField] TransformControl control;

        void Update() {
            control.Control();
        }

		public void OnModeChanged(int index) {
			switch(index) {
			case 0:
				control.mode = TransformControl.TransformMode.Translate;
				break;
			case 1:
				control.mode = TransformControl.TransformMode.Rotate;
				break;
			case 2:
				control.mode = TransformControl.TransformMode.Scale;
				break;
			}
		}

		public void OnCoordinateChanged(int index) {
			switch(index) {
			case 0:
				control.global = false;
				break;
			case 1:
				control.global = true;
				break;
			}
		}

	}

}
