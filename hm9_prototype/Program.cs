
using hm9_prototype.Entities;
using System.Diagnostics;


ThirdClass prototypeThirdClass = new ThirdClass();
ThirdClass clonedThirdClass = (ThirdClass)prototypeThirdClass.Clone();
Console.WriteLine("IClonable");
Console.WriteLine($"Прототип - {prototypeThirdClass}");
Console.WriteLine($"Клон - {clonedThirdClass}");

Console.WriteLine();
ThirdClass clonedThirdClass_my = prototypeThirdClass.MyClone();
Console.WriteLine("MyClonable");
Console.WriteLine($"Прототип - {prototypeThirdClass}");
Console.WriteLine($"Клон - {clonedThirdClass_my}");

//Console.WriteLine();
//Console.WriteLine("Тест:");
//Console.WriteLine();
//var stopWatch = new Stopwatch();
//stopWatch.Start();
//for (int i = 0; i < 100_000; i++)
//{
//    ThirdClass clonedThirdClass_ = (ThirdClass)prototypeThirdClass.Clone() ;
//}
//stopWatch.Stop();
//Console.WriteLine("Время 1 {0}", stopWatch.Elapsed);


//Console.WriteLine();
//stopWatch = new Stopwatch();
//stopWatch.Start();
//for (int i = 0; i < 100_000; i++)
//{
//    ThirdClass clonedThirdClass_My_ = prototypeThirdClass.MyClone();
//}
//stopWatch.Stop();
//Console.WriteLine("Время 2 {0}", stopWatch.Elapsed);
