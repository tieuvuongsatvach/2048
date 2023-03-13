using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : Node
{
    public int Value { get; private set; }
    public Node Node { get; private set; }
    public Block MergingBlock { get; private set; }
    public bool Merging { get; private set; }

    public Vector2 blockPos => transform.position;
    [SerializeField] private SpriteRenderer rend;
    [SerializeField] private TextMeshPro text;

    public void Init(BlockType type)
    {
        Value = type.Value;
        rend.color = type.Color;
        text.text = type.Value.ToString();
    }

    public void SetBlock(Node node)
    {
        if (Node != null) Node.SetOccupiedBlock(null);
        Node = node;
        Node.SetOccupiedBlock(this);
    }

    public void MergeBlock(Block blockToMergeWith)
    {
        MergingBlock = blockToMergeWith;

        Node.SetOccupiedBlock(null);

        blockToMergeWith.Merging = true;
    }

    public bool CanMerge(int value) => value == Value && !Merging && MergingBlock == null;
}