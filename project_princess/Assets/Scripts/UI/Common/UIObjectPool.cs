using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectPool
{
	protected Queue< GameObject > m_pQueue;
	protected int m_iPoolCount = 1; 
	protected bool m_bAutoSizing = true;
	protected bool m_bResetScript;
	protected string m_strPoolName = "Default";
	protected GameObject m_pObjectPrefab;
	protected GameObject m_pParentObject;
	
    /// <summary>
	/// 오 브 젝 트 풀 세 팅 
	/// </summary>
	/// <param name="_name">풀 이 름</param>
	/// <param name="_prefab">프 리 팹</param>
	/// <param name="_parent">객 체 가 들 어 갈 루 트 객 체</param>
	/// <param name="_count">풀 갯 수</param>
	/// <param name="_autoSizing">풀 갯 수 자 동 조 정<c>true</c>풀 갯 수 가 설 정 치 이 상 일 경 우, 초 과 분 정 리 </param>
	public UIObjectPool( string _name, GameObject _prefab, GameObject _parent, int _count, bool _resetScript,  bool _autoSizing = true )
	{
		m_strPoolName = _name;
		m_pObjectPrefab = _prefab;
		m_pParentObject = _parent;
		m_iPoolCount = _count;
		m_bResetScript = _resetScript;
		m_bAutoSizing = _autoSizing;

		m_pQueue = new Queue< GameObject > ();
		IncreasePool( m_iPoolCount );
	}

	/// <summary>
	/// 오 브 젝 트 풀 해 제 
	/// </summary>
	public void Release()
	{
		DecreasePool( m_pQueue.Count );		
		m_pQueue.Clear();
		m_pQueue = null;
	}

	/// <summary>
	/// 풀 링 된 객 체 요 청 
	/// </summary>
	public GameObject Instantiate()
	{
		//Debug.Log( "###### OJBECTPOOL Instantiate : " + m_strPoolName + ", " + m_pQueue.Count );
		if( m_pQueue.Count == 0 )
        {
			IncreasePool( 1 );
		}
		return m_pQueue.Dequeue();
	}

	/// <summary>
	/// 사 용 한 객 체 반 환 
	/// </summary>
	public void Destroy( GameObject o )
	{
		// 사 용 된 객 체 초 기 화 
		ResetObject( o );

		// 스 택 사 이 즈 조 정 
		if( m_bAutoSizing )
        {
			int gap = m_pQueue.Count - m_iPoolCount;
			if( gap > 0 )
            {
				DecreasePool( gap );
			}	
		}

		//Debug.Log( "###### OJBECTPOOL Destroy : " + m_strPoolName + ", " + m_pQueue.Count );
	}

	/// <summary>
	/// 스 택 에 지 정 된 갯 수 만 큼 객 체 할 당 
	/// </summary>
	protected void IncreasePool( int c )
	{
		for( int i = 0; i < m_iPoolCount; i++ )
        {
            //Debug.Log( m_pObjectPrefab.name );
			GameObject o = GameObject.Instantiate( m_pObjectPrefab ) as GameObject;
			o.transform.SetParent( m_pParentObject.transform );
			o.SetActive( false );
			m_pQueue.Enqueue( o );
		}

		//Debug.Log( "###### OJBECTPOOL increasePool : " + m_strPoolName + ", " + m_pQueue.Count );
	}

	/// <summary>
	/// 스 택 에 서 지 정 된 갯 수 만 큼 객 체 제 거
	/// </summary>
	/// <param name="c">C.</param>
	protected void DecreasePool( int c )
	{
		if( c > m_pQueue.Count )
        {
			c = m_pQueue.Count;
		}

		for( int i = 0; i < c; i++ )
        {
			GameObject o = m_pQueue.Dequeue();
			GameObject.Destroy( o );
		}

		//Debug.Log( "###### OJBECTPOOL decreasePool : " + m_strPoolName + ", " + m_pQueue.Count );
	}

	/// <summary>
	/// 사 용 된 객 체 초 기 화 
	/// </summary>
	protected void ResetObject( GameObject o )
	{
		if( o == null )
        {
            return;
        }
			
		o.transform.SetParent( m_pParentObject.transform );
		o.SetActive( false );
				
		if( m_bResetScript )
        {
		    Component[] components = o.GetComponents< Component >();
		    for( int i = 0; i < components.Length; i++ )
            {
			    Component t = components[ i ];
			    if( t is Transform )
                {
                    continue;
                }

			    if( t is Animator )
                {
                    continue;
                }
		    }
	    }
		m_pQueue.Enqueue( o );
	}
}
