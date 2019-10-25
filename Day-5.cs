class Solution {

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        if(n>=2 && n<=20)
        {
            int i=1,j=10,t=1;
            for(i=1;i<=j; i++)
            {
                t=n*i;
                Console.WriteLine("{0} x {1} = {2}", n,i,t);
            }
        }
    }
}