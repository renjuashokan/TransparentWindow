using System;
using Gtk;
using System.Threading.Tasks;
using System.Reflection;

namespace TransparentWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            var assemblyName = new AssemblyName("TransparentWindow");
            var resources = string.Join(Environment.NewLine, Assembly.Load(assemblyName).GetManifestResourceNames());
            Console.WriteLine("List of Manifest Resource Names");
            Console.WriteLine("======================");
            Console.WriteLine(resources);
            GladeApp(args);
        }

        public static void GladeApp(string[] args)
        {
            
            Application.Init();
            string cssData = @"
            GtkWindow,
            .stylewindow {
                background-color: transparent;
            }

            GtkWindow,
            .stylewindow2 {
                background: rgba(76, 175, 80, 0.3);
            }

             GtkLabel,
            .style_label {
                color: rebeccapurple;
                font-weight: bold;
                font-size: 25px;
            }
            ";
            var cssProvider = new CssProvider();
            cssProvider.LoadFromData(cssData);
            Gtk.StyleContext.AddProviderForScreen(Gdk.Screen.Default, cssProvider, Gtk.StyleProviderPriority.User);

            Console.WriteLine("Creating window now");
            TPwindow tiltDisplay = TPwindow.Create();
            tiltDisplay.Show();

            TPwindow2 tiltDisplay2 = TPwindow2.Create();
            tiltDisplay2.Show();

            Application.Run();
        }
    }
}
