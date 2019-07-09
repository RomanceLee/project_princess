using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemDragDpi : MonoBehaviour
{
	void Start()
	{
		int pixelDragThreshold = ( int )( 0.5f * Screen.dpi / 2.54f );
		Debug.Log( "pixelDragThreshold : " + pixelDragThreshold );
		GetComponent< EventSystem >().pixelDragThreshold = ( int )( 0.5f * Screen.dpi / 2.54f );
	}
}
