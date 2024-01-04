
namespace Homework5
{
    internal class Class2
    {
        int oldNumber, newNumber, usage;
        double cost;
        double CalculateCost(int usage)
        {
            if (usage <= 50)
            {
                return usage * 610;
            }
            else if (usage <= 100)
            {
                return usage * 720;
            }
            else if (usage <= 200)
            {
                return usage * 830;
            }
            else if (usage <= 300)
            {
                return usage * 940;
            }
            else
            {
                return usage * 1050;
            }
        }
        public void input()
        {

            Console.Write("Enter old electricity number: ");
            oldNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new electricity number: ");
            newNumber = Convert.ToInt32(Console.ReadLine());


        }
        public void output()
        {
            usage = newNumber - oldNumber;
            cost = CalculateCost(usage);
            Console.WriteLine($"The cost for {usage}kw is {cost}");

        }

    }
}
