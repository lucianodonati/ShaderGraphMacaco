using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(MeshGenerator))]
    public class MeshGeneratorEditor : UnityEditor.Editor
    {
        private MeshGenerator generator = null;

        private void Awake()
        {
            if (null == generator)
                generator = target as MeshGenerator;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Create Mesh"))
                generator.CreateMesh();
        }
    }
}