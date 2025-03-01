﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TerapicFisicHelper.Data;

namespace TerapicFisicHelper.Data.Migrations
{
    [DbContext(typeof(DbContextTerapicFisicHelperApp))]
    [Migration("20210507183357_DbContextTerapicFisicHelperMigration")]
    partial class DbContextTerapicFisicHelperMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TerapicFisicHelper.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("customers");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Equipament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("equipaments");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.EquipamentSession", b =>
                {
                    b.Property<int>("EquipamentId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("EquipamentId", "SessionId");

                    b.HasIndex("SessionId");

                    b.ToTable("equipament_sessions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.History", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Watched")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId", "SessionId");

                    b.HasIndex("SessionId");

                    b.ToTable("histories");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Review", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "SpecialistId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EndHour")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartHour")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SpecialistId");

                    b.ToTable("sessions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Specialist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("specialists");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Subscription", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionPlanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId", "SubscriptionPlanId");

                    b.HasIndex("SubscriptionPlanId");

                    b.ToTable("subscriptions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.SubscriptionPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("subscription_plans");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.TagSession", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "SessionId");

                    b.HasIndex("SessionId");

                    b.ToTable("tag_sessions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Customer", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("TerapicFisicHelper.Entities.Customer", "UserId")
                        .HasConstraintName("fk_users_customer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.EquipamentSession", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.Equipament", "Equipament")
                        .WithMany("EquipamentSessions")
                        .HasForeignKey("EquipamentId")
                        .HasConstraintName("fk_equipamentsession_equipament")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TerapicFisicHelper.Entities.Session", "Session")
                        .WithMany("EquipamentSessions")
                        .HasForeignKey("SessionId")
                        .HasConstraintName("fk_equipamentsession_session")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipament");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.History", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.Customer", "Customer")
                        .WithMany("Histories")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_history_customer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TerapicFisicHelper.Entities.Session", "Session")
                        .WithMany("Histories")
                        .HasForeignKey("SessionId")
                        .HasConstraintName("fk_history_session")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Review", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_review_customer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TerapicFisicHelper.Entities.Specialist", "Specialist")
                        .WithMany("Reviews")
                        .HasForeignKey("SpecialistId")
                        .HasConstraintName("fk_review_specialist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Session", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.Specialist", "Specialist")
                        .WithMany("Sessions")
                        .HasForeignKey("SpecialistId")
                        .HasConstraintName("fk_specialist_session")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Specialist", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.User", "User")
                        .WithOne("Specialist")
                        .HasForeignKey("TerapicFisicHelper.Entities.Specialist", "UserId")
                        .HasConstraintName("fk_users_specialist")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Subscription", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.Customer", "Customer")
                        .WithMany("Subscriptions")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_subscription_customer")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TerapicFisicHelper.Entities.SubscriptionPlan", "SubscriptionPlan")
                        .WithMany("Subscriptions")
                        .HasForeignKey("SubscriptionPlanId")
                        .HasConstraintName("fk_subscription_subscriptionplan")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("SubscriptionPlan");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.TagSession", b =>
                {
                    b.HasOne("TerapicFisicHelper.Entities.Session", "Session")
                        .WithMany("TagSessions")
                        .HasForeignKey("SessionId")
                        .HasConstraintName("fk_tagsession_session")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TerapicFisicHelper.Entities.Tag", "Tag")
                        .WithMany("TagSessions")
                        .HasForeignKey("TagId")
                        .HasConstraintName("fk_tagsession_tag")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Customer", b =>
                {
                    b.Navigation("Histories");

                    b.Navigation("Reviews");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Equipament", b =>
                {
                    b.Navigation("EquipamentSessions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Session", b =>
                {
                    b.Navigation("EquipamentSessions");

                    b.Navigation("Histories");

                    b.Navigation("TagSessions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Specialist", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.SubscriptionPlan", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.Tag", b =>
                {
                    b.Navigation("TagSessions");
                });

            modelBuilder.Entity("TerapicFisicHelper.Entities.User", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("Specialist");
                });
#pragma warning restore 612, 618
        }
    }
}
