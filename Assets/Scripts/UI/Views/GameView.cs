﻿using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Game view class.
/// Passes button events.
/// </summary>
public class GameView : BaseView
{
    // Events to attach to.
    public UnityAction OnPauseClicked;
    public UnityAction OnSentenceBuilderStarted;

    public void PauseClick()
    {
        OnPauseClicked?.Invoke();
    }

    public void SentenceBuilderStart()
    {
        OnSentenceBuilderStarted?.Invoke();
    }
}
