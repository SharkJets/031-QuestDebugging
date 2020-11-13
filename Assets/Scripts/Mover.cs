using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Mover : MonoBehaviour
{
    private InputDevice _device;
    private CharacterController _character;
    private Vector2 _inputAxis;

    private void Start()
    {
        _device = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        _character = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _device.TryGetFeatureValue(CommonUsages.primary2DAxis, out _inputAxis);
        _character.Move(new Vector3(_inputAxis.x, 0, _inputAxis.y) * Time.deltaTime * 1f);
    }
}
