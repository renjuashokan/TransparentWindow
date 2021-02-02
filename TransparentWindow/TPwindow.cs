using System;
using System.Collections.Generic;
using System.Text;
using Gtk;

namespace TransparentWindow
{
    class TPwindow : Window
    {
        private Builder builder;
        public static TPwindow Create()
        {
            Builder _builder = new Builder(null, "TransparentWindow.gladefiles.tpwindow.glade", null);
            return new TPwindow(_builder, _builder.GetObject("tpwindow").Handle);
        }
        protected TPwindow(Builder _builder, IntPtr handle) : base(handle)
        {
            builder = _builder;
            builder.Autoconnect(this);
            Console.WriteLine("TiltDisplay is created");
            Title = "background-color: transparent";
        }
    }
}
