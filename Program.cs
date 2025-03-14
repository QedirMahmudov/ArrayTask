//1.Ədədlərdən ibarət arrayın ən kiçik elementini tapın

//int[] numbers = { 33, 22, 11, 44, 66, 55 };
//int smallNum = numbers[0];
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (smallNum > numbers[i])
//    {
//        smallNum = numbers[i];
//    }
//}
//Console.WriteLine(smallNum);





//2.Ədədlərdən ibarət arrayın elementleri cemini tapan alqoritm
//int[] numbers = { 33, 22, 11, 44, 55 };
//int cem = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    cem += numbers[i];
//}
//Console.WriteLine(cem);





//3.Verilmish arrayin en boyuk ve en kicik elementlerinin indexlerini ekrana çıxaran  algorithm.***
//int[] numbers = { 33, 22, 11, 44, 66, 55, 9 };
//int smallNum = numbers[0];
//int bigNum = numbers[0];
//int smallIndex = 0;
//int bigIndex = 0;
//for (int i = 0; i < numbers.Length; i++)
//{

//    if (smallNum > numbers[i])
//    {
//        smallNum = numbers[i];
//        smallIndex = i;
//    }
//    else if (bigNum < numbers[i])
//    {
//        bigNum = numbers[i];
//        bigIndex = i;
//    }

//}
//Console.WriteLine($"Small:{smallIndex}");
//Console.WriteLine($"Big:{bigIndex}");






//4.Verilmish arrayda murekkeb ededleri ekrana çıxaran algorithm




int[] nums = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 24 };
bool result = false;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = 2; j < nums[i]; j++)
    {
        if (nums[i] % j == 0)
        {
            result = true;
            Console.WriteLine($"murekkeb{nums[i]}");
            break;
        }
    }
}









//ALINMADI SABAH BAX!

//int[] numbers = { 3, 4, 5, 6 };
//int index = 0;
//int maxNum = numbers[0];
//bool result = false;
//int[] compoundNums = new int[index];
//for (int i = 2; i < maxNum; i++)
//{
//    if (maxNum % i == 0)
//    {
//        result = true;
//        break;
//    }


//    //if (maxNum < numbers[i])
//    //{
//    //    maxNum = numbers[i];
//    //}
//}

//if (result)
//{
//    compoundNums = maxNum;
//    Console.WriteLine("Murekkeb");
//    Console.WriteLine(compoundNums);
//}
//else
//{
//    Console.WriteLine("sadedir");
//}








//int[] numbers = { 3, 4, 5, 6, 7, 8 };
//int num = numbers[0];
//bool result = false;

//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 2; j < num; j++)
//    {
//        if (num % j == 0)
//        {
//            result = true;
//            break;
//        }
//        if (num < numbers[i])
//        {
//            num = numbers[i];
//        }
//    }

//    if (result)
//    {
//        Console.WriteLine(num);
//    }
//}



//if (result)
//{
//    Console.WriteLine(num);

//}
//else
//{
//    Console.WriteLine("sadedir");
//}






//int[] numbers = { 5, 9, 12, 11 };
//int index = 0;
//int testNum = numbers[0];
//bool result = false;
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 0; j < testNum; j++)
//    {
//        if (numbers[index] % 2 != 0)
//        {
//            result = true;
//            Console.WriteLine(numbers[i]);
//        }
//        else
//        {
//            Console.WriteLine("false");
//        }

//    }
//}








//int[] nums = { 2, 6, 4, 1, 5 };
//int index = 0;
//int num = nums[0];
//int dividedNumCount = 0;
//int zeroDivided = 0;
//for (int i = 0; i <= nums.Length; i++)
//{
//    if (nums[index] == 1)
//    {
//        Console.WriteLine("ne sadedir ne murekkeb");
//        continue;
//    }
//    for (int j = 1; j <= num; j++)
//    {
//        if (num % j == 0)
//        {
//            dividedNumCount++;
//        }
//        if (dividedNumCount > 2)
//        {
//            Console.WriteLine($"murekkebdir,bolenlerin sayi:{num}");
//        }
//        else
//        {
//            Console.WriteLine("davam!");
//        }
//    }
//    dividedNumCount = 0;
//    if (num > nums[i])
//    {
//        num = nums[i];
//    }
//    Console.WriteLine(num);



//    //Console.WriteLine(num);
//}
//Console.WriteLine(num);









