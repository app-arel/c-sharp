
class Program{
    //store the salary ranges in an array with their value set to 0
    static int[] salaryRange = new int [9];
    static void Main(string[] args){
    int[] grossSales = [500, 1000, 1500, 2300, 10];
    // you can input the gross sales by each customer in thks array
    foreach (int pay in grossSales)
    {
        int salary = (int)(0.09 * pay + 200)-200/100;
        //this is to calculate the ranges of the salary
        Ranges(salary);
    }
        print();
    }

    static void Ranges(int salary){
        //this method is to calculate the number of salaries that fall under the ranges of all the gross salaries in the gross salary array
        if(salary>=200 && salary <300){
            salaryRange[0]++;
        }
        else if(salary>=300 && salary<400){
            salaryRange[1]++;
        }
        else if(salary>=400 && salary<500){
            salaryRange[2]++;
        }
        else if(salary>=500 && salary<600){
            salaryRange[3]++;
        }
        else if(salary>=600 && salary<700){
            salaryRange[4]++;
        }
        else if(salary>=700 && salary<800){
            salaryRange[5]++;
        }
        else if(salary>=800 && salary<900){
            salaryRange[6]++;
        }
        else if(salary>=900 && salary<1000){
            salaryRange[7]++;
        }
        else if(salary>=1000){
            salaryRange[8]++;
        }
    }
    static void print(){
        //this method is to print the output so as to make your code less messy
        Console.WriteLine("Ranges of salaries               Number of persons");
        Console.WriteLine($"200 - $299                              {salaryRange[0]}");
        Console.WriteLine($"300 - $399                              {salaryRange[1]}");
        Console.WriteLine($"400 - $499                              {salaryRange[2]}");
        Console.WriteLine($"500 - $599                              {salaryRange[3]}");
        Console.WriteLine($"600 - $699                              {salaryRange[4]}");
        Console.WriteLine($"700 - $799                              {salaryRange[5]}");
        Console.WriteLine($"800 - $899                              {salaryRange[6]}");
        Console.WriteLine($"900 - $999                              {salaryRange[7]}");
        Console.WriteLine($"1000                                    {salaryRange[8]}");
    }
}






































// // class Program
// // {
// //     static bool[] seatClass = new bool[10];
// //     static void Main(string[] args)
// //     {
// //         for (int i = 1;; i++)
// //         {
// //             Console.WriteLine("input your option");
// //             bool isValidOption = int.TryParse(Console.ReadLine(), out int option);
// //             if(isValidOption == false){
// //                 Console.WriteLine("Input a number, try again");
// //                 return;
// //             }
// //             Chair(option);
// //             if (i > 10){
// //                 Console.WriteLine("Spaces are booked. type t to terminate");
// //                 string terminate = Console.ReadLine();
// //                 if(terminate == "t"){
// //                     Console.WriteLine("Thank you for your time");
// //                     return;
// //                 }
// //             }
// //         }


// //     }

// //     static void Chair(int option)
// //     {
// //         if (option == 1)
// //         {
// //             for (int f = 0; f < 5; f++)
// //             {
// //                 if (seatClass[f] == false)
// //                 {
// //                     seatClass[f] = true;
// //                     Console.WriteLine($"First class, seat number {f + 1}");
// //                     return;
// //                 }


// //             }
// //             Console.WriteLine("First class is fully booked. Would you like to go to the economy class section. type y to accept");
// //             string choice = Console.ReadLine().ToUpper();
// //             if(choice == "Y"){
// //                 for (int f = 5; f < 10; f++)
// //                 {
// //                     if (seatClass[f] == false)
// //                     {
// //                         seatClass[f] = true;
// //                         Console.WriteLine($"economy class, seat number{f + 1}");
// //                         return;
// //                     }
// //                     // else{
// //                     //     Console.WriteLine("Economy class is fully booked would you");
// //                     //     return;
// //                     // }
// //                 }
// //             }
// //             else{
// //                 Console.WriteLine("Next flight in 3 hours");
// //                 return;
// //             }
// //         }
// //         else if (option == 2)
// //         {
// //             for (int f = 5; f < 10; f++)
// //             {
// //                 if (seatClass[f] == false)
// //                 {
// //                     seatClass[f] = true;
// //                     Console.WriteLine($"Economy class, seat number {f + 1}");
// //                     return;
// //                 }
// //             }
// //             Console.WriteLine("Economy class is fully booked. Would you like to go to the first class section. type y to accept");
// //             string fChoice = Console.ReadLine().ToUpper();
// //             if(fChoice == "Y"){
// //                 for (int f = 0; f < 5; f++)
// //                 {
// //                     if (seatClass[f] == false)
// //                     {
// //                         seatClass[f] = true;
// //                         Console.WriteLine($"First class, seat number {f + 1}");
// //                         return;
// //                     }
// //                 }
// //             }
// //             else{
// //                 Console.WriteLine("Next flight in 4 hours");
// //                 return;
// //             }
// //         }
// //     }
// // }

