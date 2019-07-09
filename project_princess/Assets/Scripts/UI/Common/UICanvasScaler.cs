using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasScaler : MonoBehaviour
{
    public bool isForceWidth = false; // 언제나 가로 비율로 고정

	private CanvasScaler m_pCanvasScaler;

	private const float baseRes = 720f/1280f;
	private float currentRes;

	
	protected void Awake()
    {
		ChangeScale();
	}

#if UNITY_EDITOR
    void Update()
    {
        ChangeScale();
    }
#endif

    private void ChangeScale()
    {
		if( m_pCanvasScaler == null )
        {
            m_pCanvasScaler = GetComponent< CanvasScaler >();
        }

		if( isForceWidth == false )
        {
		    float width = Screen.width;
		    float height = Screen.height;

		    currentRes = width/height;
            
		    if( currentRes > baseRes )
            {
                m_pCanvasScaler.matchWidthOrHeight = 1f;
            }
		    else
            {
                m_pCanvasScaler.matchWidthOrHeight = 0f;
            }
        }

        #if UNITY_IOS
        //Rect area = ProjectManager.Instance.camRect;
        //m_pCanvasScaler.referenceResolution = new Vector2( 720f/area.width, 1280f/area.height );
        #endif
	}
}

