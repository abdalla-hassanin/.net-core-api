# 🚀 دليل إنشاء مشروع ABP Framework كامل
## (.NET + Angular 20+)

دليل شامل خطوة بخطوة لبناء تطبيق ويب متكامل باستخدام ABP Framework مع .NET و Angular

---

## 📋 **جدول المحتويات**

1. [المتطلبات الأساسية](#المتطلبات-الأساسية)
2. [تثبيت الأدوات](#تثبيت-الأدوات)
3. [إنشاء مشروع جديد](#إنشاء-مشروع-جديد)
4. [هيكل المشروع](#هيكل-المشروع)
5. [الجزء الأول: إنشاء Backend](#الجزء-الأول-إنشاء-backend)
6. [الجزء الثاني: صفحة عرض البيانات](#الجزء-الثاني-صفحة-عرض-البيانات)
7. [الجزء الثالث: الإضافة والتعديل والحذف](#الجزء-الثالث-الإضافة-والتعديل-والحذف)
8. [الجزء الرابع: اختبارات التكامل](#الجزء-الرابع-اختبارات-التكامل)
9. [الجزء الخامس: الصلاحيات](#الجزء-الخامس-الصلاحيات)
10. [حل المشاكل الشائعة](#حل-المشاكل-الشائعة)
11. [أفضل الممارسات](#أفضل-الممارسات)

---

## ✅ **المتطلبات الأساسية**

### **البرامج المطلوبة:**

#### 1. **Visual Studio 2022 أو أحدث**
- رابط التحميل: https://visualstudio.microsoft.com/
- اختر Workload: **ASP.NET and web development**
- **الشرح:** بيئة التطوير الرئيسية لكتابة كود Backend

#### 2. **.NET 9.0 SDK أو أحدث**
- رابط التحميل: https://dotnet.microsoft.com/download
- التحقق من التثبيت:
```bash
dotnet --version
```
- **الشرح:** Platform اللي هنبني عليه Backend

#### 3. **Node.js 20+ و npm**
- رابط التحميل: https://nodejs.org/
- يُفضل تحميل LTS Version
- التحقق من التثبيت:
```bash
node --version
npm --version
```
- **الشرح:** بيئة تشغيل JavaScript اللي محتاجينها لـ Angular

#### 4. **Yarn Package Manager**
```bash
npm install -g yarn
yarn --version
```
- **الشرح:** بديل أسرع لـ npm في إدارة Packages

#### 5. **SQL Server أو SQL Server Express**
- رابط التحميل: https://www.microsoft.com/sql-server/sql-server-downloads
- أو استخدم SQL Server LocalDB (يأتي مع Visual Studio)
- **الشرح:** قاعدة البيانات اللي هنخزن فيها المعلومات

#### 6. **ABP CLI**
```bash
dotnet tool install -g Volo.Abp.Cli
abp --version
```
- **الشرح:** أداة Command Line لإنشاء وإدارة مشاريع ABP

#### 7. **Git** (اختياري لكن مُوصى به)
- رابط التحميل: https://git-scm.com/
- **الشرح:** لإدارة إصدارات الكود

#### 8. **Angular CLI 20+**
```bash
npm install -g @angular/cli@latest
ng version
```
- **الشرح:** أداة Command Line لإدارة مشاريع Angular

---

## 🔧 **تثبيت الأدوات**

### **الخطوة 1: تثبيت ABP CLI**

افتح Command Prompt أو PowerShell:
```bash
dotnet tool install -g Volo.Abp.Cli
```

**لتحديث ABP CLI لآخر إصدار:**
```bash
dotnet tool update -g Volo.Abp.Cli
```

**التحقق من التثبيت:**
```bash
abp --version
```
**الشرح:** لازم تشوف رقم الإصدار يظهر بدون أخطاء

### **الخطوة 2: التحقق من Node.js و npm**
```bash
node --version
# المفروض يظهر: v20.x.x or higher

npm --version
# المفروض يظهر: 10.x.x or higher
```
**الشرح:** لو الإصدارات أقل من المطلوب، حمّل آخر إصدار من موقع Node.js

### **الخطوة 3: تثبيت Yarn**
```bash
npm install -g yarn
yarn --version
```
**الشرح:** Yarn أسرع من npm في تحميل Packages

### **الخطوة 4: تثبيت Angular CLI**
```bash
npm install -g @angular/cli@latest
ng version
```
**الشرح:** أداة ضرورية لإدارة مشروع Angular

---

## 🆕 **إنشاء مشروع جديد**

### **الخطوة 1: إنشاء المشروع**

**افتح Command Prompt في المجلد اللي عايز تنشئ فيه المشروع:**
```bash
abp new YourProjectName -u angular -d ef --version latest
```

**شرح الـ Parameters:**
- `YourProjectName`: اسم مشروعك (مثال: `MyCompany.MyApp`)
- `-u angular`: استخدم Angular للـ Frontend
- `-d ef`: استخدم Entity Framework Core للـ Database
- `--version latest`: استخدم آخر إصدار من ABP

**مثال عملي:**
```bash
abp new Acme.BookStore -u angular -d ef --version latest
```

**ملاحظة:** العملية دي بتاخد من 2-5 دقائق لتحميل كل الملفات المطلوبة

### **الخطوة 2: الانتقال لمجلد المشروع**
```bash
cd YourProjectName
```
**الشرح:** دلوقتي إحنا جوا مجلد المشروع الرئيسي

### **الخطوة 3: فتح Solution في Visual Studio**

1. ادخل على مجلد المشروع
2. دور على ملف `.sln` (مثال: `Acme.BookStore.sln`)
3. اضغط عليه مرتين للفتح في Visual Studio

**الشرح:** ملف `.sln` هو ملف Solution اللي بيحتوي على كل الـ Projects

---

## 📁 **هيكل المشروع**

```
YourProjectName/
├── aspnet-core/                          # الـ Backend (.NET)
│   ├── src/
│   │   ├── YourProjectName.Application           # Application Services (Business Logic)
│   │   │   └── Books/                            # مثال: Services الخاصة بالكتب
│   │   ├── YourProjectName.Application.Contracts # DTOs & Interfaces
│   │   │   └── Books/                            # مثال: DTOs و Interfaces
│   │   ├── YourProjectName.DbMigrator           # أداة Migration للـ Database
│   │   ├── YourProjectName.Domain               # Domain Layer (Entities, Domain Services)
│   │   │   └── Books/                            # مثال: Entity الكتب
│   │   ├── YourProjectName.Domain.Shared        # Shared Constants & Enums
│   │   │   └── Books/                            # مثال: Constants و Enums
│   │   ├── YourProjectName.EntityFrameworkCore  # EF Core Configuration & Repositories
│   │   │   └── EntityFrameworkCore/              # DbContext و Configurations
│   │   ├── YourProjectName.HttpApi              # HTTP API Controllers
│   │   └── YourProjectName.HttpApi.Host         # API Host Application (نقطة البداية)
│   └── test/
│       ├── YourProjectName.Application.Tests     # اختبارات Application Layer
│       ├── YourProjectName.Domain.Tests          # اختبارات Domain Layer
│       ├── YourProjectName.EntityFrameworkCore.Tests
│       └── YourProjectName.TestBase
│
├── angular/                              # الـ Frontend (Angular)
│   ├── src/
│   │   ├── app/
│   │   │   ├── home/                     # الصفحة الرئيسية
│   │   │   ├── proxy/                    # Auto-generated API Proxies
│   │   │   │   └── books/                # مثال: Service Proxies للكتب
│   │   │   ├── book/                     # مثال: Components الكتب
│   │   │   ├── route.provider.ts         # إعدادات القوائم و Routes
│   │   │   └── app.config.ts             # إعدادات التطبيق
│   │   ├── assets/                       # الصور والملفات الثابتة
│   │   └── environments/                 # إعدادات البيئات (dev, prod)
│   ├── package.json                      # NPM Dependencies
│   └── angular.json                      # إعدادات Angular
│
└── README.md
```

**شرح الهيكل:**
- **Domain Layer:** فيه الـ Entities (الكيانات) والـ Business Rules الأساسية
- **Application Layer:** فيه الـ Services اللي بتنفذ Business Logic
- **HttpApi:** فيه الـ Controllers اللي بتستقبل HTTP Requests
- **EntityFrameworkCore:** فيه إعدادات قاعدة البيانات
- **Angular:** الواجهة اللي المستخدم بيتعامل معاها

---

## 🏗️ **الجزء الأول: إنشاء Backend**

### **الخطوة 1: ضبط اتصال قاعدة البيانات**

**افتح ملف `appsettings.json` في مشروع `YourProjectName.DbMigrator`:**
```json
{
  "ConnectionStrings": {
    "Default": "Server=localhost;Database=YourProjectName;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

**الشرح:** Connection String هو الخيط اللي بيربط التطبيق بقاعدة البيانات

**لو بتستخدم SQL Server Express:**
```json
"Default": "Server=localhost\\SQLEXPRESS;Database=YourProjectName;Trusted_Connection=True;TrustServerCertificate=True"
```

**لو بتستخدم SQL Server مع Username و Password:**
```json
"Default": "Server=localhost;Database=YourProjectName;User Id=sa;Password=YourPassword123;TrustServerCertificate=True"
```

**ملاحظة مهمة:** غيّر نفس الـ Connection String في مشروع `YourProjectName.HttpApi.Host` كمان

### **الخطوة 2: تشغيل Database Migration**

**الطريقة الأولى (الأسهل):**
1. في Visual Studio، اضغط كليك يمين على مشروع `YourProjectName.DbMigrator`
2. اختار **Set as Startup Project**
3. اضغط **Ctrl + F5** لتشغيل المشروع
4. استنى لحد ما تشوف "Successfully completed DbMigrator"
5. اضغط Enter

**الشرح:** البرنامج ده بينشئ قاعدة البيانات ويملاها بـ Initial Data (مستخدم admin، صلاحيات، إلخ)

**الطريقة الثانية (باستخدام Command Line):**
```bash
cd aspnet-core/src/YourProjectName.DbMigrator
dotnet run
```

**البيانات الافتراضية بعد Migration:**
- Username: `admin`
- Password: `1q2w3E*`

### **الخطوة 3: إنشاء أول Entity**

**Entity** هي Class بتمثل جدول في قاعدة البيانات (مثال: Book, Product, Customer)

#### **3.1: تعريف Constants**

**أنشئ مجلد `Books` في مشروع `YourProjectName.Domain.Shared`**

**File: `Books/BookConsts.cs`**
```csharp
namespace YourProjectName.Books;

public static class BookConsts
{
    public const int MaxNameLength = 128;
    public const int MaxIsbnLength = 13;
}
```
**الشرح:** الـ Constants دي بتحدد الحدود (مثل طول الاسم) واحنا هنستخدمها في أماكن متعددة

#### **3.2: إنشاء Enum**

**File: `Books/BookType.cs`** (في `Domain.Shared`)
```csharp
namespace YourProjectName.Books;

public enum BookType
{
    Undefined,      // غير محدد
    Adventure,      // مغامرات
    Biography,      // سيرة ذاتية
    Dystopia,       // ديستوبيا
    Fantastic,      // خيال
    Horror,         // رعب
    Science,        // علمي
    ScienceFiction, // خيال علمي
    Poetry          // شعر
}
```
**الشرح:** Enum بتخلينا نختار من قيم محددة بدل ما نكتب أي حاجة

#### **3.3: إنشاء Entity**

**أنشئ مجلد `Books` في مشروع `YourProjectName.Domain`**

**File: `Books/Book.cs`**
```csharp
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace YourProjectName.Books;

public class Book : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; } = string.Empty;
    
    public BookType Type { get; set; }
    
    public DateTime PublishDate { get; set; }
    
    public float Price { get; set; }
}
```

**شرح الـ Base Classes:**
- `Entity<TKey>`: Entity بسيط فيه ID فقط
- `AuditedEntity<TKey>`: يضيف (CreationTime, CreatorId, LastModificationTime, LastModifierId)
- `AuditedAggregateRoot<TKey>`: نفس اللي فوق + يستخدم في Domain-Driven Design
- `FullAuditedAggregateRoot<TKey>`: يضيف Soft Delete (IsDeleted, DeletionTime, DeleterId)

**ليه استخدمنا `Guid`؟**
- أمان أكثر من int
- مناسب للأنظمة الموزعة (Distributed Systems)
- صعب التنبؤ بالـ IDs

### **الخطوة 4: إضافة Entity للـ DbContext**

**افتح `YourProjectNameDbContext.cs` في مشروع `YourProjectName.EntityFrameworkCore`:**
```csharp
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using YourProjectName.Books; // أضف هذا السطر

namespace YourProjectName.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class YourProjectNameDbContext : AbpDbContext<YourProjectNameDbContext>
{
    // أضف DbSet للكتب
    public DbSet<Book> Books { get; set; }
    
    // ... باقي الـ DbSets
    
    public YourProjectNameDbContext(DbContextOptions<YourProjectNameDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // إعدادات المشروع
        builder.ConfigureYourProjectName();
        
        // أضف إعدادات Book
        builder.Entity<Book>(b =>
        {
            b.ToTable(YourProjectNameConsts.DbTablePrefix + "Books",
                      YourProjectNameConsts.DbSchema);
            b.ConfigureByConvention(); // إعدادات ABP الافتراضية
            b.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(BookConsts.MaxNameLength);
            b.Property(x => x.Price).IsRequired();
        });
    }
}
```

**الشرح:**
- `DbSet<Book>`: بتمثل جدول Books في قاعدة البيانات
- `ToTable()`: بتحدد اسم الجدول
- `ConfigureByConvention()`: بتطبق إعدادات ABP الافتراضية
- `HasMaxLength()`: بتحدد الحد الأقصى للطول في Database

### **الخطوة 5: إنشاء Database Migration**

**افتح Package Manager Console في Visual Studio:**
- من القائمة: **Tools → NuGet Package Manager → Package Manager Console**

**تأكد إن Default Project هو `YourProjectName.EntityFrameworkCore`**

```powershell
Add-Migration "Added_Book_Entity"
```

**الشرح:** 
- الأمر ده بينشئ ملف Migration في مجلد `Migrations`
- ملف الـ Migration بيحتوي على أوامر SQL لإنشاء/تعديل الجداول

**لتطبيق Migration على قاعدة البيانات:**
```powershell
Update-Database
```

**أو** شغّل مشروع `DbMigrator` تاني

**كيف تتحقق من نجاح العملية؟**
1. افتح SQL Server Management Studio
2. شوف قاعدة البيانات
3. لازم تلاقي جدول اسمه `AppBooks`

### **الخطوة 6: إضافة بيانات تجريبية (Seed Data)**

**الهدف:** نملأ قاعدة البيانات ببيانات تجريبية عشان نختبر بيها

**أنشئ أو عدّل ملف في مشروع `YourProjectName.Domain`:**
**File: `YourProjectNameDataSeederContributor.cs`**
```csharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using YourProjectName.Books;

namespace YourProjectName;

public class YourProjectNameDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Book, Guid> _bookRepository;

    public YourProjectNameDataSeederContributor(IRepository<Book, Guid> bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        // تحقق إذا كان في كتب موجودة فعلاً
        if (await _bookRepository.GetCountAsync() > 0)
        {
            return; // لو في كتب، متضفش تاني
        }

        // أضف كتب تجريبية
        await _bookRepository.InsertAsync(
            new Book
            {
                Name = "1984",
                Type = BookType.Dystopia,
                PublishDate = new DateTime(1949, 6, 8),
                Price = 19.84f
            },
            autoSave: true
        );

        await _bookRepository.InsertAsync(
            new Book
            {
                Name = "The Hitchhiker's Guide to the Galaxy",
                Type = BookType.ScienceFiction,
                PublishDate = new DateTime(1979, 10, 12),
                Price = 42.0f
            },
            autoSave: true
        );
        
        await _bookRepository.InsertAsync(
            new Book
            {
                Name = "Harry Potter and the Sorcerer's Stone",
                Type = BookType.Fantastic,
                PublishDate = new DateTime(1997, 6, 26),
                Price = 29.99f
            },
            autoSave: true
        );
    }
}
```

**الشرح:**
- `IDataSeedContributor`: Interface من ABP لإضافة بيانات أولية
- `ITransientDependency`: بتخلي ABP يسجل الـ Class تلقائياً
- `autoSave: true`: بيحفظ في قاعدة البيانات مباشرة

**شغّل `DbMigrator` تاني عشان تضيف البيانات**

### **الخطوة 7: إنشاء DTOs (Data Transfer Objects)**

**DTOs** هي Classes بتستخدم لنقل البيانات بين الـ Backend والـ Frontend

**أنشئ مجلد `Books` في مشروع `YourProjectName.Application.Contracts`**

#### **7.1: BookDto (للقراءة)**

**File: `Books/BookDto.cs`**
```csharp
using System;
using Volo.Abp.Application.Dtos;

namespace YourProjectName.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; } = string.Empty;
    
    public BookType Type { get; set; }
    
    public DateTime PublishDate { get; set; }
    
    public float Price { get; set; }
}
```

**الشرح:**
- `AuditedEntityDto`: بيورث Id, CreationTime, CreatorId, إلخ من ABP
- هنستخدمه عشان نعرض البيانات للمستخدم

#### **7.2: CreateUpdateBookDto (للكتابة)**

**File: `Books/CreateUpdateBookDto.cs`**
```csharp
using System;
using System.ComponentModel.DataAnnotations;

namespace YourProjectName.Books;

public class CreateUpdateBookDto
{
    [Required(ErrorMessage = "Book name is required")]
    [StringLength(BookConsts.MaxNameLength, ErrorMessage = "Name cannot exceed 128 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Book type is required")]
    public BookType Type { get; set; } = BookType.Undefined;

    [Required(ErrorMessage = "Publish date is required")]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Price is required")]
    [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10000")]
    public float Price { get; set; }
}
```

**الشرح:**
- `[Required]`: الحقل ده إجباري
- `[StringLength]`: الحد الأقصى للطول
- `[Range]`: نطاق القيم المسموح
- هنستخدمه عشان نضيف أو نعدل كتاب

**ليه DTO منفصل للـ Create/Update؟**
- عشان نخفي حاجات زي Id, CreationTime من المستخدم
- عشان نتحكم في الـ Validation بشكل أفضل

### **الخطوة 8: ضبط Object Mapping**

**Object Mapping** بيحول Entity لـ DTO والعكس تلقائياً

**افتح `YourProjectNameApplicationAutoMapperProfile.cs` في مشروع `YourProjectName.Application`:**
```csharp
using AutoMapper;
using YourProjectName.Books;

namespace YourProjectName;

public class YourProjectNameApplicationAutoMapperProfile : Profile
{
    public YourProjectNameApplicationAutoMapperProfile()
    {
        /* يمكنك ضبط mappings هنا */
        
        // Map من Entity لـ DTO
        CreateMap<Book, BookDto>();
        
        // Map من DTO لـ Entity
        CreateMap<CreateUpdateBookDto, Book>();
    }
}
```

**الشرح:**
- `CreateMap<Source, Destination>()`: بيعمل Mapping تلقائي للـ Properties اللي أسماؤها متشابهة
- AutoMapper بيوفر وقت كبير بدل ما نكتب كود يدوي لنقل البيانات

### **الخطوة 9: إنشاء Application Service Interface**

**File: `Books/IBookAppService.cs`** (في `Application.Contracts`)
```csharp
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace YourProjectName.Books;

public interface IBookAppService :
    ICrudAppService<
        BookDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateBookDto>
{
    // يمكنك إضافة methods إضافية هنا لو محتاج
}
```

**الشرح:**
- `ICrudAppService`: Interface من ABP بيوفر Methods أساسية:
  - `GetAsync(id)`: جلب كتاب واحد
  - `GetListAsync(input)`: جلب قائمة الكتب (مع Paging و Sorting)
  - `CreateAsync(input)`: إضافة كتاب جديد
  - `UpdateAsync(id, input)`: تعديل كتاب
  - `DeleteAsync(id)`: حذف كتاب
- `PagedAndSortedResultRequestDto`: بيسمح بـ Paging (رقم الصفحة، عدد العناصر) و Sorting

### **الخطوة 10: تنفيذ Application Service**

**أنشئ مجلد `Books` في مشروع `YourProjectName.Application`**

**File: `Books/BookAppService.cs`**
```csharp
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace YourProjectName.Books;

public class BookAppService :
    CrudAppService<
        Book,                      // Entity
        BookDto,                   // DTO للقراءة
        Guid,                      // نوع الـ Primary Key
        PagedAndSortedResultRequestDto,  // DTO للـ GetList
        CreateUpdateBookDto>,      // DTO للإضافة/التعديل
    IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
    }
    
    // يمكنك إضافة methods إضافية أو override methods موجودة
}
```

**الشرح:**
- `CrudAppService`: Class من ABP بينفذ كل الـ CRUD Operations تلقائياً
- ABP بيستخدم:
  - `Repository` للوصول لقاعدة البيانات
  - `ObjectMapper` للتحويل بين Entity و DTO
- كل ده **بدون كتابة سطر واحد من كود CRUD!**

**إزاي CrudAppService بيشتغل؟**
1. لما تستدعي `GetAsync(id)`: بيجيب Entity من Repository، يحوله لـ DTO، يرجعه
2. لما تستدعي `CreateAsync(dto)`: بيحول DTO لـ Entity، يحفظه في Database
3. لما تستدعي `UpdateAsync(id, dto)`: بيجيب Entity، يعدله، يحفظه
4. لما تستدعي `DeleteAsync(id)`: بيحذف Entity من Database

---

## 🎨 **الجزء الثاني: صفحة عرض البيانات (Frontend)**

### **الخطوة 1: تشغيل Backend**

**في Visual Studio:**
1. اضغط كليك يمين على مشروع `YourProjectName.HttpApi.Host`
2. اختار **Set as Startup Project**
3. اضغط **F5** أو **Ctrl + F5** للتشغيل

**الشرح:** Backend لازم يكون شغال عشان Angular يقدر يتصل بيه

**تحقق من تشغيل API:**
- افتح المتصفح وروح على: `https://localhost:44300/swagger`
- **الشرح:** Swagger هي واجهة لاختبار API بشكل تفاعلي

### **الخطوة 2: تشغيل Angular**

**افتح Terminal جديد وروح لمجلد Angular:**
```bash
cd angular
```

**تثبيت Dependencies (أول مرة فقط):**
```bash
npm install
# أو
yarn install
```
**الشرح:** بيحمل كل الـ Libraries اللي Angular محتاجها

**تشغيل التطبيق:**
```bash
npm start
# أو
yarn start
```

**افتح المتصفح على:**
```
http://localhost:4200
```

**بيانات تسجيل الدخول الافتراضية:**
- Username: `admin`
- Password: `1q2w3E*`

### **الخطوة 3: إنشاء Service Proxy**

**Service Proxy** هو Class بيتولد تلقائياً عشان يتصل بالـ Backend من Angular

**في Terminal مجلد Angular، شغّل:**
```bash
abp generate-proxy -t ng
```

**الشرح:**
- الأمر ده بيقرأ الـ API من Backend
- بينشئ TypeScript Services جاهزة للاستخدام
- بيحفظهم في مجلد `src/app/proxy`

**ملاحظة:** لازم Backend يكون شغال قبل ما تنفذ الأمر ده

**الملفات اللي هتتولد:**
```
src/app/proxy/
└── books/
    ├── book.service.ts          # Service للتعامل مع API
    ├── models.ts                # TypeScript Models (DTOs)
    └── book-type.enum.ts        # Enum للأنواع
```

### **الخطوة 4: إضافة Route في القوائم**

**افتح ملف `src/app/route.provider.ts`:**
```typescript
import { eLayoutType, RoutesService } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  {
    provide: APP_INITIALIZER,
    useFactory: configureRoutes,
    deps: [RoutesService],
    multi: true
  }
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application
      },
      {
        path: '/books',
        name: '::Menu:Books',
        iconClass: 'fas fa-book',
        order: 2,
        layout: eLayoutType.application
      }
    ]);
  };
}
```

**الشرح:**
- `path`: المسار اللي هيظهر في URL
- `name`: اسم القائمة (بيستخدم Localization)
- `iconClass`: أيقونة من Font Awesome
- `order`: ترتيب القائمة في Sidebar
- `layout`: نوع الـ Layout المستخدم

### **الخطوة 5: إضافة Localization (الترجمة)**

**افتح `src/assets/localization/ar.json` (للغة العربية):**
```json
{
  "culture": "ar",
  "texts": {
    "Menu:Home": "الصفحة الرئيسية",
    "Menu:Books": "الكتب",
    "Books": "الكتب",
    "NewBook": "كتاب جديد",
    "Name": "الاسم",
    "Type": "النوع",
    "PublishDate": "تاريخ النشر",
    "Price": "السعر",
    "CreationTime": "وقت الإنشاء",
    "Actions": "الإجراءات",
    "Edit": "تعديل",
    "Delete": "حذف",
    "AreYouSure": "هل أنت متأكد؟",
    "AreYouSureToDelete": "هل أنت متأكد من الحذف؟",
    "Enum:BookType:0": "غير محدد",
    "Enum:BookType:1": "مغامرات",
    "Enum:BookType:2": "سيرة ذاتية",
    "Enum:BookType:3": "ديستوبيا",
    "Enum:BookType:4": "خيال",
    "Enum:BookType:5": "رعب",
    "Enum:BookType:6": "علمي",
    "Enum:BookType:7": "خيال علمي",
    "Enum:BookType:8": "شعر"
  }
}
```

**افتح `src/assets/localization/en.json` (للغة الإنجليزية):**
```json
{
  "culture": "en",
  "texts": {
    "Menu:Home": "Home",
    "Menu:Books": "Books",
    "Books": "Books",
    "NewBook": "New Book",
    "Name": "Name",
    "Type": "Type",
    "PublishDate": "Publish Date",
    "Price": "Price",
    "CreationTime": "Creation Time",
    "Actions": "Actions",
    "Edit": "Edit",
    "Delete": "Delete",
    "AreYouSure": "Are you sure?",
    "AreYouSureToDelete": "Are you sure to delete this item?",
    "Enum:BookType:0": "Undefined",
    "Enum:BookType:1": "Adventure",
    "Enum:BookType:2": "Biography",
    "Enum:BookType:3": "Dystopia",
    "Enum:BookType:4": "Fantastic",
    "Enum:BookType:5": "Horror",
    "Enum:BookType:6": "Science",
    "Enum:BookType:7": "Science Fiction",
    "Enum:BookType:8": "Poetry"
  }
}
```

**الشرح:**
- `::` في بداية النص بتعني إنه key للترجمة
- ABP بيبحث تلقائياً في ملفات JSON
- `Enum:BookType:X` بتترجم قيم الـ Enum

### **الخطوة 6: إنشاء Book Component**

**في Terminal مجلد Angular:**
```bash
ng generate component book --module app
```
**الشرح:** الأمر ده بينشئ Component جديد في مجلد `src/app/book`

**أو أنشئ يدوياً:**

**File: `src/app/book/book.component.ts`**
```typescript
import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { BookService, BookDto } from '@proxy/books';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { bookTypeOptions } from '@proxy/books';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss'],
  providers: [
    ListService,
    { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }
  ]
})
export class BookComponent implements OnInit {
  book = { items: [], totalCount: 0 } as PagedResultDto<BookDto>;
  
  form: FormGroup;
  
  isModalOpen = false;
  
  bookTypes = bookTypeOptions;

  constructor(
    public readonly list: ListService,
    private bookService: BookService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) {}

  ngOnInit() {
    const bookStreamCreator = (query) => this.bookService.getList(query);

    this.list.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.book = response;
    });
  }

  createBook() {
    this.buildForm();
    this.isModalOpen = true;
  }

  editBook(id: string) {
    this.bookService.get(id).subscribe((book) => {
      this.buildForm(book);
      this.isModalOpen = true;
    });
  }

  buildForm(book?: BookDto) {
    this.form = this.fb.group({
      name: [book?.name || '', [Validators.required, Validators.maxLength(128)]],
      type: [book?.type || null, Validators.required],
      publishDate: [
        book?.publishDate ? new Date(book.publishDate) : null,
        Validators.required
      ],
      price: [book?.price || null, [Validators.required, Validators.min(0)]]
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.form.value.id
      ? this.bookService.update(this.form.value.id, this.form.value)
      : this.bookService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

  delete(id: string) {
    this.confirmation
      .warn('::AreYouSureToDelete', '::AreYouSure')
      .subscribe((status) => {
        if (status === Confirmation.Status.confirm) {
          this.bookService.delete(id).subscribe(() => this.list.get());
        }
      });
  }
}
```

**الشرح:**
- `ListService`: Service من ABP بيدير Paging, Sorting, و Filtering
- `PagedResultDto`: بيحتوي على `items` (البيانات) و `totalCount` (العدد الكلي)
- `FormGroup`: بيدير Form Inputs و Validation
- `NgbDateAdapter`: بيحول التواريخ بين Angular و ng-bootstrap
- `ConfirmationService`: بيعرض رسائل تأكيد

**File: `src/app/book/book.component.html`**
```html
<abp-page [title]="'::Menu:Books' | abpLocalization">
  <abp-page-toolbar>
    <abp-button
      iconClass="fa fa-plus"
      [text]="'::NewBook' | abpLocalization"
      (click)="createBook()">
    </abp-button>
  </abp-page-toolbar>

  <div class="card">
    <div class="card-body">
      <ngx-datatable
        [rows]="book.items"
        [count]="book.totalCount"
        [list]="list"
        default>
        
        <ngx-datatable-column
          [name]="'::Name' | abpLocalization"
          prop="name">
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::Type' | abpLocalization"
          prop="type">
          <ng-template let-row="row" ngx-datatable-cell-template>
            {{ 'Enum:BookType:' + row.type | abpLocalization }}
          </ng-template>
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::PublishDate' | abpLocalization"
          prop="publishDate">
          <ng-template let-row="row" ngx-datatable-cell-template>
            {{ row.publishDate | date: 'shortDate' }}
          </ng-template>
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::Price' | abpLocalization"
          prop="price">
          <ng-template let-row="row" ngx-datatable-cell-template>
            {{ row.price | currency }}
          </ng-template>
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::Actions' | abpLocalization"
          [maxWidth]="150"
          [sortable]="false">
          <ng-template let-row="row" ngx-datatable-cell-template>
            <div ngbDropdown container="body" class="d-inline-block">
              <button
                class="btn btn-primary btn-sm dropdown-toggle"
                data-toggle="dropdown"
                aria-haspopup="true"
                ngbDropdownToggle>
                <i class="fa fa-cog mr-1"></i>{{ '::Actions' | abpLocalization }}
              </button>
              <div ngbDropdownMenu>
                <button ngbDropdownItem (click)="editBook(row.id)">
                  {{ '::Edit' | abpLocalization }}
                </button>
                <button ngbDropdownItem (click)="delete(row.id)">
                  {{ '::Delete' | abpLocalization }}
                </button>
              </div>
            </div>
          </ng-template>
        </ngx-datatable-column>
      </ngx-datatable>
    </div>
  </div>
</abp-page>

<!-- Modal للإضافة/التعديل -->
<abp-modal [(visible)]="isModalOpen">
  <ng-template #abpHeader>
    <h3>{{ (form.value.id ? '::Edit' : '::NewBook') | abpLocalization }}</h3>
  </ng-template>

  <ng-template #abpBody>
    <form [formGroup]="form" (ngSubmit)="save()">
      <div class="form-group">
        <label for="book-name">{{ '::Name' | abpLocalization }} *</label>
        <input type="text" id="book-name" class="form-control" formControlName="name" />
      </div>

      <div class="form-group">
        <label for="book-type">{{ '::Type' | abpLocalization }} *</label>
        <select class="form-control" id="book-type" formControlName="type">
          <option [ngValue]="null">{{ '::PleaseSelect' | abpLocalization }}</option>
          <option [ngValue]="type.value" *ngFor="let type of bookTypes">
            {{ 'Enum:BookType:' + type.value | abpLocalization }}
          </option>
        </select>
      </div>

      <div class="form-group">
        <label for="book-publish-date">{{ '::PublishDate' | abpLocalization }} *</label>
        <input
          type="date"
          id="book-publish-date"
          class="form-control"
          formControlName="publishDate"
          ngbDatepicker
          #datepicker="ngbDatepicker" />
      </div>

      <div class="form-group">
        <label for="book-price">{{ '::Price' | abpLocalization }} *</label>
        <input type="number" id="book-price" class="form-control" formControlName="price" />
      </div>
    </form>
  </ng-template>

  <ng-template #abpFooter>
    <button type="button" class="btn btn-secondary" (click)="isModalOpen = false">
      {{ '::Close' | abpLocalization }}
    </button>
    <button type="button" class="btn btn-primary" (click)="save()">
      <i class="fa fa-check mr-1"></i>{{ '::Save' | abpLocalization }}
    </button>
  </ng-template>
</abp-modal>
```

**الشرح:**
- `abp-page`: Component من ABP لتنسيق الصفحة
- `ngx-datatable`: جدول قوي مع Paging و Sorting
- `abpLocalization` pipe: بيترجم النصوص
- `abp-modal`: Modal من ABP Framework
- `ngbDatepicker`: Date Picker من ng-bootstrap

### **الخطوة 7: إضافة Routing**

**افتح `src/app/app.routes.ts`:**
```typescript
import { Routes } from '@angular/router';
import { authGuard, permissionGuard } from '@abp/ng.core';

export const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    loadChildren: () => import('./home/home.routes').then(m => m.default)
  },
  {
    path: 'books',
    loadComponent: () => import('./book/book.component').then(m => m.BookComponent),
    canActivate: [authGuard]
  }
];
```

**الشرح:**
- `loadComponent`: بيحمل Component بشكل Lazy (عند الحاجة فقط)
- `authGuard`: بيتأكد إن المستخدم مسجل دخول
- `permissionGuard`: هنستخدمه لاحقاً للصلاحيات

### **الخطوة 8: اختبار التطبيق**

1. تأكد إن Backend شغال
2. تأكد إن Angular شغال
3. سجل دخول بـ admin / 1q2w3E*
4. اضغط على "الكتب" في القائمة الجانبية
5. المفروض تشوف الكتب التجريبية اللي أضفناها

---

## ✏️ **الجزء الثالث: الإضافة والتعديل والحذف**

**الـ CRUD Operations خلصت بالفعل!** 🎉

الكود اللي كتبناه في `BookComponent` بيشمل:
- ✅ **Create**: Method `createBook()` و `save()`
- ✅ **Read**: `ngOnInit()` و `ListService`
- ✅ **Update**: Method `editBook()` و `save()`
- ✅ **Delete**: Method `delete()`

**اختبر العمليات:**
1. **إضافة كتاب جديد:** اضغط "كتاب جديد"، املأ البيانات، احفظ
2. **تعديل كتاب:** اضغط Actions → Edit، عدل، احفظ
3. **حذف كتاب:** اضغط Actions → Delete، أكد الحذف

---

## 🧪 **الجزء الرابع: اختبارات التكامل**

### **لماذا الاختبارات مهمة؟**
- بتتأكد إن الكود بيشتغل صح
- بتمنع Bugs من الظهور مستقبلاً
- بتوثق كيفية استخدام الـ Code

### **الخطوة 1: إنشاء Integration Test**

**افتح مشروع `YourProjectName.Application.Tests`**

**أنشئ مجلد `Books` وملف `BookAppService_Tests.cs`:**
```csharp
using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace YourProjectName.Books;

public class BookAppService_Tests : YourProjectNameApplicationTestBase
{
    private readonly IBookAppService _bookAppService;

    public BookAppService_Tests()
    {
        _bookAppService = GetRequiredService<IBookAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_Books()
    {
        // Act
        var result = await _bookAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        // Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "1984");
    }

    [Fact]
    public async Task Should_Create_A_Valid_Book()
    {
        // Act
        var result = await _bookAppService.CreateAsync(
            new CreateUpdateBookDto
            {
                Name = "Test Book",
                Type = BookType.Science,
                PublishDate = DateTime.Now,
                Price = 10
            }
        );

        // Assert
        result.Id.ShouldNotBe(Guid.Empty);
        result.Name.ShouldBe("Test Book");
    }

    [Fact]
    public async Task Should_Not_Create_A_Book_Without_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _bookAppService.CreateAsync(
                new CreateUpdateBookDto
                {
                    Name = "",
                    Type = BookType.Science,
                    PublishDate = DateTime.Now,
                    Price = 10
                }
            );
        });

        exception.ValidationErrors
            .ShouldContain(err => err.MemberNames.Any(m => m == "Name"));
    }

    [Fact]
    public async Task Should_Update_A_Book()
    {
        // Arrange: أنشئ كتاب أولاً
        var createdBook = await _bookAppService.CreateAsync(
            new CreateUpdateBookDto
            {
                Name = "Original Name",
                Type = BookType.Horror,
                PublishDate = DateTime.Now,
                Price = 15
            }
        );

        // Act: عدّل الكتاب
        await _bookAppService.UpdateAsync(
            createdBook.Id,
            new CreateUpdateBookDto
            {
                Name = "Updated Name",
                Type = BookType.Horror,
                PublishDate = DateTime.Now,
                Price = 20
            }
        );

        // Assert: تحقق من التعديل
        var updatedBook = await _bookAppService.GetAsync(createdBook.Id);
        updatedBook.Name.ShouldBe("Updated Name");
        updatedBook.Price.ShouldBe(20);
    }

    [Fact]
    public async Task Should_Delete_A_Book()
    {
        // Arrange
        var createdBook = await _bookAppService.CreateAsync(
            new CreateUpdateBookDto
            {
                Name = "To Be Deleted",
                Type = BookType.Poetry,
                PublishDate = DateTime.Now,
                Price = 5
            }
        );

        // Act
        await _bookAppService.DeleteAsync(createdBook.Id);

        // Assert
        var exception = await Assert.ThrowsAsync<Volo.Abp.Domain.Entities.EntityNotFoundException>(
            async () => await _bookAppService.GetAsync(createdBook.Id)
        );
    }
}
```

**الشرح:**
- `[Fact]`: Attribute بيعلّم إن ده Test Method
- `Shouldly`: Library بتخلي Assertions أوضح
- `YourProjectNameApplicationTestBase`: Base Class بيجهز بيئة الاختبار

### **الخطوة 2: تشغيل الاختبارات**

**في Visual Studio:**
1. افتح **Test Explorer** من القائمة: **Test → Test Explorer**
2. اضغط **Run All**

**أو من Command Line:**
```bash
cd aspnet-core/test/YourProjectName.Application.Tests
dotnet test
```

**المفروض كل الاختبارات تنجح (Pass) ✅**

---

## 🔐 **الجزء الخامس: الصلاحيات (Permissions)**

### **لماذا نحتاج Permissions؟**
- عشان نتحكم مين يقدر يشوف/يضيف/يعدل/يحذف
- مثال: Manager يقدر يضيف، لكن Viewer يقدر يشوف بس

### **الخطوة 1: تعريف Permissions**

**افتح `YourProjectNamePermissions.cs` في `Application.Contracts`:**
```csharp
namespace YourProjectName.Permissions;

public static class YourProjectNamePermissions
{
    public const string GroupName = "YourProjectName";

    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
```

**الشرح:**
- `Default`: صلاحية عرض الكتب
- `Create`: صلاحية إضافة كتاب
- `Edit`: صلاحية تعديل كتاب
- `Delete`: صلاحية حذف كتاب

### **الخطوة 2: تعريف Permission Definitions**

**افتح `YourProjectNamePermissionDefinitionProvider.cs`:**
```csharp
using YourProjectName.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace YourProjectName.Permissions;

public class YourProjectNamePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(YourProjectNamePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(
            YourProjectNamePermissions.Books.Default, 
            L("Permission:Books")
        );
        
        booksPermission.AddChild(
            YourProjectNamePermissions.Books.Create, 
            L("Permission:Books.Create")
        );
        
        booksPermission.AddChild(
            YourProjectNamePermissions.Books.Edit, 
            L("Permission:Books.Edit")
        );
        
        booksPermission.AddChild(
            YourProjectNamePermissions.Books.Delete, 
            L("Permission:Books.Delete")
        );
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<YourProjectNameResource>(name);
    }
}
```

**الشرح:**
- `AddGroup`: بينشئ مجموعة Permissions
- `AddPermission`: بيضيف Permission رئيسي
- `AddChild`: بيضيف Permission فرعي (يعتمد على الرئيسي)

### **الخطوة 3: إضافة Localization للصلاحيات**

**في `src/assets/localization/ar.json`:**
```json
{
  "Permission:Books": "إدارة الكتب",
  "Permission:Books.Create": "إضافة كتاب",
  "Permission:Books.Edit": "تعديل كتاب",
  "Permission:Books.Delete": "حذف كتاب"
}
```

**في `src/assets/localization/en.json`:**
```json
{
  "Permission:Books": "Book Management",
  "Permission:Books.Create": "Create Book",
  "Permission:Books.Edit": "Edit Book",
  "Permission:Books.Delete": "Delete Book"
}
```

### **الخطوة 4: تطبيق Permissions على AppService**

**عدّل `BookAppService.cs`:**
```csharp
using System;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using YourProjectName.Permissions;

namespace YourProjectName.Books;

[Authorize(YourProjectNamePermissions.Books.Default)]
public class BookAppService :
    CrudAppService<
        Book,
        BookDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateBookDto>,
    IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = YourProjectNamePermissions.Books.Default;
        GetListPolicyName = YourProjectNamePermissions.Books.Default;
        CreatePolicyName = YourProjectNamePermissions.Books.Create;
        UpdatePolicyName = YourProjectNamePermissions.Books.Edit;
        DeletePolicyName = YourProjectNamePermissions.Books.Delete;
    }
}
```

**الشرح:**
- `[Authorize]`: بيتطلب تسجيل دخول + Permission معين
- `GetPolicyName`: Permission للـ Get (عرض كتاب واحد)
- `GetListPolicyName`: Permission للـ GetList (عرض القائمة)
- `CreatePolicyName`: Permission للإضافة
- `UpdatePolicyName`: Permission للتعديل
- `DeletePolicyName`: Permission للحذف

### **الخطوة 5: تطبيق Migration للصلاحيات**

**شغّل `DbMigrator` تاني:**
1. Set as Startup Project: `YourProjectName.DbMigrator`
2. اضغط Ctrl + F5
3. استنى لحد ما يخلص

**الشرح:** DbMigrator بيضيف Permissions الجديدة لقاعدة البيانات

### **الخطوة 6: منح Permissions لـ Admin**

**بعد تشغيل التطبيق:**
1. سجل دخول كـ admin
2. روح على **Administration → Identity Management → Roles**
3. اضغط على **admin**
4. اختار تاب **Permissions**
5. فعّل كل الصلاحيات تحت "إدارة الكتب"
6. احفظ

**الشرح:** دلوقتي Admin عنده صلاحية كاملة على الكتب

### **الخطوة 7: إخفاء Buttons بناءً على Permissions (Angular)**

**عدّل `book.component.ts`:**
```typescript
import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { BookService, BookDto } from '@proxy/books';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { bookTypeOptions } from '@proxy/books';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss'],
  providers: [
    ListService,
    { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }
  ]
})
export class BookComponent implements OnInit {
  book = { items: [], totalCount: 0 } as PagedResultDto<BookDto>;
  
  form: FormGroup;
  
  isModalOpen = false;
  
  bookTypes = bookTypeOptions;

  constructor(
    public readonly list: ListService,
    private bookService: BookService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) {}

  ngOnInit() {
    const bookStreamCreator = (query) => this.bookService.getList(query);

    this.list.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.book = response;
    });
  }

  createBook() {
    this.buildForm();
    this.isModalOpen = true;
  }

  editBook(id: string) {
    this.bookService.get(id).subscribe((book) => {
      this.buildForm(book);
      this.isModalOpen = true;
    });
  }

  buildForm(book?: BookDto) {
    this.form = this.fb.group({
      name: [book?.name || '', [Validators.required, Validators.maxLength(128)]],
      type: [book?.type || null, Validators.required],
      publishDate: [
        book?.publishDate ? new Date(book.publishDate) : null,
        Validators.required
      ],
      price: [book?.price || null, [Validators.required, Validators.min(0)]]
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.form.value.id
      ? this.bookService.update(this.form.value.id, this.form.value)
      : this.bookService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

  delete(id: string) {
    this.confirmation
      .warn('::AreYouSureToDelete', '::AreYouSure')
      .subscribe((status) => {
        if (status === Confirmation.Status.confirm) {
          this.bookService.delete(id).subscribe(() => this.list.get());
        }
      });
  }
}
```

**عدّل `book.component.html` لإضافة Permission Checks:**
```html
<abp-page [title]="'::Menu:Books' | abpLocalization">
  <abp-page-toolbar>
    <abp-button
      *abpPermission="'YourProjectName.Books.Create'"
      iconClass="fa fa-plus"
      [text]="'::NewBook' | abpLocalization"
      (click)="createBook()">
    </abp-button>
  </abp-page-toolbar>

  <div class="card">
    <div class="card-body">
      <ngx-datatable
        [rows]="book.items"
        [count]="book.totalCount"
        [list]="list"
        default>
        
        <ngx-datatable-column
          [name]="'::Name' | abpLocalization"
          prop="name">
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::Type' | abpLocalization"
          prop="type">
          <ng-template let-row="row" ngx-datatable-cell-template>
            {{ 'Enum:BookType:' + row.type | abpLocalization }}
          </ng-template>
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::PublishDate' | abpLocalization"
          prop="publishDate">
          <ng-template let-row="row" ngx-datatable-cell-template>
            {{ row.publishDate | date: 'shortDate' }}
          </ng-template>
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::Price' | abpLocalization"
          prop="price">
          <ng-template let-row="row" ngx-datatable-cell-template>
            {{ row.price | currency }}
          </ng-template>
        </ngx-datatable-column>

        <ngx-datatable-column
          [name]="'::Actions' | abpLocalization"
          [maxWidth]="150"
          [sortable]="false">
          <ng-template let-row="row" ngx-datatable-cell-template>
            <div ngbDropdown container="body" class="d-inline-block">
              <button
                class="btn btn-primary btn-sm dropdown-toggle"
                data-toggle="dropdown"
                aria-haspopup="true"
                ngbDropdownToggle>
                <i class="fa fa-cog mr-1"></i>{{ '::Actions' | abpLocalization }}
              </button>
              <div ngbDropdownMenu>
                <button 
                  *abpPermission="'YourProjectName.Books.Edit'"
                  ngbDropdownItem 
                  (click)="editBook(row.id)">
                  {{ '::Edit' | abpLocalization }}
                </button>
                <button 
                  *abpPermission="'YourProjectName.Books.Delete'"
                  ngbDropdownItem 
                  (click)="delete(row.id)">
                  {{ '::Delete' | abpLocalization }}
                </button>
              </div>
            </div>
          </ng-template>
        </ngx-datatable-column>
      </ngx-datatable>
    </div>
  </div>
</abp-page>

<!-- Modal للإضافة/التعديل -->
<abp-modal [(visible)]="isModalOpen">
  <ng-template #abpHeader>
    <h3>{{ (form.value.id ? '::Edit' : '::NewBook') | abpLocalization }}</h3>
  </ng-template>

  <ng-template #abpBody>
    <form [formGroup]="form" (ngSubmit)="save()">
      <div class="form-group">
        <label for="book-name">{{ '::Name' | abpLocalization }} *</label>
        <input type="text" id="book-name" class="form-control" formControlName="name" />
      </div>

      <div class="form-group">
        <label for="book-type">{{ '::Type' | abpLocalization }} *</label>
        <select class="form-control" id="book-type" formControlName="type">
          <option [ngValue]="null">{{ '::PleaseSelect' | abpLocalization }}</option>
          <option [ngValue]="type.value" *ngFor="let type of bookTypes">
            {{ 'Enum:BookType:' + type.value | abpLocalization }}
          </option>
        </select>
      </div>

      <div class="form-group">
        <label for="book-publish-date">{{ '::PublishDate' | abpLocalization }} *</label>
        <input
          type="date"
          id="book-publish-date"
          class="form-control"
          formControlName="publishDate"
          ngbDatepicker
          #datepicker="ngbDatepicker" />
      </div>

      <div class="form-group">
        <label for="book-price">{{ '::Price' | abpLocalization }} *</label>
        <input type="number" id="book-price" class="form-control" formControlName="price" />
      </div>
    </form>
  </ng-template>

  <ng-template #abpFooter>
    <button type="button" class="btn btn-secondary" (click)="isModalOpen = false">
      {{ '::Close' | abpLocalization }}
    </button>
    <button type="button" class="btn btn-primary" (click)="save()">
      <i class="fa fa-check mr-1"></i>{{ '::Save' | abpLocalization }}
    </button>
  </ng-template>
</abp-modal>
```

**الشرح:**
- `*abpPermission`: Directive بتخفي Element لو المستخدم مالوش Permission
- دلوقتي Buttons بتظهر بس للمستخدمين اللي عندهم الصلاحية

### **الخطوة 8: حماية Route**

**عدّل `app.routes.ts`:**
```typescript
import { Routes } from '@angular/router';
import { authGuard, permissionGuard } from '@abp/ng.core';

export const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    loadChildren: () => import('./home/home.routes').then(m => m.default)
  },
  {
    path: 'books',
    loadComponent: () => import('./book/book.component').then(m => m.BookComponent),
    canActivate: [authGuard, permissionGuard],
    data: {
      requiredPolicy: 'YourProjectName.Books.Default'
    }
  }
];
```

**الشرح:**
- `permissionGuard`: بيمنع الوصول للصفحة لو المستخدم مالوش Permission
- `requiredPolicy`: Permission المطلوب للدخول

---

## 🐛 **حل المشاكل الشائعة**

### **مشكلة 1: Connection String خطأ**

**الخطأ:**
```
A network-related or instance-specific error occurred...
```

**الحل:**
1. تأكد إن SQL Server شغال
2. تحقق من Connection String في `appsettings.json`
3. جرب الاتصال من SQL Server Management Studio أولاً

**Connection Strings الشائعة:**
```json
// LocalDB
"Server=(localdb)\\mssqllocaldb;Database=YourProjectName;Trusted_Connection=True"

// SQL Server Express
"Server=localhost\\SQLEXPRESS;Database=YourProjectName;Trusted_Connection=True;TrustServerCertificate=True"

// SQL Server مع Username/Password
"Server=localhost;Database=YourProjectName;User Id=sa;Password=YourPassword;TrustServerCertificate=True"
```

### **مشكلة 2: Migration فشل**

**الخطأ:**
```
The entity type 'Book' requires a primary key to be defined
```

**الحل:**
- تأكد إن Entity بيرث من `Entity<TKey>` أو `AuditedAggregateRoot<TKey>`
- تأكد إن فيه `Id` Property

### **مشكلة 3: Angular بيطلع أخطاء Compilation**

**الخطأ:**
```
Module not found: Error: Can't resolve '@proxy/books'
```

**الحل:**
```bash
# شغّل Backend أولاً، بعدين:
abp generate-proxy -t ng
```

### **مشكلة 4: CORS Error**

**الخطأ:**
```
Access to XMLHttpRequest has been blocked by CORS policy
```

**الحل:**
**افتح `YourProjectNameHttpApiHostModule.cs`:**
```csharp
context.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder
            .WithOrigins(
                configuration["App:CorsOrigins"]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(o => o.RemovePostFix("/"))
                    .ToArray()
            )
            .WithAbpExposedHeaders()
            .SetIsOriginAllowedToAllowWildcardSubdomains()
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});
```

**تحقق من `appsettings.json`:**
```json
{
  "App": {
    "CorsOrigins": "https://localhost:4200,http://localhost:4200"
  }
}
```

### **مشكلة 5: Swagger مش شغال**

**الحل:**
- تأكد إن Backend شغال على نفس الـ Port
- جرب: `https://localhost:44300/swagger` (أو Port التطبيق بتاعك)
- لو لسه مش شغال، شيك `launchSettings.json`

### **مشكلة 6: npm install بياخد وقت طويل**

**الحل:**
```bash
# استخدم Yarn بدل npm
npm install -g yarn
cd angular
yarn install
```

### **مشكلة 7: Database مش بتتحدث**

**الحل:**
```bash
# احذف Migration وأعد إنشاءه
Remove-Migration
Add-Migration "YourMigrationName"
Update-Database
```

**أو شغّل DbMigrator تاني:**
```bash
cd aspnet-core/src/YourProjectName.DbMigrator
dotnet run
```

### **مشكلة 8: Permissions مش شغالة**

**الحل:**
1. شغّل DbMigrator عشان يضيف Permissions
2. سجل دخول كـ admin
3. روح **Administration → Roles → admin → Permissions**
4. فعّل الصلاحيات المطلوبة
5. سجل خروج ودخول تاني

### **مشكلة 9: Angular Service Proxy مش متولد**

**الحل:**
```bash
# تأكد إن Backend شغال أولاً
cd angular
abp generate-proxy -t ng

# لو فيه مشكلة، جرب:
abp generate-proxy -t ng --url https://localhost:44300
```

### **مشكلة 10: Visual Studio مش بيفتح Solution**

**الحل:**
1. تأكد إن عندك Visual Studio 2022 أو أحدث
2. تأكد إن عندك .NET 9.0 SDK
3. جرب تفتح Solution كـ Administrator
4. لو لسه في مشكلة، احذف مجلدات `.vs` و `bin` و `obj`

---

## ✨ **أفضل الممارسات**

### **1. تنظيم الكود**

**استخدم Folders منظمة:**
```
YourProjectName.Domain/
├── Books/
│   ├── Book.cs              // Entity
│   ├── BookManager.cs       // Domain Service (لو محتاج)
│   └── IBookRepository.cs   // Custom Repository (لو محتاج)
├── Orders/
└── Customers/
```

**الشرح:** كل Feature في مجلد مستقل

### **2. استخدام Constants**

**❌ سيء:**
```csharp
public string Name { get; set; } // طول غير محدد
```

**✅ جيد:**
```csharp
public static class BookConsts
{
    public const int MaxNameLength = 128;
}

public string Name { get; set; } // في Entity

// في DbContext:
b.Property(x => x.Name).HasMaxLength(BookConsts.MaxNameLength);

// في DTO:
[StringLength(BookConsts.MaxNameLength)]
public string Name { get; set; }
```

### **3. استخدام Domain Services للـ Business Logic المعقدة**

**مثال:**
```csharp
public class BookManager : DomainService
{
    private readonly IRepository<Book, Guid> _bookRepository;

    public BookManager(IRepository<Book, Guid> bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Book> CreateAsync(
        string name,
        BookType type,
        DateTime publishDate,
        float price)
    {
        // Business Rules المعقدة هنا
        var existingBook = await _bookRepository
            .FirstOrDefaultAsync(x => x.Name == name);
            
        if (existingBook != null)
        {
            throw new BusinessException("BookAlreadyExists");
        }

        return new Book
        {
            Name = name,
            Type = type,
            PublishDate = publishDate,
            Price = price
        };
    }
}
```

**الشرح:** Domain Service بيخليك تفصل Business Logic عن AppService

### **4. استخدام Custom Repository لـ Queries معقدة**

**مثال:**
```csharp
// في Domain:
public interface IBookRepository : IRepository<Book, Guid>
{
    Task<List<Book>> GetBooksByTypeAsync(BookType type);
}

// في EntityFrameworkCore:
public class BookRepository : EfCoreRepository<YourProjectNameDbContext, Book, Guid>, IBookRepository
{
    public BookRepository(IDbContextProvider<YourProjectNameDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    public async Task<List<Book>> GetBooksByTypeAsync(BookType type)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet
            .Where(b => b.Type == type)
            .OrderBy(b => b.Name)
            .ToListAsync();
    }
}
```

### **5. استخدام DTOs منفصلة**

**❌ سيء:**
```csharp
public class BookDto // نفس الـ DTO للقراءة والكتابة
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    // ...
}
```

**✅ جيد:**
```csharp
public class BookDto // للقراءة فقط
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreationTime { get; set; }
    // ...
}

public class CreateUpdateBookDto // للكتابة فقط
{
    public string Name { get; set; }
    // لا يحتوي Id أو CreationTime
}
```

### **6. Validation في أكثر من مكان**

**Client-Side (Angular):**
```typescript
this.form = this.fb.group({
  name: ['', [Validators.required, Validators.maxLength(128)]],
  price: [0, [Validators.required, Validators.min(0)]]
});
```

**Server-Side (DTO):**
```csharp
[Required]
[StringLength(128)]
public string Name { get; set; }

[Required]
[Range(0, 10000)]
public float Price { get; set; }
```

**Domain (Entity):**
```csharp
public void SetName(string name)
{
    Name = Check.NotNullOrWhiteSpace(name, nameof(name), BookConsts.MaxNameLength);
}
```

**الشرح:** Validation في كل Layer بيضمن Data Integrity

### **7. استخدام Soft Delete**

**بدل:**
```csharp
public class Book : AuditedAggregateRoot<Guid>
```

**استخدم:**
```csharp
public class Book : FullAuditedAggregateRoot<Guid>
```

**الشرح:** Soft Delete بيحفظ السجلات المحذوفة (بيعلّمها `IsDeleted = true`) بدل ما يمسحها نهائياً

### **8. استخدام Unit of Work**

**ABP بيطبقه تلقائياً!**
```csharp
[UnitOfWork] // اختياري، لأن AppService بيطبقه تلقائياً
public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
{
    var book = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
    await _repository.InsertAsync(book);
    // ❌ مش محتاج SaveChanges، ABP بيعمله تلقائياً
    return ObjectMapper.Map<Book, BookDto>(book);
}
```

### **9. Logging**

**استخدم ILogger:**
```csharp
public class BookAppService : ApplicationService, IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
    }

    public override async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        Logger.LogInformation("Creating a new book: {BookName}", input.Name);
        
        var result = await base.CreateAsync(input);
        
        Logger.LogInformation("Created book with Id: {BookId}", result.Id);
        
        return result;
    }
}
```

### **10. Caching**

**للبيانات اللي مش بتتغير كتير:**
```csharp
public class BookAppService : ApplicationService, IBookAppService
{
    private readonly IDistributedCache<List<BookDto>> _cache;

    public BookAppService(
        IRepository<Book, Guid> repository,
        IDistributedCache<List<BookDto>> cache)
        : base(repository)
    {
        _cache = cache;
    }

    public async Task<List<BookDto>> GetCachedListAsync()
    {
        return await _cache.GetOrAddAsync(
            "AllBooks",
            async () =>
            {
                var books = await _repository.GetListAsync();
                return ObjectMapper.Map<List<Book>, List<BookDto>>(books);
            },
            () => new DistributedCacheEntryOptions
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddHours(1)
            }
        );
    }
}
```

---

## 📚 **موارد إضافية**

### **الوثائق الرسمية:**
- **ABP Framework:** https://docs.abp.io
- **Angular:** https://angular.dev
- **.NET:** https://docs.microsoft.com/dotnet

### **دروس فيديو:**
- **ABP Official YouTube:** https://www.youtube.com/@Volosoft
- **ABP Community Articles:** https://community.abp.io

### **أدوات مفيدة:**
- **ABP Suite:** أداة مدفوعة لتوليد CRUD Pages تلقائياً
- **ABP CLI:** https://docs.abp.io/en/abp/latest/CLI
- **Postman:** لاختبار API
- **SQL Server Management Studio:** لإدارة قاعدة البيانات

### **مجتمعات:**
- **ABP Community:** https://community.abp.io
- **Stack Overflow:** #abp-framework
- **GitHub:** https://github.com/abpframework/abp

---

## 🎯 **الخلاصة**

**الآن أنت جاهز لبناء تطبيقات ABP احترافية!**

**ما تعلمته:**
✅ إنشاء مشروع ABP من الصفر
✅ بناء Backend بـ .NET و Entity Framework Core
✅ إنشاء Frontend بـ Angular 20+
✅ تطبيق CRUD Operations
✅ إدارة Permissions
✅ كتابة Integration Tests
✅ حل المشاكل الشائعة
✅ تطبيق Best Practices

**الخطوات التالية:**
1. 🚀 ابدأ مشروعك الخاص
2. 📖 اقرأ ABP Documentation للـ Features المتقدمة
3. 🧪 جرب ABP Suite لتسريع التطوير
4. 💬 انضم لمجتمع ABP Community
5. 🎓 شارك معرفتك مع الآخرين

---

## 📝 **ملاحظات نهائية**

### **تحديثات المشروع:**
```bash
# لتحديث ABP CLI:
dotnet tool update -g Volo.Abp.Cli

# لتحديث Packages في Backend:
abp update

# لتحديث Packages في Angular:
cd angular
npm update
```

### **Deployment (النشر):**

**Backend:**
```bash
cd aspnet-core/src/YourProjectName.HttpApi.Host
dotnet publish -c Release
```

**Angular:**
```bash
cd angular
ng build --configuration production
```

**الشرح:** ملفات Production بتكون في مجلد `dist/`

### **Docker Support:**

**ABP بيدعم Docker تلقائياً!**
```bash
# في مجلد المشروع الرئيسي:
docker-compose up
```

---

## 🙏 **شكر خاص**

هذا الدليل مبني على:
- [ABP Framework Documentation](https://docs.abp.io)
- [Microsoft .NET Documentation](https://docs.microsoft.com/dotnet)
- [Angular Documentation](https://angular.dev)
- تجارب المطورين في مجتمع ABP

---

## 📧 **التواصل والدعم**

**لو واجهت أي مشكلة:**
1. ابحث في [ABP Documentation](https://docs.abp.io)
2. اسأل في [ABP Community](https://community.abp.io)
3. افتح Issue في [GitHub](https://github.com/abpframework/abp)

**بالتوفيق في مشاريعك! 🚀**

---

**آخر تحديث:** نوفمبر 2025  
**الإصدارات المستخدمة:**
- ABP Framework: Latest
- .NET: 9.0+
- Angular: 20+
- Entity Framework Core: 9.0+
