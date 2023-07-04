namespace GithubDemon
{
    internal class Progrem
    {
        static void Main(string[] args)
        {
            int random_number = new Random().Next(1, 10);
            int ans, attempts = 1;
        qayta:
            Console.Write("Random sonni aniqlang(1-10 bolgan son kiriting): ");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans < 0 && ans > 11)
            {
                Console.WriteLine("Kiritilgan raqam talablarga javob bermaydi");
                attempts++;
                goto qayta;
            }
            else if (ans < random_number)
            {
                Console.WriteLine("Siz kiritgan raqam Random sondan kichkinaroq, yana bir bor harakat qilib ko`ring!");
                attempts++;
                goto qayta;
            }
            else if (ans > random_number)
            {
                Console.WriteLine("Siz kiritgan raqam Random sondan kattaroq, yana bir bor harakat qilib ko`ring!");
                attempts++;
                goto qayta;
            }
            else if (ans == random_number)
            {
                Console.WriteLine("Congratulations!!! Siz random sonni muvofaqiyatli aniqladingiz!");
                Console.WriteLine($"Buning uchun sizda {attempts}-ta urunish ketdi");
            }
            else
            {
                goto qayta;
            }
        }
    }

}