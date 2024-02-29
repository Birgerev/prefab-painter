using UnityEngine;
using UnityEditor;
using UnityEngine.Serialization;

namespace PrefabPainter
{
    [System.Serializable]
    public class PaintObject
    {
        public GameObject prefab;
        public Vector2 size = Vector2.one;
        public bool randomRotationX = false;
        public bool randomRotationY = true;
        public bool randomRotationZ = false;
        public string prefabName;
        
        public PaintObject(GameObject prefab)
        {
            this.prefab = prefab;
        }

        public void displaySettings()
        {
            EditorGUILayout.BeginVertical(PrefabPainter.BoxStyle);
            GUILayout.Space(3);

            if (prefabName == "") GUILayout.Label("Prefab Settings", EditorStyles.boldLabel);
            else GUILayout.Label("Prefab Settings - " + prefabName, EditorStyles.boldLabel);

            EditorGUILayout.BeginHorizontal();
            size.x = EditorGUILayout.FloatField("Min Size", size.x);
            size.y = EditorGUILayout.FloatField("", size.y);
            EditorGUILayout.Space();
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            
            EditorGUILayout.Space();
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Random Rotation :");
            randomRotationX = GUILayout.Toggle(randomRotationX, "X");
            randomRotationY = GUILayout.Toggle(randomRotationY, "Y");
            randomRotationZ = GUILayout.Toggle(randomRotationZ, "Z");
            EditorGUILayout.EndHorizontal();

            GUILayout.Space(3);
            EditorGUILayout.EndVertical();
            GUILayout.Space(0);
        }
        
        public void setName(string name)
        {
            prefabName = name;
        }
    }
}