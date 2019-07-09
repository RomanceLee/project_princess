using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

namespace TouchEffectSystem 
{
	public delegate void SignalCallBack( object obj );

	public class UITouchEffectSystem : MonoBehaviour
	{
		#region Inspector
		public GameObject m_pRootObject;
		//public GameObject m_pTouchEffectPrefab;
		#endregion
		//public const int POOL_COUNT = 5;
		public static bool EnableTouchEffectSystem = true;

		protected Canvas m_pCanvas;
		protected float m_fScaleFactor; 	// Screen 화 면 대 비 Canvas 화 면 의 Scale factor

        protected Dictionary< string, UIObjectPool > m_pObjectPools;

		void Awake()
		{
			m_pCanvas = this.gameObject.GetComponent< Canvas >();
            m_pObjectPools = new Dictionary< string, UIObjectPool >();
		}

		void Start()
		{
			if( m_pCanvas != null )
            {
				m_fScaleFactor = 1f/m_pCanvas.scaleFactor;
			}

            LoadResource( "Prefabs/Effects/", "Touch_Effect", 5 );
		}

		public void ShowEffect( Vector2 pos )
		{
			GameObject o = GetInstantiatedObject( "Touch_Effect", m_pRootObject.transform );
			if( o != null )
            {
				UITouchObject touchObject = o.GetComponent< UITouchObject >();
				touchObject.Activate( 0.8f, SignalCallBack );

				RectTransform rt = o.GetComponent< RectTransform > ();
				rt.anchoredPosition = pos;
				o.SetActive( true );
			}
		}

	    protected void LoadResource( string _path, string _name, int _poolCount = 1 )
	    {
		    string path = _path + _name;
		    GameObject prefab = Resources.Load< GameObject >( path );
		    UIObjectPool pool = new UIObjectPool( _name, prefab, this.gameObject, _poolCount, false, true );
		    m_pObjectPools.Add( _name, pool );
	    }

        protected GameObject GetInstantiatedObject( string _key, Transform _parent )
	    {
		    if( m_pObjectPools.ContainsKey( _key ) )
            {
			    UIObjectPool pool = m_pObjectPools[ _key ];
			    GameObject o = pool.Instantiate();
			    o.transform.SetParent( _parent );
			    o.transform.localScale = Vector3.one;
			    o.transform.localPosition = Vector3.zero;
			    return o;
		    }
		    return null;
	    }

        public void ReturnInstantiatedObject( string _key, GameObject _o )
	    {
		    if( m_pObjectPools.ContainsKey( _key ) )
            {
			    UIObjectPool o = m_pObjectPools[ _key ];
			    o.Destroy( _o );
		    }
	    }
        
        protected void SignalCallBack( object touchObject )
		{
			UITouchObject o = touchObject as UITouchObject;
			if( o != null )
            {
				ReturnInstantiatedObject( "Touch_Effect", o.gameObject );
			}
		}

		void Update ()
		{
			#if UNITY_EDITOR
			if( EnableTouchEffectSystem == true && Input.GetMouseButtonDown( 0 ) )
			{
				Vector2 mousePos = Input.mousePosition;
				Vector3 vec = new Vector3( mousePos.x, mousePos.y );
				Vector3 viewportPos = m_pCanvas.worldCamera.ScreenToViewportPoint( vec );

				RectTransform rt = m_pCanvas.GetComponent< RectTransform >();

				if( rt != null )
				{
					float x = viewportPos.x * rt.rect.width;
					float y = viewportPos.y * rt.rect.height;

					mousePos.x = x;
					mousePos.y = y;

					ShowEffect( mousePos );
				}
			}
			#else 
			if( EnableTouchEffectSystem == true &&  Input.touchCount == 1 )
			{
				if( Input.touches[ 0 ].phase == TouchPhase.Began )
				{
					Vector2 mousePos = Input.touches[ 0 ].position;
					Vector3 vec = new Vector3( mousePos.x, mousePos.y );
					Vector3 viewportPos = m_pCanvas.worldCamera.ScreenToViewportPoint( vec );

					RectTransform rt = m_pCanvas.GetComponent< RectTransform >();

					if( rt != null )
					{
						float x = viewportPos.x * rt.rect.width;
						float y = viewportPos.y * rt.rect.height;

						mousePos.x = x;
						mousePos.y = y;

						ShowEffect( mousePos );
					}
				}
			}
			#endif
		}
	}
}
