namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //singel dimantioal array
            //from any dataype
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[5];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            // arr[5] = 6; // OUT OF BOUND WIDTH 

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>






            //MULTI DIMANTIONAL ARRAY
            // show as 
            //1,2,3,4   ===> Matrix
            //5,6,7,8

            int[,] grades = new int[2,2];
            grades[0,0] = 1;
            grades[0,1] = 2;
            grades[1,0] = 1;
            grades[1,1] = 1;




            // jagged arrays 
            int[][] employess = new int[2][];
            employess[0] = new int[3] { 1, 2, 3 };
            employess[1] = new int[2] { 1, 2 };





            // 


            int s;
            s = Convert.ToInt32(Console.ReadLine());
            string [] arr1= new string [s];

            arr1[0] = "sara";
            arr1[1] = "asma";


            //

            string [,] grades1 = new string[2, 2];
            grades1[0, 0] = "50";
            grades1[0, 1] = "60";
            grades1[1, 0] = "90";



            // jagged arrays
          





        }
    }
}