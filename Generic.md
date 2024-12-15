# الـ Generic في C#

## ما هو الـ Generic؟

Generics يسمح لك بكتابة كود يمكن استخدامه مع أي نوع من البيانات. إليك مثال على كلاس Generic:

```csharp
public class Container<T>
{
    private T item;
    
    public void SetItem(T value)
    {
        item = value;
    }
    
    public T GetItem()
    {
        return item;
    }
}

// استخدام الكلاس
var intContainer = new Container<int>();
var stringContainer = new Container<string>();
```

## فوائد استخدام Generics

1. **Type Safety (أمان النوع)**: يمنع استخدام أنواع بيانات غير متوافقة
2. **منع Boxing/Unboxing**: تحسين الأداء
3. **إعادة استخدام الكود**: كتابة كود قابل للتطبيق على أنواع مختلفة
4. **أداء أفضل**: تجنب التحويلات غير الضرورية
5. **اكتشاف الأخطاء في وقت Compile-time**: كشف الأخطاء مبكرًا

## الفرق بين List و ArrayList

```csharp
// ArrayList (non-generic)
ArrayList list1 = new ArrayList();
list1.Add(1);        // boxing يحدث
list1.Add("string"); // يقبل أي نوع
int num = (int)list1[0]; // unboxing لازم

// List<T> (generic)
List<int> list2 = new List<int>();
list2.Add(1);        // لا يحدث boxing
list2.Add("string"); // خطأ في التصنيف - أمان النوع!
int num = list2[0];  // لا يحتاج casting
```

## Generic Methods

```csharp
public T FindMax<T>(T first, T second) where T : IComparable<T>
{
    return first.CompareTo(second) > 0 ? first : second;
}

// استخدام الدالة
int maxInt = FindMax<int>(10, 20);
string maxString = FindMax<string>("apple", "banana");
```

## Generic Constraints

```csharp
// قيود مختلفة
public class Example<T> where T : class // فقط reference types
{
}

public class Example2<T> where T : struct // فقط value types
{
}

public class Example3<T> where T : new() // يجب أن يكون له constructor فارغ
{
}

public class Example4<T> where T : IComparable // يجب أن ينفذ interface معين
{
}
```

## Multiple Type Parameters

```csharp
public class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
    
    public KeyValuePair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}

// استخدام
var pair = new KeyValuePair<int, string>(1, "One");
```

## Default Value في Generics

```csharp
public T GetDefaultValue<T>()
{
    return default(T);
}

// استخدام
int defaultInt = GetDefaultValue<int>();     // returns 0
string defaultString = GetDefaultValue<string>(); // returns null
```

## Generic Interface

```csharp
public interface IRepository<T>
{
    T GetById(int id);
    void Add(T item);
    void Delete(T item);
    IEnumerable<T> GetAll();
}

public class CustomerRepository : IRepository<Customer>
{
    // تنفيذ الواجهة للعميل
}
```

## Generic Delegate

```csharp
public delegate T Operation<T>(T x, T y);

public class Calculator
{
    public static int Add(int x, int y) { return x + y; }
    public static int Multiply(int x, int y) { return x * y; }
    
    public void DoOperation()
    {
        Operation<int> op = Add;
        int result = op(5, 3); // 8
        
        op = Multiply;
        result = op(5, 3); // 15
    }
}
```

## Generic Collections

```csharp
public void CollectionsExample()
{
    // List
    List<string> names = new List<string>();
    
    // Dictionary
    Dictionary<int, string> dict = new Dictionary<int, string>();
    
    // Queue
    Queue<int> numbers = new Queue<int>();
    
    // Stack
    Stack<double> values = new Stack<double>();
    
    // HashSet
    HashSet<string> uniqueNames = new HashSet<string>();
}
```

## Generic Variance

```csharp
// Covariance - using out
IEnumerable<string> strings = new List<string>();
IEnumerable<object> objects = strings; // OK - covariant

// Contravariance - using in
Action<object> actionObject = obj => Console.WriteLine(obj);
Action<string> actionString = actionObject; // OK - contravariant
```

## Generic Events

```csharp
public class EventArgs<T>
{
    public T Data { get; set; }
}

public class Publisher
{
    public event EventHandler<EventArgs<string>> OnDataReceived;
    
    public void ReceiveData(string data)
    {
        OnDataReceived?.Invoke(this, new EventArgs<string> { Data = data });
    }
}
```
