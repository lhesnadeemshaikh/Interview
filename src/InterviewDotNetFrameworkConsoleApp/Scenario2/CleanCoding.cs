using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDotNetFrameworkConsoleApp.Scenario2
{

    public class Program_Scenario2
    {
        static WebServer GetWebServer() { return new WebServer(); }
        
        public static void Main2()
        {
            Console.WriteLine("Code Review \"GenDisclaimrDealrLnks\" method and cleanup the code, consider best practices like SOLID, Naming Convention, RedundantCode etc...");
            Console.WriteLine("Finally add a new location, in WebServer.cs \"Oldsmar,FL\" and it should be displayed in");
            Console.WriteLine("===================================================");
            Console.WriteLine("Output: " + Environment.NewLine);
            Console.WriteLine(GenDisclaimrDealrLnks());
            // expected output:
            // <a href=\""http://xyz.com?make=Toyota&p1=San Francisco&p2=CA\">2002, Toyota, Camry, San Francisco, CA</a>
            // <a href=\""http://xyz.com?make=Toyota&p1=Jersey City&p2=NJ\">2002, Toyota, Camry, Jersey City, NJ</a>
            // <a href=\""http://xyz.com?make=Toyota&p1=Austin&p2=TX\">2002, Toyota, Camry, Austin, TX</a>
            // <a href=\""http://xyz.com?make=Toyota&p1=Oldsmar&p2=FL\">2002, Toyota, Camry, Oldsmar, FL</a>
        }


        // =====================================================
        // START CODE REVIEW FROM HERE...
        // =====================================================


        static int? auto_yearName = 2002;
        static string auto_make = "Toyota";
        static string auto_model = "Camry";
        static string dl1Url = string.Empty;
        static string dl1Text = string.Empty;
        
        // Generates Disclaimer HTML Anchor tags for auto make and model for each SEO Target location
        public static string GenDisclaimrDealrLnks()
        {
            

            var dislaimerUrls = string.Empty;
            // var ws = new WebServer(); 
            var ws = GetWebServer();

            if (!string.IsNullOrEmpty(ws.SEOTargetLocation1) && ws.SEOTargetLocation1.Contains(","))
            {
                string[] pieces = ws.SEOTargetLocation1.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (pieces.Length == 2 && pieces[1].Trim().Length == 2)
                {
                    dl1Url = BuildDealerUrl(auto_make, pieces[0], pieces[1]);
                    //dl1Text = string.Format("<a href=\"{0}\">{1}, {2}, {3}, {4}, {5}</a>", dl1Url, auto_yearName ?? 0, auto_make, auto_model, pieces[0], pieces[1]);

                    dislaimerUrls += CreateFinalHref(dl1Url, pieces) + " " + Environment.NewLine;
                }
            }

            if (!string.IsNullOrEmpty(ws.SEOTargetLocation2) && ws.SEOTargetLocation2.Contains(","))
            {
                string[] pieces = ws.SEOTargetLocation2.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (pieces.Length == 2 && pieces[1].Trim().Length == 2)
                {
                    dl1Url = BuildDealerUrl(auto_make, pieces[0], pieces[1]);
                    // dl1Text = string.Format("<a href=\"{0}\">{1}, {2}, {3}, {4}, {5}</a>", dl1Url, auto_yearName ?? 0, auto_make, auto_model, pieces[0], pieces[1]);

                    dislaimerUrls += CreateFinalHref(dl1Url, pieces) + " ";
                }
            }

            //if (!string.IsNullOrEmpty(ws.SEOTargetLocation4) && ws.SEOTargetLocation4.Contains(","))
            //{
            //    string[] pieces = ws.SEOTargetLocation4.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //    if (pieces.Length == 2 && pieces[1].Trim().Length == 2)
            //    {
            //        dl1Url = BuildDealerUrl(auto_make, pieces[0], pieces[1]);
            //        // string dl1Text = string.Format("<a href=\"{0}\">{1}, {2}, {3}, {4}, {5}</a>", dl1Url, auto_yearName ?? 0, auto_make, auto_model, pieces[0], pieces[1]);

            //        dislaimerUrls += CreateFinalHref(dl1Url, pieces) + " " + Environment.NewLine;
            //    }
            //}

            if (!string.IsNullOrEmpty(ws.SEOTargetLocation3) && ws.SEOTargetLocation3.Contains(","))
            {
                string[] pieces = ws.SEOTargetLocation2.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (pieces.Length == 2 && pieces[1].Trim().Length == 2)
                {
                    dl1Url = BuildDealerUrl(auto_make, pieces[0], pieces[1]);
                    // dl1Text = string.Format("<a href=\"{0}\">{1}, {2}, {3}, {4}, {5}</a>", dl1Url, auto_yearName ?? 0, auto_make, auto_model, pieces[0], pieces[1]);
                    dislaimerUrls += CreateFinalHref(dl1Url, pieces) + " " + Environment.NewLine;

                }
            }

            return dislaimerUrls;
        }

        // do not modify these stub methods
        static string BuildDealerUrl(string make, string piece1, string piece2)
        {
            return "http://xyz.com?make=" + make + "&p1=" + piece1 + "&p2=" + piece2;
        }
        static string CreateFinalHref(string url, string[] pieces)
        {
            dl1Text = string.Format("<a href=\"{0}\">{1}, {2}, {3}, {4}, {5}</a>", url, auto_yearName ?? 0, auto_make, auto_model, pieces[0], pieces[1]);

            return dl1Text;
        }
    }

}



