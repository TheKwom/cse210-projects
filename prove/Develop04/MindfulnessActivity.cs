using System;
using System.Threading;

// Base class for all activities
abstract class MindfulnessActivity
{
    protected int duration; // Duration of the activity in seconds

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    public abstract void StartActivity();
}