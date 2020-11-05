using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
public class TrackableEvent : DefaultTrackableEventHandler {

    public UnityEvent onTrackingFound;
    public UnityEvent onTrackingLost;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        onTrackingFound.Invoke();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        onTrackingLost.Invoke();
    }
}
