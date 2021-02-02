using System;
using System.Collections.Generic;
using System.Text;
using Gtk;
namespace TransparentWindow
{
    class TPwindow2 : Window
    {
        private Builder builder;
        public static TPwindow2 Create()
        {
            Builder _builder = new Builder(null, "TransparentWindow.gladefiles.tpwindow2.glade", null);
            return new TPwindow2(_builder, _builder.GetObject("tpwindow2").Handle);
        }
        protected TPwindow2(Builder _builder, IntPtr handle) : base(handle)
        {
            builder = _builder;
            builder.Autoconnect(this);
            Console.WriteLine("TiltDisplay is created");
            Title = "background: rgba";
        }
    }
}
