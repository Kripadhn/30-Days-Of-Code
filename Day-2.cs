class Solution {

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
        double total_cost, ti, ta;
        ti = ((Double)tip_percent/100) * meal_cost;
        ta = ((Double)tax_percent/100) * meal_cost; 
        total_cost=meal_cost + ti + ta;
        int tc= Convert.ToInt32(total_cost);
        Console.WriteLine(tc);

    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}