using System;
using Raspberry.IO.GeneralPurpose;
using Raspberry.IO.GeneralPurpose.Behaviors;

namespace blinky
{
	class MainClass
	{
		public static void Main (string[] args){
		var led1 = ConnectorPin.P1Pin07.Output();

		var connection = new GpioConnection(led1);

		for (var i = 0; i<100; i++) {
			connection.Toggle(led1);
			System.Threading.Thread.Sleep(500);
		}
		connection.Close();
	}
	}
}

