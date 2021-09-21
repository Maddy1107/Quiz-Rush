﻿using UnityEngine;

public class LetterBlockScript : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        transform.Rotate(new Vector3(0, speed, 0), Space.Self);
    }
}
