namespace PM1App1;

public class Program
{ 
    public static void Main()
    {
        // Loops();

        // Functions();

        // Tuples();

        OOP();
    }

    #region Loops
    public static void Loops()
    {
        {
            // First check condition, then execute loop iteration
            //while(condition)
            //{
            //    body of loop
            //}

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            string[] names = { "John", "Silvester", "Patrick", "Vladimir" };
            int nameCounter = 0;
            while (nameCounter < names.Length)
            {
                var name = names[nameCounter];
                Console.WriteLine(name);
                nameCounter++;
            }

            Console.WriteLine("infinite loop");
            int i = 0;
            while (true)
            {
                i++;

                if (i > 3 && i < 7)
                    continue; // break iteration, skip code below continue during current interation

                if (i > 15)
                    break; // exit the loop

                Console.WriteLine(i);
            }
        }

        {
            // First execute, then check condition
            //do 
            //{ 

            //}
            //while (condition);

            do
            {
                Console.WriteLine("How old are you?");
                var strAge = Console.ReadLine();

                int age;

                if (!Int32.TryParse(strAge, out age) || age < 0 || age > 150)
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }

                Console.WriteLine($"Your age is {age}");
                break;
            }
            while (true);
        }

        {
            // for(init; condition; rule for step)
            //{

            //}

            string separator = "--------------------------------------------";

            Console.WriteLine("for loop");
            Console.WriteLine(separator);
            string[] names = { "John", "Silvester", "Patrick", "Vladimir" };
            for (var i = 0; i < names.Length; i++)
            {
                var name = names[i];
                Console.WriteLine(name);
            }
            Console.WriteLine(separator);
            Console.WriteLine("");

            Console.WriteLine("for reverse loop");
            Console.WriteLine(separator);
            for (var i = names.Length - 1; i >= 0; i--)
            {
                var name = names[i];
                Console.WriteLine(name);
            }
            Console.WriteLine(separator);
            Console.WriteLine("");

            Console.WriteLine("for +2 loop");
            Console.WriteLine(separator);
            for (var i = 0; i < names.Length; i += 2)
            {
                var name = names[i];
                Console.WriteLine(name);
            }
            Console.WriteLine(separator);
            Console.WriteLine("");

            Console.WriteLine("while +2 loop");
            Console.WriteLine(separator);
            int j = 0;
            while (j < names.Length)
            {
                var name = names[j];
                Console.WriteLine(name);
                j += 2;
            }
            Console.WriteLine(separator);
            Console.WriteLine("");

            Console.WriteLine("for loop with continue");
            Console.WriteLine(separator);
            for (var i = 0; i < names.Length; i++)
            {
                if (i % 2 == 0)
                    continue;

                var name = names[i];

                Console.WriteLine(name);
            }
            Console.WriteLine(separator);
            Console.WriteLine("");
        }

        {
            // foreach(var item in collecton)
            //{

            //}

            string separator = "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";

            Console.WriteLine("foreach loop");
            Console.WriteLine(separator);
            string[] names = { "Olga", "Julia", "Evgeniya", "Klavdiya", "Elizaveta", "Ekaterina" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(separator);
            Console.WriteLine("");

            Console.WriteLine("foreach loop over numbers");
            Console.WriteLine(separator);
            int[] numbers = { 23, 34, 45, 67, 12, 34, 57, 89, 72 };
            var sum = 0;
            foreach (var number in numbers)
                sum += number;
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine(separator);
            Console.WriteLine("");

        }
    }

    #endregion

    #region funcions
    public static void Functions()
    {
        // /Вызов функции
        PrintHello("Vasya");

        PrintHello(name: "Vasya");

        PrintHello("Vasya", 10);

        PrintHello(age: 67, name: "Petya");

        // PrintHello(67, "petya"); низя

        PrintHello("Vasya", age: 24);

        PrintHello(name: "Vasya", 34);

        int c = Sum(10, 22);

        int d = Sum(10, 45, 34);

        int e = Sum(10, 20, 30, 40, 50);

        float res = Divide(numer: 34.45f, denom: 67.23f);

        int res2 = Sum(new int[] { 12, 45, 56, 67, 56, 12, 89, 43, 12, 123 });
        Console.WriteLine(res2);

        int res3 = Sum(12, 45, 56, 67, 56, 12, 89, 43, 12, 123);
        Console.WriteLine(res3);

        int num = 10;
        ChangeValue1(num);
        Console.WriteLine(num);

        ChangeValue2(ref num);
        Console.WriteLine(num);

        string dirName;
        string filePath = @"C:\Users\MVereshchagin\Downloads\unione-testers-1663951351694.xls";
        if (TryGetDirName(filePath, out dirName))
            Console.WriteLine($"Directory Name is {dirName}");
        else
            Console.WriteLine($"File {filePath} is incorrect");

        var fib10 = Fibonacci(10);
        Console.WriteLine(fib10);

        PrintHello3("Венцеслав");
    }

    // модификатор_доступа доп_слова
    // тип_возвращаемого_значения Название(тип_параметра название_параметраб ...)
    // Объявление функции
    static void PrintHello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

    static void PrintHello(string name, int age)
    {
        if (age < 18)
            Console.WriteLine($"Hi, {name}");
        else
            Console.WriteLine($"Good morning, {name}");
    }

    static int Sum(int a, int b = 0, int c = 0, int d = 0, int e = 0)
    {
        return a + b + c + d + e;
    }

    static int Sum(params int[] numbers)
    {
        var res = 0;
        foreach (var number in numbers)
            res += number;
        return res;
    }

    //static int Sum(int a, int b, int c)
    //{
    //    return a + b + c;
    //}

    static float Divide(float numer, float denom)
    {
        return numer / denom;
    }

    static void ChangeValue1(int a)
    {
        a += 10;
    }

    // ref = передается по ссылке
    static void ChangeValue2(ref int a)
    {
        a += 10;
    }

    // out = передается по ссылке и должен быть присвоен внутри функции
    static bool TryGetDirName(string filePath, out string? dirName)
    {
        if (!System.IO.File.Exists(filePath))
        {
            dirName = null;
            return false;
        }

        dirName = System.IO.Path.GetDirectoryName(filePath);

        return true;
    }

    // in = передается по ссылке, но менять нельзя
    static void ChangeValue3(in int a)
    {
        // a = 10; низя
    }

    static int Fibonacci(int i)
    {
        if (i == 0)
            return 0;
        if (i == 1)
            return 1;

        return Fibonacci(i - 1) + Fibonacci(i - 2);
    }

    static void PrintHello3(string name) => Console.WriteLine($"Hello, {name}");

    #endregion

    #region Tuples
    public static void Tuples()
    {
        float[] array = { 23.4f, 12.4f, 7.2f, 13.1f, 16.8f, 2.3f, 5.3f, 11.2f};
        var valueToSearch = 5.0f;

        var res = FindValueInArray(array, valueToSearch);
        Console.WriteLine($"found closest value is {res.Item2} with index {res.Item1}");

        (var index, var value) = FindValueInArray(array, valueToSearch);
        Console.WriteLine($"found closest value is {value} with index {index}");

        var (index1, value1) = FindValueInArray(array, valueToSearch);
        Console.WriteLine($"found closest value is {value1} with index {index1}");

        var res2 = FindValueInArray2(array, valueToSearch);
        Console.WriteLine($"found closest value is {res2.Value} with index {res2.Index}");

        Write("Hello, PM1 in position", 50, 2);
        Console.WriteLine("dsadsadas");
    }

    public static (int, float?) FindValueInArray(float[] array, float value)
    {
        var curIndex = -1;
        for(var i = 0; i < array.Length; i++)
        {
            var curValue = (curIndex > -1 ? array[curIndex] : float.MaxValue);

            if (MathF.Abs(curValue - value) > MathF.Abs(array[i] - value))
                curIndex = i;
        }

        if (curIndex == -1)
            return (curIndex, null);

        return (curIndex, array[curIndex]);
    }

    public static (int Index, float? Value) FindValueInArray2(float[] array, float value)
    {
        var curIndex = -1;
        for (var i = 0; i < array.Length; i++)
        {
            var curValue = (curIndex > -1 ? array[curIndex] : float.MaxValue);

            if (MathF.Abs(curValue - value) > MathF.Abs(array[i] - value))
                curIndex = i;
        }

        if (curIndex == -1)
            return (curIndex, null);

        return (curIndex, array[curIndex]);
    }

    public static void Write(string message, int left, int top)
    {
        var position = Console.GetCursorPosition();

        Console.SetCursorPosition(left, top);
        Console.Write(message);
        Console.SetCursorPosition(position.Left, position.Top);
    }
    #endregion

    #region OOP
    public static void OOP()
    {
        // создание объектов
        Person person1 = new Person(); // new означает инцииализацию объекта
                                       // выделяется память для объекта
                                       // вызывается конструктор

        string str = $"Hello, {person1}";
        Console.WriteLine(str);

        var person2 = new Person();

        Person person3 = new();

        Person person4 = new("Petya");

        Person person5 = new(name: "Vasilii", email: "vaslilii@mail.ru");
        person5.Name = "Егор";

        // создание с инициализацией pulbic fields
        Person person6 = new() { Name = "Vasilii" };

        // деконструтрование объекта
        var (name, email) = person6;
        var (name1, email1, description1) = person6;

        // обращение к статической переменной
        var count = Person.Count;
        Console.WriteLine($"Count = {count}");

        person1.Email = "dsadsadas";
        var email6 = person1.Email;

        Person person7 = new() { Email3 = "dsadsadas" };
        var email3 = person7.Email3;
        // низя, ай-ай-ай
        // person7.Email3 = "dsadsada";

        //var budeny = new Human()
        //{
        //    Name = "Василий",
        //    Surname = "Буденый",
        //    Email = "super_vaska@mail.ru",
        //    Phone = null,
        //    Gender = Gender.Male,
        //    DateOfBirth = new DateTime(day: 22, month: 8, year: 1968),
        //};
        //Console.WriteLine(budeny);

        var savkin = new Teacher(name: "Дмитрий", surname: "Савкин", dateOfBirth: new DateTime(day: 1, month: 1, year: 1970),
            gender: Gender.Male)
        {
            //Name = "Дмитрий",
            //Surname = "Савкин",
            Email = "savkind@list.ru",
            //Gender = Gender.Male,
            Occupation = "Руководитель образовательных программ",
            Title = "Доцент",
            Degree = null,
            Phone = null,
            //DateOfBirth = new DateTime(day: 1, month: 1, year: 1970),
        };

        Console.WriteLine("============================================");
        Console.WriteLine(savkin);
        Console.WriteLine("============================================");
        Console.WriteLine("");

        var kchromova = new Student(name: "Наталья", surname: "Хромова", gender: Gender.Female,
            dateOfBirth: new DateTime(day: 1, month: 1, year: 2000))
        {
            Name = "Наталья",
            Surname = "Хромова",
            Email = "NKhromova@stud.kantiana.ru",
            Phone = null,
            Gender = Gender.Female,
            DateOfBirth = new DateTime(day: 1, month: 1, year: 2000),
            Direction = "Прикладная математика и информатика",
            Course = 1,
        };

        Console.WriteLine("============================================");
        Console.WriteLine(kchromova);
        Console.WriteLine("============================================");
        Console.WriteLine("");

        Human[] humans =
        {
            new Student(name: "Наталья", surname: "Хромова", gender: Gender.Female,
                        dateOfBirth: new DateTime(day: 1, month: 1, year: 2000))
            {
                Email = "NKhromova@stud.kantiana.ru",
                Phone = null,
                Direction = "Прикладная математика и информатика",
                Course = 1,
            },
            new Student(name: "Роман", surname: "Гросс", gender: Gender.Male,
                        dateOfBirth: new DateTime(day: 1, month: 1, year: 2000))
            {
                Email = "RGross@stud.kantiana.ru",
                Phone = null,
                DateOfBirth = new DateTime(day: 1, month: 1, year: 2000),
                Direction = "Прикладная математика и информатика",
                Course = 1,
            },
            new Teacher(name: "Дмитрий", surname: "Савкин", dateOfBirth: new DateTime(day: 1, month: 1, year: 1970),
                gender: Gender.Male)
            {
                //Name = "Дмитрий",
                //Surname = "Савкин",
                Email = "savkind@list.ru",
                //Gender = Gender.Male,
                Occupation = "Руководитель образовательных программ",
                Title = "Доцент",
                Degree = null,
                Phone = null,
                //DateOfBirth = new DateTime(day: 1, month: 1, year: 1970),
            }
        };

        Console.WriteLine("==========================================");
        Console.WriteLine("Output of Array");
        Console.WriteLine("==========================================");
        foreach (var human in humans)
            Console.WriteLine(human);
    }
    #endregion
}





