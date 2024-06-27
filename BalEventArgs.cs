using System;

namespace Ball
{
    /// <summary>
    /// Everything Starts from here.
    /// </summary>
    // Define a class named "BallEventArgs" that inherits from EventArgs.
    public class BallEventArgs : EventArgs
    {
        // Declare properties to store trajectory and distance values.
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }

        // Constructor to initialize trajectory and distance values
        public BallEventArgs(int trajectory, int distance)
        {
            Trajectory = trajectory;
            Distance = distance;
        }
    }
}