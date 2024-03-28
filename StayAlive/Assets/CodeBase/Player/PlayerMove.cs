using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Camera _camera;
    private IInputService _inputService;

    private void Awake()
    {
        _inputService = IInputService; // нужно записать во все сервисы
    }

    private void Start()
    {
        _camera = Camera.main;
    }
    
}

internal interface IInputService
{
    
}
