﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    public bool walkable;
    public Vector3 worldPosition;

    public Node(bool _walkable, Vector3 _WroldPos)
    {
        walkable = _walkable;
        worldPosition = _WroldPos;

    }
}
