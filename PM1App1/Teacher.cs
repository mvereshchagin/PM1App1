using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM1App1;

internal class Teacher : Human
{
    public string Occupation { get; set; } = null!;

    public string Title { get; set; } = null!;
    
    public string? Degree { get; set; }

    public override string ToString()
    {
        var str = base.ToString();
        StringBuilder sb = new StringBuilder();
        sb.Append(str);
        sb.AppendLine($"Должность: {Occupation}");
        sb.Append($"Звание: {Title}");
        if (this.Degree is not null)
        {
            sb.Append($"\r\nУченая степень: {Degree}");
        }

        return sb.ToString();
    }

    public Teacher(string name, string surname, DateTime dateOfBirth, Gender gender) : 
        base(name, surname, dateOfBirth, gender)
    { }
}
