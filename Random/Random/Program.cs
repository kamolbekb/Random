namespace GithubDemon
{
    internal class Progrem
    {
        static void Main(string[] args)
        {
            int random_number = new Random().Next(1, 100);
            int ans, attempts = 1;
        qayta:
            Console.Write("To identofy random number enter number from 1 to 100: ");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans < 0 && ans > 101)
            {
                Console.WriteLine("Kiritilgan raqam talablarga javob bermaydi");
                attempts++;
                goto qayta;
            }
            else if (ans < random_number)
            {
                Console.WriteLine("The number that you entered is less than random nuber, please try again!");
                attempts++;
                goto qayta;
            }
            else if (ans > random_number)
            {
                Console.WriteLine("The number that you entered is greater than random nuber, please try again!");
                attempts++;
                goto qayta;
            }
            else if (ans == random_number)
            {
                Console.WriteLine("Congratulations!!! You have successfully find random number!");
                Console.WriteLine($"To find random number you`ve spent {attempts}-attempts");
            }
            else
            {
                goto qayta;
            }
        }
    }

}