class Solution {
    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());

        var list = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var tmp = Console.ReadLine().Split(' ');
            var name = tmp[0];
            var email = tmp[1];

            if (Regex.IsMatch(email, @".+@gmail\.com$"))
            {
                list.Add(name);
            }
        }

        list.Sort();

        foreach (var name in list)
        {
            Console.WriteLine(name);
        }
    }
}
