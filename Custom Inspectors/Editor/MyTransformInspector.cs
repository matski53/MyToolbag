﻿using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Transform), true)]
public class MyTransformInspector : Editor
{
    Transform transform;

    public override void OnInspectorGUI()
    {
        if(transform == null)
            transform = (Transform) target;

        base.OnInspectorGUI();

        GUILayout.BeginHorizontal();
        {
            if (GUILayout.Button("Zero Position"))
            {
                transform.position = Vector3.zero;
            }
            if (GUILayout.Button("Snap To Int"))
            {
                transform.position = new Vector3(transform.position.x.RoundTo(0), transform.position.y.RoundTo(0), transform.position.z.RoundTo(0));
            }
            if (GUILayout.Button("Snap To Int 2D"))
            {
                transform.position = new Vector3(transform.position.x.RoundTo(0), transform.position.y.RoundTo(0), transform.position.z);
            }
            if (GUILayout.Button("Snap To 0.5"))
            {
                transform.position = new Vector3(transform.position.x.RoundToNearest(0.5f), transform.position.y.RoundToNearest(0.5f), transform.position.z);
            }
        }
        GUILayout.EndHorizontal();
    }
}


