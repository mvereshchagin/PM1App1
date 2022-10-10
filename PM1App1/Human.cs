using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM1App1;

/// <summary>
/// Class Human
/// </summary>
internal abstract class Human : System.Object
{
    private string filePath = "";

    public string Name { get; init; } = null!;

    public string Surname { get; init; } = null!;

    public string? Patronymic {  get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime DateOfBirth { get; init; }

    public Gender Gender { get; init; }

    /// <summary>
    /// Returns Age (but does not work right now)
    /// </summary>
    public int Age => throw new NotImplementedException();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Имя: {Name}");
        sb.AppendLine($"Фамилия: {Surname}");
        sb.AppendLine($"ФИО: {ShortName}");
        sb.AppendLine($"Дата рождения: {DateOfBirth:dd.MM.yyyy}");
        if(this.Email is not null)
            sb.AppendLine($"Email: {Email}");
        if(this.Phone is not null)
            sb.AppendLine($"Телефон: {Phone}");
        return sb.ToString();
    }

    public string ShortName
    {
        get
        {
            var res = $"{Surname}";
            if (!String.IsNullOrEmpty(Name))
                res += $" {Name.Substring(0, 1)}.";
            if(Patronymic is not null && !String.IsNullOrEmpty(Patronymic))
                res += $" {Patronymic.Substring(0, 1)}.";

            return res;
        }
    }

    public Human(string name, string surname, DateTime dateOfBirth, Gender gender)
    {
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
        Gender = gender;
    }
}
