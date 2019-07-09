using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleManager : UICommon
{
    public Button titleButton;

    protected override void OnAwake()
    {
        base.OnAwake();
        StartCoroutine( DisappiearTitleButton() );
    }

    protected override void OnDestroied()
    {
        base.OnDestroied();
        StopAllCoroutines();
    }

    protected override void InitializeEvents()
    {
        titleButton.onClick.AddListener( OnClickTitleButton );
    }

    protected override void ReleaseEvents()
    {
        titleButton.onClick.RemoveListener( OnClickTitleButton );
    }

    private void OnClickTitleButton()
    {
        Utils.LoadLevel( "Title", "Main" );
    }

    private IEnumerator DisappiearTitleButton()
    {
        yield return StartCoroutine( AnimationManager.DisappearImageAlphaAnimation( titleButton.image, 1f, 0f, 0.01f, 10 ) );
        StartCoroutine( AppiearTitleButton() );
    }

    private IEnumerator AppiearTitleButton()
    {
        yield return StartCoroutine( AnimationManager.AppearImageAlphaAnimation( titleButton.image, 0f, 1f, 0.01f, 10 ) );
        StartCoroutine( DisappiearTitleButton() );
    }
}
