class Solution {
    
//If N is even and in the inclusive range of  to , print Not Weird
//If N is even and in the inclusive range of  to , print Weird
//If N is even and greater than , print Not Weird

    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        if(N % 2==1)
        Console.WriteLine("Weird");
        else if(N % 2==0 && N>1 && N<6)
        Console.WriteLine("Not Weird"); 
        else if(N % 2==0 && N>6 && N<21)
        Console.WriteLine("Weird");
        else if(N % 2==0 && N>20)
        Console.WriteLine("Not Weird");
    }
}