using System;
using System.Threading;

namespace TDETestTask5
{
	class Program
	{
		static void Main(string[] args)
		{
			SingletonClass singletonClass1 = SingletonClass.getInstance;
			singletonClass1.writeStr();
			singletonClass1.readStr();

			SingletonClass singletonClass2 = SingletonClass.getInstance;
			singletonClass2.writeStr("Adebola 2");

			singletonClass1.writeStr("2");
		
			singletonClass1.readStr();
			singletonClass2.readStr();

			Thread myThread1 = new Thread(() => {
				SingletonClass singletonClass3 = SingletonClass.getInstance;
				singletonClass3.writeStr("54");
				singletonClass3.readStr(); 
			});
			myThread1.Start();

			Thread myThread2 = new Thread(() => {
				SingletonClass singletonClass4 = SingletonClass.getInstance;
				singletonClass4.writeStr("45");
				singletonClass4.readStr();
			});
			myThread2.Start();

			Console.WriteLine("obj count: "+ TDETestTask5.SingletonClass.count);
		}

	}
}
