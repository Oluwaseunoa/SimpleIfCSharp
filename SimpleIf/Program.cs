

class Program
{
    static void Main()
    {
        int marks = 69;
        char gradeLetter;

        //Print Congratulation
        if(marks >= 70)
        {
            gradeLetter = 'A';
           

        }

        else if (marks >= 60 && marks <= 69 )
        {
            gradeLetter = 'B';
            
        }

        else if (marks >= 50 && marks < 59)
        {
            gradeLetter = 'C';
            
        }
        else if (marks >= 40 && marks < 49)
        {
            gradeLetter = 'D';
            
        }
        //Print Failed
        else
        {
            gradeLetter = 'F';
        }
        System.Console.WriteLine(gradeLetter);
        System.Console.ReadKey();
    }
}