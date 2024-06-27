using System;
using System.Collections.ObjectModel;

namespace Ball
{
    public class Pitcher : Fan_Pitcher
    {
        public ObservableCollection<string> PitcherSays = new ObservableCollection<string>();

        public Pitcher(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }

                #pragma warning disable IDE1006 // Naming Styles
        private void ball_BallInPlay(object sender, EventArgs e)
        {
            _pitchNumber++;
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CatchBall()
        {
            PitcherSays.Add("Pitch #" + _pitchNumber + ": I caught the ball");
        }
        private void CoverFirstBase()
        {
            PitcherSays.Add("Pitch #" + _pitchNumber + ": I covered first base");
        }
    }
}