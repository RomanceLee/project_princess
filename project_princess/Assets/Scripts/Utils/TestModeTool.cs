using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
public class TestModeTool : EditorWindow 
{
	[ MenuItem ( "Dev/TestModeTool" ) ]
	public static void UseTestMode()
	{
		EditorWindow.GetWindow( typeof ( TestModeTool ) );
	}

	void OnGUI()
	{
		EditorGUILayout.BeginHorizontal ();
		GUILayout.Label ( "[TimeScale]" );
		if ( GUILayout.Button ( "x0.2" ) ) { ChangeGameTimeScale ( 0.2f ); }
		if ( GUILayout.Button ( "x0.5" ) ) { ChangeGameTimeScale ( 0.5f ); }
		if ( GUILayout.Button ( "x1" ) ) { ChangeGameTimeScale ( 1 ); }
		if ( GUILayout.Button ( "x2" ) ) { ChangeGameTimeScale ( 2 ); }
		if ( GUILayout.Button ( "x3" ) ) { ChangeGameTimeScale ( 3 ); }
		if ( GUILayout.Button ( "x4" ) ) { ChangeGameTimeScale ( 4 ); }
		if ( GUILayout.Button ( "x5" ) ) { ChangeGameTimeScale ( 5 ); }
		EditorGUILayout.EndHorizontal ();
	}

	public void ChangeGameTimeScale( float _scale )
	{
		if( Application.isPlaying )
        {
			Time.timeScale = _scale;
		}
	}
}
#endif
