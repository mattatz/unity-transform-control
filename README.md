unity-transform-control
=================

Transform controller in Game View for Unity.

![translate](https://raw.githubusercontent.com/mattatz/unity-transform-control/master/Captures/translate.gif)
![rotate](https://raw.githubusercontent.com/mattatz/unity-transform-control/master/Captures/rotate.gif)
![scale](https://raw.githubusercontent.com/mattatz/unity-transform-control/master/Captures/scale.gif)

## Usage

```cs

// 1. Attatch TranformControl to target GameObject.
GameObject target;

void Update () {
    // 2. Call TranformControl.Control() method in Update() loop.
    TranformControl tc = target.GetComponent<TransformControl>();
    tc.Control();
}

```
