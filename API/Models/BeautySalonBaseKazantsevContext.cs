using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public partial class BeautySalonBaseKazantsevContext : DbContext
{
    public BeautySalonBaseKazantsevContext()
    {
    }

    public BeautySalonBaseKazantsevContext(DbContextOptions<BeautySalonBaseKazantsevContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthHistory> AuthHistory { get; set; }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<Client> Client { get; set; }

    public virtual DbSet<ClientService> ClientService { get; set; }

    public virtual DbSet<ClientServiceView> ClientServiceViews { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<Gender> Gender { get; set; }

    public virtual DbSet<Role> Role { get; set; }

    public virtual DbSet<Service> Service { get; set; }

    public virtual DbSet<ServiceCategory> ServiceCategory { get; set; }

    public virtual DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=192.168.147.69\\MSSQL2;database=BeautySalonBaseKazantsev;user=pk;password=1;TrustServerCertificate=true;");
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS1;database=BeautySalonBase;Trusted_Connection=true;TrustServerCertificate=True");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthHistory>(entity =>
        {
            entity.ToTable("AuthHistory");

            entity.Property(e => e.DateTime).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.AuthHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AuthHistory_User");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhotoPath).HasMaxLength(1000);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.Birthday).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.RegistrationDate).HasColumnType("date");

            entity.HasOne(d => d.Gender).WithMany(p => p.Clients)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK_Client_Gender");
        });

        modelBuilder.Entity<ClientService>(entity =>
        {
            entity.ToTable("ClientService");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.ClientServices)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_ClientService_Employee");

            entity.HasOne(d => d.Service).WithMany(p => p.ClientServices)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK_ClientService_Service");
        });

        modelBuilder.Entity<ClientServiceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ClientServiceView");

            entity.Property(e => e.ClientInfo).HasMaxLength(56);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EmployeeInfo).HasMaxLength(56);
            entity.Property(e => e.Service).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Post).HasMaxLength(50);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("Gender");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.ToTable("Service");

            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ServiceCategory>(entity =>
        {
            entity.ToTable("ServiceCategory");

            entity.HasOne(d => d.Category).WithMany(p => p.ServiceCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_ServiceCategory_Category");

            entity.HasOne(d => d.Service).WithMany(p => p.ServiceCategories)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK_ServiceCategory_Service");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Lastenter).HasColumnType("date");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
