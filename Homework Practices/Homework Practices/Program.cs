


#region Fibonacci



//Fibonacci(8);
//static void Fibonacci(int n)
//{
//    int a = 0;
//    int b = 1;
//    int c;

//    Console.WriteLine(a);
//    Console.WriteLine(b);

//    for (int i = 1; i <= n; i++)
//    {
//        c = a + b;
//        a = b;
//        b = c;

//        Console.WriteLine(c);

//    }
//}


// double for

//Test();
//static void Test()
//{
//    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

//	for (int i = 0; i < arr.Length; i++)
//	{
//		for (int j = i + 1; j < arr.Length - 1; j++) 
//		{
//			Console.WriteLine(arr[i] + " " + arr[j]);
//		}
//	}
//}

#endregion




//using Homework_Practices;
//ShowSameNameStudentsCount();
//static void ShowSameNameStudentsCount()
//{
//    Student stu1 = new Student()
//    {
//        Id = 1,
//        Name= "Test",
//    };
//    Student stu2 = new Student()
//    {
//        Id = 2,
//        Name = "Test",
//    };
//    Student stu3 = new Student()
//    {
//        Id = 3,
//        Name = "Test1",
//    };
//    Student stu4 = new Student()
//    {
//        Id = 4,
//        Name = "Test",
//    };

//    Student[] students = { stu1, stu2, stu3, stu4 };

//    int count = 0;  
//    for (int i = 0; i < students.Length; i++)
//    {
//        for (int j = 0; j < students.Length - 1; j++) 
//        {
//            if (students[i].Name == students[i].Name)
//            {
//                count++;
//            }
//        }
//    }

//    Console.WriteLine(count);
//}




#region impilicit expilicit

//using Homework_Practices;
//using Homework_Practices.Models;

//Manat manat = new Manat(340);

//Dollar dollar = manat;

//Console.WriteLine(dollar.Usd);

#endregion




using Homework_Practices;
using Homework_Practices.Models;

//StringList list1= new StringList();

//list1.Add("Roya");

//list1.Add("Konul");

//list1.Add("Cinare");

//list1.GetAll();



//DataList<string> students= new DataList<string>();

//students.Add("Roya");

//students.Add("Konul");

//students.Add("Cinare");

//students.GetAll();







//IntList list2=new IntList();

//list2.Add(1);

//list2.Add(2);

//list2.Add(3);

//list2.Add(4);

//list2.GetAll();



//DataList<int> numbers= new DataList<int>();

//numbers.Add(1);

//numbers.Add(2);

//numbers.Add(3);

//numbers.Add(4);

//numbers.GetAll();


//Student2List list3 = new Student2List();

//list3.Add(new Student2 { Id = 1, Name = "Ali" });
//list3.Add(new Student2 { Id = 2, Name = "Aqshin" });
//list3.Add(new Student2 { Id = 3, Name = "Elcan" });

//list3.GetAll();


//DataList<Student2> studentList= new DataList<Student2>();

//studentList.Add(new Student2 { Id = 1, Name = "Ali" });
//studentList.Add(new Student2 { Id = 2, Name = "Aqshin" });
//studentList.Add(new Student2 { Id = 3, Name = "Elcan" });

//studentList.GetAll();



//List<int> nums= new List<int>();

//nums.Add(100);
//nums.Add(22);

//for (int i = 0; i < nums.Count ; i++)
//{
//    for (int j = i + 1; j <= nums.Count - 1; j++)
//    {
//        if (nums[i] > nums[j])
//        {
//            Console.WriteLine("Boyukdur");
//            break;
//        }
//    }
//}



//Repository<Student2> student= new Repository<Student2>();

//Repository<int> num = new Repository<int>();

//Repository<string> str = new Repository<string>();

//Repository<bool> married = new Repository<bool>();


//Repository<Test1, Test2> data = new Repository<Test1, Test2>();






