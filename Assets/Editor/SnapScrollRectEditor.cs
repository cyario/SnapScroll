using UnityEngine;
using UnityEditor;

[CustomEditor( typeof(SnapScrollRect))]
public sealed class SnapScrollRectEditor : Editor {

	public override void OnInspectorGUI(){
		DrawDefaultInspector ();
	}
}