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

    public DbSet<AccountEntity> Account { get; set; }
    public DbSet<AccountTypeEntity> AccountType { get; set; }
    public DbSet<LogsEntity> Logs { get; set; }
    public DbSet<ProxyEntity> Proxy { get; set; }
    public DbSet<BrowserEntity> Browser { get; set; }
    public DbSet<AccountsInBrowserEntity> AccountsInBrowser { get; set; }
    public DbSet<ProjectEntity> Project { get; set; }
    public DbSet<AccountsInProjectEntity> AccountsInProject { get; set; }
    public DbSet<ScriptsInProjectEntity> ScriptsInProject { get; set; }
    public DbSet<PlanEntity> Plan { get; set; }
    public DbSet<ScriptEntity> Script { get; set; }
    public DbSet<ScriptsInPlanEntity> ScriptsInPlan { get; set; }
    public DbSet<DevicesEntity> Devices { get; set; }
    public DbSet<ScheduleEntity> Schedule { get; set; }
    public DbSet<PlansInScheduleEntity> PlansInSchedule { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Account Configuration
        modelBuilder.Entity<AccountEntity>()
            .HasKey(ap => new { ap.Id });

        // AccountType Configuration
        modelBuilder.Entity<AccountTypeEntity>()
            .HasKey(ap => new { ap.Id });

        // Relationship between Account and AccountType
        modelBuilder.Entity<AccountEntity>()
            .HasOne(a => a.AccountType)
            .WithMany(at => at.AccountType_Accounts)
            .HasForeignKey(a => a.UserType);

        // Logs Configuration
        modelBuilder.Entity<LogsEntity>()
            .HasKey(ap => new { ap.Id });

        // Relationship between Account and Logs
        modelBuilder.Entity<LogsEntity>()
            .HasOne(a => a.Logs_Account)
            .WithMany(at => at.Logs)
            .HasForeignKey(a => a.User);

        // Proxy Configuration
        modelBuilder.Entity<ProxyEntity>()
            .HasKey(ap => new { ap.Id });

        // Relationship between Account and Logs

        modelBuilder.Entity<AccountEntity>()
            .HasOne(a => a.Account_Proxy)
            .WithMany(at => at.Logs_Account)
            .HasForeignKey(a => a.Proxy);

        // Browser Configuration
        modelBuilder.Entity<BrowserEntity>()
            .HasKey(ap => new { ap.Id });

        // Browser Configuration
        modelBuilder.Entity<AccountsInBrowserEntity>()
            .HasKey(ab => new { ab.AccountId, ab.BrowserId });

        // Relationship between AccountsInBrowser and Browser
        modelBuilder.Entity<AccountsInBrowserEntity>()
            .HasOne(a => a.AccountsInBrowser_Browser)
            .WithMany(at => at.Browser_AccountsInBrowser)
            .HasForeignKey(a => a.BrowserId);

        // Relationship between AccountsInBrowser and Account
        modelBuilder.Entity<AccountsInBrowserEntity>()
            .HasOne(a => a.AccountsInBrowser_Account)
            .WithMany(at => at.Account_AccountsInBrowser)
            .HasForeignKey(a => a.AccountId);

        // Project Configuration
        modelBuilder.Entity<ProjectEntity>()
            .HasKey(ap => new { ap.Id });

        // AccountsInProject Configuration
        modelBuilder.Entity<AccountsInProjectEntity>()
            .HasKey(ap => new { ap.AccountId, ap.ProjectId });

        // Relationship between AccountsInProject and Account
        modelBuilder.Entity<AccountsInProjectEntity>()
            .HasOne(a => a.AccountsInProject_Account)
            .WithMany(at => at.Account_AccountsInProject)
            .HasForeignKey(a => a.AccountId);

        // Relationship between AccountsInProject and Project
        modelBuilder.Entity<AccountsInProjectEntity>()
            .HasOne(a => a.AccountsInProject_Project)
            .WithMany(at => at.AccountsInProject)
            .HasForeignKey(a => a.ProjectId);

        // ScriptsInProject Configuration
        modelBuilder.Entity<ScriptsInProjectEntity>()
            .HasKey(spp => new { spp.ProjectId, spp.ScriptId });

        // Script Configuration
        modelBuilder.Entity<ScriptEntity>()
            .HasKey(ap => new { ap.Id });

        // Relationship between ScriptsInProject and Project
        modelBuilder.Entity<ScriptsInProjectEntity>()
            .HasOne(a => a.ScriptsInProject_Project)
            .WithMany(at => at.ScriptsInProjects)
            .HasForeignKey(a => a.ProjectId);

        // Relationship between ScriptsInProject and Script
        modelBuilder.Entity<ScriptsInProjectEntity>()
            .HasOne(a => a.ScriptsInProject_Script)
            .WithMany(at => at.ScriptsInProjects)
            .HasForeignKey(a => a.ScriptId);

        // Plan Configuration
        modelBuilder.Entity<PlanEntity>()
            .HasKey(ap => new { ap.Id });

        // ScriptsInPlan Configuration
        modelBuilder.Entity<ScriptsInPlanEntity>()
            .HasKey(sp => new { sp.PlanId, sp.ScriptId });

        // Schedule Configuration
        modelBuilder.Entity<ScheduleEntity>()
            .HasKey(ap => new { ap.Id });

        // Devices Configuration
        modelBuilder.Entity<DevicesEntity>()
            .HasKey(ap => new { ap.Id });

        // PlansInSchedule Configuration
        modelBuilder.Entity<PlansInScheduleEntity>()
            .HasKey(ps => new { ps.ScheduleId, ps.DeviceId, ps.PlanId });

        // Relationship between PlansInSchedules and Schedules
        modelBuilder.Entity<PlansInScheduleEntity>()
            .HasOne(a => a.PlansInSchedule_Schedule)
            .WithMany(at => at.PlansInSchedules)
            .HasForeignKey(a => a.ScheduleId);

        // Relationship between PlansInSchedules and Devices
        modelBuilder.Entity<PlansInScheduleEntity>()
            .HasOne(a => a.PlansInSchedule_Device)
            .WithMany(at => at.PlansInSchedules)
            .HasForeignKey(a => a.DeviceId);

        // Relationship between PlansInSchedules and Plan
        modelBuilder.Entity<PlansInScheduleEntity>()
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
        Guid proxyId3 = Guid.NewGuid();

        ProxyEntity proxyDb1 = new ProxyEntity { Id = proxyId1, Ip = "192.168.1.6", Port = 8080, User = "proxyUser1", Password = "proxyPass1", IsDelete = false };
        ProxyEntity proxyDb2 = new ProxyEntity { Id = proxyId2, Ip = "192.168.1.7", Port = 8080, User = "proxyUser2", Password = "proxyPass2", IsDelete = false };
        ProxyEntity proxyDb3 = new ProxyEntity { Id = proxyId3, Ip = "192.168.1.8", Port = 8080, User = "proxyUser2", Password = "proxyPass2", IsDelete = false };

        modelBuilder.Entity<ProxyEntity>().HasData(
            proxyDb1,
            proxyDb2,
            proxyDb3
        );
        #endregion

        //// Seeding AccountType
        //#region AccountTypeTable
        //Guid accountTypeId1 = Guid.NewGuid();
        //Guid accountTypeId2 = Guid.NewGuid();

        //AccountTypeEntity accountTypeDb1 = new AccountTypeEntity { Id = accountTypeId1, TypeName = AccountTypeEnum.GameFi, IsDelete = false };
        //AccountTypeEntity accountTypeDb2 = new AccountTypeEntity { Id = accountTypeId2, TypeName = AccountTypeEnum.Depin, IsDelete = false };

        //modelBuilder.Entity<AccountTypeEntity>().HasData(
        //    accountTypeDb1,
        //    accountTypeDb2
        //);
        //#endregion

        //// Seeding Account
        //#region AccountTable
        //Guid accountId1 = Guid.NewGuid();
        //Guid accountId2 = Guid.NewGuid();
        //Guid accountId3 = Guid.NewGuid();

        //AccountEntity accountDb1 = new AccountEntity { Id = accountId1, UserName = "User1", Password = "UserPass", Email = "User@example.com", IsDelete = false, IsStatus = true, CreateDate = DateTime.Now, UserType = accountTypeId1, Proxy = proxyId1 };
        //AccountEntity accountDb2 = new AccountEntity { Id = accountId2, UserName = "User2", Password = "UserPass", Email = "User@example.com", IsDelete = false, IsStatus = true, CreateDate = DateTime.Now, UserType = accountTypeId2, Proxy = proxyId1 };
        //AccountEntity accountDb3 = new AccountEntity { Id = accountId3, UserName = "User3", Password = "UserPass", Email = "User@example.com", IsDelete = false, IsStatus = true, CreateDate = DateTime.Now, UserType = accountTypeId2 };

        //modelBuilder.Entity<AccountEntity>().HasData(
        //    accountDb1,
        //    accountDb2,
        //    accountDb3
        //);
        //#endregion

        //// Seeding Log
        //#region LogTable
        //Guid logId1 = Guid.NewGuid();
        //Guid logId2 = Guid.NewGuid();

        //LogsEntity logDb1 = new LogsEntity
        //{
        //    Id = logId1,
        //    IsDelete = false,
        //    Code = 200,
        //    Message = "Message",
        //    CreateDate = DateTime.Now,
        //    User = accountId1
        //};

        //LogsEntity logDb2 = new LogsEntity
        //{
        //    Id = logId2,
        //    IsDelete = false,
        //    Code = 200,
        //    Message = "Message",
        //    CreateDate = DateTime.Now,
        //    User = accountId2
        //};
        //modelBuilder.Entity<LogsEntity>().HasData(
        //    logDb1,
        //    logDb2
        //);
        //#endregion

        //// Seeding Browser
        //#region BrowserTable
        //Guid browserId1 = Guid.NewGuid();
        //Guid browserId2 = Guid.NewGuid();

        //BrowserEntity browserDb1 = new BrowserEntity { Id = browserId1, IsDelete = false, Name = "Name1", Path = "Path", CreateDate = DateTime.Now };
        //BrowserEntity browserDb2 = new BrowserEntity { Id = browserId2, IsDelete = false, Name = "Name2", Path = "Path", CreateDate = DateTime.Now };

        //modelBuilder.Entity<BrowserEntity>().HasData(
        //    browserDb1,
        //    browserDb2
        //);
        //#endregion

        //// Seeding AccountsInBrowser
        //#region AccountsInBrowserTable
        //Guid accountsInBrowserId1 = Guid.NewGuid();
        //Guid accountsInBrowserId2 = Guid.NewGuid();

        //AccountsInBrowserEntity accountsInBrowserDb1 = new AccountsInBrowserEntity
        //{
        //    AccountId = accountId1,
        //    BrowserId = browserId1,
        //    IsDelete = false
        //};

        //AccountsInBrowserEntity accountsInBrowserDb2 = new AccountsInBrowserEntity
        //{
        //    AccountId = accountId2,
        //    BrowserId = browserId2,
        //    IsDelete = false
        //};

        //modelBuilder.Entity<AccountsInBrowserEntity>().HasData(
        //    accountsInBrowserDb1,
        //    accountsInBrowserDb2
        //);
        //#endregion

        //// Seeding Project
        //#region ProjectTable
        //Guid projectId1 = Guid.NewGuid();
        //Guid projectId2 = Guid.NewGuid();

        //ProjectEntity projectDb1 = new ProjectEntity
        //{
        //    Id = projectId1,
        //    Name = "Project1",
        //    StartDate = DateTime.Now,
        //    EndDate = DateTime.Now.AddDays(5),
        //    CreateDate = DateTime.Now,
        //    IsDelete = false
        //};

        //ProjectEntity projectDb2 = new ProjectEntity
        //{
        //    Id = projectId2,
        //    Name = "Project2",
        //    StartDate = DateTime.Now,
        //    EndDate = DateTime.Now.AddDays(5),
        //    CreateDate = DateTime.Now,
        //    IsDelete = false
        //};

        //modelBuilder.Entity<ProjectEntity>().HasData(
        //    projectDb1,
        //    projectDb2
        //);
        //#endregion

        //// Seeding AccountsInProject
        //#region AccountsInProjectTable
        //Guid accountsInProjectId1 = Guid.NewGuid();
        //Guid accountsInProjectId2 = Guid.NewGuid();

        //AccountsInProjectEntity accountsInProjectDb1 = new AccountsInProjectEntity
        //{
        //    AccountId = accountId1,
        //    ProjectId = projectId1,
        //    IsDelete = false
        //};

        //AccountsInProjectEntity accountsInProjectDb2 = new AccountsInProjectEntity
        //{
        //    AccountId = accountId2,
        //    ProjectId = projectId2,
        //    IsDelete = false
        //};

        //modelBuilder.Entity<AccountsInProjectEntity>().HasData(
        //    accountsInProjectDb1,
        //    accountsInProjectDb2
        //);
        //#endregion

        //// Seeding Script
        //#region ScriptTable
        //Guid scriptId1 = Guid.NewGuid();
        //Guid scriptId2 = Guid.NewGuid();

        //ScriptEntity scriptDb1 = new ScriptEntity { Id = scriptId1, Name = "Script 1", CreateDate = DateTime.Now, IsDelete = false };
        //ScriptEntity scriptDb2 = new ScriptEntity { Id = scriptId2, Name = "Script 2", CreateDate = DateTime.Now, IsDelete = false };

        //modelBuilder.Entity<ScriptEntity>().HasData(
        //    scriptDb1,
        //    scriptDb2
        //);
        //#endregion

        //// Seeding ScriptsInProject
        //#region ScriptsInProjectTable
        //ScriptsInProjectEntity scriptsInProjectDb1 = new ScriptsInProjectEntity
        //{
        //    ProjectId = projectId1,
        //    ScriptId = scriptId1,
        //    IsDelete = false
        //};

        //ScriptsInProjectEntity scriptsInProjectDb2 = new ScriptsInProjectEntity
        //{
        //    ProjectId = projectId2,
        //    ScriptId = scriptId2,
        //    IsDelete = false
        //};

        //modelBuilder.Entity<ScriptsInProjectEntity>().HasData(
        //    scriptsInProjectDb1,
        //    scriptsInProjectDb2
        //);
        //#endregion

        //// Seeding Plan
        //#region PlanTable
        //Guid planId1 = Guid.NewGuid();
        //Guid planId2 = Guid.NewGuid();

        //PlanEntity planDb1 = new PlanEntity { Id = planId1, Name = "Plan 1", CreateDate = DateTime.Now, IsDelete = false };
        //PlanEntity planDb2 = new PlanEntity { Id = planId2, Name = "Plan 2", CreateDate = DateTime.Now, IsDelete = false };
        //modelBuilder.Entity<PlanEntity>().HasData(
        //    planDb1,
        //    planDb2
        //);
        //#endregion

        //// Seeding ScriptsInPlan
        //#region ScriptsInPlanTable
        //ScriptsInPlanEntity scriptsInPlanDb1 = new ScriptsInPlanEntity
        //{
        //    PlanId = planId1,
        //    ScriptId = scriptId1,
        //    IsDelete = false
        //};

        //ScriptsInPlanEntity scriptsInPlanDb2 = new ScriptsInPlanEntity
        //{
        //    PlanId = planId2,
        //    ScriptId = scriptId2,
        //    IsDelete = false
        //};

        //modelBuilder.Entity<ScriptsInPlanEntity>().HasData(
        //    scriptsInPlanDb1,
        //    scriptsInPlanDb2
        //);
        //#endregion

        //// Seeding Schedule
        //#region ScheduleTable
        //Guid scheduleId1 = Guid.NewGuid();
        //Guid scheduleId2 = Guid.NewGuid();

        //ScheduleEntity scheduleDb1 = new ScheduleEntity
        //{
        //    Id = scheduleId1,
        //    Name = "Name1",
        //    DateTimeStart = DateTime.Now,
        //    CreateDate = DateTime.Now,
        //    IsDelete = false,
        //    IsRun = StatusRunEnum.NotRun,
        //    IsStatus = StatusEnum.Waitting
        //};

        //ScheduleEntity scheduleDb2 = new ScheduleEntity
        //{
        //    Id = scheduleId2,
        //    Name = "Name1",
        //    DateTimeStart = DateTime.Now,
        //    CreateDate = DateTime.Now,
        //    IsDelete = false,
        //    IsRun = StatusRunEnum.NotRun,
        //    IsStatus = StatusEnum.Waitting
        //};

        //modelBuilder.Entity<ScheduleEntity>().HasData(
        //    scheduleDb1,
        //    scheduleDb2
        //);
        //#endregion

        //// Seeding Device
        //#region DeviceTable
        //Guid deviceId1 = Guid.NewGuid();
        //Guid deviceId2 = Guid.NewGuid();

        //DevicesEntity devicesDb1 = new DevicesEntity
        //{
        //    Id = deviceId1,
        //    Name = "Name1",
        //    IsStatus = StatusEnum.Waitting,
        //    IsDelete = false,
        //    CreateDate = DateTime.Now
        //};

        //DevicesEntity devicesDb2 = new DevicesEntity
        //{
        //    Id = deviceId2,
        //    Name = "Name1",
        //    IsStatus = StatusEnum.Waitting,
        //    IsDelete = false,
        //    CreateDate = DateTime.Now
        //};

        //modelBuilder.Entity<DevicesEntity>().HasData(
        //    devicesDb1,
        //    devicesDb2
        //);
        //#endregion

        //// Seeding PlansInSchedule
        //#region PlansInScheduleTable
        //Guid plansInScheduleId1 = Guid.NewGuid();
        //Guid plansInScheduleId2 = Guid.NewGuid();

        //PlansInScheduleEntity plansInScheduleDb1 = new PlansInScheduleEntity
        //{
        //    ScheduleId = scheduleId1,
        //    DeviceId = deviceId1,
        //    PlanId = planId1,
        //    IsDelete = false
        //};

        //PlansInScheduleEntity plansInScheduleDb2 = new PlansInScheduleEntity
        //{
        //    ScheduleId = scheduleId2,
        //    DeviceId = deviceId2,
        //    PlanId = planId2,
        //    IsDelete = false
        //};

        //modelBuilder.Entity<PlansInScheduleEntity>().HasData(
        //    plansInScheduleDb1,
        //    plansInScheduleDb2
        //);
        //#endregion
        return modelBuilder;
    }
}
