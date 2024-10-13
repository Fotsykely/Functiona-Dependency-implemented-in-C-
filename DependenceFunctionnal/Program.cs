// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using DependenceFunctionnal;

FunctionalDependency df1 = new FunctionalDependency("A", "B");
FunctionalDependency df2 = new FunctionalDependency("B", "C");
FunctionalDependency df3 = new FunctionalDependency("D", "E");
FunctionalDependency df4 = new FunctionalDependency("D", "R");
FunctionalDependency df5 = new FunctionalDependency("X", "Z,Y");

FunctionalDependencySet R = new FunctionalDependencySet();
R.addDependency(new FunctionalDependency("X", "Y"));
R.addDependency(df1);
R.addDependency(df2);
R.addDependency(R.transitivity(df1, df2));
R.addDependency(df3);
R.addDependency(R.augment(df2));
R.addDependency(R.Union(df3, df4));

var df6 = R.Decomposition(df5)[0];
var df7 = R.Decomposition(df5)[1];

R.addDependency(df6);
R.addDependency(df7);
R.addDependency(R.Union(df6,df7));

Console.WriteLine(R);

//check transitivity
if (R.transitivity(df2, df4) != null)
    Console.WriteLine("transitive");
else Console.WriteLine("Not Transitive");