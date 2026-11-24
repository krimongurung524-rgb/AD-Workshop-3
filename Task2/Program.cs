using System;

namespace Task2
{
    class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;

            // 1. Ternary operator
            Console.WriteLine(username == null ? "Username is not available" : username);

            // 2. Null-coalescing operator
            Console.WriteLine(username ?? "Username is not available");

            // 3. Null-coalescing assignment: assigns only if username is null
            username ??= "Guest";
            Console.WriteLine($"Updated username: {username}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NullOperations obj = new NullOperations();
            obj.PerformNullChecks();
        }
    }
}