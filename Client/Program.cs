using System;
using Patterns.Observer;
using Patterns.FactoryMethod;
using Patterns.Bridge;
using Patterns.AbstractFactory;

namespace Client
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			#region Observer Pattern
				Book b = new Book ("The lord of the rings");
				var l = new Librarian ();
				var g = new Grocer ();
				var r = new Restorer ();
				b.addObserver (l);
				b.addObserver (g);
				b.addObserver (r);
				b.Notify ();
				Console.WriteLine ("---------------------------------------------------------");
			#endregion

			#region Factory Method Pattern
				MyApplication app = new MyApplication();
				var doc = app.createDocument();
				doc.Open();
				Console.WriteLine ("---------------------------------------------------------");
			#endregion

			#region Bridge Pattern
				AbstractPicture img = new JPG(new OSXImp());
				img.Caller();
				img = new BMP(new WinImp());
				img.Caller();
				img = new GIF(new LinuxImp());
				img.Caller();
				Console.WriteLine ("---------------------------------------------------------");
			#endregion

			#region Abstract Factory Pattern
				// THIS IS THE CLIENT CLASS CONTENT MENTIONED ON PATTERN PRINCIPLES.
				IFactory factory = new PMFactory();
				IScrollbar scrollbar = factory.BuildScrollbar();
				IWindow window = factory.BuildWindow();

				scrollbar.Draw();
				window.Draw();
				
				Console.WriteLine ("\n");
				
				factory = new MOTIFFactory();
				scrollbar = factory.BuildScrollbar();
				window = factory.BuildWindow();
				
				scrollbar.Draw();
				window.Draw();
				Console.WriteLine ("---------------------------------------------------------");
			#endregion
		}
	}
}
