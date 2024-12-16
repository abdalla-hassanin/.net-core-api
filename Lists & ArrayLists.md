## 1. ما الفرق بين List<T> و ArrayList؟

الجواب:

| الميزة | List<T> | ArrayList |
|--------|---------|-----------|
| النوعية | Generic (تُحدد النوع أثناء التعريف) | Non-Generic (يمكن تخزين أنواع متعددة) |
| الأداء | أسرع لأنه لا يحتاج إلى Boxing/Unboxing | أبطأ بسبب الحاجة إلى Boxing/Unboxing |
| التحقق من النوع | يتم التحقق أثناء وقت الترجمة (Compile-time) | يتم التحقق أثناء وقت التشغيل (Runtime) |
| الأمان | أكثر أمانًا (Type-Safe) | أقل أمانًا، قد تحدث أخطاء من اختلاف الأنواع |
| الدعم في C# | يُفضل استخدامها مع .NET الحديثة | قديمة، ولا يُفضل استخدامها بعد C# 2.0 |

## 2. ما الفرق بين Array و List<T>؟

الجواب:

| الميزة | Array | List<T> |
|--------|-------|---------|
| الحجم | حجم ثابت عند الإنشاء | ديناميكي، يمكن تعديل الحجم بإضافة/حذف عناصر |
| الكفاءة | أسرع عند معرفة عدد العناصر | أقل كفاءة نسبيًا بسبب التوسع الديناميكي |
| الوظائف | أساسي، يدعم التخزين والوصول فقط | يحتوي على وظائف مدمجة مثل Add, Remove |
| الدعم للـ Generics | لا يدعم Generics | يدعم Generics لتحديد نوع العناصر |

## 3. متى تستخدم Array بدلاً من List<T>؟

الجواب:

استخدم Array إذا:
- كنت تعرف عدد العناصر مسبقًا.
- الأداء هو الأولوية (الأسرع عند الوصول العشوائي).
- تحتاج إلى تخزين بيانات أساسية ثابتة.

استخدم List<T> إذا:
- كنت بحاجة إلى مجموعة ديناميكية يمكن تعديل حجمها.
- كنت تحتاج إلى وظائف جاهزة مثل الفرز، الإضافة، والحذف.

## 4. لماذا يعتبر List<T> أكثر كفاءة من ArrayList؟

الجواب:

الأداء:
- List<T> يستخدم Generics مما يعني عدم وجود عمليات Boxing/Unboxing.
- ArrayList يستخدم Boxing/Unboxing عند التعامل مع الأنواع الأساسية (مثل int, float)، مما يستهلك أداء إضافيًا.

الأمان:
- List<T> يوفر أمان نوعي (Type Safety)، مما يمنع إضافة عناصر من أنواع مختلفة.

## 5. ما هو Boxing و Unboxing؟ وكيف يؤثران على ArrayList؟

الجواب:

- Boxing: تحويل نوع قيمة (Value Type) مثل int إلى نوع مرجعي (Reference Type) مثل object.
- Unboxing: تحويل نوع مرجعي إلى نوع قيمة.

في ArrayList:
- عند تخزين int في ArrayList، يتم تحويله إلى object (Boxing).
- عند استرجاع int، يتم تحويله مرة أخرى إلى نوع int (Unboxing).
- هذا يؤثر على الأداء ويزيد من استهلاك الذاكرة.

مثال:

```csharp
ArrayList list = new ArrayList();
list.Add(5); // Boxing
int value = (int)list[0]; // Unboxing
```

## 6. ما هي طريقة AddRange في List<T>؟

الجواب:

AddRange تُستخدم لإضافة مجموعة من العناصر إلى الـ List<T> مرة واحدة.

مثال:

```csharp
List<int> numbers = new List<int> { 1, 2, 3 };
List<int> moreNumbers = new List<int> { 4, 5, 6 };

numbers.AddRange(moreNumbers);

foreach (int num in numbers)
{
    Console.WriteLine(num); // 1, 2, 3, 4, 5, 6
}
```

## 7. ما الفرق بين ArrayList.Add و List<T>.Add؟

الجواب:

- ArrayList.Add: يسمح بإضافة أي نوع لأن ArrayList غير نوعي (Non-Generic).
- List<T>.Add: يقبل فقط النوع المحدد أثناء تعريف القائمة (Generic).

مثال:

```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(10);       // مسموح
arrayList.Add("string"); // مسموح

List<int> list = new List<int>();
list.Add(10);            // مسموح
// list.Add("string");   // خطأ
```

## 8. هل يمكن استخدام أنواع متعددة داخل List<object>؟

الجواب: نعم، يمكن تخزين أنواع متعددة داخل List<object> لأنه يقبل أي نوع مشتق من object.

مثال:

```csharp
List<object> mixedList = new List<object>();
mixedList.Add(10);        // int
mixedList.Add("Hello");   // string
mixedList.Add(3.14);      // double
```

## 9. كيف يمكن تحويل Array إلى List<T> والعكس؟

الجواب:

تحويل Array إلى List:

```csharp
int[] array = { 1, 2, 3 };
List<int> list = new List<int>(array);
```

تحويل List إلى Array:

```csharp
List<int> list = new List<int> { 1, 2, 3 };
int[] array = list.ToArray();
```

## 10. ما هي الفروقات الرئيسية بين List<T>, ArrayList, و Array؟

| الميزة | List<T> | ArrayList | Array |
|--------|---------|-----------|-------|
| Generic | نعم | لا | لا |
| Type Safety | نعم | لا | نعم |
| الأداء | أسرع لأن Generics لا يتطلب Boxing/Unboxing | أبطأ بسبب Boxing/Unboxing | أسرع عند معرفة الحجم مسبقًا |
| الحجم | ديناميكي | ديناميكي | ثابت |
| التوسع | سهل عبر Add, Remove | سهل عبر Add, Remove | لا يمكن التوسع |
| متى تُستخدم؟ | عند الحاجة إلى قائمة ديناميكية | قديمة وغير مفضلة | عند الحاجة إلى قائمة ثابتة الحجم |

## 11. ما الفرق بين Insert و Add في List<T>؟

الجواب:

- Add: تضيف عنصرًا إلى نهاية القائمة.
- Insert: تضيف عنصرًا في موقع محدد داخل القائمة.

مثال:

```csharp
List<int> list = new List<int> { 1, 2, 3 };
list.Add(4);       // 1, 2, 3, 4
list.Insert(1, 10); // 1, 10, 2, 3, 4
```

## 12. ما الفرق بين Count و Capacity في List<T>؟

الجواب:

- Count: يُظهر عدد العناصر الفعلية داخل القائمة.
- Capacity: يُظهر السعة الإجمالية التي يمكن للقائمة استيعابها قبل الحاجة إلى زيادة السعة.

مثال:

```csharp
List<int> list = new List<int>();
Console.WriteLine(list.Count);   // 0
Console.WriteLine(list.Capacity); // 0 (أو قيمة افتراضية)
```

## 13. كيف يتم فرز العناصر في List<T>؟

الجواب: يمكنك استخدام طريقة Sort لفرز العناصر. بشكل افتراضي، يتم الفرز تصاعديًا.

مثال:

```csharp
List<int> numbers = new List<int> { 3, 1, 4, 1, 5 };
numbers.Sort();
foreach (int number in numbers)
{
    Console.WriteLine(number); // 1, 1, 3, 4, 5
}
```

## 14. هل يمكن إزالة العناصر من List<T> أثناء التكرار؟

الجواب: لا يمكن إزالة العناصر أثناء التكرار باستخدام foreach لأنه يؤدي إلى استثناء. يجب استخدام for أو RemoveAll.

مثال باستخدام RemoveAll:

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
numbers.RemoveAll(x => x % 2 == 0); // إزالة الأرقام الزوجية
```
