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
// class Program{

// static int[] rangeOfSalaries = new int[9];
//     static void Main(string[]args){
// int[] grossSales = [2300, 400, 1242, 780, 560, 430, 3400,12000, 334, 992, 8893];

//  int count = 0;
// foreach(int sale in grossSales){
//     double salary = (0.09 * sale) + 200;
//     RangeDisplay(salary);
// }
// Print();
// }


// static void RangeDisplay(double salary)
// {
//     if(salary>200 && salary < 299){
//         rangeOfSalaries[0]++;
//     }
//     else if(salary>300 && salary < 399){
//         rangeOfSalaries[1]++;
//     }
//     else if(salary>400 && salary < 499){
//         rangeOfSalaries[2]++;
//     }
//     else if(salary>500 && salary < 599){
//         rangeOfSalaries[3]++;
//     }
//     else if(salary>600 && salary < 699){
//         rangeOfSalaries[4]++;
//     }
//     else if(salary>700 && salary < 799){
//         rangeOfSalaries[5]++;
//     }
//     else if(salary>800 && salary < 899){
//         rangeOfSalaries[6]++;
//     }
//     else if(salary>900 && salary < 999){
//         rangeOfSalaries[7]++;
//     }
//     else if(salary>1000){
//         rangeOfSalaries[8]++;
//     }
// }
//     static void Print(){
//         Console.WriteLine("Range of salaries            Number of customers in category");
//         Console.WriteLine($"$200-$299                              {rangeOfSalaries[0]}");
//         Console.WriteLine($"$300-$399                              {rangeOfSalaries[1]}");
//         Console.WriteLine($"$400-$499                              {rangeOfSalaries[2]}");
//         Console.WriteLine($"$500-$599                              {rangeOfSalaries[3]}");
//         Console.WriteLine($"$600-$699                              {rangeOfSalaries[4]}");
//         Console.WriteLine($"$700-$799                              {rangeOfSalaries[5]}");
//         Console.WriteLine($"$800-$899                              {rangeOfSalaries[6]}");
//         Console.WriteLine($"$900-$999                              {rangeOfSalaries[7]}");
//         Console.WriteLine($"$1000 and above                        {rangeOfSalaries[8]}");
//     }
// }

class Program{
    static int[] salaryRange = new int [9];
    static void Main(string[] args){
    int[] grossSales = [500, 1000, 1500, 2300, 10];

    foreach (int pay in grossSales)
    {
        int salary = (int)(0.09 * pay + 200)-200/100;
        Ranges(salary);
    }
        print();
    }

    static void Ranges(int salary){
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