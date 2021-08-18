using System;

namespace Behavioral.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList<Student>();
            list.Add(new Student { Id=Guid.NewGuid(),Name="George"});
            list.Add(new Student { Id = Guid.NewGuid(), Name = "Bir Baba Hindi" });
            list.Add(new Student { Id = Guid.NewGuid(), Name = "Billur Hasan" });

            Console.WriteLine(list.GetNext().Name);
            Console.WriteLine(list.GetNext().Name);
            Console.WriteLine(list.GetNext().Name);
            Console.WriteLine(list.GetNext().Name);
            Console.WriteLine("HALT");
        }
    }
}
