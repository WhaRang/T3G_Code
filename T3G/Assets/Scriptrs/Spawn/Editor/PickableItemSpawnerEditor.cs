using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(PickableItemSpawner))]
public class PickableItemSpawnerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.Space();

        PickableItemSpawner component = target as PickableItemSpawner;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Spawn item"))
        {
            if (Application.isPlaying)
                component.SpawnPickableItem();
        }

        if (GUILayout.Button("Despawn All Items"))
        {
            if (Application.isPlaying)
            {
                component.DespawnAllItems();
            }
        }

        GUILayout.EndHorizontal();
    }
}
