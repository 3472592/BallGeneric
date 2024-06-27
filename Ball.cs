using System;

namespace Ball
{
    /// <summary>
    /// Ball class is Publisher class because, it raises the BallInPlay event using
    /// the OnBallInPlay method. It triggers the event to notify subs about a certain state
    /// or action in this case when ball is in play.
    /// </summary>
    public class Ball
    {
        // Declare an event named "BallInPlay" of type EventHandler.
        // Events are a way to notify subscribers (event handlers) when a specific action occurs.
        public event EventHandler<BallEventArgs> BallInPlay;

        // Define a method to invoke the "BallInPlay" event.
        public void OnBallInPlay(BallEventArgs e)
        {
            // Create a local copy of the event handler delegate.
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            // Check if there are any subscribers (event handlers) for the event.
            if (ballInPlay != null)
                // Invoke the event by calling the delegate with appropriate parameters.
                /////////////////////////////////////////////////////////////////////////
                /* The this and e parameters in the OnBallInPlay method serve specific
                 * purposes in the context of event handling in C#.
                 * Let's break down why these parameters are used: *///
                /////////////////////////////////////////////////////////////////////////
                //    this:
                ///////////
                ///this param in C# refers to current instance of the class,
                ///in the context of the OnBallInPlay method this used to refer to instance
                ///of the Ball class that is invoking the event.
                ///      e:
                ///////////
                ///e param is an event argument, instance of BallEventArgs which inherits from EventArgs 
                ///when event is raised the subscribers event handlers are notified about the event and
                ///are passed the necessary info, including source of the event.
                ///By using this as first param when invoking event,
                ///the event handlers will know which instance of the Ball class raised the event.
                BallInPlay?.Invoke(this, e);
        }
    }
}