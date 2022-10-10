using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM1App1;

// модификатор_доступа дополнительные_модиифкаторы class название_класса
// модификаторы доступа:
// public - доступно везде
// private - применяется только для вложенных классов. Означает, доступен только внутри обрамляющего класса
// internal - public для текущего проекта, private для всех остальных
// дополнительные модификаторы:
// sealed - нельзя наследовать
// static - нельзя создавать экземпляр данного класса. Все методы класса static. Дотсуп осещестлвяется Название_класс.Метод
// abstract - нельзя создавать экземпляр данного класса, но можно наследовать и создавать потомков 
internal class Person : System.Object // : родительский класс -> наследование
{
    #region fields
    // поля
    // модификатор_доступа дополнительные_модификаторы тип название_поля
    // модификаторы досступа:
    // private - доступ только внуиирм класса
    // protected - доступ внутри класса и его потомков
    // public - доступ всем
    // private protected - из класса и из потомков в рамках данной сборки
    // protected internal - досттупен всем в текущей сборки и в классах потомках в других сборках
    // дополнительные модификатры:
    // const - неизменямое значение
    // readonly - мжет быть присвоен только в конструкторе и больгше меняться не может
    // static - поле не принадлжит конкретному экхемпляру класса (одно на всех)
    private readonly string _name;
    private string _email;

    public static int Count = 0;

    public string Name;
    #endregion

    #region properties
    // свойства
    // Свойства с атоматическим получением и присвоением
    public string Email
    {
        get; set;
    }

    // Свойства только на чтение извне
    public string Email2
    {
        get;
    }

    // Свойства для чтения, а присвоение только при инициализации
    public string Email3
    {
        get; init;
    }

    public string Email4
    {
        get
        {
            return _email;
        }
    }

    public string Email6 => _email;

    public string Email5
    {
        get
        {
            return _email;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
                return;
            if (!value.Contains("@"))
                return;
            _email = value;
        }
    }

    public string Email7
    {
        get => _email;
        set => _email = value;
    }

    public string Email8
    {
        get => _email;
        set
        {
            if (String.IsNullOrEmpty(value))
                return;
            if (!value.Contains("@"))
                return;
            _email = value;
        }
    }
    #endregion

    #region methods
    // методы
    // setter
    public void SetEmail(string email)
    {
        if (String.IsNullOrEmpty(email))
            return;
        if (!email.Contains("@"))
            return;
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }
    #endregion

    #region ctors
    // конструктор
    // модификатор_доступа название_класса(аргументы)
    public Person(string name, string email) : this(name)
    {
        _email = email;
    }

    public Person(string name) : this()
    {
        _name = name;
    }

    public Person()
    {
        Count++;
    }
    #endregion

    #region deconstructors
    // деконструктор
    public void Deconstruct(out string name, out string email)
    {
        name = Name;
        email = _email;
    }
    public void Deconstruct(out string name, out string email, out string description)
    {
        name = Name;
        email = _email;
        description = "Описание";
    }
    #endregion

}
