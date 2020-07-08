using System;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            var anonymType = new
            {
                Year = DateTime.Now.Year,
                Moving = true,
                Name = "George",
                Speed = 200
            };

            var newType = new
            { 
                Pi = Math.PI,
                PetName = "Jude",
                Sym = '%'                       
            
            };

            object a1 = anonymType;
            dynamic a2 = anonymType;

            Console.WriteLine($"Year: {anonymType.Year}, Is Moving: {anonymType.Moving}, Name: {anonymType.Name}, Speed: {anonymType.Speed}");

        }
    }
}
