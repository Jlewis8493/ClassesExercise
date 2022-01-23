using System;
namespace ClassesExercise
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string makeInput, string modelInput, int year)
        {
            Make = makeInput;
            Model = modelInput;
            Year = year;
        }


        //Create a make property of type string that is public
        public string Make { get; set; } //get = read set = write
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
