using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM1App1;

internal class Student : Human
{
    public string Direction { get; set; } = null!;

    public byte Course { get; set; }

    public override string ToString()
    {
        string str = base.ToString();
        str += $"Направление подготовки: {Direction}" +
            $"\r\nКурс: {Course}";

        return str;
    }

    public Student(string name, string surname, DateTime dateOfBirth, Gender gender) :
        base(name, surname, dateOfBirth, gender)
    { }
}
