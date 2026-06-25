using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{

	[Serializable]
	public class MyException : ApplicationException
	{
		public MyException() 
		{ 
			Data.Add("Date", DateTime.Now); 
		}
		public MyException(string message) : base(message) { }
		public MyException(string message, Exception inner) : base(message, inner) { }
		protected MyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }




	}
}
