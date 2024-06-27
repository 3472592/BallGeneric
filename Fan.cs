using System;
using System.Collections.ObjectModel;

namespace Ball
{
    public class Fan : Fan_Pitcher
    {
        public ObservableCollection<string> FanSays = new ObservableCollection<string>();

        public Fan (Ball ball)
        {
            ball.BallInPlay += new EventHandler<BallEventArgs>(ball_BallInPlay);
        }


                #pragma warning disable IDE1006 // Naming Styles
        private void ball_BallInPlay(object sender, EventArgs e)
        {
            _pitchNumber++;
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;

                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    FanSays.Add("Pitch #" + _pitchNumber
                         + ": Home run! I'm going for the ball!");
                else
                    FanSays.Add("Pitch #" + _pitchNumber + ": Woo-hoo! Yeah!");
            }
        }
    }
}