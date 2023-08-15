### Паттерн "Прототип"

#### 0. Придумать и создать 3-4 класса, которые как минимум дважды наследуются и написать краткое описание текстом.

Создал три класса FirstClass, SecondClass, ThirdClass. SecondClass наследуется от FirstClass, ThirdClass - от SecondClass. 
У каждого класса по одному полю - FirstField, SecondField, ThirdField соответственно.

#### 1. Создать свой дженерик интерфейс IMyCloneable для реализации шаблона "Прототип".

Создал интерфейс interface IMyClonable<T> с методом MyClone():

```cs
internal interface IMyClonable<T>
{
    public T MyClone();
}
```

#### 2. Сделать возможность клонирования объекта для каждого из этих классов, используя вызовы родительских конструкторов.

Классы FirstClass, SecondClass, ThirdClass реализуют интерфейсы IMyClonable, ICloneable:

```cs
public class FirstClass : ICloneable, IMyClonable<FirstClass>
{
    public string FirstField { get; set; }
    public FirstClass()
    {
        FirstField = "First class";
    }

    public FirstClass(FirstClass obj)
    {
        FirstField = obj.FirstField;
    }
    public object Clone()
    {
        return new FirstClass(this);
    }

    public FirstClass MyClone()
    {
        return new FirstClass(this);
    }

    public override string ToString()
    {
        return FirstField;
    }
}


public class SecondClass : FirstClass, ICloneable, IMyClonable<SecondClass>
{
    public string SecondName { get; set; }

    public SecondClass(SecondClass obj) : base(obj)
    {
        SecondName = obj.SecondName;
    }

    public SecondClass()
    {
        SecondName = "Second class";
    }

    public new object Clone()
    {
        return new SecondClass(this);
    }

    public new SecondClass MyClone()
    {
        return new SecondClass(this);
    }

    public override string ToString()
    {
        return base.ToString() + ", " + SecondName;
    }
}


public class ThirdClass : SecondClass, ICloneable, IMyClonable<ThirdClass>
{
    public string ThirdName { get; set; }

    public ThirdClass()
    {
        ThirdName = "Third class";
    }

    public ThirdClass(ThirdClass obj) : base(obj)
    {
        ThirdName = obj.ThirdName;
    }

    public new object Clone()
    {
        return new ThirdClass(this);
    }

    public new ThirdClass MyClone()
    {
        return new ThirdClass(this);
    }

    public override string ToString()
    {
        return base.ToString() + ", " + ThirdName;
    }
}
```

#### 3. Составить тесты или написать программу для демонстрации функции клонирования.

Создал тестовый xUnit-проект с названием hm9_test со следующим функционалом:

```cs
public class UnitTest
{
    [Fact]
    public void CloneTest()
    {
        var prototypeThirdClass = new ThirdClass();
        var clonedThirdClass = (ThirdClass)prototypeThirdClass.Clone();
        Assert.Equal(prototypeThirdClass.ToString(), clonedThirdClass.ToString());
    }

    [Fact]
    public void MyCloneTest()
    {
        var prototypeThirdClass = new ThirdClass();
        var clonedThirdClass_my = prototypeThirdClass.MyClone();
        Assert.Equal(prototypeThirdClass.ToString(), clonedThirdClass_my.ToString());
    }
}
```

#### 4. Добавить к каждому классу реализацию стандартного интерфейса ICloneable и реализовать его функционал через уже созданные методы.
Описано в пункте 2

#### 5. Написать вывод: какие преимущества и недостатки у каждого из интерфейсов: IMyCloneable и ICloneable.

Результат работы программы:

<image src="images/result.png" alt="result">


<image src="images/res_test.png" alt="test result">

Вывод: Клонирование через стандартный интерфейс ICloneable дольше, чем через IMyCloneable, т.к метод Clone() интерфейса ICloneable возвращает объект типа object, который необходимо привести к типу ThirdClass, а интерфейс IMyCloneable использует дженерик и приведения типов в данном случае нет. 

