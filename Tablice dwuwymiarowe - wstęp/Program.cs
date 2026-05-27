class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int[,] macierz = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for ( int j = 0; j < n; j++)
            {
                
                /* Console.Write(macierz[i, j]); */
                if ( i == j)
                {
                    macierz[i, j] = 1;
                    
                }
                else
                {
                    macierz[i, j] = 0;
                }
            }
            
           
        }
           for (int i = 0; i < n; i++)
        {
                
            for (int j = 0; j < n; j++)
            {
                Console.Write($" {macierz[i, j]} ");
            }
            Console.WriteLine();
        }
         






    }







}