using CQRS.Domain.Entities;
using CQRS.Contract.Share.Enum;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<ProductEntity> Products { get; set; }

    public DbSet<Account> Account { get; set; }
    public DbSet<AccountType> AccountType { get; set; }
    public DbSet<Logs> Logs { get; set; }
    public DbSet<Proxy> Proxy { get; set; }
    public DbSet<Browser> Browser { get; set; }
    public DbSet<AccountsInBrowser> AccountsInBrowser { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<AccountsInProject> AccountsInProject { get; set; }
    public DbSet<ScriptsInProject> ScriptsInProject { get; set; }
    public DbSet<Plan> Plan { get; set; }
    public DbSet<Script> Script { get; set; }
    public DbSet<ScriptsInPlan> ScriptsInPlan { get; set; }
    public DbSet<Devices> Devices { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
    public DbSet<PlansInSchedule> PlansInSchedule { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Account Configuration
        modelBuilder.Entity<Account>()
            .HasKey(ap => new { ap.Id });

        // AccountType Configuration
        modelBuilder.Entity<AccountType>()
            .HasKey(ap => new { ap.Id });

        // Relationship between Account and AccountType
        modelBuilder.Entity<Account>()
            .HasOne(a => a.AccountType)
            .WithMany(at => at.AccountType_Accounts)
            .HasForeignKey(a => a.UserType);

        // Logs Configuration
        modelBuilder.Entity<Logs>()
            .HasKey(ap => new { ap.Id });

        // Relationship between Account and Logs
        modelBuilder.Entity<Logs>()
            .HasOne(a => a.Logs_Account)
            .WithMany(at => at.Logs)
            .HasForeignKey(a => a.User);

        // Proxy Configuration
        modelBuilder.Entity<Proxy>()
            .HasKey(ap => new { ap.Id });

        // Relationship between Account and Logs

        modelBuilder.Entity<Account>()
            .HasOne(a => a.Account_Proxy)
            .WithMany(at => at.Logs_Account)
            .HasForeignKey(a => a.Proxy);

        // Browser Configuration
        modelBuilder.Entity<Browser>()
            .HasKey(ap => new { ap.Id });

        // Browser Configuration
        modelBuilder.Entity<AccountsInBrowser>()
            .HasKey(ab => new { ab.AccountId, ab.BrowserId });

        // Relationship between AccountsInBrowser and Browser
        modelBuilder.Entity<AccountsInBrowser>()
            .HasOne(a => a.AccountsInBrowser_Browser)
            .WithMany(at => at.Browser_AccountsInBrowser)
            .HasForeignKey(a => a.BrowserId);

        // Relationship between AccountsInBrowser and Account
        modelBuilder.Entity<AccountsInBrowser>()
            .HasOne(a => a.AccountsInBrowser_Account)
            .WithMany(at => at.Account_AccountsInBrowser)
            .HasForeignKey(a => a.AccountId);

        // Project Configuration
        modelBuilder.Entity<Project>()
            .HasKey(ap => new { ap.Id });

        // AccountsInProject Configuration
        modelBuilder.Entity<AccountsInProject>()
            .HasKey(ap => new { ap.AccountId, ap.ProjectId });

        // Relationship between AccountsInProject and Account
        modelBuilder.Entity<AccountsInProject>()
            .HasOne(a => a.AccountsInProject_Account)
            .WithMany(at => at.Account_AccountsInProject)
            .HasForeignKey(a => a.AccountId);

        // Relationship between AccountsInProject and Project
        modelBuilder.Entity<AccountsInProject>()
            .HasOne(a => a.AccountsInProject_Project)
            .WithMany(at => at.AccountsInProject)
            .HasForeignKey(a => a.ProjectId);

        // ScriptsInProject Configuration
        modelBuilder.Entity<ScriptsInProject>()
            .HasKey(spp => new { spp.ProjectId, spp.ScriptId });

        // Script Configuration
        modelBuilder.Entity<Script>()
            .HasKey(ap => new { ap.Id });

        // Relationship between ScriptsInProject and Project
        modelBuilder.Entity<ScriptsInProject>()
            .HasOne(a => a.ScriptsInProject_Project)
            .WithMany(at => at.ScriptsInProjects)
            .HasForeignKey(a => a.ProjectId);

        // Relationship between ScriptsInProject and Script
        modelBuilder.Entity<ScriptsInProject>()
            .HasOne(a => a.ScriptsInProject_Script)
            .WithMany(at => at.ScriptsInProjects)
            .HasForeignKey(a => a.ScriptId);

        // Plan Configuration
        modelBuilder.Entity<Plan>()
            .HasKey(ap => new { ap.Id });

        // ScriptsInPlan Configuration
        modelBuilder.Entity<ScriptsInPlan>()
            .HasKey(sp => new { sp.PlanId, sp.ScriptId });

        // Schedule Configuration
        modelBuilder.Entity<Schedule>()
            .HasKey(ap => new { ap.Id });

        // Devices Configuration
        modelBuilder.Entity<Devices>()
            .HasKey(ap => new { ap.Id });

        // PlansInSchedule Configuration
        modelBuilder.Entity<PlansInSchedule>()
            .HasKey(ps => new { ps.ScheduleId, ps.DeviceId, ps.PlanId });

        // Relationship between PlansInSchedules and Schedules
        modelBuilder.Entity<PlansInSchedule>()
            .HasOne(a => a.PlansInSchedule_Schedule)
            .WithMany(at => at.PlansInSchedules)
            .HasForeignKey(a => a.ScheduleId);

        // Relationship between PlansInSchedules and Devices
        modelBuilder.Entity<PlansInSchedule>()
            .HasOne(a => a.PlansInSchedule_Device)
            .WithMany(at => at.PlansInSchedules)
            .HasForeignKey(a => a.DeviceId);

        // Relationship between PlansInSchedules and Plan
        modelBuilder.Entity<PlansInSchedule>()
            .HasOne(a => a.PlansInSchedule_Plan)
            .WithMany(at => at.PlansInSchedule)
            .HasForeignKey(a => a.PlanId);


        modelBuilder = SeedingData(modelBuilder);
    }

    private ModelBuilder SeedingData(ModelBuilder modelBuilder)
    {
        // Seeding Proxy
        #region ProxyTable
        Guid proxyId1 = Guid.NewGuid();
        Guid proxyId2 = Guid.NewGuid();

        Proxy proxyDb1 = new Proxy { Id = proxyId1, Ip = "192.168.1.1", Port = 8080, User = "proxyUser1", Password = "proxyPass1", IsDelete = false };
        Proxy proxyDb2 = new Proxy { Id = proxyId2, Ip = "192.168.1.2", Port = 8080, User = "proxyUser2", Password = "proxyPass2", IsDelete = false };

        modelBuilder.Entity<Proxy>().HasData(
            proxyDb1,
            proxyDb2
        );
        #endregion

        // Seeding AccountType
        #region AccountTypeTable
        Guid accountTypeId1 = Guid.NewGuid();
        Guid accountTypeId2 = Guid.NewGuid();

        AccountType accountTypeDb1 = new AccountType { Id = accountTypeId1, TypeName = AccountTypeEnum.GameFi, IsDelete = false };
        AccountType accountTypeDb2 = new AccountType { Id = accountTypeId2, TypeName = AccountTypeEnum.Depin, IsDelete = false };

        modelBuilder.Entity<AccountType>().HasData(
            accountTypeDb1,
            accountTypeDb2
        );
        #endregion

        // Seeding Account
        #region AccountTable
        Guid accountId1 = Guid.NewGuid();
        Guid accountId2 = Guid.NewGuid();
        Guid accountId3 = Guid.NewGuid();

        Account accountDb1 = new Account { Id = accountId1, UserName = "User1", Password = "UserPass", Email = "User@example.com", IsDelete = false, IsStatus = true, CreateDate = DateTime.Now, UserType = accountTypeId1, Proxy = proxyId1 };
        Account accountDb2 = new Account {Id = accountId2, UserName = "User2", Password = "UserPass", Email = "User@example.com", IsDelete = false, IsStatus = true, CreateDate = DateTime.Now, UserType = accountTypeId2, Proxy = proxyId1 };
        Account accountDb3 = new Account { Id = accountId3, UserName = "User3", Password = "UserPass", Email = "User@example.com", IsDelete = false, IsStatus = true, CreateDate = DateTime.Now, UserType = accountTypeId2 };

        modelBuilder.Entity<Account>().HasData(
            accountDb1,
            accountDb2,
            accountDb3
        );
        #endregion

        // Seeding Log
        #region LogTable
        Guid logId1 = Guid.NewGuid();
        Guid logId2 = Guid.NewGuid();

        Logs logDb1 = new Logs
        {
            Id = logId1,
            IsDelete = false,
            Code = 200,
            Message = "Message",
            CreateDate = DateTime.Now,
            User = accountId1
        };

        Logs logDb2 = new Logs
        {
            Id = logId2,
            IsDelete = false,
            Code = 200,
            Message = "Message",
            CreateDate = DateTime.Now,
            User = accountId2
        };
        modelBuilder.Entity<Logs>().HasData(
            logDb1,
            logDb2
        );
        #endregion

        // Seeding Browser
        #region BrowserTable
        Guid browserId1 = Guid.NewGuid();
        Guid browserId2 = Guid.NewGuid();

        Browser browserDb1 = new Browser { Id = browserId1, IsDelete = false, Name = "Name1", Path = "Path", CreateDate = DateTime.Now };
        Browser browserDb2 = new Browser { Id = browserId2, IsDelete = false, Name = "Name2", Path = "Path", CreateDate = DateTime.Now };

        modelBuilder.Entity<Browser>().HasData(
            browserDb1,
            browserDb2
        );
        #endregion

        // Seeding AccountsInBrowser
        #region AccountsInBrowserTable
        Guid accountsInBrowserId1 = Guid.NewGuid();
        Guid accountsInBrowserId2 = Guid.NewGuid();

        AccountsInBrowser accountsInBrowserDb1 = new AccountsInBrowser
        {
            AccountId = accountId1,
            BrowserId = browserId1,
            IsDelete = false
        };

        AccountsInBrowser accountsInBrowserDb2 = new AccountsInBrowser
        {
            AccountId = accountId2,
            BrowserId = browserId2,
            IsDelete = false
        };

        modelBuilder.Entity<AccountsInBrowser>().HasData(
            accountsInBrowserDb1,
            accountsInBrowserDb2
        );
        #endregion

        // Seeding Project
        #region ProjectTable
        Guid projectId1 = Guid.NewGuid();
        Guid projectId2 = Guid.NewGuid();

        Project projectDb1 = new Project
        {
            Id = projectId1,
            Name = "Project1",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(5),
            CreateDate = DateTime.Now,
            IsDelete = false
        };

        Project projectDb2 = new Project
        {
            Id = projectId2,
            Name = "Project2",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(5),
            CreateDate = DateTime.Now,
            IsDelete = false
        };

        modelBuilder.Entity<Project>().HasData(
            projectDb1,
            projectDb2
        );
        #endregion

        // Seeding AccountsInProject
        #region AccountsInProjectTable
        Guid accountsInProjectId1 = Guid.NewGuid();
        Guid accountsInProjectId2 = Guid.NewGuid();

        AccountsInProject accountsInProjectDb1 = new AccountsInProject
        {
            AccountId = accountId1,
            ProjectId = projectId1,
            IsDelete = false
        };

        AccountsInProject accountsInProjectDb2 = new AccountsInProject
        {
            AccountId = accountId2,
            ProjectId = projectId2,
            IsDelete = false
        };

        modelBuilder.Entity<AccountsInProject>().HasData(
            accountsInProjectDb1,
            accountsInProjectDb2
        );
        #endregion

        // Seeding Script
        #region ScriptTable
        Guid scriptId1 = Guid.NewGuid();
        Guid scriptId2 = Guid.NewGuid();

        Script scriptDb1 = new Script { Id = scriptId1, Name = "Script 1", CreateDate = DateTime.Now, IsDelete = false };
        Script scriptDb2 = new Script { Id = scriptId2, Name = "Script 2", CreateDate = DateTime.Now, IsDelete = false };

        modelBuilder.Entity<Script>().HasData(
            scriptDb1,
            scriptDb2
        );
        #endregion

        // Seeding ScriptsInProject
        #region ScriptsInProjectTable
        ScriptsInProject scriptsInProjectDb1 = new ScriptsInProject
        {
            ProjectId = projectId1,
            ScriptId = scriptId1,
            IsDelete = false
        };

        ScriptsInProject scriptsInProjectDb2 = new ScriptsInProject
        {
            ProjectId = projectId2,
            ScriptId = scriptId2,
            IsDelete = false
        };

        modelBuilder.Entity<ScriptsInProject>().HasData(
            scriptsInProjectDb1,
            scriptsInProjectDb2
        );
        #endregion

        // Seeding Plan
        #region PlanTable
        Guid planId1 = Guid.NewGuid();
        Guid planId2 = Guid.NewGuid();

        Plan planDb1 = new Plan { Id = planId1, Name = "Plan 1", CreateDate = DateTime.Now, IsDelete = false };
        Plan planDb2 = new Plan { Id = planId2, Name = "Plan 2", CreateDate = DateTime.Now, IsDelete = false };
        modelBuilder.Entity<Plan>().HasData(
            planDb1,
            planDb2
        );
        #endregion

        // Seeding ScriptsInPlan
        #region ScriptsInPlanTable
        ScriptsInPlan scriptsInPlanDb1 = new ScriptsInPlan
        {
            PlanId = planId1,
            ScriptId = scriptId1,
            IsDelete = false
        };

        ScriptsInPlan scriptsInPlanDb2 = new ScriptsInPlan
        {
            PlanId = planId2,
            ScriptId = scriptId2,
            IsDelete = false
        };

        modelBuilder.Entity<ScriptsInPlan>().HasData(
            scriptsInPlanDb1,
            scriptsInPlanDb2
        );
        #endregion

        // Seeding Schedule
        #region ScheduleTable
        Guid scheduleId1 = Guid.NewGuid();
        Guid scheduleId2 = Guid.NewGuid();

        Schedule scheduleDb1 = new Schedule
        {
            Id = scheduleId1,
            Name = "Name1",
            DateTimeStart = DateTime.Now,
            CreateDate = DateTime.Now,
            IsDelete = false,
            IsRun = StatusRunEnum.NotRun,
            IsStatus = StatusEnum.Waitting
        };

        Schedule scheduleDb2 = new Schedule
        {
            Id = scheduleId2,
            Name = "Name1",
            DateTimeStart = DateTime.Now,
            CreateDate = DateTime.Now,
            IsDelete = false,
            IsRun = StatusRunEnum.NotRun,
            IsStatus = StatusEnum.Waitting
        };

        modelBuilder.Entity<Schedule>().HasData(
            scheduleDb1,
            scheduleDb2
        );
        #endregion

        // Seeding Device
        #region DeviceTable
        Guid deviceId1 = Guid.NewGuid();
        Guid deviceId2 = Guid.NewGuid();

        Devices devicesDb1 = new Devices
        {
            Id = deviceId1,
            Name = "Name1",
            IsStatus = StatusEnum.Waitting,
            IsDelete = false,
            CreateDate = DateTime.Now
        };

        Devices devicesDb2 = new Devices
        {
            Id = deviceId2,
            Name = "Name1",
            IsStatus = StatusEnum.Waitting,
            IsDelete = false,
            CreateDate = DateTime.Now
        };

        modelBuilder.Entity<Devices>().HasData(
            devicesDb1,
            devicesDb2
        );
        #endregion

        // Seeding PlansInSchedule
        #region PlansInScheduleTable
        Guid plansInScheduleId1 = Guid.NewGuid();
        Guid plansInScheduleId2 = Guid.NewGuid();

        PlansInSchedule plansInScheduleDb1 = new PlansInSchedule
        {
            ScheduleId = scheduleId1,
            DeviceId = deviceId1,
            PlanId = planId1,
            IsDelete = false
        };

        PlansInSchedule plansInScheduleDb2 = new PlansInSchedule
        {
            ScheduleId = scheduleId2,
            DeviceId = deviceId2,
            PlanId = planId2,
            IsDelete = false
        };

        modelBuilder.Entity<PlansInSchedule>().HasData(
            plansInScheduleDb1,
            plansInScheduleDb2
        );
        #endregion
        return modelBuilder;
    }
}
