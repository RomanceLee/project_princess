using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 모든 UI오브젝트 공통 기능 작성
/// </summary>
public class UICommon : MonoBehaviour 
{
	private StaticDataManager m_staticDataManager;

	public StaticDataManager staticDataManager
    {
        get
        {
		    if( m_staticDataManager == null )
            {
			    m_staticDataManager = ProjectManager.Instance.staticDataManager;
		    }

		    return m_staticDataManager;
	    }
    }
	
	private void Awake()
	{
		OnAwake();
	}

	private void Start() 
	{
		OnStart();
	}

	private void OnEnable()
	{
		OnEnabled();
	}

    private void OnDisable()
    {
        OnDisabled();
    }

    private void OnDestroy()
	{
		OnDestroied();
	}

	protected virtual void OnAwake()
	{
        InitializeEvents();
	}

	protected virtual void OnStart()
	{

	}

	protected virtual void OnEnabled()
	{
	}

    protected virtual void OnDisabled()
	{
	}

	protected virtual void OnDestroied()
	{
        ReleaseEvents();
	}

    protected virtual void InitializeEvents()
    {

    }

    protected virtual void ReleaseEvents()
    {

    }

	/// <summary>
	/// 객체내용 다시 표시할때 사용
	/// </summary>
	public virtual void OnUpdate()
	{

	}
}
