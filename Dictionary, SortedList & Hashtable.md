## 1. ما هو الفرق بين Dictionary و Hashtable؟

الجواب:

| الميزة | Dictionary<TKey, TValue> | Hashtable |
|--------|--------------------------|-----------|
| النوع | Generic (يستخدم TKey و TValue لأنواع معينة) | Non-Generic (يخزن الأنواع كـ object) |
| الأداء | أسرع بسبب النوع العام (Generic) وتحقق النوع | أبطأ بسبب استخدام Boxing و Unboxing |
| الأمان | أكثر أمانًا من حيث النوع (Type-Safe) | أقل أمانًا، لا يتحقق من النوع في وقت الترجمة |
| الدعم للـ null | لا يمكن استخدام null في الـ Key ولكن يمكن في الـ Value | يمكن استخدام null في كل من الـ Key و الـ Value |
| الدعم للترتيب | غير مرتب | غير مرتب |

## 2. كيف تقوم بإضافة عناصر إلى Dictionary<TKey, TValue>؟

الجواب: يمكنك إضافة عناصر باستخدام Add أو باستخدام المؤشر ([]).

مثال:

```csharp
Dictionary<int, string> dictionary = new Dictionary<int, string>();

// باستخدام Add
dictionary.Add(1, "One");
dictionary.Add(2, "Two");

// باستخدام المؤشر []
dictionary[3] = "Three";
```

ملاحظة: إذا حاولت إضافة مفتاح موجود مسبقًا باستخدام Add، سيتم رمي استثناء ArgumentException.

## 3. ما الفرق بين Dictionary و SortedList؟

الجواب:

| الميزة | Dictionary<TKey, TValue> | SortedList<TKey, TValue> |
|--------|--------------------------|--------------------------|
| الترتيب | غير مرتب | مرتب بناءً على المفتاح |
| الأداء | أسرع عند إضافة/حذف العناصر (O(1) في المتوسط) | أبطأ بسبب الترتيب الداخلي (O(log n) لكل عملية إضافة) |
| الدعم للـ null | لا يمكن أن يحتوي على null في الـ Key ولكن يمكن في الـ Value | يمكن أن يحتوي على null في الـ Value |
| التكرار | Dictionary لا يحافظ على الترتيب عند التكرار | SortedList يحافظ على الترتيب عند التكرار |

مثال:

```csharp
SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(3, "Three");
sortedList.Add(1, "One");
sortedList.Add(2, "Two");

foreach (var item in sortedList)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
// Output will be in sorted order:
// 1: One
// 2: Two
// 3: Three
```

## 4. متى تستخدم Dictionary بدلاً من Hashtable؟

الجواب:

استخدم Dictionary عندما:
- تحتاج إلى أمان نوع (Type Safety) لأن Dictionary هو نوع عام.
- تحتاج إلى أداء أعلى، لأن Dictionary أكثر كفاءة في التعامل مع الأنواع المحددة.
- تحتاج إلى دعم لعمليات الـ Key و Value التي تكون متوافقة مع أنواع محددة.
- Hashtable هي قديمة، ويجب تجنب استخدامها إذا كنت تعمل مع .NET 2.0 أو الإصدارات الأحدث.

## 5. كيف يتم التعامل مع الـ Keys و Values في Dictionary؟

الجواب: يمكنك الوصول إلى المفاتيح و القيم باستخدام خصائص Keys و Values.

مثال:

```csharp
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "One");
dictionary.Add(2, "Two");

var keys = dictionary.Keys;
var values = dictionary.Values;

Console.WriteLine("Keys:");
foreach (var key in keys)
{
    Console.WriteLine(key);
}

Console.WriteLine("Values:");
foreach (var value in values)
{
    Console.WriteLine(value);
}
```

## 6. ما هو الفرق بين Hashtable و SortedList؟

الجواب:

| الميزة | Hashtable | SortedList<TKey, TValue> |
|--------|-----------|--------------------------|
| الترتيب | غير مرتب | مرتب بناءً على المفتاح |
| الأداء | أسرع عند التعامل مع البيانات غير المرتبة | أبطأ عند إضافة العناصر بسبب الترتيب الداخلي |
| الدعم للـ null | يمكن أن يحتوي على null في الـ Key و الـ Value | يمكن أن يحتوي على null فقط في الـ Value |
| المرونة | أقل مرونة في التفاعل مع الأنواع مقارنة بـ SortedList | يدعم التكرار المرتب (تكرار العناصر في ترتيب معين) |

## 7. كيف تتعامل مع التكرار في Dictionary و SortedList؟

الجواب:

- في Dictionary: التكرار لا يحافظ على ترتيب العناصر.
- في SortedList: التكرار يحافظ على ترتيب العناصر بناءً على المفتاح.

مثال على التكرار في Dictionary:

```csharp
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(3, "Three");
dictionary.Add(1, "One");
dictionary.Add(2, "Two");

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
// Output could be in any order:
// 3: Three
// 1: One
// 2: Two
```

مثال على التكرار في SortedList:

```csharp
SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(3, "Three");
sortedList.Add(1, "One");
sortedList.Add(2, "Two");

foreach (var item in sortedList)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
// Output will be in sorted order:
// 1: One
// 2: Two
// 3: Three
```

## 8. ما هي طرق البحث والتعديل في Dictionary؟

الجواب:

البحث عن قيمة باستخدام TryGetValue:

يُفضل استخدام TryGetValue لتجنب الاستثناءات إذا كانت المفتاح غير موجود.

مثال:

```csharp
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "One");

if (dictionary.TryGetValue(1, out string value))
{
    Console.WriteLine(value);  // One
}
else
{
    Console.WriteLine("Key not found");
}
```

التعديل باستخدام المؤشر []:

يمكن تعديل القيمة المرتبطة بمفتاح معين باستخدام المؤشر.

مثال:

```csharp
dictionary[1] = "Updated One";  // تعديل القيمة
```

## 9. ما هي أفضل الممارسات لاختيار بين Dictionary, Hashtable, و SortedList؟

الجواب:

- استخدم Dictionary<TKey, TValue> إذا كنت بحاجة إلى أداء عالي و أمان نوع مع مفتاح وقيمة.
- استخدم Hashtable إذا كنت تتعامل مع أمثلة قديمة ولا تحتاج إلى نوع ثابت (غير عام)، ولكن يفضل تجنب استخدامها.
- استخدم SortedList<TKey, TValue> إذا كنت بحاجة إلى الترتيب التلقائي بناءً على المفتاح.

## 10. هل يمكن استخدام null كمفتاح في Dictionary و Hashtable؟

الجواب:

- في Dictionary: لا يمكن استخدام null كمفتاح إلا إذا كان النوع المخصص للمفتاح يسمح بذلك (مثل Nullable<int>).
- في Hashtable: يمكن استخدام null كمفتاح وكمحتوى.

## 11. كيف يمكن حذف عنصر من Dictionary و Hashtable؟

الجواب:

في Dictionary:

استخدم Remove لحذف عنصر بواسطة المفتاح.

مثال:

```csharp
dictionary.Remove(1);  // حذف العنصر الذي مفتاحه 1
```

في Hashtable:

أيضًا يمكنك استخدام Remove.

مثال:

```csharp
Hashtable hashtable = new Hashtable();
hashtable.Add(1, "One");
hashtable.Remove(1);  // حذف العنصر الذي مفتاحه 1
```

## الخلاصة:
- Dictionary<TKey, TValue>: الأفضل من حيث الأداء والأمان النوعي.
- Hashtable: قديم ويجب تجنب استخدامه إذا كان بالإمكان.
- SortedList<TKey, TValue>: مناسب إذا كنت تحتاج إلى ترتيب داخلي للمفاتيح.

اختر الهيكل المناسب بناءً على احتياجاتك من حيث الترتيب والأداء والأمان.
