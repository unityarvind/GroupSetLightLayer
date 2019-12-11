using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GroupSetLightLayer))]
[CanEditMultipleObjects]
public class GroupSetLightLayerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GroupSetLightLayer groupSetLightLayer = (GroupSetLightLayer) target;

        if (GUILayout.Button("Set LightLayer To Children"))
        {
            groupSetLightLayer.SetLightLayerToChildren();
        }
    }
}
