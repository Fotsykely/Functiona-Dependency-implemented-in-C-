using System;
using System.Runtime.CompilerServices;

namespace DependenceFunctionnal
{
	public class FunctionalDependencySet
	{
		private List<FunctionalDependency> depedencies = new List<FunctionalDependency>();

		public void addDependency(FunctionalDependency fd)
		{
			if (!depedencies.Contains(fd))
				depedencies.Add(fd);
			else ThrowInTheListException(fd);
		}

		//X->Y : W,X->W,Y
		public FunctionalDependency augment(FunctionalDependency f)
		{
			return new FunctionalDependency((f.left + "W"),(f.right + "W"));
		}

		//X->Y & Y->Z: X->Z
		public FunctionalDependency? transitivity(FunctionalDependency f1,FunctionalDependency f2)
		{
			if (f1.right == f2.left)
				return new FunctionalDependency(f1.left, f2.right);
			return null;
		}

		//X->Y & X->Z: X->Y,Z
		public FunctionalDependency? Union(FunctionalDependency f1, FunctionalDependency f2)
		{
			if (f1.left == f2.left)
				return new FunctionalDependency(f1.left, f1.right + "," + f2.right);
			else return null;
		}

		//X->Z,Y:  X->Z & X->Y
		//return an array add [0] for the first element and [1] for the second
		public FunctionalDependency[]? Decomposition(FunctionalDependency f)
		{
			if(f.right.Contains(','))
				return new FunctionalDependency[] { new FunctionalDependency(f.left, f.right.Substring(0,1)),
									new FunctionalDependency(f.left,f.right.Substring(2,1))};
			else return null;
		}

		public override string? ToString()
        {
			string s = string.Join("\n", depedencies); ;
			return s;
        }

		private void ThrowInTheListException(FunctionalDependency f, [CallerLineNumber] int line = 0,
			[CallerMemberName] string memberName="")
		{
			throw new isAlreadyInTheListException(f,$"{f} is already in the list at the line {line} on method " +
				$"{memberName}.");
		}
    }
}

