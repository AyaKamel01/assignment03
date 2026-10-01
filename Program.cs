namespace assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.Write("enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


            //2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.Write("enter an integer number:");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("negative number");
            }
            else
            {
                Console.WriteLine("positive");
            }


            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.Write("Enter 3 integer numbers: ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int max = num1;
            int min = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine($"Max ={max}");
            Console.WriteLine($"Min ={min}");


            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter an integer number: ");

            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }


            //5- Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            Console.WriteLine("enter a character:");

            char ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }


            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.WriteLine("Enter an integar");

            int n = int.Parse(Console.ReadLine());

            int i = 1;

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }


            //7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Console.Write("Enter an integer: ");

            int m = int.Parse(Console.ReadLine());

            int j = 1;

            for (j = 1; j <= 12; j++)
            {
                Console.Write(j * m);
                Console.Write("  ");
            }

            Console.WriteLine();


            //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number.
            Console.WriteLine("enter a num");

            int e = int.Parse(Console.ReadLine());

            int v = 1;

            for (v = 1; v <= e; v++)
            {
                if (v % 2 == 0)
                {
                    Console.WriteLine(v);
                }
            }


            //9- Write a program that takes two integers then prints the power.
            Console.WriteLine("enter two integers");

            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            int result = 1;

            for (int r = 1; r <= q; r++)
            {
                result *= p;
            }

            Console.WriteLine(result);


            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            Console.WriteLine("Enter marks of five subjects:");

            int sub1 = int.Parse(Console.ReadLine());
            int sub2 = int.Parse(Console.ReadLine());
            int sub3 = int.Parse(Console.ReadLine());
            int sub4 = int.Parse(Console.ReadLine());
            int sub5 = int.Parse(Console.ReadLine());

            int total = sub1 + sub2 + sub3 + sub4 + sub5;

            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Percentage: {percentage}%");


            //11- Write a program to input the month number and print the number of day in that month.
            Console.WriteLine("Enter month number:");

            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 2:
                    Console.WriteLine("Days in Month: 28 or 29");
                    break;

                case 3:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 4:
                    Console.WriteLine("Days in Month: 30");
                    break;

                case 5:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 6:
                    Console.WriteLine("Days in Month: 30");
                    break;

                case 7:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 8:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 9:
                    Console.WriteLine("Days in Month: 30");
                    break;

                case 10:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 11:
                    Console.WriteLine("Days in Month: 30");
                    break;

                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;
            }


            //12- Write a program to create a Simple Calculator.
            Console.WriteLine("enter two numbers and operator:");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            char z = char.Parse(Console.ReadLine());

            switch (z)
            {
                case '+':
                    Console.WriteLine(x + y);
                    break;

                case '-':
                    Console.WriteLine(x - y);
                    break;

                case '*':
                    Console.WriteLine(x * y);
                    break;

                case '/':
                    Console.WriteLine(x / y);
                    break;

                case '%':
                    Console.WriteLine(x % y);
                    break;

                case '^':
                    Console.WriteLine(Math.Pow(x, y));
                    break;
            }


            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.WriteLine("enter a string");

            string str = Console.ReadLine();

            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));


            //14- Write a program to allow the user to enter int and print the REVERSED of it.
            Console.WriteLine("enter a integar");

            int num4 = int.Parse(Console.ReadLine());

            char[] numArray = num4.ToString().ToCharArray();

            Array.Reverse(numArray);

            Console.WriteLine(new string(numArray));


            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.Write("enter start num and end num :");

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i2 = start; i2 <= end; i2++)
            {
                int count = 0;

                for (int j2 = 1; j2 <= i2; j2++)
                {
                    if (i2 % j2 == 0)
                        count++;
                }

                if (count == 2)
                    Console.WriteLine(i2);
            }


            //16- Write a program in C# Sharp to convert a decimal number into binary without using an array.
            Console.Write("Enter a number to convert : ");

            int decimalNumber = int.Parse(Console.ReadLine());

            int binary = 0;
            int place = 1;

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;

                binary = binary + remainder * place;

                decimalNumber = decimalNumber / 2;
                place = place * 10;
            }

            Console.WriteLine($"The Binary is {binary}");


            //17- Create a program that asks the user to input three points (x1, y1),(x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter x3: ");
            double x3 = double.Parse(Console.ReadLine());

            Console.Write("Enter y3: ");
            double y3 = double.Parse(Console.ReadLine());

            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            {
                Console.WriteLine("The points lie on a straight line");
            }
            else
            {
                Console.WriteLine("The points do not lie on a straight line");
            }


            //18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows:
            Console.Write("Enter the time taken: ");

            double time = double.Parse(Console.ReadLine());

            switch (time)
            {
                case double t when t >= 2 && t < 3:
                    Console.WriteLine("Highly efficient");
                    break;

                case double t when t >= 3 && t < 4:
                    Console.WriteLine("Increase your speed");
                    break;

                case double t when t >= 4 && t <= 5:
                    Console.WriteLine("Training is required");
                    break;

                case double t when t > 5:
                    Console.WriteLine("Leave the company");
                    break;
            }


            //19- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n*n.
            Console.Write("Enter n: ");

            int n2 = int.Parse(Console.ReadLine());

            for (int i3 = 0; i3 < n2; i3++)
            {
                for (int j3 = 0; j3 < n2; j3++)
                {
                    if (i3 == j3)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }

                Console.WriteLine();
            }


            //20- Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = { 1, 2, 3, 4, 5 };

            int sum = 0;

            for (int i4 = 0; i4 < arr.Length; i4++)
            {
                sum += arr[i4];
            }

            Console.WriteLine($"The sum of all elements in the array is: {sum}");


            //21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            Console.Write("Enter size of arrays: ");

            int n3 = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n3];
            int[] arr2 = new int[n3];
            int[] merged = new int[n3 * 2];

            Console.WriteLine("Enter elements of first array:");

            for (int i5 = 0; i5 < n3; i5++)
            {
                arr1[i5] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of second array:");

            for (int i6 = 0; i6 < n3; i6++)
            {
                arr2[i6] = int.Parse(Console.ReadLine());
            }

            for (int i7 = 0; i7 < n3; i7++)
            {
                merged[i7] = arr1[i7];
                merged[i7 + n3] = arr2[i7];
            }

            Array.Sort(merged);

            Console.WriteLine("Merged array:");

            for (int i8 = 0; i8 < merged.Length; i8++)
            {
                Console.Write(merged[i8] + " ");
            }

            Console.WriteLine();


            //22- Write a program in C# Sharp to count the frequency of each element of an array.
            Console.Write("Enter size of array: ");

            int n4 = int.Parse(Console.ReadLine());

            int[] arr3 = new int[n4];
            bool[] counted = new bool[n4];

            Console.WriteLine("Enter elements:");

            for (int i9 = 0; i9 < n4; i9++)
            {
                arr3[i9] = int.Parse(Console.ReadLine());
            }

            for (int i10 = 0; i10 < n4; i10++)
            {
                if (counted[i10])
                    continue;

                int count = 1;

                for (int j4 = i10 + 1; j4 < n4; j4++)
                {
                    if (arr3[i10] == arr3[j4])
                    {
                        count++;
                        counted[j4] = true;
                    }
                }

                Console.WriteLine(arr3[i10] + " occurs " + count + " time(s)");
            }


            //23- Write a program in C# Sharp to find maximum and minimum element in an array.
            Console.Write("Enter size of array: ");

            int n5 = int.Parse(Console.ReadLine());

            int[] arr4 = new int[n5];

            Console.WriteLine("Enter elements:");

            for (int i11 = 0; i11 < n5; i11++)
            {
                arr4[i11] = int.Parse(Console.ReadLine());
            }

            int max2 = arr4[0];
            int min2 = arr4[0];

            for (int i12 = 1; i12 < n5; i12++)
            {
                if (arr4[i12] > max2)
                    max2 = arr4[i12];

                if (arr4[i12] < min2)
                    min2 = arr4[i12];
            }

            Console.WriteLine("Maximum = " + max2);
            Console.WriteLine("Minimum = " + min2);


            //24- Write a program in C# Sharp to find the second largest element in an array.
            Console.Write("Enter size of array: ");

            int n6 = int.Parse(Console.ReadLine());

            int[] arr5 = new int[n6];

            Console.WriteLine("Enter elements:");

            for (int i13 = 0; i13 < n6; i13++)
            {
                arr5[i13] = int.Parse(Console.ReadLine());
            }

            int max3 = arr5[0];
            int secondMax = arr5[0];

            for (int i14 = 1; i14 < n6; i14++)
            {
                if (arr5[i14] > max3)
                {
                    secondMax = max3;
                    max3 = arr5[i14];
                }
                else if (arr5[i14] > secondMax && arr5[i14] != max3)
                {
                    secondMax = arr5[i14];
                }
            }

            Console.WriteLine("Second largest = " + secondMax);


            //25- Write a program to find the longest distance between two equal elements in an array.
            Console.Write("Enter size of array: ");

            int n7 = int.Parse(Console.ReadLine());

            int[] arr6 = new int[n7];

            Console.WriteLine("Enter elements:");

            for (int i15 = 0; i15 < n7; i15++)
            {
                arr6[i15] = int.Parse(Console.ReadLine());
            }

            int maxDistance = 0;

            for (int i16 = 0; i16 < n7; i16++)
            {
                for (int j5 = i16 + 1; j5 < n7; j5++)
                {
                    if (arr6[i16] == arr6[j5])
                    {
                        int distance = j5 - i16 - 1;

                        if (distance > maxDistance)
                            maxDistance = distance;
                    }
                }
            }

            Console.WriteLine("Longest distance = " + maxDistance);


            //26- Given a list of space separated words, reverse the order of the words.
            Console.Write("Enter a sentence: ");

            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            for (int i17 = words.Length - 1; i17 >= 0; i17--)
            {
                Console.Write(words[i17] + " ");
            }

            Console.WriteLine();


            //27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            Console.Write("Enter number of rows: ");

            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");

            int columns = int.Parse(Console.ReadLine());

            int[,] arr7 = new int[rows, columns];
            int[,] arr8 = new int[rows, columns];

            Console.WriteLine("Enter elements:");

            for (int i18 = 0; i18 < rows; i18++)
            {
                for (int j6 = 0; j6 < columns; j6++)
                {
                    arr7[i18, j6] = int.Parse(Console.ReadLine());
                }
            }

            for (int i19 = 0; i19 < rows; i19++)
            {
                for (int j7 = 0; j7 < columns; j7++)
                {
                    arr8[i19, j7] = arr7[i19, j7];
                }
            }

            Console.WriteLine("Second Array:");

            for (int i20 = 0; i20 < rows; i20++)
            {
                for (int j8 = 0; j8 < columns; j8++)
                {
                    Console.Write(arr8[i20, j8] + " ");
                }

                Console.WriteLine();
            }


            //28- Write a Program to Print One Dimensional Array in Reverse Order.
            Console.Write("Enter size of array: ");

            int n8 = int.Parse(Console.ReadLine());

            int[] arr9 = new int[n8];

            Console.WriteLine("Enter elements:");

            for (int i21 = 0; i21 < n8; i21++)
            {
                arr9[i21] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order:");

            for (int i22 = n8 - 1; i22 >= 0; i22--)
            {
                Console.Write(arr9[i22] + " ");
            }
        }
    }
}