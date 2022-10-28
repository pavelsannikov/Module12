using System;
class Program
{
    static User[] users = new User[2];
    static void Main(string[] args)
    {
        users[0] = new User();
        users[0].IsPremium = false;
        users[0].Login = "123";
        users[0].Name = "Вася";

        users[1] = new User();
        users[1].IsPremium = true;
        users[1].Login = "ЛогинПети";
        users[1].Name = "Петя";

        foreach (User user in users)
        {
            Console.WriteLine("Здравствуйте, {0}", user.Name);
            if (!user.IsPremium)
            {
                ShowAds();
            }
        }

    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}
