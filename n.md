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
