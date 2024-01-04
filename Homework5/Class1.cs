namespace Homework5
{
    internal class Class1
    {
        private int score;


        public void input()
        {
            score = int.Parse(Console.ReadLine());
        }
        public void output()
        {

            string rank = score < 50 ? "F" : score < 60 ? "E" : score < 70 ? "D" : score < 80 ? "C" : score < 85 ? "B" : score < 90 ? "A" : score < 95 ? "A+" : "A+";


            Console.WriteLine($"Your rank is {rank}");

        }
    }
}
