using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobiDll
{
    public class webmatat
    {
    }
    public class idozito 
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();


        t.Interval = 3000; // 3s
            t.Tick += new EventHandler(timer_Tick);
        //   t.Start();

    }

    void timer_Tick(object sender, EventArgs e)
    {
        //Call method
        linkcsere2();
    }
}

}
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            web1.LoadCompleted += web1_LoadCompleted;
     
        public void linkcsere2()
        {
            HTMLDocument document = (HTMLDocument)web1.Document;
            foreach (IHTMLElement link in document.links)
            {
                if (link.className == "share_action_link")
                { link.innerHTML = "fffffffffff"; }

            }
        }

        public void linkcsere(object sender, RoutedEventArgs e)
        {
            HTMLDocument document = (HTMLDocument)web1.Document;
            foreach (IHTMLElement link in document.links)
            {
                if (link.className == "share_action_link")
                { link.innerHTML = "dddddddddddd"; }

            }
        }



        public void divtext(object sender, RoutedEventArgs e)
        {
            string lll = "";
            HTMLDocument document = (HTMLDocument)web1.Document;
            foreach (IHTMLElement div in document.getElementsByTagName("div"))
            {
                if (div.className == "userContentWrapper _5pcr _3ccb")
                {
                    IHTMLElementCollection bejar = div.all;
                    IHTMLElementCollection elem = div.all;
                    foreach (IHTMLElement fff in elem)
                    {


                        if (fff.className == "_5pcq")
                        {
                            lll = fff.getAttribute("href");
                        }

                        if (fff.className == "_5pcp _5vsi _52i6 _1tsu _4l4" || fff.className == "_5pcp _5vsi _52i6 _4l4")
                        {
                            fff.innerHTML = "<div class=\"robi\">like Robi<div>";

                        }

                 
                    }
                }
            }
        }

        public void kepcsere1(object sender, RoutedEventArgs e)
        {
            HTMLDocument document = (HTMLDocument)web1.Document;

            Popup1.IsOpen = true;
            ASCIIEncoding Encode = new ASCIIEncoding();
            byte[] post = Encode.GetBytes("username=nyuszoka&password=123");

            // The destination url
            string url = "http://192.168.1.66";

            // The same Header that its sent when you submit a form.
            string PostHeaders = "Content-Type: application/x-www-form-urlencoded";

            popBrowser1.Navigate(url, null, post, PostHeaders);

        }

        public void web1_LoadCompleted(object sender, NavigationEventArgs e)
        {

            HTMLDocument document = (HTMLDocument)web1.Document;

            // document.body.innerHTML = "hsfbashfbs";
            foreach (IHTMLSpanElement myelem in document.getElementsByTagName("span"))
            {
                HTMLSpanElement el = myelem as HTMLSpanElement;
                if (el.className.Equals("_2dpb"))
                {
                    el.innerText = "párom";

                }

            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void web1_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            HTMLDocument document = (HTMLDocument)web1.Document;
            foreach (IHTMLElement div in document.getElementsByTagName("div"))
            {
                if (div.className == "_5pcp _5vsi")
                {

                    div.innerHTML = "something" + div.innerHTML;
                }
            }
        }
    }
}
