# 🚀 .NET Backend Developer - Complete Knowledge Checklist

## 📘 Junior Level Topics

### ✅ C# Fundamentals - Types, Loops, Collections
**المفاهيم والمصطلحات المطلوبة:**
- [ ] Value Types (int, double, float, decimal, bool, char, byte, struct, enum)
- [ ] Reference Types (class, string, array, object, delegate)
- [ ] Nullable Types (int?, Nullable<int>)
- [ ] var keyword and type inference
- [ ] Type Casting (implicit casting, explicit casting)
- [ ] Type Conversion (Convert.ToInt32, int.Parse, int.TryParse)
- [ ] Boxing and Unboxing
- [ ] if-else statements
- [ ] switch statements and switch expressions (C# 8+)
- [ ] Pattern Matching (is, when)
- [ ] for loop
- [ ] foreach loop
- [ ] while loop
- [ ] do-while loop
- [ ] break and continue
- [ ] Arrays (single-dimensional, multi-dimensional, jagged)
- [ ] List<T> and methods (Add, Remove, Find, Contains, Sort)
- [ ] Dictionary<TKey, TValue> and methods (Add, ContainsKey, TryGetValue)
- [ ] HashSet<T> (unique items, fast lookup)
- [ ] Queue<T> (FIFO - First In First Out)
- [ ] Stack<T> (LIFO - Last In First Out)
- [ ] IEnumerable<T> and ICollection<T> interfaces
- [ ] ArrayList vs List<T> (generic vs non-generic)
- [ ] String manipulation (Substring, Split, Join, Replace, Trim)
- [ ] StringBuilder for performance
- [ ] DateTime and DateTimeOffset
- [ ] TimeSpan
- [ ] Guid (globally unique identifier)

---

### ❌ OOP Principles - Encapsulation, Inheritance, Polymorphism, Abstraction
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Encapsulation** - إخفاء البيانات وتقييد الوصول
- [ ] Access Modifiers (public, private, protected, internal, protected internal, private protected)
- [ ] Properties (get, set, init, auto-properties)
- [ ] Fields vs Properties
- [ ] Backing fields
- [ ] **Inheritance** - الوراثة
- [ ] Base class and Derived class
- [ ] base keyword للوصول للـ parent class
- [ ] sealed class (منع الوراثة)
- [ ] Method Overriding (virtual, override, new)
- [ ] **Polymorphism** - تعدد الأشكال
- [ ] Method Overloading (نفس الاسم، parameters مختلفة)
- [ ] Runtime Polymorphism (virtual/override)
- [ ] Compile-time Polymorphism (method overloading)
- [ ] **Abstraction** - التجريد
- [ ] Abstract Classes (abstract keyword)
- [ ] Abstract Methods (لازم يتعمل override)
- [ ] Interfaces (interface keyword)
- [ ] Interface vs Abstract Class (متى تستخدم كل واحد)
- [ ] Multiple Interface Implementation
- [ ] Default Interface Methods (C# 8+)
- [ ] Constructor chaining (this, base)
- [ ] Static classes and members
- [ ] Extension Methods
- [ ] partial classes
- [ ] Object class methods (ToString, Equals, GetHashCode)

---

### ❌ Exception Handling
**المفاهيم والمصطلحات المطلوبة:**
- [ ] try-catch-finally blocks
- [ ] Exception class hierarchy
- [ ] SystemException
- [ ] ApplicationException
- [ ] Common exceptions (NullReferenceException, ArgumentNullException, InvalidOperationException, ArgumentException)
- [ ] throw keyword
- [ ] throw vs throw ex (الفرق في Stack Trace)
- [ ] Creating Custom Exceptions
- [ ] InnerException property
- [ ] Exception.Message, Exception.StackTrace
- [ ] using statement (IDisposable pattern)
- [ ] try-catch with multiple catch blocks
- [ ] Exception Filters (when keyword)
- [ ] Best practices (catch specific exceptions, avoid empty catch)
- [ ] finally block execution guarantee
- [ ] Critical exceptions (OutOfMemoryException, StackOverflowException)

---

### ❌ Generics, Delegates, Events
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Generics** - Generic Programming
- [ ] Generic Classes (MyClass<T>)
- [ ] Generic Methods (MyMethod<T>)
- [ ] Generic Constraints (where T : class, struct, new(), IInterface)
- [ ] Generic Collections vs Non-generic (ArrayList vs List<T>)
- [ ] Covariance and Contravariance (out, in keywords)
- [ ] Default keyword for generics
- [ ] **Delegates** - Type-safe function pointers
- [ ] delegate keyword
- [ ] Func<T> (returns value)
- [ ] Action<T> (returns void)
- [ ] Predicate<T> (returns bool)
- [ ] Multicast Delegates
- [ ] Anonymous Methods
- [ ] Lambda Expressions (=>, expression-bodied members)
- [ ] Closure in lambda expressions
- [ ] **Events** - Observer pattern implementation
- [ ] event keyword
- [ ] EventHandler and EventHandler<TEventArgs>
- [ ] EventArgs and custom event arguments
- [ ] Raising events (?.Invoke pattern)
- [ ] Subscribing and Unsubscribing (+=, -=)
- [ ] Publisher-Subscriber pattern
- [ ] WeakReference for events (memory leak prevention)

---

### ❌ LINQ Basics
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **LINQ** - Language Integrated Query
- [ ] Query Syntax (from... where... select)
- [ ] Method Syntax (fluent API)
- [ ] Deferred Execution vs Immediate Execution
- [ ] IEnumerable<T> vs IQueryable<T>
- [ ] **Filtering**: Where
- [ ] **Projection**: Select, SelectMany
- [ ] **Sorting**: OrderBy, OrderByDescending, ThenBy, ThenByDescending
- [ ] **Grouping**: GroupBy
- [ ] **Aggregation**: Count, Sum, Average, Min, Max, Aggregate
- [ ] **Element operators**: First, FirstOrDefault, Single, SingleOrDefault, Last, LastOrDefault
- [ ] **Quantifiers**: Any, All, Contains
- [ ] **Set operations**: Distinct, Union, Intersect, Except
- [ ] **Partitioning**: Take, Skip, TakeLast, SkipLast, TakeWhile, SkipWhile
- [ ] **Joining**: Join, GroupJoin
- [ ] **Conversion**: ToList, ToArray, ToDictionary, ToHashSet
- [ ] Let clause in query syntax
- [ ] Anonymous Types
- [ ] Expression Trees (Expression<Func<T>>)

---

### ❌ ASP.NET Core Web API - Controllers, Routing
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **ASP.NET Core** framework
- [ ] Web API vs MVC
- [ ] Controller class (inherits ControllerBase)
- [ ] [ApiController] attribute (automatic model validation, binding source inference)
- [ ] [Route] attribute for routing
- [ ] Route templates ([Route("api/[controller]")])
- [ ] Route parameters ([Route("api/users/{id}")])
- [ ] Route constraints ([Route("api/users/{id:int}")])
- [ ] **HTTP Verbs attributes**:
  - [ ] [HttpGet]
  - [ ] [HttpPost]
  - [ ] [HttpPut]
  - [ ] [HttpDelete]
  - [ ] [HttpPatch]
  - [ ] [HttpHead]
  - [ ] [HttpOptions]
- [ ] Action methods
- [ ] **Action Results**:
  - [ ] Ok() / OkObjectResult (200)
  - [ ] Created() / CreatedAtAction() / CreatedAtRoute() (201)
  - [ ] NoContent() (204)
  - [ ] BadRequest() (400)
  - [ ] Unauthorized() (401)
  - [ ] Forbid() (403)
  - [ ] NotFound() (404)
  - [ ] Conflict() (409)
  - [ ] StatusCode() (custom status)
- [ ] IActionResult vs ActionResult<T>
- [ ] **Model Binding**:
  - [ ] [FromBody] - JSON body
  - [ ] [FromRoute] - URL parameters
  - [ ] [FromQuery] - query string
  - [ ] [FromHeader] - HTTP headers
  - [ ] [FromForm] - form data
  - [ ] [FromServices] - dependency injection
- [ ] Content Negotiation (JSON, XML)
- [ ] Attribute Routing vs Convention Routing
- [ ] Multiple routes on same action
- [ ] Route naming and URL generation

---

### ❌ ASP.NET Core - Middleware, Filters
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Middleware** - Request pipeline components
- [ ] app.Use vs app.Run vs app.Map
- [ ] Request Pipeline order
- [ ] Creating custom middleware (InvokeAsync, RequestDelegate)
- [ ] Middleware class vs inline middleware
- [ ] **Built-in Middleware**:
  - [ ] UseRouting
  - [ ] UseAuthentication
  - [ ] UseAuthorization
  - [ ] UseEndpoints
  - [ ] UseStaticFiles
  - [ ] UseCors
  - [ ] UseHttpsRedirection
  - [ ] UseExceptionHandler
  - [ ] UseDeveloperExceptionPage
- [ ] Middleware order importance
- [ ] **Filters** - Action pipeline
- [ ] Filter types:
  - [ ] Authorization Filters (IAuthorizationFilter)
  - [ ] Resource Filters (IResourceFilter)
  - [ ] Action Filters (IActionFilter, OnActionExecuting, OnActionExecuted)
  - [ ] Exception Filters (IExceptionFilter)
  - [ ] Result Filters (IResultFilter)
- [ ] Filter execution order
- [ ] Global filters vs Controller filters vs Action filters
- [ ] [Authorize] attribute
- [ ] [AllowAnonymous] attribute
- [ ] [ValidateAntiForgeryToken]
- [ ] Custom filter attributes
- [ ] Async filters (IAsyncActionFilter)
- [ ] Short-circuiting pipeline

---

### ❌ Dependency Injection (Scoped, Singleton, Transient)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Dependency Injection (DI)** pattern
- [ ] Inversion of Control (IoC)
- [ ] Service Container / IoC Container
- [ ] IServiceCollection interface
- [ ] **Service Lifetimes**:
  - [ ] **Transient** - new instance every request (AddTransient)
  - [ ] **Scoped** - one instance per HTTP request (AddScoped)
  - [ ] **Singleton** - one instance for app lifetime (AddSingleton)
- [ ] Constructor Injection
- [ ] Interface-based dependency injection
- [ ] Service registration (services.Add...)
- [ ] IServiceProvider
- [ ] Service resolution
- [ ] Multiple implementations of same interface
- [ ] TryAdd methods (TryAddTransient, TryAddScoped, TryAddSingleton)
- [ ] AddHostedService for background services
- [ ] Captive Dependency problem
- [ ] Disposed object exceptions
- [ ] Factory pattern with DI
- [ ] IServiceScopeFactory for manual scope creation
- [ ] Using DI in middleware

---

### ❌ REST Standards (Verbs, Status Codes, Versioning Basics)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **REST** - Representational State Transfer
- [ ] RESTful API principles
- [ ] Resource-based URLs (nouns not verbs)
- [ ] **HTTP Methods**:
  - [ ] GET - retrieve resource (idempotent, safe)
  - [ ] POST - create resource (not idempotent)
  - [ ] PUT - full update (idempotent)
  - [ ] PATCH - partial update
  - [ ] DELETE - remove resource (idempotent)
  - [ ] HEAD - headers only
  - [ ] OPTIONS - allowed methods
- [ ] Idempotency concept
- [ ] Safe methods vs unsafe methods
- [ ] **HTTP Status Codes**:
  - [ ] **2xx Success**: 200 OK, 201 Created, 202 Accepted, 204 No Content
  - [ ] **3xx Redirection**: 301 Moved Permanently, 302 Found, 304 Not Modified
  - [ ] **4xx Client Errors**: 400 Bad Request, 401 Unauthorized, 403 Forbidden, 404 Not Found, 405 Method Not Allowed, 409 Conflict, 422 Unprocessable Entity, 429 Too Many Requests
  - [ ] **5xx Server Errors**: 500 Internal Server Error, 502 Bad Gateway, 503 Service Unavailable, 504 Gateway Timeout
- [ ] Resource naming conventions (plural nouns)
- [ ] Hierarchical URLs (/users/{userId}/orders/{orderId})
- [ ] Query parameters for filtering, sorting, pagination
- [ ] HATEOAS (Hypermedia As The Engine Of Application State)
- [ ] **API Versioning strategies**:
  - [ ] URL versioning (/api/v1/users)
  - [ ] Query string versioning (?version=1)
  - [ ] Header versioning (Accept: application/vnd.api.v1+json)
  - [ ] Media type versioning
- [ ] Content-Type and Accept headers
- [ ] ETags for caching
- [ ] CORS (Cross-Origin Resource Sharing)

---

### ❌ Swagger / Postman
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Swagger / OpenAPI Specification**
- [ ] Swashbuckle.AspNetCore package
- [ ] AddSwaggerGen and UseSwagger
- [ ] Swagger UI (/swagger endpoint)
- [ ] XML Comments for documentation (/// comments)
- [ ] [Produces] attribute (response content type)
- [ ] [Consumes] attribute (request content type)
- [ ] [SwaggerOperation] attribute
- [ ] [SwaggerResponse] attribute
- [ ] Swagger annotations for examples
- [ ] Customizing Swagger UI theme
- [ ] API versioning in Swagger
- [ ] Bearer token authentication in Swagger
- [ ] Swagger schema generation
- [ ] **Postman**
- [ ] Creating requests (GET, POST, PUT, DELETE)
- [ ] Request collections
- [ ] Environment variables
- [ ] Pre-request scripts
- [ ] Tests tab (JavaScript assertions)
- [ ] Collection runner
- [ ] Authorization types in Postman
- [ ] Importing Swagger/OpenAPI definition
- [ ] Postman mock servers
- [ ] Postman monitors
- [ ] Newman (CLI for Postman)

---

### ❌ EF Core Basics - DbContext, DbSets, Migrations
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Entity Framework Core (EF Core)** - ORM
- [ ] ORM concept (Object-Relational Mapping)
- [ ] DbContext class
- [ ] DbSet<TEntity> properties
- [ ] OnConfiguring vs OnModelCreating
- [ ] Connection strings (appsettings.json)
- [ ] AddDbContext in Startup/Program.cs
- [ ] **Code-First approach**
- [ ] Database Providers (SQL Server, PostgreSQL, SQLite, MySQL)
- [ ] Microsoft.EntityFrameworkCore.SqlServer package
- [ ] **Data Annotations**:
  - [ ] [Key] - primary key
  - [ ] [Required] - not null
  - [ ] [MaxLength] - string length
  - [ ] [MinLength]
  - [ ] [StringLength]
  - [ ] [Column] - column name/type
  - [ ] [Table] - table name
  - [ ] [ForeignKey]
  - [ ] [NotMapped] - exclude from database
  - [ ] [Index]
  - [ ] [DatabaseGenerated] (Identity, None, Computed)
- [ ] **Fluent API** (more powerful than annotations)
- [ ] modelBuilder in OnModelCreating
- [ ] HasKey, Property, HasMaxLength
- [ ] IsRequired, HasColumnName, HasColumnType
- [ ] **Migrations**:
  - [ ] Add-Migration command (Package Manager Console)
  - [ ] dotnet ef migrations add (CLI)
  - [ ] Update-Database command
  - [ ] dotnet ef database update (CLI)
  - [ ] Remove-Migration / dotnet ef migrations remove
  - [ ] Migration history table (__EFMigrationsHistory)
  - [ ] Up and Down methods in migrations
  - [ ] Pending migrations
- [ ] Initial migration
- [ ] Reverting migrations
- [ ] EF Core Tools (dotnet ef)

---

### ❌ EF Core Relationships (1-1, 1-Many, Many-Many)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **One-to-One Relationship**
- [ ] Principal entity and dependent entity
- [ ] Foreign key in dependent
- [ ] Navigation properties (reference navigation)
- [ ] HasOne().WithOne() fluent API
- [ ] Required vs Optional relationships
- [ ] **One-to-Many Relationship**
- [ ] Collection navigation property
- [ ] HasMany().WithOne() fluent API
- [ ] [ForeignKey] attribute
- [ ] OnDelete behavior configuration
- [ ] **Many-to-Many Relationship**
- [ ] Join entity (explicit)
- [ ] Skip navigations (EF Core 5+, implicit join table)
- [ ] HasMany().WithMany() fluent API
- [ ] Configuring join table
- [ ] Payload in join table
- [ ] **Cascade Delete Behaviors**:
  - [ ] Cascade - delete related entities
  - [ ] Restrict - prevent delete if related exist
  - [ ] SetNull - set foreign key to null
  - [ ] NoAction - no automatic action
- [ ] **Loading Related Data**:
  - [ ] Eager Loading (.Include(), .ThenInclude())
  - [ ] Explicit Loading (.Load())
  - [ ] Lazy Loading (proxies, lazy loading without proxies)
- [ ] Inverse navigation properties
- [ ] Shadow properties (foreign keys not in model)
- [ ] Alternate keys
- [ ] Owned types for value objects

---

### ❌ EF Core Tracking vs No-Tracking
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Change Tracking** mechanism
- [ ] ChangeTracker in DbContext
- [ ] Entity states:
  - [ ] Added
  - [ ] Unchanged
  - [ ] Modified
  - [ ] Deleted
  - [ ] Detached
- [ ] Tracking queries (default behavior)
- [ ] **No-Tracking queries** (.AsNoTracking())
- [ ] AsNoTrackingWithIdentityResolution
- [ ] Performance differences (tracking overhead)
- [ ] When to use no-tracking (read-only, reporting queries)
- [ ] When to use tracking (updates, deletes)
- [ ] DetectChanges method
- [ ] AutoDetectChangesEnabled property
- [ ] Attaching entities (.Attach(), .Update())
- [ ] Entry() method
- [ ] SaveChanges vs SaveChangesAsync
- [ ] Transaction handling with SaveChanges
- [ ] Optimistic concurrency check
- [ ] Context lifetime and tracking scope

---

### ❌ JWT Authentication Basics
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **JWT** - JSON Web Token
- [ ] JWT structure: Header.Payload.Signature
- [ ] **Header** (algorithm, token type)
- [ ] **Payload** (claims: sub, exp, iat, iss, aud)
- [ ] **Signature** (ensures integrity)
- [ ] Base64URL encoding
- [ ] **Claims** in JWT
- [ ] Standard claims (sub, email, name, role, exp, nbf, iat)
- [ ] Custom claims
- [ ] ClaimsPrincipal and ClaimsIdentity
- [ ] Creating JWT with JwtSecurityTokenHandler
- [ ] SecurityTokenDescriptor
- [ ] SymmetricSecurityKey vs AsymmetricSecurityKey
- [ ] Signing credentials (HmacSha256)
- [ ] Secret key management
- [ ] Token expiration (exp claim)
- [ ] **Authentication in ASP.NET Core**:
  - [ ] AddAuthentication()
  - [ ] AddJwtBearer()
  - [ ] TokenValidationParameters
  - [ ] ValidateIssuer, ValidateAudience
  - [ ] ValidateLifetime, ValidateIssuerSigningKey
  - [ ] ClockSkew
- [ ] Bearer token in Authorization header
- [ ] [Authorize] attribute
- [ ] HttpContext.User
- [ ] Getting user claims (User.FindFirst, User.Claims)
- [ ] Token validation flow
- [ ] Why JWT is stateless

---

### ❌ ASP.NET Identity Basics
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **ASP.NET Core Identity** framework
- [ ] IdentityUser class
- [ ] Extending IdentityUser (custom properties)
- [ ] IdentityRole class
- [ ] UserManager<TUser>
- [ ] SignInManager<TUser>
- [ ] RoleManager<TRole>
- [ ] AddIdentity vs AddIdentityCore
- [ ] IdentityDbContext
- [ ] Identity tables (AspNetUsers, AspNetRoles, AspNetUserRoles, etc.)
- [ ] **User Registration**:
  - [ ] CreateAsync method
  - [ ] IdentityResult (Succeeded, Errors)
  - [ ] Password validation
- [ ] **Password requirements**:
  - [ ] RequiredLength
  - [ ] RequireDigit
  - [ ] RequireLowercase, RequireUppercase
  - [ ] RequireNonAlphanumeric
  - [ ] RequiredUniqueChars
- [ ] **User Login**:
  - [ ] PasswordSignInAsync
  - [ ] lockoutOnFailure parameter
  - [ ] isPersistent (remember me)
- [ ] Lockout settings
- [ ] **Email confirmation**:
  - [ ] GenerateEmailConfirmationTokenAsync
  - [ ] ConfirmEmailAsync
  - [ ] RequireConfirmedEmail option
- [ ] **Password reset**:
  - [ ] GeneratePasswordResetTokenAsync
  - [ ] ResetPasswordAsync
- [ ] Two-factor authentication basics
- [ ] Security stamps
- [ ] User stores (IUserStore)
- [ ] AddDefaultTokenProviders
- [ ] Identity options configuration

---

### ❌ Role-based Authorization
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Authorization** vs Authentication
- [ ] **Role-based Access Control (RBAC)**
- [ ] Creating roles (RoleManager.CreateAsync)
- [ ] Assigning users to roles (UserManager.AddToRoleAsync)
- [ ] Removing users from roles (RemoveFromRoleAsync)
- [ ] Checking user roles (IsInRoleAsync, GetRolesAsync)
- [ ] [Authorize(Roles = "Admin")]
- [ ] Multiple roles [Authorize(Roles = "Admin,Manager")]
- [ ] Role claims
- [ ] HttpContext.User.IsInRole()
- [ ] **Policy-based authorization** (intro):
  - [ ] AuthorizationPolicy
  - [ ] RequireRole
  - [ ] [Authorize(Policy = "PolicyName")]
- [ ] Combining roles with authentication schemes
- [ ] Role hierarchy concepts
- [ ] Custom authorization requirements
- [ ] Authorization handlers (IAuthorizationHandler)
- [ ] Resource-based authorization basics

---

### ❌ Git/GitHub Basics
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Version Control System (VCS)**
- [ ] Git vs GitHub
- [ ] Repository (repo)
- [ ] **Basic Git commands**:
  - [ ] git init - initialize repository
  - [ ] git clone - copy remote repository
  - [ ] git add - stage changes
  - [ ] git commit - save changes
  - [ ] git push - upload to remote
  - [ ] git pull - download from remote
  - [ ] git fetch - download without merge
  - [ ] git status - check current state
  - [ ] git log - view commit history
  - [ ] git diff - see changes
- [ ] Staging area (index)
- [ ] Working directory
- [ ] **Branching**:
  - [ ] git branch - list/create branches
  - [ ] git checkout - switch branches
  - [ ] git switch (modern alternative)
  - [ ] git merge - combine branches
  - [ ] Fast-forward merge vs three-way merge
- [ ] main/master branch
- [ ] Feature branches
- [ ] **Merge conflicts**:
  - [ ] Conflict markers (<<<<, ====, >>>>)
  - [ ] Resolving conflicts manually
  - [ ] git merge --abort
- [ ] .gitignore file (bin, obj, .vs, appsettings.Development.json)
- [ ] .gitattributes
- [ ] **GitHub features**:
  - [ ] Remote repositories
  - [ ] Fork
  - [ ] Pull Request (PR)
  - [ ] Code review
  - [ ] Issues
  - [ ] GitHub Projects
  - [ ] README.md
  - [ ] GitHub Actions (intro)
- [ ] git remote (add, remove, -v)
- [ ] origin (default remote name)
- [ ] Commit messages best practices
- [ ] Git workflows (feature branch workflow, gitflow)

---

### ❌ Debugging in Visual Studio
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Breakpoints**:
  - [ ] Setting breakpoints (F9 or clicking gutter)
  - [ ] Conditional breakpoints (right-click → Conditions)
  - [ ] Hit count breakpoints
  - [ ] Logpoint (tracepoint)
  - [ ] Breakpoint actions
  - [ ] Disable/Enable breakpoints
- [ ] **Stepping through code**:
  - [ ] Start Debugging (F5)
  - [ ] Step Over (F10) - execute current line
  - [ ] Step Into (F11) - enter method
  - [ ] Step Out (Shift+F11) - exit method
  - [ ] Run to Cursor (Ctrl+F10)
  - [ ] Continue (F5)
- [ ] **Debug windows**:
  - [ ] Locals window - local variables
  - [ ] Autos window - relevant variables
  - [ ] Watch window - custom expressions
  - [ ] Call Stack window - execution path
  - [ ] Immediate window - execute code
  - [ ] Output window - debug messages
  - [ ] Threads window
- [ ] QuickWatch (Shift+F9)
- [ ] DataTips (hover over variables)
- [ ] Exception settings (Ctrl+Alt+E)
- [ ] Break on thrown exceptions
- [ ] Break on unhandled exceptions
- [ ] Debug vs Release configuration
- [ ] Attach to Process
- [ ] Hot Reload feature
- [ ] Edit and Continue
- [ ] Diagnostic Tools window
- [ ] Performance profiling basics

---

### ❌ Unit Testing Basics (xUnit)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Unit Testing** concept
- [ ] Test-driven development (TDD) intro
- [ ] **xUnit framework**
- [ ] xUnit test project creation
- [ ] [Fact] attribute - single test
- [ ] [Theory] attribute - parameterized test
- [ ] [InlineData] for test data
- [ ] [MemberData] and [ClassData]
- [ ] **Assert class methods**:
  - [ ] Assert.Equal / Assert.NotEqual
  - [ ] Assert.True / Assert.False
  - [ ] Assert.Null / Assert.NotNull
  - [ ] Assert.Empty / Assert.NotEmpty
  - [ ] Assert.Contains / Assert.DoesNotContain
  - [ ] Assert.Throws<TException>
  - [ ] Assert.Same / Assert.NotSame
  - [ ] Assert.InRange
  - [ ] Assert.IsType<T> / Assert.IsAssignableFrom<T>
- [ ] **AAA Pattern**:
  - [ ] Arrange - setup test data
  - [ ] Act - execute method
  - [ ] Assert - verify result
- [ ] Test naming conventions (MethodName_Scenario_ExpectedResult)
- [ ] Test class naming (ClassNameTests)
- [ ] Running tests (Test Explorer)
- [ ] Test coverage
- [ ] Fast, Isolated, Repeatable tests
- [ ] Constructor and Dispose for setup/cleanup
- [ ] IClassFixture for shared context
- [ ] ICollectionFixture for shared context across classes
- [ ] [Skip] attribute to temporarily disable tests
- [ ] Parallel test execution

---

### ❌ Logging (Serilog, ILogger)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Logging** importance
- [ ] **ILogger<T>** interface
- [ ] ILoggerFactory
- [ ] Dependency injection of ILogger
- [ ] **Log Levels**:
  - [ ] Trace (0) - very detailed
  - [ ] Debug (1) - debugging info
  - [ ] Information (2) - general info
  - [ ] Warning (3) - unexpected events
  - [ ] Error (4) - errors and exceptions
  - [ ] Critical (5) - critical failures
  - [ ] None - disable logging
- [ ] LogLevel configuration in appsettings.json
- [ ] Logging providers (Console, Debug, EventSource)
- [ ] **Structured Logging**
- [ ] Log message templates with placeholders
- [ ] **Serilog**:
  - [ ] Serilog.AspNetCore package
  - [ ] UseSerilog in Program.cs
  - [ ] Serilog configuration (appsettings.json or code)
  - [ ] **Sinks** (output destinations):
    - [ ] Console sink
    - [ ] File sink (rolling files)
    - [ ] Seq sink
    - [ ] Application Insights sink
    - [ ] Elasticsearch sink
  - [ ] WriteTo configuration
  - [ ] MinimumLevel configuration
  - [ ] Enrichers (environment, machine name, thread ID)
  - [ ] Request logging middleware
  - [ ] Destructuring objects in logs
- [ ] Log correlation (correlation ID for distributed tracing)
- [ ] Filtering logs by namespace
- [ ] Logging best practices (don't log sensitive data)

---

### ❌ Global Error Handling
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Exception Handling Middleware**
- [ ] app.UseExceptionHandler("/error")
- [ ] Developer exception page (UseDeveloperExceptionPage)
- [ ] Environment checking (IsDevelopment, IsProduction)
- [ ] Custom exception middleware
- [ ] IExceptionHandlerPathFeature
- [ ] **ProblemDetails** (RFC 7807 standard):
  - [ ] Type, Title, Status, Detail, Instance properties
  - [ ] ValidationProblemDetails for validation errors
- [ ] Consistent error response format
- [ ] Global exception filter (IExceptionFilter)
- [ ] Logging exceptions globally
- [ ] HttpContext in exception handlers
- [ ] Status code pages (UseStatusCodePages)
- [ ] Custom error pages for 404, 500
- [ ] Error controller for handling exceptions
- [ ] Returning appropriate status codes with errors
- [ ] Hiding sensitive error details in production
- [ ] Centralized error logging

---

## 📗 Mid-Level Topics

### ❌ Advanced C# - async/await Deep Dive
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Asynchronous Programming** concept
- [ ] Synchronous vs Asynchronous execution
- [ ] Task<T> and Task classes
- [ ] async keyword on methods
- [ ] await keyword
- [ ] async Task vs async void (avoid void except events)
- [ ] Task.Run for CPU-bound operations
- [ ] I/O-bound vs CPU-bound operations
- [ ] **ConfigureAwait**:
  - [ ] ConfigureAwait(false) - don't capture context
  - [ ] ConfigureAwait(true) - default, capture context
  - [ ] SynchronizationContext
- [ ] **ValueTask<T>**:
  - [ ] When to use ValueTask (high-performance scenarios)
  - [ ] ValueTask vs Task performance
- [ ] **Async Streams** (IAsyncEnumerable<T>):
  - [ ] yield return in async methods
  - [ ] await foreach
- [ ] Task.WhenAll - wait for multiple tasks
- [ ] Task.WhenAny - wait for first task
- [ ] Task.Delay for async delays
- [ ] **CancellationToken**:
  - [ ] CancellationTokenSource
  - [ ] Passing cancellation tokens
  - [ ] ThrowIfCancellationRequested
  - [ ] IsCancellationRequested
- [ ] Task.FromResult for synchronous results
- [ ] Task.CompletedTask
- [ ] Exception handling in async (try-catch, AggregateException)
- [ ] Deadlock scenarios and prevention
- [ ] async all the way principle
- [ ] TaskScheduler
- [ ] Task continuation (ContinueWith)

---

### ❌ Task Parallelism, Threading Basics
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Threading** basics
- [ ] Thread class
- [ ] Thread vs Task difference
- [ ] Foreground vs Background threads
- [ ] ThreadPool
- [ ] **Parallel class**:
  - [ ] Parallel.For
  - [ ] Parallel.ForEach
  - [ ] ParallelOptions (MaxDegreeOfParallelism)
  - [ ] ParallelLoopState
- [ ] **Thread Safety**:
  - [ ] Race conditions
  - [ ] Deadlocks
  - [ ] Thread synchronization
- [ ] **lock statement** (Monitor.Enter/Exit):
  - [ ] lock(object) syntax
  - [ ] Locking best practices
- [ ] Monitor class (Wait, Pulse, PulseAll)
- [ ] **Concurrent Collections**:
  - [ ] ConcurrentBag<T>
  - [ ] ConcurrentQueue<T>
  - [ ] ConcurrentStack<T>
  - [ ] ConcurrentDictionary<TKey, TValue>
  - [ ] BlockingCollection<T>
- [ ] **Interlocked class**:
  - [ ] Interlocked.Increment
  - [ ] Interlocked.Decrement
  - [ ] Interlocked.CompareExchange
- [ ] Mutex for inter-process synchronization
- [ ] Semaphore and SemaphoreSlim (limiting concurrent access)
- [ ] ReaderWriterLockSlim
- [ ] volatile keyword
- [ ] Thread.Sleep vs Task.Delay
- [ ] Thread local storage (ThreadLocal<T>)
- [ ] Context switching overhead

---

### ❌ Expression Trees Basics
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Expression Trees** concept
- [ ] Expression<TDelegate> vs Func<T>
- [ ] System.Linq.Expressions namespace
- [ ] When expressions are used (LINQ providers, dynamic queries)
- [ ] Expression class
- [ ] **Building expressions**:
  - [ ] Expression.Constant
  - [ ] Expression.Parameter
  - [ ] Expression.Property
  - [ ] Expression.Call
  - [ ] Expression.Lambda
  - [ ] Expression.Add, Subtract, Multiply, etc.
  - [ ] Expression.AndAlso, OrElse
- [ ] Compiling expressions (Compile() method)
- [ ] ExpressionVisitor for traversing/modifying trees
- [ ] **Use cases**:
  - [ ] Dynamic LINQ queries
  - [ ] Specification pattern
  - [ ] ORM query translation
  - [ ] Dynamic filtering and sorting
- [ ] ParameterExpression
- [ ] MemberExpression
- [ ] MethodCallExpression
- [ ] BinaryExpression
- [ ] LambdaExpression
- [ ] Expression body inspection
- [ ] Quote method

---

### ❌ Records vs Structs
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Record types** (C# 9+)
- [ ] Reference records (record class, default)
- [ ] Record structs (C# 10+)
- [ ] readonly record struct
- [ ] **Value equality** in records (vs reference equality in classes)
- [ ] Positional records (primary constructor)
- [ ] **with expression** for non-destructive mutation
- [ ] Deconstruction support
- [ ] init-only properties
- [ ] Record ToString override (automatic)
- [ ] Record GetHashCode and Equals (automatic)
- [ ] **Struct** type:
  - [ ] Value type (stored on stack if local)
  - [ ] No inheritance
  - [ ] Default constructor
  - [ ] Boxing and unboxing
- [ ] readonly struct
- [ ] ref struct (stack-only, e.g., Span<T>)
- [ ] **Class vs Struct vs Record** comparison:
  - [ ] Memory allocation (heap vs stack)
  - [ ] Equality semantics
  - [ ] Mutability
  - [ ] Performance implications
- [ ] When to use records (DTOs, immutable data)
- [ ] When to use structs (small, value-like data)
- [ ] When to use classes (entities, complex behavior)

---

### ❌ EF Core Performance Tuning - Compiled Queries
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Performance bottlenecks** in EF Core
- [ ] Query execution pipeline
- [ ] **Compiled Queries**:
  - [ ] EF.CompileQuery
  - [ ] EF.CompileAsyncQuery
  - [ ] When to use compiled queries (repeated queries)
- [ ] Query plan caching
- [ ] **N+1 Query Problem**:
  - [ ] Identification
  - [ ] Solution with .Include()
  - [ ] Solution with Select projection
- [ ] **Eager Loading** (.Include, .ThenInclude)
- [ ] **Explicit Loading** (Entry().Collection().Load())
- [ ] **Lazy Loading** (avoid in APIs)
- [ ] **Split Queries** (AsSplitQuery):
  - [ ] When to use (large Include chains)
  - [ ] Cartesian explosion problem
- [ ] **Projection** (Select) for performance:
  - [ ] Selecting only needed columns
  - [ ] Anonymous types
  - [ ] DTOs in projection
- [ ] **AsNoTracking** for read-only queries
- [ ] **Batch operations** (EF Core 7+):
  - [ ] ExecuteUpdate
  - [ ] ExecuteDelete
- [ ] Query statistics and analysis
- [ ] **Indexing** in database:
  - [ ] HasIndex in Fluent API
  - [ ] [Index] attribute
  - [ ] Composite indexes
- [ ] Query Tags for debugging (.TagWith())
- [ ] DbContext pooling (AddDbContextPool)
- [ ] Connection pooling
- [ ] Query result caching (manual or distributed)

---

### ❌ EF Core Raw SQL & Stored Procedures
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Raw SQL Queries**
- [ ] FromSqlRaw method
- [ ] FromSqlInterpolated (safer, parameterized)
- [ ] SQL injection risks and prevention
- [ ] Composing LINQ after FromSql
- [ ] **Non-query SQL**:
  - [ ] ExecuteSqlRaw
  - [ ] ExecuteSqlInterpolated
  - [ ] Returning affected rows count
- [ ] **Stored Procedures**:
  - [ ] Calling stored procedures with FromSqlRaw
  - [ ] Output parameters
  - [ ] Return values
  - [ ] Multiple result sets
- [ ] Mapping stored procedure results to entities
- [ ] SqlParameter for parameters
- [ ] Parameterized queries
- [ ] **When to use raw SQL**:
  - [ ] Complex queries not expressible in LINQ
  - [ ] Performance optimization
  - [ ] Bulk operations
  - [ ] Database-specific functions
- [ ] Mixing LINQ and raw SQL
- [ ] Views mapping (ToView)
- [ ] Keyless entity types for query results

---

### ❌ EF Core Interceptors
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Interceptors** concept
- [ ] **IDbCommandInterceptor**:
  - [ ] ReaderExecuting / ReaderExecuted
  - [ ] NonQueryExecuting / NonQueryExecuted
  - [ ] ScalarExecuting / ScalarExecuted
  - [ ] CommandCreated
  - [ ] Query logging with interceptor
  - [ ] Query modification
- [ ] **ISaveChangesInterceptor**:
  - [ ] SavingChanges / SavedChanges
  - [ ] SavingChangesAsync / SavedChangesAsync
  - [ ] Audit trail implementation
  - [ ] Setting timestamps automatically
  - [ ] Soft delete implementation
- [ ] **IDbConnectionInterceptor**:
  - [ ] ConnectionOpening / ConnectionOpened
  - [ ] ConnectionClosing / ConnectionClosed
- [ ] **IDbTransactionInterceptor**
- [ ] Registering interceptors:
  - [ ] AddInterceptors in DbContextOptionsBuilder
  - [ ] Global interceptors vs context-specific
- [ ] Multiple interceptors execution order
- [ ] **Use cases**:
  - [ ] Performance monitoring
  - [ ] Automatic auditing (CreatedDate, ModifiedDate)
  - [ ] Multi-tenancy filtering
  - [ ] Query hints injection
  - [ ] Logging slow queries
- [ ] Interceptor vs Global Query Filters

---

### ❌ Transactions & Concurrency Handling
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Database Transactions**
- [ ] **ACID properties**:
  - [ ] Atomicity - all or nothing
  - [ ] Consistency - valid state
  - [ ] Isolation - concurrent execution
  - [ ] Durability - permanent changes
- [ ] **Transaction in EF Core**:
  - [ ] BeginTransaction method
  - [ ] Commit and Rollback
  - [ ] IDbContextTransaction
  - [ ] SaveChanges as implicit transaction
- [ ] **TransactionScope** (System.Transactions):
  - [ ] Distributed transactions
  - [ ] Two-phase commit
  - [ ] TransactionScopeOption
- [ ] Transaction isolation levels:
  - [ ] ReadUncommitted
  - [ ] ReadCommitted (default)
  - [ ] RepeatableRead
  - [ ] Serializable
  - [ ] Snapshot
- [ ] **Optimistic Concurrency**:
  - [ ] [ConcurrencyCheck] attribute
  - [ ] [Timestamp] / RowVersion
  - [ ] IsConcurrencyToken in Fluent API
  - [ ] DbUpdateConcurrencyException
  - [ ] Handling concurrency conflicts
  - [ ] Retry logic
- [ ] **Pessimistic Concurrency**:
  - [ ] Database locks (SELECT FOR UPDATE)
  - [ ] Row-level locking
- [ ] SaveChanges return value (rows affected)
- [ ] Multiple DbContext coordination
- [ ] Saga pattern for distributed transactions

---

### ❌ Clean Architecture
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Clean Architecture** principles (Robert C. Martin)
- [ ] Separation of concerns
- [ ] **Dependency Rule** (dependencies point inward)
- [ ] **Layers**:
  - [ ] **Domain Layer** (core):
    - [ ] Entities
    - [ ] Value Objects
    - [ ] Domain Events
    - [ ] Aggregate Roots
    - [ ] Business rules and logic
    - [ ] No dependencies on outer layers
  - [ ] **Application Layer**:
    - [ ] Use Cases / Application Services
    - [ ] Interfaces (repository, services)
    - [ ] DTOs / ViewModels
    - [ ] Commands and Queries (CQRS)
    - [ ] Application logic (orchestration)
  - [ ] **Infrastructure Layer**:
    - [ ] Repository implementations
    - [ ] DbContext
    - [ ] External services (email, SMS)
    - [ ] File system access
    - [ ] Third-party integrations
  - [ ] **Presentation Layer** (Web API):
    - [ ] Controllers
    - [ ] Middleware
    - [ ] Filters
    - [ ] Request/Response models
- [ ] Inversion of Control (IoC)
- [ ] Dependency Injection across layers
- [ ] Domain-Driven Design alignment
- [ ] Testability benefits
- [ ] **Project structure**:
  - [ ] Domain project (no dependencies)
  - [ ] Application project (depends on Domain)
  - [ ] Infrastructure project (depends on Application)
  - [ ] Presentation/API project (depends on Application)
- [ ] Use case-driven development
- [ ] Screaming architecture concept

---

### ❌ SOLID Principles (Applied in Code)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **SOLID** acronym
- [ ] **S - Single Responsibility Principle (SRP)**:
  - [ ] One class, one reason to change
  - [ ] Cohesion
  - [ ] God object anti-pattern
  - [ ] Separation of concerns
- [ ] **O - Open/Closed Principle (OCP)**:
  - [ ] Open for extension, closed for modification
  - [ ] Using abstractions (interfaces)
  - [ ] Strategy pattern application
  - [ ] Avoiding if-else chains with polymorphism
- [ ] **L - Liskov Substitution Principle (LSP)**:
  - [ ] Derived classes must be substitutable for base
  - [ ] Contract preservation
  - [ ] Preconditions and postconditions
  - [ ] Behavioral subtyping
- [ ] **I - Interface Segregation Principle (ISP)**:
  - [ ] Many specific interfaces better than one general
  - [ ] Clients shouldn't depend on unused methods
  - [ ] Fat interface anti-pattern
  - [ ] Role interfaces
- [ ] **D - Dependency Inversion Principle (DIP)**:
  - [ ] Depend on abstractions, not concretions
  - [ ] High-level modules shouldn't depend on low-level
  - [ ] Dependency injection as implementation
  - [ ] Program to an interface
- [ ] **Code smells** indicating violations:
  - [ ] Large classes
  - [ ] Long methods
  - [ ] Tight coupling
  - [ ] Fragile base class
- [ ] Refactoring to SOLID
- [ ] SOLID benefits (maintainability, testability, flexibility)

---

### ❌ Design Patterns - Repository, Unit of Work
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Repository Pattern**:
  - [ ] Purpose (abstraction over data access)
  - [ ] Generic repository interface
  - [ ] Specific repository interfaces
  - [ ] Repository implementation
  - [ ] CRUD operations (GetAll, GetById, Add, Update, Delete)
  - [ ] Query methods in repository
  - [ ] Async repository methods
  - [ ] IQueryable vs IEnumerable in repositories
- [ ] **Unit of Work Pattern**:
  - [ ] Purpose (transaction management)
  - [ ] Single transaction for multiple repositories
  - [ ] IUnitOfWork interface
  - [ ] SaveChanges / Complete method
  - [ ] Coordinating multiple repositories
  - [ ] DbContext as Unit of Work
- [ ] Combining Repository and Unit of Work
- [ ] **Specification Pattern**:
  - [ ] Encapsulating query logic
  - [ ] ISpecification interface
  - [ ] Combining specifications (And, Or)
  - [ ] Apply method
- [ ] **Pros and cons**:
  - [ ] Benefits: testability, abstraction
  - [ ] Drawbacks with EF Core (already abstraction)
  - [ ] When to use repository pattern
- [ ] Generic vs specific repositories debate
- [ ] Repository per aggregate pattern (DDD)

---

### ❌ Design Patterns - Factory, Strategy, Observer
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Factory Pattern**:
  - [ ] **Simple Factory**:
    - [ ] Factory method creates objects
    - [ ] Switch/if logic for creation
  - [ ] **Factory Method**:
    - [ ] Abstract creator class
    - [ ] Concrete creators
    - [ ] Product interface
  - [ ] **Abstract Factory**:
    - [ ] Family of related objects
    - [ ] Multiple factory methods
  - [ ] When to use Factory patterns
  - [ ] Dependency injection with factories
- [ ] **Strategy Pattern**:
  - [ ] Purpose (algorithm selection at runtime)
  - [ ] Strategy interface
  - [ ] Concrete strategies
  - [ ] Context class
  - [ ] **Use cases**:
    - [ ] Payment processors
    - [ ] Sorting algorithms
    - [ ] Compression strategies
    - [ ] Validation strategies
  - [ ] Open/Closed principle application
- [ ] **Observer Pattern**:
  - [ ] Purpose (one-to-many dependency)
  - [ ] Subject (publisher)
  - [ ] Observer (subscriber)
  - [ ] Attach/Detach/Notify methods
  - [ ] Event-driven architecture
  - [ ] C# events vs Observer pattern
  - [ ] Weak events (memory leak prevention)
  - [ ] **Use cases**:
    - [ ] Event handling
    - [ ] Notification systems
    - [ ] Data binding (UI)
- [ ] Other patterns awareness:
  - [ ] Singleton
  - [ ] Builder
  - [ ] Adapter
  - [ ] Decorator

---

### ❌ Background Jobs - Hangfire
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Hangfire** library
- [ ] Background job processing
- [ ] Installing Hangfire packages
- [ ] **Storage options**:
  - [ ] SQL Server storage
  - [ ] Redis storage
  - [ ] In-memory (development only)
- [ ] AddHangfire configuration
- [ ] UseHangfireServer middleware
- [ ] **Job types**:
  - [ ] **Fire-and-forget**:
    - [ ] BackgroundJob.Enqueue
    - [ ] Execute once immediately
  - [ ] **Delayed jobs**:
    - [ ] BackgroundJob.Schedule
    - [ ] TimeSpan delay
  - [ ] **Recurring jobs**:
    - [ ] RecurringJob.AddOrUpdate
    - [ ] Cron expressions
    - [ ] Cron.Daily, Cron.Hourly, etc.
  - [ ] **Continuations**:
    - [ ] ContinueJobWith
    - [ ] Job chaining
- [ ] **Hangfire Dashboard**:
  - [ ] /hangfire endpoint
  - [ ] Monitoring jobs
  - [ ] Retrying failed jobs
  - [ ] Job statistics
  - [ ] Dashboard authorization
- [ ] Job cancellation (CancellationToken)
- [ ] **Job retry**:
  - [ ] AutomaticRetry attribute
  - [ ] Attempts configuration
  - [ ] Exponential backoff
- [ ] Job filters (IServerFilter, IClientFilter)
- [ ] Queue prioritization
- [ ] Job parameters serialization
- [ ] DisableConcurrentExecution attribute
- [ ] Hangfire vs Quartz.NET

---

### ❌ Messaging - RabbitMQ Basics (Direct, Fanout, Topic)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Message Queue** concept
- [ ] **RabbitMQ** message broker
- [ ] **AMQP** protocol (Advanced Message Queuing Protocol)
- [ ] RabbitMQ installation and setup
- [ ] RabbitMQ Management UI
- [ ] **Core concepts**:
  - [ ] Producer (publisher)
  - [ ] Consumer (subscriber)
  - [ ] Queue
  - [ ] Exchange
  - [ ] Binding
  - [ ] Routing Key
  - [ ] Virtual Host (vhost)
- [ ] **Exchange Types**:
  - [ ] **Direct Exchange**:
    - [ ] Exact routing key match
    - [ ] Point-to-point messaging
  - [ ] **Fanout Exchange**:
    - [ ] Broadcast to all bound queues
    - [ ] Ignores routing key
    - [ ] Publish/Subscribe pattern
  - [ ] **Topic Exchange**:
    - [ ] Pattern-based routing (wildcards)
    - [ ] * (one word), # (zero or more words)
    - [ ] Flexible routing
  - [ ] **Headers Exchange** (awareness)
- [ ] RabbitMQ.Client library
- [ ] ConnectionFactory and IConnection
- [ ] IModel (channel)
- [ ] BasicPublish for sending messages
- [ ] BasicConsume for receiving messages
- [ ] Message acknowledgments (ack, nack, reject)
- [ ] **Message properties**:
  - [ ] Persistent vs transient
  - [ ] Content-Type
  - [ ] Priority
  - [ ] Expiration
- [ ] Queue declaration (durable, exclusive, auto-delete)
- [ ] Prefetch count (QoS - Quality of Service)
- [ ] Dead Letter Exchange (DLQ)
- [ ] Message TTL (Time To Live)
- [ ] **Use cases**:
  - [ ] Decoupling services
  - [ ] Asynchronous processing
  - [ ] Load leveling
  - [ ] Event distribution

---

### ❌ Real-time Communication - SignalR
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **SignalR** library
- [ ] Real-time bidirectional communication
- [ ] WebSockets protocol
- [ ] Fallback transports (Server-Sent Events, Long Polling)
- [ ] **Hub** class:
  - [ ] Inheriting from Hub or Hub<T>
  - [ ] Hub methods (callable from clients)
  - [ ] Context property (connection info)
- [ ] AddSignalR in Program.cs
- [ ] MapHub endpoint
- [ ] **Clients property**:
  - [ ] Clients.All - all connected clients
  - [ ] Clients.Caller - current client
  - [ ] Clients.Others - all except caller
  - [ ] Clients.Client(connectionId) - specific client
  - [ ] Clients.Group(groupName) - all in group
  - [ ] Clients.User(userId) - specific user
- [ ] **Groups**:
  - [ ] Groups.AddToGroupAsync
  - [ ] Groups.RemoveFromGroupAsync
  - [ ] Use cases (chat rooms, notifications)
- [ ] **Connection lifecycle**:
  - [ ] OnConnectedAsync
  - [ ] OnDisconnectedAsync
  - [ ] Context.ConnectionId
  - [ ] Context.User (authenticated user)
- [ ] **Client-side (JavaScript)**:
  - [ ] HubConnection and HubConnectionBuilder
  - [ ] connection.start()
  - [ ] connection.on() - receive from server
  - [ ] connection.invoke() - call server method
  - [ ] connection.send() - fire and forget
- [ ] Strongly-typed hubs (Hub<T>)
- [ ] **Authentication**:
  - [ ] [Authorize] on hub or methods
  - [ ] JWT token in query string or headers
  - [ ] Context.User.Identity
- [ ] **Scaling SignalR**:
  - [ ] Sticky sessions
  - [ ] Redis backplane (later topic)
  - [ ] Azure SignalR Service
- [ ] **Use cases**:
  - [ ] Chat applications
  - [ ] Live notifications
  - [ ] Real-time dashboards
  - [ ] Collaborative editing
  - [ ] Live sports scores

---

### ❌ OAuth2 & OpenID Connect Basics
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **OAuth 2.0** protocol
- [ ] **Authentication vs Authorization**
- [ ] OAuth2 roles:
  - [ ] Resource Owner (user)
  - [ ] Client (application)
  - [ ] Authorization Server (identity provider)
  - [ ] Resource Server (API)
- [ ] **OAuth2 flows / Grant types**:
  - [ ] **Authorization Code Flow**:
    - [ ] Most secure for web apps
    - [ ] Authorization code exchange
    - [ ] Client secret required
  - [ ] **Implicit Flow** (deprecated):
    - [ ] For SPAs (old approach)
  - [ ] **Client Credentials Flow**:
    - [ ] Machine-to-machine
    - [ ] No user context
  - [ ] **Resource Owner Password Credentials** (avoid):
    - [ ] Direct username/password
- [ ] **PKCE** (Proof Key for Code Exchange):
  - [ ] Code verifier and code challenge
  - [ ] For public clients (mobile, SPA)
- [ ] **Tokens**:
  - [ ] Access Token (short-lived)
  - [ ] Refresh Token (long-lived)
  - [ ] Token expiration and renewal
- [ ] **Scopes** (permissions):
  - [ ] Requesting specific scopes
  - [ ] Scope-based authorization
- [ ] **OpenID Connect (OIDC)**:
  - [ ] Layer on top of OAuth2
  - [ ] Authentication protocol
  - [ ] ID Token (JWT with user info)
  - [ ] UserInfo endpoint
  - [ ] Standard claims (sub, name, email, picture)
- [ ] **Endpoints**:
  - [ ] /authorize - authorization endpoint
  - [ ] /token - token endpoint
  - [ ] /userinfo - user info endpoint
  - [ ] /.well-known/openid-configuration - discovery
- [ ] **IdentityServer** (Duende IdentityServer):
  - [ ] Self-hosted identity provider
  - [ ] Client configuration
  - [ ] Resource configuration
- [ ] External identity providers (Google, Microsoft, etc.)
- [ ] Redirect URIs and callback handling
- [ ] State parameter (CSRF protection)

---

### ❌ Social Logins (Google, Facebook)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **External Authentication** in ASP.NET Core
- [ ] OAuth2 providers
- [ ] **Google Authentication**:
  - [ ] Google Cloud Console setup
  - [ ] OAuth 2.0 Client ID
  - [ ] AddGoogle in Program.cs
  - [ ] GoogleOptions configuration
  - [ ] Requested scopes (email, profile)
- [ ] **Facebook Authentication**:
  - [ ] Facebook Developers setup
  - [ ] App ID and App Secret
  - [ ] AddFacebook in Program.cs
  - [ ] FacebookOptions configuration
- [ ] **Microsoft Account** (AddMicrosoftAccount)
- [ ] **Twitter** (AddTwitter)
- [ ] External authentication flow:
  - [ ] Challenge redirects to provider
  - [ ] Callback from provider
  - [ ] ExternalLoginInfo
- [ ] **Handling external login**:
  - [ ] SignInManager.GetExternalLoginInfoAsync
  - [ ] ExternalLoginCallback action
  - [ ] Creating local user
  - [ ] Linking external login to user
- [ ] AddLogin / RemoveLogin for user
- [ ] UserLoginInfo
- [ ] External claims retrieval
- [ ] Profile picture from providers
- [ ] Email verification from external login
- [ ] Multiple external providers for same user
- [ ] Provider-specific setup (redirect URIs, domains)

---

### ❌ Refresh Tokens Implementation
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Refresh Token** purpose
- [ ] Access token (short lifetime, e.g., 15 min)
- [ ] Refresh token (long lifetime, e.g., 7 days)
- [ ] Token pair (access + refresh)
- [ ] **Refresh token flow**:
  - [ ] Client uses expired access token
  - [ ] Client sends refresh token to /refresh endpoint
  - [ ] Server validates refresh token
  - [ ] Server issues new access + refresh tokens
- [ ] **Storing refresh tokens**:
  - [ ] Database storage (recommended)
  - [ ] User association
  - [ ] Token hash (security)
  - [ ] Expiration date
  - [ ] IsRevoked flag
- [ ] **Token Rotation**:
  - [ ] New refresh token on each refresh
  - [ ] Old token invalidation
  - [ ] Token family/chain
- [ ] **Refresh token revocation**:
  - [ ] Logout revokes token
  - [ ] Revoke all tokens for user
  - [ ] Admin revocation
- [ ] **Security considerations**:
  - [ ] Refresh token must be kept secret
  - [ ] HttpOnly cookies for storage (web)
  - [ ] Secure transmission (HTTPS)
  - [ ] Replay attack detection
- [ ] Token reuse detection
- [ ] Sliding expiration window
- [ ] Absolute expiration
- [ ] RefreshToken entity model
- [ ] Background cleanup of expired tokens

---

### ❌ API Versioning
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **API Versioning** importance
- [ ] Breaking vs non-breaking changes
- [ ] Microsoft.AspNetCore.Mvc.Versioning package
- [ ] **Versioning strategies**:
  - [ ] **URL versioning**:
    - [ ] /api/v1/products
    - [ ] /api/v2/products
    - [ ] Route template with version
  - [ ] **Query string versioning**:
    - [ ] /api/products?api-version=1.0
    - [ ] QueryStringApiVersionReader
  - [ ] **Header versioning**:
    - [ ] Custom header (x-api-version: 1.0)
    - [ ] HeaderApiVersionReader
  - [ ] **Media type versioning**:
    - [ ] Accept: application/vnd.company.v1+json
    - [ ] MediaTypeApiVersionReader
- [ ] AddApiVersioning configuration
- [ ] [ApiVersion("1.0")] attribute
- [ ] [ApiVersion("2.0")] attribute
- [ ] [MapToApiVersion("1.0")] attribute
- [ ] ApiVersioningOptions:
  - [ ] ReportApiVersions
  - [ ] AssumeDefaultVersionWhenUnspecified
  - [ ] DefaultApiVersion
- [ ] Version-neutral endpoints
- [ ] **Deprecating versions**:
  - [ ] [ApiVersion("1.0", Deprecated = true)]
  - [ ] Sunset header
  - [ ] Communication with clients
- [ ] API version conventions
- [ ] Version discovery (OPTIONS request)
- [ ] Documentation per version (Swagger)
- [ ] Gradual migration strategies

---

### ❌ Pagination, Filtering, Sorting
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Pagination** concept
- [ ] Page-based pagination:
  - [ ] pageNumber and pageSize parameters
  - [ ] Skip and Take in LINQ
  - [ ] Offset-based pagination
- [ ] **Cursor-based pagination** (for large datasets)
- [ ] **PagedList<T>** implementation:
  - [ ] Items collection
  - [ ] TotalCount
  - [ ] CurrentPage
  - [ ] TotalPages
  - [ ] HasPrevious, HasNext
- [ ] Pagination metadata in response:
  - [ ] Custom header (X-Pagination)
  - [ ] Response wrapper
- [ ] **HATEOAS links** (next, previous, first, last)
- [ ] Default page size and max page size
- [ ] **Filtering**:
  - [ ] Query string parameters (name=John)
  - [ ] Multiple filter criteria
  - [ ] Dynamic LINQ for filtering
  - [ ] Expression building for filters
  - [ ] Filter by nested properties
  - [ ] Date range filtering
  - [ ] Text search (Contains)
- [ ] **Sorting**:
  - [ ] orderBy parameter (orderBy=name)
  - [ ] Ascending vs descending (name desc)
  - [ ] Multiple sort fields (orderBy=name,age desc)
  - [ ] Dynamic OrderBy with reflection
  - [ ] System.Linq.Dynamic.Core package
  - [ ] Default sorting
- [ ] **Search**:
  - [ ] Full-text search basics
  - [ ] searchTerm parameter
  - [ ] Combining with filtering
- [ ] Performance considerations (indexing)
- [ ] IQueryable deferred execution
- [ ] Query object pattern
- [ ] Specification pattern for complex queries

---

### ❌ Validation (FluentValidation)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **FluentValidation** library
- [ ] FluentValidation.AspNetCore package
- [ ] AbstractValidator<T> base class
- [ ] **Validation rules**:
  - [ ] NotEmpty / NotNull
  - [ ] MaximumLength / MinimumLength
  - [ ] Length (exact or range)
  - [ ] EmailAddress
  - [ ] Must (custom rule with predicate)
  - [ ] Matches (regex)
  - [ ] GreaterThan / LessThan
  - [ ] InclusiveBetween / ExclusiveBetween
  - [ ] Equal / NotEqual
  - [ ] Null / NotNull
  - [ ] Empty / NotEmpty
  - [ ] ScalePrecision (for decimals)
- [ ] RuleFor method
- [ ] Custom error messages (.WithMessage())
- [ ] Error codes (.WithErrorCode())
- [ ] **Conditional validation**:
  - [ ] When / Unless
  - [ ] Predicate-based conditions
- [ ] **Dependent rules**:
  - [ ] DependentRules
  - [ ] Cascading validation
- [ ] **Async validators**:
  - [ ] MustAsync
  - [ ] Custom async rules
  - [ ] Database uniqueness checks
- [ ] **RuleSet**:
  - [ ] Different validation for different scenarios
  - [ ] RuleSet("Create"), RuleSet("Update")
  - [ ] Executing specific rule sets
- [ ] **Complex validations**:
  - [ ] Child validators
  - [ ] Collection validators (RuleForEach)
  - [ ] SetCollectionValidator
- [ ] Integration with ASP.NET Core:
  - [ ] AddFluentValidation
  - [ ] Automatic validation on model binding
  - [ ] Replacing DataAnnotations
- [ ] ValidationResult
- [ ] ValidationFailure
- [ ] Manual validation (validator.Validate())
- [ ] [Validator] attribute
- [ ] Localization support
- [ ] Test helpers

---

### ❌ Integration Testing (EF In-Memory)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Integration Testing** vs Unit Testing
- [ ] Testing full request/response cycle
- [ ] **WebApplicationFactory<TStartup>**:
  - [ ] Microsoft.AspNetCore.Mvc.Testing package
  - [ ] Creating test server
  - [ ] Custom WebApplicationFactory
- [ ] **In-Memory Database**:
  - [ ] UseInMemoryDatabase
  - [ ] Database name for isolation
  - [ ] Limitations (no relational features)
- [ ] **SQLite In-Memory** (better alternative):
  - [ ] UseSqlite with "DataSource=:memory:"
  - [ ] Connection must stay open
  - [ ] Relational features support
- [ ] **Test database seeding**:
  - [ ] Seed data in test setup
  - [ ] Factory method for test data
- [ ] **HttpClient** for testing:
  - [ ] CreateClient method
  - [ ] Sending requests (GetAsync, PostAsync, etc.)
  - [ ] Asserting response status codes
  - [ ] Deserializing response content
- [ ] **Authentication in tests**:
  - [ ] Test authentication handler
  - [ ] Mocking JWT tokens
  - [ ] WithWebHostBuilder customization
- [ ] **Overriding services**:
  - [ ] ConfigureTestServices
  - [ ] Replacing dependencies with mocks
- [ ] **Test fixtures**:
  - [ ] IClassFixture for shared context
  - [ ] Database cleanup between tests
- [ ] **Assertions**:
  - [ ] Status code assertions
  - [ ] Response body assertions
  - [ ] Header assertions
- [ ] Testing database operations
- [ ] Testing validation errors
- [ ] Testing authentication flows
- [ ] Test data builders pattern
- [ ] Respawn library for database cleanup

---

### ❌ Mocking (Moq)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Mocking** concept
- [ ] Test doubles (mock, stub, fake, spy)
- [ ] **Moq library**
- [ ] Mock<T> class
- [ ] **Setup methods**:
  - [ ] Setup(x => x.Method())
  - [ ] Returns for return values
  - [ ] ReturnsAsync for async methods
  - [ ] Throws for exceptions
  - [ ] ThrowsAsync for async exceptions
  - [ ] Callback for side effects
- [ ] **Argument matching**:
  - [ ] It.IsAny<T>() - any value
  - [ ] It.Is<T>(predicate) - specific condition
  - [ ] It.IsRegex(pattern) - regex match
  - [ ] It.IsIn(collection) - value in collection
- [ ] **Verification**:
  - [ ] Verify method calls
  - [ ] Times.Once, Times.Never, Times.Exactly(n)
  - [ ] Times.AtLeast, Times.AtMost
  - [ ] VerifyAll / VerifyNoOtherCalls
- [ ] **Properties**:
  - [ ] SetupProperty
  - [ ] SetupAllProperties
  - [ ] SetupGet / SetupSet
- [ ] **Sequences**:
  - [ ] SetupSequence for multiple calls
  - [ ] Different returns on subsequent calls
- [ ] **Strict vs Loose mocks**:
  - [ ] MockBehavior.Strict - all setups required
  - [ ] MockBehavior.Loose - default values (default)
- [ ] **MockRepository**:
  - [ ] Create multiple mocks
  - [ ] Verify all mocks
- [ ] Mock.Of<T> for quick mocks
- [ ] Protected() method for protected members
- [ ] As<TInterface>() for multiple interfaces
- [ ] **Best practices**:
  - [ ] Mock interfaces, not classes
  - [ ] Verify behavior, not implementation
  - [ ] Don't over-mock
- [ ] Mocking repositories in unit tests
- [ ] Mocking external services (email, SMS)
- [ ] Mocking HttpClient with HttpMessageHandler

---

### ❌ Azure App Service Deployment
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Azure App Service** (PaaS)
- [ ] **Creating App Service**:
  - [ ] Azure Portal
  - [ ] App Service Plan
  - [ ] Runtime stack (.NET 6/7/8)
  - [ ] Region selection
  - [ ] Pricing tiers (Free, Basic, Standard, Premium)
- [ ] **App Service Plans**:
  - [ ] Shared vs Dedicated
  - [ ] Scaling up (vertical) vs scaling out (horizontal)
  - [ ] Linux vs Windows plans
- [ ] **Deployment methods**:
  - [ ] Visual Studio Publish
  - [ ] FTP/FTPS
  - [ ] Git deployment (Local Git, GitHub)
  - [ ] Azure DevOps Pipelines
  - [ ] GitHub Actions
  - [ ] ZIP deploy
  - [ ] ARM templates
- [ ] **Deployment slots**:
  - [ ] Staging slot
  - [ ] Production slot
  - [ ] Slot swapping
  - [ ] Testing in staging before swap
  - [ ] Auto-swap
- [ ] **Configuration**:
  - [ ] App Settings (environment variables)
  - [ ] Connection strings
  - [ ] Application settings override appsettings.json
- [ ] **Kudu** (SCM site):
  - [ ] https://<app-name>.scm.azurewebsites.net
  - [ ] Debug console
  - [ ] File explorer
  - [ ] Process explorer
- [ ] **Deployment Center**:
  - [ ] Configuring CI/CD
  - [ ] GitHub integration
  - [ ] Azure Repos integration
- [ ] **Custom domains**:
  - [ ] Adding custom domain
  - [ ] SSL/TLS certificates
  - [ ] Managed certificates (free)
- [ ] **Scaling**:
  - [ ] Manual scale (instance count)
  - [ ] Auto-scale rules (CPU, memory, schedule)
  - [ ] Scale-out to multiple instances
- [ ] **Logs and monitoring**:
  - [ ] Application logs
  - [ ] Web server logs
  - [ ] Streaming logs
  - [ ] Log Stream in portal
- [ ] Always On setting
- [ ] ARR Affinity (sticky sessions)
- [ ] Health checks
- [ ] Backup and restore

---

### ❌ Azure SQL Database
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Azure SQL Database** (PaaS)
- [ ] **Creating SQL Database**:
  - [ ] Azure Portal creation
  - [ ] Server creation
  - [ ] Database name
  - [ ] Pricing tiers (DTU vs vCore)
- [ ] **DTU model** (Database Transaction Units):
  - [ ] Basic, Standard, Premium tiers
  - [ ] Fixed compute + storage
- [ ] **vCore model**:
  - [ ] General Purpose
  - [ ] Business Critical
  - [ ] Hyperscale
  - [ ] Provisioned vs Serverless
- [ ] **Serverless tier**:
  - [ ] Auto-pause and auto-resume
  - [ ] Pay per second when active
- [ ] **Connection strings**:
  - [ ] SQL authentication
  - [ ] Azure AD authentication
  - [ ] Storing in Azure Key Vault
- [ ] **Firewall rules**:
  - [ ] Server-level rules
  - [ ] Database-level rules
  - [ ] Allow Azure Services
  - [ ] IP allowlisting
- [ ] **Security**:
  - [ ] Transparent Data Encryption (TDE)
  - [ ] Always Encrypted
  - [ ] Dynamic Data Masking
  - [ ] Advanced Threat Protection
- [ ] **Backup and restore**:
  - [ ] Automated backups (default)
  - [ ] Point-in-time restore
  - [ ] Long-term retention
  - [ ] Geo-restore
- [ ] **High availability**:
  - [ ] Built-in HA
  - [ ] Active geo-replication
  - [ ] Auto-failover groups
  - [ ] Read replicas
- [ ] **Monitoring**:
  - [ ] Query Performance Insight
  - [ ] Intelligent Insights
  - [ ] Automatic tuning
  - [ ] Index recommendations
- [ ] Running EF Core migrations on Azure SQL
- [ ] Connection pooling
- [ ] Elastic pools (multiple databases)
- [ ] SQL Database vs SQL Managed Instance

---

### ❌ Azure Storage (Blob, Queue)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Azure Storage Account**
- [ ] Storage account types (General-purpose v2, Blob)
- [ ] Replication options (LRS, GRS, RA-GRS, ZRS)
- [ ] **Blob Storage**:
  - [ ] Block blobs (files, images, videos)
  - [ ] Append blobs (logs)
  - [ ] Page blobs (VHD disks)
- [ ] **Containers** (similar to folders)
- [ ] **Access tiers**:
  - [ ] Hot tier (frequent access)
  - [ ] Cool tier (infrequent access)
  - [ ] Archive tier (rare access)
- [ ] **Azure.Storage.Blobs SDK**:
  - [ ] BlobServiceClient
  - [ ] BlobContainerClient
  - [ ] BlobClient
- [ ] **Blob operations**:
  - [ ] UploadAsync
  - [ ] DownloadAsync
  - [ ] DeleteAsync
  - [ ] ListBlobsAsync
  - [ ] GetBlobClient
- [ ] **SAS tokens** (Shared Access Signatures):
  - [ ] Limited time access
  - [ ] Read, Write, Delete permissions
  - [ ] Generating SAS URLs
- [ ] **Access policies**:
  - [ ] Public access (anonymous)
  - [ ] Private access (authentication required)
- [ ] **Queue Storage**:
  - [ ] Message queuing service
  - [ ] QueueClient
  - [ ] SendMessageAsync
  - [ ] ReceiveMessagesAsync
  - [ ] DeleteMessageAsync
- [ ] **Visibility timeout** (message lock)
- [ ] **DequeueCount** (retry tracking)
- [ ] Poison messages (dead-letter handling)
- [ ] **Use cases**:
  - [ ] File uploads (Blob)
  - [ ] Background job queuing (Queue)
  - [ ] Decoupling components
- [ ] CDN integration with Blob storage
- [ ] Blob versioning and soft delete
- [ ] Storage Explorer tool
- [ ] Connection strings and keys

---

### ❌ CI/CD Basics (GitHub Actions)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **CI/CD** (Continuous Integration / Continuous Deployment)
- [ ] **GitHub Actions** platform
- [ ] **Workflow** YAML files (.github/workflows/)
- [ ] **Workflow components**:
  - [ ] name - workflow name
  - [ ] on - triggers (push, pull_request, schedule)
  - [ ] jobs - collection of jobs
  - [ ] runs-on - runner OS (ubuntu-latest, windows-latest)
  - [ ] steps - individual tasks
- [ ] **Triggers**:
  - [ ] on: push (branches, tags)
  - [ ] on: pull_request
  - [ ] on: schedule (cron)
  - [ ] on: workflow_dispatch (manual)
- [ ] **Actions**:
  - [ ] uses - use existing action
  - [ ] actions/checkout@v3 - checkout code
  - [ ] actions/setup-dotnet@v3 - setup .NET SDK
  - [ ] run - execute shell commands
- [ ] **Building .NET app**:
  - [ ] dotnet restore
  - [ ] dotnet build
  - [ ] dotnet test
  - [ ] dotnet publish
- [ ] **Secrets**:
  - [ ] Repository secrets
  - [ ] ${{ secrets.SECRET_NAME }}
  - [ ] Storing API keys, connection strings
- [ ] **Artifacts**:
  - [ ] actions/upload-artifact
  - [ ] actions/download-artifact
  - [ ] Sharing build output between jobs
- [ ] **Environments**:
  - [ ] Development, Staging, Production
  - [ ] Environment-specific secrets
  - [ ] Deployment protection rules
- [ ] **Deploy to Azure**:
  - [ ] azure/webapps-deploy@v2
  - [ ] Azure credentials (service principal)
  - [ ] Publish profile
- [ ] **Job dependencies** (needs keyword)
- [ ] **Matrix builds** (multiple versions/OS)
- [ ] **Caching** (actions/cache):
  - [ ] NuGet packages
  - [ ] Build cache
- [ ] Status badges (README.md)
- [ ] Workflow logs and debugging
- [ ] Self-hosted runners
- [ ] Workflow templates

---

### ❌ Payment Integration Basics (PayPal, Stripe, Telr, Fawry)
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Payment Gateway** concept
- [ ] Payment flow (checkout → gateway → callback)
- [ ] **Stripe**:
  - [ ] Stripe.net SDK
  - [ ] API keys (publishable, secret)
  - [ ] Test mode vs Live mode
  - [ ] Payment Intents API
  - [ ] Stripe Checkout (hosted page)
  - [ ] Stripe Elements (custom UI)
  - [ ] Webhooks (payment.succeeded, payment.failed)
  - [ ] Customer objects
  - [ ] Subscription billing
- [ ] **PayPal**:
  - [ ] PayPal REST API
  - [ ] Client ID and Secret
  - [ ] Sandbox vs Production
  - [ ] Orders API (create, capture)
  - [ ] Payment approval flow
  - [ ] IPN (Instant Payment Notification)
  - [ ] Webhooks
- [ ] **Telr** (MENA region):
  - [ ] Payment page integration
  - [ ] Store ID and Auth Key
  - [ ] Create payment request
  - [ ] Redirect to Telr hosted page
  - [ ] Return URL handling
  - [ ] Payment status verification
- [ ] **Fawry** (Egypt):
  - [ ] Merchant code
  - [ ] Payment reference number
  - [ ] Charge request
  - [ ] Callback/webhook handling
  - [ ] Payment methods (card, wallet, cash)
- [ ] **Common concepts**:
  - [ ] Amount and currency
  - [ ] Order/transaction ID
  - [ ] Customer information
  - [ ] Success and failure URLs
  - [ ] Callback/webhook URLs
- [ ] **Sandbox testing**:
  - [ ] Test cards
  - [ ] Test credentials
- [ ] **Security**:
  - [ ] HTTPS required
  - [ ] Signature verification (webhooks)
  - [ ] PCI compliance awareness
- [ ] Storing payment records:
  - [ ] Transaction ID
  - [ ] Amount, currency
  - [ ] Status (pending, completed, failed)
  - [ ] Customer reference
- [ ] Handling payment failures
- [ ] Refunds and chargebacks basics
- [ ] Idempotency (preventing duplicate charges)

---

### ❌ Webhooks Handling
**المفاهيم والمصطلحات المطلوبة:**
- [ ] **Webhooks** concept (reverse API / callback)
- [ ] Event-driven notifications
- [ ] HTTP POST to your endpoint
- [ ] **Webhook endpoint**:
  - [ ] Public URL accessible
  - [ ] POST action in controller
  - [ ] [AllowAnonymous] if needed
- [ ] **Payload**:
  - [ ] JSON body with event data
  - [ ] Event type/name
  - [ ] Timestamp
  - [ ] Resource data
- [ ] **Security**:
  - [ ] **Signature verification**:
    - [ ] HMAC signatures
    - [ ] Shared secret
    - [ ] Header-based signatures (X-Signature)
  - [ ] Validating webhook authenticity
  - [ ] Rejecting invalid signatures
- [ ] **Idempotency**:
  - [ ] Event ID tracking
  - [ ] Preventing duplicate processing
  - [ ] Database check before processing
- [ ] **Retry mechanisms**:
  - [ ] Webhook providers retry on failure
  - [ ] Return 2xx for successful processing
  - [ ] Return 5xx for retryable errors
- [ ] **Async processing**:
  - [ ] Acknowledge quickly (return 200)
  - [ ] Process in background job
  - [ ] Queue message for processing
- [ ] **Logging webhook payloads**:
  - [ ] Store raw payload
  - [ ] Event type and timestamp
  - [ ] Processing status
- [ ] **Testing webhooks locally**:
  - [ ] ngrok for tunneling
  - [ ] Exposing local endpoint
  - [ ] Webhook testing tools
- [ ] **Use cases**:
  - [ ] Payment confirmations
  - [ ] Order status updates
  - [ ] Third-party events
  - [ ] Subscription changes
- [ ] Webhook versioning
- [ ] Handling webhook failures gracefully
- [ ] Dead letter queue for failed webhooks

---

