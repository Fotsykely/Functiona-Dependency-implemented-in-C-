using System;
using System.Runtime.CompilerServices;

namespace DependenceFunctionnal
{
	public class isAlreadyInTheListException:Exception
	{
		public isAlreadyInTheListException(FunctionalDependency f):base($"{f} is already in the list.")
		{
		}

		public isAlreadyInTheListException(FunctionalDependency f, string message) : base(message) { }

		public isAlreadyInTheListException(FunctionalDependency f, string message, Exception innerException)
																	:base(message,innerException)
		{ }
	}
}

