using UIKit;

namespace ComputerScienceCalculator
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            try
            {
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch 
            {
                UIAlertView alert = new UIAlertView()
                {
                    Title = "Unexpected Conversion",
                    Message = "The number cannot be converted."
                };


                alert.AddButton("OK");
                alert.Show();
            }
        }
    }
}
