using UnityEngine;
using System.Collections;

public class UITalkText : UIText
{
    private bool isDisplayComplete;
    private string talkText;

    public bool DisplayComplete
    { 
        get
        { 
            return isDisplayComplete;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        isDisplayComplete = false;
        talkText = string.Empty;
    }

    public void DisplayTalkText()
    {
        isDisplayComplete = false;
        talkText = text;
        text = string.Empty;

        StartCoroutine( "PlayTalkText" );
    }

    protected IEnumerator PlayTalkText()
    {
        int index = 0;
        while( index <= talkText.Length )
        {
            text = talkText.Substring( 0, index );

            yield return YieldReturnManager.waitForSeconds( 70 );
            index++;
        }

        isDisplayComplete = true;
    }

    public void SkipTalkDisplay()
    {
        StopCoroutine( "PlayTalkText" );
        text = talkText;
        isDisplayComplete = true;
    }
}
