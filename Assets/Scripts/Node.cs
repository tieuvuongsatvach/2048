using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Vector2 nodePos => transform.position;

    public Block OccupiedBlock { get; private set; }

    public void SetOccupiedBlock(Block value)
    {
        OccupiedBlock = value;
    }
}
