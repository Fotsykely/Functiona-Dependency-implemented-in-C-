using System;
namespace DependenceFunctionnal
{
	public class FunctionalDependency
	{
		public string left,right;

        /// <summary>
        ///		the dependence functional that take the left element as
        ///		first parameter and then the right as a second
        ///		parameter
        /// </summary>
        /// <param name="l">the left element</param>
        /// <param name="r">the right element</param>
        public FunctionalDependency(string l,string r)
		{
			this.right = r;
			this.left = l;
		}

        public override string? ToString()
        {
            return this.left+" --> "+this.right;
        }
    }
}

