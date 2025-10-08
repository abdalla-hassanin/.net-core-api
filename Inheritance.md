# 🧬 المفهوم الثاني: Inheritance (الوراثة)

## الفهم النظري العميق

**Inheritance** هو إعادة استخدام وتوسيع خصائص وسلوكيات class موجود. زي العيلة - الابن بيرث صفات من أبوه، لكن كمان بيضيف صفات خاصة بيه.

### المصطلحات الأساسية:
- **Base Class / Parent Class / Super Class**: الكلاس الأب اللي بنرث منه
- **Derived Class / Child Class / Sub Class**: الكلاس الابن اللي بيرث
- **Inheritance Hierarchy**: التسلسل الهرمي للوراثة

### الفوائد الحقيقية في Backend:
* **Code Reusability**: مش هتكرر نفس الكود في أماكن كتير
* **Extensibility**: سهل تضيف features جديدة بدون ما تعدل الكود القديم
* **Maintainability**: لما تعدل في الـ Base Class، كل الـ Derived Classes بتتحدث
* **Polymorphism Foundation**: الوراثة هي أساس الـ Polymorphism
* **Logical Hierarchy**: تنظيم الكود بشكل منطقي يعكس العلاقات الحقيقية

---

## 🎓 مثال من الواقع الحقيقي:

### ❌ الطريقة الخطأ - بدون Inheritance

تخيل عندك E-Learning Platform وعايز تعمل system للمستخدمين:

```csharp
// 💣 كارثة - تكرار الكود في كل حتة!

public class Student
{
    // معلومات أساسية
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public DateTime RegisteredAt { get; set; }
    public bool IsActive { get; set; }
    
    // معلومات خاصة بالطالب
    public string StudentCode { get; set; }
    public int CurrentLevel { get; set; }
    public decimal GPA { get; set; }
    
    // Methods متكررة
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    
    public int GetAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }
    
    public void UpdateEmail(string newEmail)
    {
        // Validation
        if (string.IsNullOrWhiteSpace(newEmail))
            throw new ArgumentException("Email cannot be empty");
        
        Email = newEmail;
    }
}

public class Instructor
{
    // نفس المعلومات الأساسية! 🔄
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public DateTime RegisteredAt { get; set; }
    public bool IsActive { get; set; }
    
    // معلومات خاصة بالمدرس
    public string EmployeeCode { get; set; }
    public string Specialization { get; set; }
    public decimal HourlyRate { get; set; }
    public int YearsOfExperience { get; set; }
    
    // نفس الـ Methods! 🔄
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    
    public int GetAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }
    
    public void UpdateEmail(string newEmail)
    {
        // نفس الـ Validation! 🔄
        if (string.IsNullOrWhiteSpace(newEmail))
            throw new ArgumentException("Email cannot be empty");
        
        Email = newEmail;
    }
}

public class Admin
{
    // نفس المعلومات مرة تالتة! 🔄🔄🔄
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public DateTime RegisteredAt { get; set; }
    public bool IsActive { get; set; }
    
    // معلومات خاصة بالأدمن
    public string Department { get; set; }
    public string[] Permissions { get; set; }
    public bool IsSuperAdmin { get; set; }
    
    // نفس الـ Methods مرة تالتة! 🔄🔄🔄
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    
    public int GetAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }
    
    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail))
            throw new ArgumentException("Email cannot be empty");
        
        Email = newEmail;
    }
}
```

### 🔥 المشاكل الكارثية:

```csharp
// المشكلة 1: تكرار الكود 🔄
// كتبت نفس الـ Properties 3 مرات!
// كتبت نفس الـ Methods 3 مرات!
// = 300 سطر code مكرر! 💀

// المشكلة 2: الصيانة كابوس 😱
// لو عايز تضيف property جديدة زي "ProfilePicture"
// هتضيفها في 3 أماكن!
// لو عايز تعدل validation للـ Email
// هتعدل في 3 أماكن!
// لو نسيت مكان = Bug! 🐛

// المشكلة 3: Inconsistency 🎭
public class Student
{
    public string GetFullName()
    {
        return $"{FirstName} {LastName}"; // مسافة واحدة
    }
}

public class Instructor
{
    public string GetFullName()
    {
        return $"{FirstName}  {LastName}"; // مسافتين! ❌
    }
}

public class Admin
{
    public string GetFullName()
    {
        return FirstName + " " + LastName; // طريقة مختلفة! ❌
    }
}

// النتيجة: نفس الوظيفة، 3 تطبيقات مختلفة! 🤦‍♂️

// المشكلة 4: مفيش Generic Methods ❌
public void SendEmailToStudent(Student student)
{
    // Send email logic
}

public void SendEmailToInstructor(Instructor instructor)
{
    // نفس الـ logic! 🔄
}

public void SendEmailToAdmin(Admin admin)
{
    // نفس الـ logic مرة تالتة! 🔄
}

// كنت ممكن تعمل method واحدة لو كان في base class! 😢

// المشكلة 5: Validation مختلفة 🎲
// في Student:
public void UpdateEmail(string newEmail)
{
    if (string.IsNullOrWhiteSpace(newEmail))
        throw new ArgumentException("Email cannot be empty");
    Email = newEmail;
}

// في Instructor (Developer تاني كتبها):
public void UpdateEmail(string newEmail)
{
    if (string.IsNullOrWhiteSpace(newEmail))
        throw new ArgumentException("Email is required"); // رسالة مختلفة!
    
    // نسي الـ email format validation! ❌
    Email = newEmail;
}

// في Admin (Developer تالت):
public void UpdateEmail(string newEmail)
{
    // نسي الـ null check خالص! 💀
    Email = newEmail; // NullReferenceException waiting to happen!
}

// المشكلة 6: Bug Multiplication 🐛🐛🐛
// لو في bug في GetAge():
public int GetAge()
{
    return DateTime.Now.Year - DateOfBirth.Year; // ❌ مش accurate!
}

// الـ bug موجود في 3 أماكن!
// هتصلحه في 3 أماكن!
// لو نسيت مكان = inconsistent data! 💥

// المشكلة 7: Testing Nightmare 🧪
// هتعمل نفس الـ tests 3 مرات!
[Test]
public void Student_GetFullName_ReturnsCorrectFormat() { }

[Test]
public void Instructor_GetFullName_ReturnsCorrectFormat() { }

[Test]
public void Admin_GetFullName_ReturnsCorrectFormat() { }

// = 3x الوقت والمجهود! ⏰

// المشكلة 8: لو عايز تضيف User Type جديد 📈
public class Guest
{
    // هتكتب كل الـ code من أول وجديد! 💀
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    // ... نسخ ولصق 50 سطر!
    
    // وممكن تنسى حاجة أو تغلط في حاجة! 🎲
}

// المشكلة 9: مفيش Shared Behavior 🔗
// لو عايز method تشتغل على أي user:
public void DeactivateUser(???) // ❌ مش عارف أحط إيه!
{
    // مفيش common type!
}

// هتعمل 3 methods:
public void DeactivateStudent(Student student) { }
public void DeactivateInstructor(Instructor instructor) { }
public void DeactivateAdmin(Admin admin) { }

// المشكلة 10: Database Schema Redundancy 🗄️
// في الـ Database:
Table: Students
- Id, FirstName, LastName, Email, ... (10 columns)
- StudentCode, CurrentLevel, GPA (3 columns)

Table: Instructors  
- Id, FirstName, LastName, Email, ... (نفس الـ 10 columns! 🔄)
- EmployeeCode, Specialization, ... (4 columns)

Table: Admins
- Id, FirstName, LastName, Email, ... (نفس الـ 10 columns مرة تالتة! 🔄)
- Department, Permissions, ... (3 columns)

// = 30 column مكرر في 3 tables! 💾
```

### 💣 سيناريو كارثي واقعي:

```csharp
// يوم عادي في الشركة:

// 9:00 AM - الـ Manager طلب feature جديدة:
// "عايزين نضيف Last Login Time لكل المستخدمين"

// Developer 1:
public class Student
{
    // ... existing code
    public DateTime LastLoginTime { get; set; } // ✅
}

// Developer 2: (مش عارف إن Developer 1 خلص):
public class Instructor  
{
    // ... existing code
    public DateTime LastLogin { get; set; } // ⚠️ اسم مختلف!
}

// Developer 3: (نسي Admin خالص):
public class Admin
{
    // ... existing code
    // ❌ مضافش الـ property!
}

// 11:00 AM - Testing:
var students = GetActiveStudents();
foreach(var student in students)
{
    Console.WriteLine(student.LastLoginTime); // ✅ Works
}

var instructors = GetActiveInstructors();
foreach(var instructor in instructors)
{
    Console.WriteLine(instructor.LastLoginTime); // 💥 Compile Error!
    // Property doesn't exist!
}

var admins = GetActiveAdmins();
foreach(var admin in admins)
{
    Console.WriteLine(admin.LastLoginTime); // 💥 Compile Error!
}

// 3:00 PM - الـ Manager زعلان:
// "الـ feature مش شغالة! وعايزين نعرض آخر login في الـ report!"

// 4:00 PM - Emergency Meeting:
// Developer 1: "أنا عملت Student!"
// Developer 2: "أنا عملت Instructor بس بـ اسم مختلف!"  
// Developer 3: "أنا نسيت Admin! 😅"

// 5:00 PM - الحل:
// هنصلح في 3 أماكن
// هنعمل الـ testing تاني
// هنعمل الـ deployment تاني
// = ضياع يوم كامل! 🗓️❌

// كل ده كان هيتحل في 5 دقائق لو كان في Inheritance! ✅
```

### 📊 الإحصائيات المرعبة:

```csharp
// بدون Inheritance في مشروع حقيقي:

// Code Duplication: 70% 🔄
// - نفس الـ Properties في 3+ classes
// - نفس الـ Methods في 3+ classes  
// - نفس الـ Validation في 3+ classes

// Bugs: 3x أكتر 🐛
// - Bug في مكان = Bug في 3 أماكن
// - Fix في مكان، نسيان مكانين

// Development Time: 2x أطول ⏰
// - كتابة نفس الكود مرات متعددة
// - Testing نفس الـ logic مرات متعددة

// Maintenance Cost: 5x أغلى 💰
// - تعديل في 3+ أماكن لأي تغيير
// - Risk of inconsistency عالي جداً

// Team Conflicts: كتير جداً 👥❌
// - كل developer بيكتب بطريقته
// - Merge conflicts كل يوم
// - Code reviews تاخد وقت طويل

// Database: Redundant جداً 🗄️
// - نفس الـ columns في tables كتير
// - Inconsistent data types
// - صعوبة عمل queries موحدة
```

### 🎯 الخلاصة المؤلمة:

بدون Inheritance في مشروع حقيقي:

❌ **70% من الكود مكرر** - نفس الـ properties والـ methods في كل مكان  
❌ **Bugs أكتر 3x** - نفس الـ bug في أماكن متعددة  
❌ **Maintenance كابوس** - أي تغيير محتاج تعديل في أماكن كتير  
❌ **Inconsistency عالية** - كل developer بيكتب بطريقته  
❌ **Testing متكرر** - نفس الـ tests لنفس الـ logic  
❌ **Development بطيء** - كتابة نفس الكود مرات كتير  
❌ **Team conflicts** - merge conflicts وmisunderstandings  
❌ **Database redundant** - نفس الـ columns في tables كتير  
❌ **مفيش polymorphism** - مش قادر تعمل generic methods  
❌ **Scalability صفر** - صعب جداً تضيف user types جديدة  

في الواقع:
🔥 شركات كتير refactored بالكامل علشان المشكلة دي  
🔥 Projects فشلت بسبب code duplication  
🔥 Teams انفصلت بسبب maintainability issues  

**الحل؟ Inheritance! 🚀**

---

## ✅ الطريقة الصحيحة - مع Inheritance الاحترافي

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ELearningPlatform;

// 👤 BASE CLASS - كل الحاجات المشتركة
public abstract class User
{
    // 🔒 Protected Fields - متاحة للـ derived classes
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phoneNumber;
    
    // 📖 Public Properties
    public Guid Id { get; protected set; }
    
    public string FirstName
    {
        get => _firstName;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name cannot be empty");
            
            if (value.Length < 2)
                throw new ArgumentException("First name must be at least 2 characters");
            
            if (value.Length > 50)
                throw new ArgumentException("First name cannot exceed 50 characters");
            
            _firstName = value.Trim();
        }
    }
    
    public string LastName
    {
        get => _lastName;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name cannot be empty");
            
            if (value.Length < 2)
                throw new ArgumentException("Last name must be at least 2 characters");
            
            if (value.Length > 50)
                throw new ArgumentException("Last name cannot exceed 50 characters");
            
            _lastName = value.Trim();
        }
    }
    
    public string Email
    {
        get => _email;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email cannot be empty");
            
            if (!IsValidEmail(value))
                throw new ArgumentException("Invalid email format");
            
            _email = value.Trim().ToLower();
        }
    }
    
    public string PhoneNumber
    {
        get => _phoneNumber;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number cannot be empty");
            
            // Remove spaces and dashes
            var cleaned = Regex.Replace(value, @"[\s-]", "");
            
            if (!Regex.IsMatch(cleaned, @"^\+?[0-9]{10,15}$"))
                throw new ArgumentException("Invalid phone number format");
            
            _phoneNumber = cleaned;
        }
    }
    
    public DateTime DateOfBirth { get; protected set; }
    public string Address { get; protected set; }
    public DateTime RegisteredAt { get; protected set; }
    public DateTime? LastLoginAt { get; protected set; }
    public bool IsActive { get; protected set; }
    
    // Computed Properties
    public string FullName => $"{_firstName} {_lastName}";
    public int Age => CalculateAge();
    public string UserType => GetType().Name;
    
    // 🏗️ Protected Constructor - يستخدم من الـ derived classes بس
    protected User(string firstName, string lastName, string email, 
                   string phoneNumber, DateTime dateOfBirth, string address)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
        Address = address ?? string.Empty;
        RegisteredAt = DateTime.UtcNow;
        IsActive = true;
        LastLoginAt = null;
    }
    
    // 📧 Shared Methods - كل الـ users يستخدموها
    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail))
            throw new ArgumentException("Email cannot be empty");
        
        if (!IsValidEmail(newEmail))
            throw new ArgumentException("Invalid email format");
        
        var oldEmail = _email;
        _email = newEmail.Trim().ToLower();
        
        OnEmailChanged(oldEmail, _email);
    }
    
    public void UpdatePhoneNumber(string newPhoneNumber)
    {
        if (string.IsNullOrWhiteSpace(newPhoneNumber))
            throw new ArgumentException("Phone number cannot be empty");
        
        var cleaned = Regex.Replace(newPhoneNumber, @"[\s-]", "");
        
        if (!Regex.IsMatch(cleaned, @"^\+?[0-9]{10,15}$"))
            throw new ArgumentException("Invalid phone number format");
        
        _phoneNumber = cleaned;
    }
    
    public void UpdateAddress(string newAddress)
    {
        Address = newAddress?.Trim() ?? string.Empty;
    }
    
    public void RecordLogin()
    {
        LastLoginAt = DateTime.UtcNow;
        OnUserLoggedIn();
    }
    
    public void Activate()
    {
        if (IsActive) return;
        
        IsActive = true;
        OnActivated();
    }
    
    public void Deactivate(string reason = "")
    {
        if (!IsActive) return;
        
        IsActive = false;
        OnDeactivated(reason);
    }
    
    // 🎯 Virtual Methods - ممكن الـ derived classes تعملها override
    public virtual string GetDisplayInfo()
    {
        return $"{FullName} ({UserType}) - {Email}";
    }
    
    public virtual Dictionary<string, object> GetBasicInfo()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["FullName"] = FullName,
            ["Email"] = Email,
            ["Phone"] = PhoneNumber,
            ["Age"] = Age,
            ["Type"] = UserType,
            ["RegisteredAt"] = RegisteredAt,
            ["LastLogin"] = LastLoginAt?.ToString("dd/MM/yyyy HH:mm") ?? "Never",
            ["IsActive"] = IsActive
        };
    }
    
    // 🔐 Protected Virtual Methods - للـ derived classes تستخدمها/تعدلها
    protected virtual void OnEmailChanged(string oldEmail, string newEmail)
    {
        Console.WriteLine($"📧 Email changed from {oldEmail} to {newEmail}");
    }
    
    protected virtual void OnUserLoggedIn()
    {
        Console.WriteLine($"🔐 {FullName} logged in at {LastLoginAt:dd/MM/yyyy HH:mm}");
    }
    
    protected virtual void OnActivated()
    {
        Console.WriteLine($"✅ {FullName} account activated");
    }
    
    protected virtual void OnDeactivated(string reason)
    {
        Console.WriteLine($"❌ {FullName} account deactivated. Reason: {reason}");
    }
    
    // 🧮 Private Helper Methods
    private int CalculateAge()
    {
        var today = DateTime.Today;
        var age = today.Year - DateOfBirth.Year;
        
        // Adjust if birthday hasn't occurred this year
        if (DateOfBirth.Date > today.AddYears(-age))
            age--;
        
        return age;
    }
    
    private bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;
        
        try
        {
            // Simple regex for email validation
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        catch
        {
            return false;
        }
    }
    
    public override string ToString()
    {
        return GetDisplayInfo();
    }
}

// 🎓 DERIVED CLASS 1: Student
public class Student : User
{
    private string _studentCode;
    private int _currentLevel;
    private decimal _gpa;
    
    public string StudentCode
    {
        get => _studentCode;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Student code cannot be empty");
            
            _studentCode = value.Trim().ToUpper();
        }
    }
    
    public int CurrentLevel
    {
        get => _currentLevel;
        private set
        {
            if (value < 1 || value > 4)
                throw new ArgumentException("Level must be between 1 and 4");
            
            _currentLevel = value;
        }
    }
    
    public decimal GPA
    {
        get => _gpa;
        private set
        {
            if (value < 0 || value > 4)
                throw new ArgumentException("GPA must be between 0 and 4");
            
            _gpa = value;
        }
    }
    
    public List<string> EnrolledCourses { get; private set; }
    public int CompletedCourses { get; private set; }
    
    // Constructor
    public Student(string firstName, string lastName, string email, string phoneNumber,
                   DateTime dateOfBirth, string address, string studentCode, int level = 1)
        : base(firstName, lastName, email, phoneNumber, dateOfBirth, address)
    {
        StudentCode = studentCode;
        CurrentLevel = level;
        GPA = 0;
        EnrolledCourses = new List<string>();
        CompletedCourses = 0;
    }
    
    // Student-specific methods
    public void EnrollInCourse(string courseName)
    {
        if (string.IsNullOrWhiteSpace(courseName))
            throw new ArgumentException("Course name cannot be empty");
        
        if (EnrolledCourses.Contains(courseName))
            throw new InvalidOperationException("Already enrolled in this course");
        
        EnrolledCourses.Add(courseName);
        Console.WriteLine($"📚 {FullName} enrolled in {courseName}");
    }
    
    public void CompleteCourse(string courseName, decimal grade)
    {
        if (!EnrolledCourses.Contains(courseName))
            throw new InvalidOperationException("Not enrolled in this course");
        
        if (grade < 0 || grade > 4)
            throw new ArgumentException("Grade must be between 0 and 4");
        
        EnrolledCourses.Remove(courseName);
        CompletedCourses++;
        
        // Recalculate GPA (simplified)
        GPA = ((GPA * (CompletedCourses - 1)) + grade) / CompletedCourses;
        
        Console.WriteLine($"✅ {FullName} completed {courseName} with grade {grade:F2}");
        Console.WriteLine($"   New GPA: {GPA:F2}");
    }
    
    public void PromoteToNextLevel()
    {
        if (CurrentLevel >= 4)
            throw new InvalidOperationException("Already at maximum level");
        
        CurrentLevel++;
        Console.WriteLine($"🎉 {FullName} promoted to Level {CurrentLevel}");
    }
    
    // Override base methods
    public override string GetDisplayInfo()
    {
        return $"🎓 Student: {FullName} ({StudentCode}) - Level {CurrentLevel} - GPA: {GPA:F2}";
    }
    
    public override Dictionary<string, object> GetBasicInfo()
    {
        var info = base.GetBasicInfo();
        info["StudentCode"] = StudentCode;
        info["Level"] = CurrentLevel;
        info["GPA"] = GPA;
        info["EnrolledCourses"] = EnrolledCourses.Count;
        info["CompletedCourses"] = CompletedCourses;
        return info;
    }
    
    protected override void OnUserLoggedIn()
    {
        base.OnUserLoggedIn();
        Console.WriteLine($"   📚 Enrolled in {EnrolledCourses.Count} courses");
    }
}

// 👨‍🏫 DERIVED CLASS 2: Instructor
public class Instructor : User
{
    private string _employeeCode;
    private decimal _hourlyRate;
    
    public string EmployeeCode
    {
        get => _employeeCode;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Employee code cannot be empty");
            
            _employeeCode = value.Trim().ToUpper();
        }
    }
    
    public string Specialization { get; private set; }
    
    public decimal HourlyRate
    {
        get => _hourlyRate;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Hourly rate cannot be negative");
            
            _hourlyRate = value;
        }
    }
    
    public int YearsOfExperience { get; private set; }
    public List<string> TeachingCourses { get; private set; }
    public int TotalStudentsTaught { get; private set; }
    public decimal AverageRating { get; private set; }
    
    // Constructor
    public Instructor(string firstName, string lastName, string email, string phoneNumber,
                      DateTime dateOfBirth, string address, string employeeCode,
                      string specialization, decimal hourlyRate, int yearsOfExperience)
        : base(firstName, lastName, email, phoneNumber, dateOfBirth, address)
    {
        EmployeeCode = employeeCode;
        Specialization = specialization ?? "General";
        HourlyRate = hourlyRate;
        YearsOfExperience = yearsOfExperience;
        TeachingCourses = new List<string>();
        TotalStudentsTaught = 0;
        AverageRating = 0;
    }
    
    // Instructor-specific methods
    public void AssignCourse(string courseName)
    {
        if (string.IsNullOrWhiteSpace(courseName))
            throw new ArgumentException("Course name cannot be empty");
        
        if (TeachingCourses.Contains(courseName))
            throw new InvalidOperationException("Already teaching this course");
        
        TeachingCourses.Add(courseName);
        Console.WriteLine($"📖 {FullName} assigned to teach {courseName}");
    }
    
    public void RemoveCourse(string courseName)
    {
        if (!TeachingCourses.Contains(courseName))
            throw new InvalidOperationException("Not teaching this course");
        
        TeachingCourses.Remove(courseName);
        Console.WriteLine($"📕 {FullName} removed from {courseName}");
    }
    
    public void UpdateHourlyRate(decimal newRate)
    {
        if (newRate < 0)
            throw new ArgumentException("Hourly rate cannot be negative");
        
        var oldRate = _hourlyRate;
        _hourlyRate = newRate;
        
        Console.WriteLine($"💰 Hourly rate updated from {oldRate:F2} to {newRate:F2} EGP");
    }
    
    public void RecordStudentsTaught(int count)
    {
        if (count < 0)
            throw new ArgumentException("Count cannot be negative");
        
        TotalStudentsTaught += count;
    }
    
    public void UpdateRating(decimal rating)
    {
        if (rating < 0 || rating > 5)
            throw new ArgumentException("Rating must be between 0 and 5");
        
        // Simple average (in real app, you'd track all ratings)
        AverageRating = (AverageRating + rating) / 2;
        
        Console.WriteLine($"⭐ New rating recorded: {rating:F1}/5.0 - Average: {AverageRating:F1}");
    }
    
    public decimal CalculateMonthlyEarnings(int hoursWorked)
    {
        if (hoursWorked < 0)
            throw new ArgumentException("Hours cannot be negative");
        
        return HourlyRate * hoursWorked;
    }
    
    // Override base methods
    public override string GetDisplayInfo()
    {
        return $"👨‍🏫 Instructor: {FullName} ({EmployeeCode}) - {Specialization} - ⭐{AverageRating:F1}";
    }
    
    public override Dictionary<string, object> GetBasicInfo()
    {
        var info = base.GetBasicInfo();
        info["EmployeeCode"] = EmployeeCode;
        info["Specialization"] = Specialization;
        info["HourlyRate"] = $"{HourlyRate:F2} EGP";
        info["Experience"] = $"{YearsOfExperience} years";
        info["TeachingCourses"] = TeachingCourses.Count;
        info["StudentsTaught"] = TotalStudentsTaught;
        info["Rating"] = $"{AverageRating:F1}/5.0";
        return info;
    }
    
    protected override void OnUserLoggedIn()
    {
        base.OnUserLoggedIn();
        Console.WriteLine($"   📖 Teaching {TeachingCourses.Count} courses");
    }
}

// 👔 DERIVED CLASS 3: Admin
public class Admin : User
{
    private string _department;
    
    public string Department
    {
        get => _department;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Department cannot be empty");
            
            _department = value.Trim();
        }
    }
    
    public bool IsSuperAdmin { get; private set; }
    public List<string> Permissions { get; private set; }
    public DateTime LastPermissionChange { get; private set; }
    public int ActionsPerformed { get; private set; }
    
    // Constructor
    public Admin(string firstName, string lastName, string email, string phoneNumber,
                 DateTime dateOfBirth, string address, string department, bool isSuperAdmin = false)
        : base(firstName, lastName, email, phoneNumber, dateOfBirth, address)
    {
        Department = department;
        IsSuperAdmin = isSuperAdmin;
        Permissions = new List<string>();
        LastPermissionChange = DateTime.UtcNow;
        ActionsPerformed = 0;
        
        // Default permissions
        AddDefaultPermissions();
    }
    
    // Admin-specific methods
    private void AddDefaultPermissions()
    {
        Permissions.AddRange(new[]
        {
            "VIEW_USERS",
            "VIEW_COURSES",
            "VIEW_REPORTS"
        });
        
        if (IsSuperAdmin)
        {
            Permissions.AddRange(new[]
            {
                "CREATE_USERS",
                "EDIT_USERS",
                "DELETE_USERS",
                "MANAGE_COURSES",
                "MANAGE_PERMISSIONS",
                "VIEW_FINANCIALS",
                "SYSTEM_SETTINGS"
            });
        }
    }
    
    public void GrantPermission(string permission)
    {
        if (string.IsNullOrWhiteSpace(permission))
            throw new ArgumentException("Permission cannot be empty");
        
        if (Permissions.Contains(permission))
            throw new InvalidOperationException("Permission already granted");
        
        Permissions.Add(permission.ToUpper());
        LastPermissionChange = DateTime.UtcNow;
        
        Console.WriteLine($"✅ Permission '{permission}' granted to {FullName}");
    }
    
    public void RevokePermission(string permission)
    {
        if (!Permissions.Contains(permission))
            throw new InvalidOperationException("Permission not found");
        
        Permissions.Remove(permission);
        LastPermissionChange = DateTime.UtcNow;
        
        Console.WriteLine($"❌ Permission '{permission}' revoked from {FullName}");
    }
    
    public bool HasPermission(string permission)
    {
        if (IsSuperAdmin)
            return true; // Super admin has all permissions
        
        return Permissions.Contains(permission.ToUpper());
    }
    
    public void PromoteToSuperAdmin()
    {
        if (IsSuperAdmin)
            throw new InvalidOperationException("Already a super admin");
        
        IsSuperAdmin = true;
        AddDefaultPermissions(); // Add super admin permissions
        
        Console.WriteLine($"⭐ {FullName} promoted to Super Admin");
    }
    
    public void DemoteFromSuperAdmin()
    {
        if (!IsSuperAdmin)
            throw new InvalidOperationException("Not a super admin");
        
        IsSuperAdmin = false;
        
        // Remove super admin permissions
        var superAdminPermissions = new[] 
        { 
            "DELETE_USERS", "MANAGE_PERMISSIONS", 
            "VIEW_FINANCIALS", "SYSTEM_SETTINGS" 
        };
        
        foreach (var perm in superAdminPermissions)
        {
            Permissions.Remove(perm);
        }
        
        Console.WriteLine($"⬇️ {FullName} demoted from Super Admin");
    }
    
    public void RecordAction()
    {
        ActionsPerformed++;
    }
    
    // Override base methods
    public override string GetDisplayInfo()
    {
        var role = IsSuperAdmin ? "Super Admin" : "Admin";
        return $"👔 {role}: {FullName} - {Department} - {Permissions.Count} permissions";
    }
    
    public override Dictionary<string, object> GetBasicInfo()
    {
        var info = base.GetBasicInfo();
        info["Department"] = Department;
        info["IsSuperAdmin"] = IsSuperAdmin;
        info["Permissions"] = Permissions.Count;
        info["ActionsPerformed"] = ActionsPerformed;
        info["LastPermissionChange"] = LastPermissionChange.ToString("dd/MM/yyyy HH:mm");
        return info;
    }
    
    protected override void OnUserLoggedIn()
    {
        base.OnUserLoggedIn();
        Console.WriteLine($"   👔 {(IsSuperAdmin ? "Super Admin" : "Admin")} access - {Permissions.Count} permissions");
    }
    
    protected override void OnDeactivated(string reason)
    {
        base.OnDeactivated(reason);
        Console.WriteLine($"   🔒 All permissions suspended");
    }
}

// 📊 Service Class - demonstrates polymorphism with inheritance
public class UserManagementService
{
    private List<User> _users = new List<User>();
    
    public void RegisterUser(User user)
    {
        if (_users.Any(u => u.Email == user.Email))
            throw new InvalidOperationException("Email already registered");
        
        _users.Add(user);
        Console.WriteLine($"\n✅ User registered: {user.GetDisplayInfo()}");
    }
    
    public void LoginUser(string email)
    {
        var user = _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        
        if (user == null)
            throw new InvalidOperationException("User not found");
        
        if (!user.IsActive)
            throw new InvalidOperationException("User account is deactivated");
        
        user.RecordLogin();
    }
    
    public void DisplayAllUsers()
    {
        Console.WriteLine("\n" + new string('═', 80));
        Console.WriteLine("ALL REGISTERED USERS");
        Console.WriteLine(new string('═', 80));
        
        foreach (var user in _users)
        {
            Console.WriteLine($"\n{user.GetDisplayInfo()}");
            
            var info = user.GetBasicInfo();
            foreach (var kvp in info.Where(k => k.Key != "FullName" && k.Key != "Email"))
            {
                Console.WriteLine($"  • {kvp.Key}: {kvp.Value}");
            }
        }
    }
    
    public void DisplayStatistics()
    {
        Console.WriteLine("\n" + new string('═', 80));
        Console.WriteLine("PLATFORM STATISTICS");
        Console.WriteLine(new string('═', 80));
        
        var totalUsers = _users.Count;
        var activeUsers = _users.Count(u => u.IsActive);
        var students = _users.OfType<Student>().ToList();
        var instructors = _users.OfType<Instructor>().ToList();
        var admins = _users.OfType<Admin>().ToList();
        
        Console.WriteLine($"📊 Total Users: {totalUsers}");
        Console.WriteLine($"✅ Active Users: {activeUsers}");
        Console.WriteLine($"🎓 Students: {students.Count}");
        Console.WriteLine($"👨‍🏫 Instructors: {instructors.Count}");
        Console.WriteLine($"👔 Admins: {admins.Count}");
        
        if (students.Any())
        {
            var avgGPA = students.Average(s => s.GPA);
            var totalEnrollments = students.Sum(s => s.EnrolledCourses.Count);
            Console.WriteLine($"📚 Average GPA: {avgGPA:F2}");
            Console.WriteLine($"📖 Total Course Enrollments: {totalEnrollments}");
        }
        
        if (instructors.Any())
        {
            var avgRating = instructors.Average(i => i.AverageRating);
            var totalCourses = instructors.Sum(i => i.TeachingCourses.Count);
            Console.WriteLine($"⭐ Average Instructor Rating: {avgRating:F1}/5.0");
            Console.WriteLine($"📕 Total Courses Being Taught: {totalCourses}");
        }
    }
    
    // Polymorphic method - works with any User type!
    public void SendEmailToAllUsers(string subject, string message)
    {
        Console.WriteLine($"\n📧 Sending email to all users...");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}\n");
        
        foreach (var user in _users.Where(u => u.IsActive))
        {
            Console.WriteLine($"  ✉️ Sent to: {user.Email} ({user.FullName})");
        }
        
        Console.WriteLine($"\n✅ Email sent to {_users.Count(u => u.IsActive)} users");
    }
}

// 🚀 DEMO PROGRAM
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║         E-LEARNING PLATFORM - INHERITANCE DEMONSTRATION              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
            
            var userService = new UserManagementService();
            
            // Create Students
            Console.WriteLine("\n🎓 CREATING STUDENTS...");
            Console.WriteLine(new string('─', 80));
            
            var student1 = new Student(
                "Ahmed", "Hassan", "ahmed.hassan@student.com", "+201234567890",
                new DateTime(2003, 5, 15), "Cairo, Egypt", "STU2024001", 1
            );
            userService.RegisterUser(student1);
            
            var student2 = new Student(
                "Fatma", "Ali", "fatma.ali@student.com", "+201234567891",
                new DateTime(2002, 8, 20), "Alexandria, Egypt", "STU2024002", 2
            );
            userService.RegisterUser(student2);
            
            // Create Instructors
            Console.WriteLine("\n👨‍🏫 CREATING INSTRUCTORS...");
            Console.WriteLine(new string('─', 80));
            
            var instructor1 = new Instructor(
                "Dr. Mohamed", "Ibrahim", "m.ibrahim@instructor.com", "+201234567892",
                new DateTime(1985, 3, 10), "Giza, Egypt", "INS2024001",
                "Computer Science", 250m, 10
            );
            userService.RegisterUser(instructor1);
            
            var instructor2 = new Instructor(
                "Dr. Sara", "Ahmed", "sara.ahmed@instructor.com", "+201234567893",
                new DateTime(1988, 7, 22), "Cairo, Egypt", "INS2024002",
                "Mathematics", 220m, 8
            );
            userService.RegisterUser(instructor2);
            
            // Create Admins
            Console.WriteLine("\n👔 CREATING ADMINS...");
            Console.WriteLine(new string('─', 80));
            
            var admin1 = new Admin(
                "Omar", "Khaled", "omar.khaled@admin.com", "+201234567894",
                new DateTime(1990, 1, 5), "Cairo, Egypt", "IT Department", true
            );
            userService.RegisterUser(admin1);
            
            var admin2 = new Admin(
                "Nour", "Salem", "nour.salem@admin.com", "+201234567895",
                new DateTime(1992, 11, 18), "Alexandria, Egypt", "Academic Affairs", false
            );
            userService.RegisterUser(admin2);
            
            // Demonstrate Student Operations
            Console.WriteLine("\n\n🎓 STUDENT OPERATIONS");
            Console.WriteLine(new string('═', 80));
            
            student1.EnrollInCourse("Introduction to Programming");
            student1.EnrollInCourse("Data Structures");
            student1.CompleteCourse("Introduction to Programming", 3.7m);
            
            student2.EnrollInCourse("Advanced Mathematics");
            student2.CompleteCourse("Advanced Mathematics", 3.9m);
            student2.PromoteToNextLevel();
            
            // Demonstrate Instructor Operations
            Console.WriteLine("\n\n👨‍🏫 INSTRUCTOR OPERATIONS");
            Console.WriteLine(new string('═', 80));
            
            instructor1.AssignCourse("Introduction to Programming");
            instructor1.AssignCourse("Data Structures");
            instructor1.RecordStudentsTaught(45);
            instructor1.UpdateRating(4.5m);
            instructor1.UpdateRating(4.8m);
            
            Console.WriteLine($"\n💰 Monthly earnings for 120 hours: {instructor1.CalculateMonthlyEarnings(120):F2} EGP");
            
            // Demonstrate Admin Operations
            Console.WriteLine("\n\n👔 ADMIN OPERATIONS");
            Console.WriteLine(new string('═', 80));
            
            admin2.GrantPermission("EDIT_USERS");
            admin2.GrantPermission("MANAGE_COURSES");
            Console.WriteLine($"\nAdmin has 'EDIT_USERS' permission: {admin2.HasPermission("EDIT_USERS")}");
            Console.WriteLine($"Admin has 'DELETE_USERS' permission: {admin2.HasPermission("DELETE_USERS")}");
            
            // Demonstrate Polymorphism
            Console.WriteLine("\n\n🔐 USER LOGIN SIMULATION");
            Console.WriteLine(new string('═', 80));
            
            userService.LoginUser("ahmed.hassan@student.com");
            userService.LoginUser("m.ibrahim@instructor.com");
            userService.LoginUser("omar.khaled@admin.com");
            
            // Display all users
            userService.DisplayAllUsers();
            
            // Display statistics
            userService.DisplayStatistics();
            
            // Polymorphic email sending
            userService.SendEmailToAllUsers(
                "Welcome to New Semester!",
                "Dear user, we're excited to start the new semester with you!"
            );
            
            // Demonstrate shared base class methods
            Console.WriteLine("\n\n🔄 DEMONSTRATING SHARED BASE CLASS METHODS");
            Console.WriteLine(new string('═', 80));
            
            student1.UpdateEmail("ahmed.new@student.com");
            instructor1.UpdatePhoneNumber("+201111111111");
            admin1.RecordLogin();
            
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    ✅ DEMO COMPLETED SUCCESSFULLY                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n💥 ERROR: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
    }
}
```
---

## 🎯 تحليل الكود - ليه Inheritance غيّر كل حاجة!

### 1️⃣ **Code Reusability - إعادة استخدام الكود 🔄✅**

```csharp
// ❌ بدون Inheritance:
// كتبت GetFullName() 3 مرات (Student, Instructor, Admin)
// كتبت UpdateEmail() 3 مرات
// كتبت GetAge() 3 مرات
// = 150+ سطر مكرر!

// ✅ مع Inheritance:
public abstract class User
{
    public string FullName => $"{_firstName} {_lastName}";
    public int Age => CalculateAge();
    public void UpdateEmail(string newEmail) { /* مرة واحدة بس! */ }
}

// النتيجة:
// كتبت كل method مرة واحدة بس
// Student, Instructor, Admin كلهم ورثوها
// = توفير 70% من الكود! 🎉
```

### 2️⃣ **Single Source of Truth - مصدر واحد للحقيقة ✅**

```csharp
// ✅ أي تعديل في User Class بيأثر على الكل
protected User(string firstName, string lastName, string email, ...)
{
    Id = Guid.NewGuid();
    FirstName = firstName;  // Validation هنا بس!
    LastName = lastName;
    Email = email;          // Validation مرة واحدة!
    // ...
}

// لو عايز تضيف property جديدة:
public string ProfilePicture { get; protected set; }

// ✅ كل الـ derived classes هتورثها أوتوماتيك!
// مش محتاج تضيفها في 3 أماكن!
```

### 3️⃣ **Consistent Validation - توحيد الـ Validation ✅**

```csharp
// ✅ Email validation في مكان واحد
public string Email
{
    get => _email;
    protected set
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email cannot be empty");
        
        if (!IsValidEmail(value))
            throw new ArgumentException("Invalid email format");
        
        _email = value.Trim().ToLower();
    }
}

// كل Student, Instructor, Admin بيستخدموا نفس الـ validation!
// مفيش اختلافات أو inconsistency!
```

### 4️⃣ **Polymorphism - التعامل الموحد 🎯**

```csharp
// ✅ Method واحدة تشتغل على أي User type!
public void RegisterUser(User user)  // ← User = base type
{
    _users.Add(user);  // يقبل Student, Instructor, Admin!
    Console.WriteLine($"✅ Registered: {user.GetDisplayInfo()}");
}

// Usage:
RegisterUser(new Student(...));     // ✅ Works
RegisterUser(new Instructor(...));  // ✅ Works
RegisterUser(new Admin(...));       // ✅ Works

// بدل ما تعمل 3 methods:
// RegisterStudent(Student s)
// RegisterInstructor(Instructor i)
// RegisterAdmin(Admin a)
```

### 5️⃣ **Virtual Methods - المرونة في التخصيص 🎨**

```csharp
// في Base Class:
public virtual string GetDisplayInfo()
{
    return $"{FullName} ({UserType}) - {Email}";
}

// في Student Class:
public override string GetDisplayInfo()
{
    return $"🎓 Student: {FullName} ({StudentCode}) - Level {CurrentLevel}";
}

// في Instructor Class:
public override string GetDisplayInfo()
{
    return $"👨‍🏫 Instructor: {FullName} - {Specialization} - ⭐{AverageRating:F1}";
}

// النتيجة:
// كل type عنده display خاص بيه
// لكن كلهم بيستخدموا نفس الـ interface
// = Flexibility + Consistency!
```

### 6️⃣ **Protected Members - مشاركة آمنة 🔐**

```csharp
// ✅ Protected: متاح للـ derived classes بس
protected virtual void OnUserLoggedIn()
{
    Console.WriteLine($"🔐 {FullName} logged in");
}

// في Student:
protected override void OnUserLoggedIn()
{
    base.OnUserLoggedIn();  // استخدم الكود الأساسي
    Console.WriteLine($"   📚 Enrolled in {EnrolledCourses.Count} courses");
}

// في Instructor:
protected override void OnUserLoggedIn()
{
    base.OnUserLoggedIn();
    Console.WriteLine($"   📖 Teaching {TeachingCourses.Count} courses");
}

// = كل derived class يقدر يضيف behavior خاص بيه!
```

### 7️⃣ **Maintainability - سهولة الصيانة 🛠️**

```csharp
// مثال: عايز تضيف "Last Modified Date" لكل المستخدمين

// ✅ مع Inheritance:
// في Base Class بس:
public DateTime LastModifiedAt { get; protected set; }

protected void RecordModification()
{
    LastModifiedAt = DateTime.UtcNow;
}

// ✅ كل الـ derived classes هتورثها أوتوماتيك!
// ✅ تعديل واحد في مكان واحد!
// ✅ مفيش احتمال تنسى class!
```

### 8️⃣ **Testing - سهولة الاختبار 🧪**

```csharp
// ✅ تقدر تعمل tests للـ base class مرة واحدة
[TestFixture]
public class UserTests
{
    [Test]
    public void UpdateEmail_WithValidEmail_UpdatesSuccessfully()
    {
        // يشتغل على Student, Instructor, Admin!
        var user = new Student(...);
        user.UpdateEmail("new@email.com");
        Assert.AreEqual("new@email.com", user.Email);
    }
}

// بدل ما تعمل نفس الـ test 3 مرات!
```

---

## 🚀 المقارنة الكاملة: Before & After

| **Aspect** | ❌ بدون Inheritance | ✅ مع Inheritance |
|------------|---------------------|-------------------|
| **Code Lines** | 900+ سطر | 600 سطر |
| **Code Duplication** | 70% مكرر | 0% تكرار |
| **Maintenance** | تعديل في 3+ أماكن | تعديل في مكان واحد |
| **Consistency** | مختلف في كل class | موحد تماماً |
| **Adding Features** | يوم كامل | 5 دقائق |
| **Testing Effort** | 3x | 1x |
| **Bugs** | كتير جداً | قليل جداً |
| **Scalability** | صعب جداً | سهل جداً |
| **Polymorphism** | مستحيل | ممكن |
| **Team Conflicts** | عالية | قليلة |

---

## 💡 متى تستخدم Inheritance؟

### ✅ استخدم Inheritance لما:

1. **IS-A Relationship**: Student IS-A User, Instructor IS-A User
2. **Shared Behavior**: كل الـ types بيشاركوا نفس السلوكيات الأساسية
3. **Logical Hierarchy**: التسلسل منطقي ومفهوم
4. **Code Reusability**: محتاج تتجنب code duplication

```csharp
// ✅ مثال صح:
Vehicle → Car, Motorcycle, Truck
Animal → Dog, Cat, Bird
Employee → Manager, Developer, Designer
```

### ❌ متستخدمش Inheritance لما:

1. **HAS-A Relationship**: Car HAS-A Engine (استخدم Composition)
2. **No Shared Behavior**: الـ types مختلفة تماماً
3. **Multiple Inheritance**: C# مبتدعمش (استخدم Interfaces)

---

