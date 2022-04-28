using System;

using AppKit;
using Foundation;
using System.Timers;

namespace StopWatch
{
    public partial class ViewController : NSViewController
    {
        Time time = new Time("0:0:0:0");
        Timer timer = new System.Timers.Timer();
        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            clock.StringValue = time.getCurrentTime();
            Timer timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();


            // Do any additional setup after loading the view.
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //DateTime myDate = DateTime.Now;
            InvokeOnMainThread(() => {
                //time.oneSecondPassed();
                time.oneSecondPassed();
                clock.StringValue = time.getCurrentTime();
            });
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        partial void startButton(NSObject sender)
        {
            clock.StringValue = "clicked!";
        }
    }
}
