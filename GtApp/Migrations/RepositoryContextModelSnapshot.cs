﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace GtApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entitites.Models.Author", b =>
                {
                    b.Property<int>("AUTHOR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AUTHOR_ID"), 1L, 1);

                    b.Property<string>("AUTHOR_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AUTHOR_ID");

                    b.ToTable("AUTHORS", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.Institute", b =>
                {
                    b.Property<int>("INSTITUTE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("INSTITUTE_ID"), 1L, 1);

                    b.Property<string>("INSTITUTE_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UNIVERSITY_ID")
                        .HasColumnType("int");

                    b.HasKey("INSTITUTE_ID");

                    b.ToTable("INSTITUTES", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.Keyword", b =>
                {
                    b.Property<decimal>("THESIS_NO")
                        .HasColumnType("numeric(7,0)");

                    b.Property<string>("KEYWORD")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("THESIS_NO", "KEYWORD");

                    b.ToTable("KEYWORDS", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.SubjectTopic", b =>
                {
                    b.Property<int>("SUBJECT_TOPIC_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SUBJECT_TOPIC_ID"), 1L, 1);

                    b.Property<string>("SUBJECT_TOPIC_CONTENT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SUBJECT_TOPIC_ID");

                    b.ToTable("SubjectTopics");
                });

            modelBuilder.Entity("Entitites.Models.Supervisor", b =>
                {
                    b.Property<int>("SUPERVISOR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SUPERVISOR_ID"), 1L, 1);

                    b.Property<string>("SUPERVISOR_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SUPERVISOR_ID");

                    b.ToTable("SUPERVISORS", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.Thesis", b =>
                {
                    b.Property<decimal>("THESIS_NO")
                        .HasColumnType("numeric(7,0)");

                    b.Property<string>("ABSTRACT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AUTHOR_ID")
                        .HasColumnType("int");

                    b.Property<int>("INSTITUTE_ID")
                        .HasColumnType("int");

                    b.Property<string>("LANGUAGE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NUM_PAGES")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SUBMISSION_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TYPE_ID")
                        .HasColumnType("int");

                    b.Property<int>("UNIVERSITY_ID")
                        .HasColumnType("int");

                    b.Property<short?>("YEAR")
                        .HasColumnType("smallint");

                    b.HasKey("THESIS_NO");

                    b.ToTable("THESES", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.ThesisAuthorship", b =>
                {
                    b.Property<decimal>("THESIS_NO")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AUTHOR_ID")
                        .HasColumnType("int");

                    b.HasKey("THESIS_NO", "AUTHOR_ID");

                    b.ToTable("THESIS_AUTHORSHIP", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.ThesisSubjectTopic", b =>
                {
                    b.Property<decimal>("THESIS_NO")
                        .HasColumnType("numeric(7,0)");

                    b.Property<int>("SUBJECT_TOPIC_ID")
                        .HasColumnType("int");

                    b.HasKey("THESIS_NO", "SUBJECT_TOPIC_ID");

                    b.ToTable("THESIS_SUBJECT_TOPICS", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.ThesisSupervision", b =>
                {
                    b.Property<decimal>("THESIS_NO")
                        .HasColumnType("numeric(7,0)");

                    b.Property<int>("SUPERVISOR_ID")
                        .HasColumnType("int");

                    b.Property<int?>("CO_SUPERVISOR_ID")
                        .HasColumnType("int");

                    b.HasKey("THESIS_NO", "SUPERVISOR_ID");

                    b.ToTable("THESIS_SUPERVISION", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.ThesisType", b =>
                {
                    b.Property<int>("TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TYPE_ID"), 1L, 1);

                    b.Property<string>("TYPE_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TYPE_ID");

                    b.ToTable("THESIS_TYPE", (string)null);
                });

            modelBuilder.Entity("Entitites.Models.University", b =>
                {
                    b.Property<int>("UNIVERSITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UNIVERSITY_ID"), 1L, 1);

                    b.Property<string>("UNIVERSITY_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UNIVERSITY_ID");

                    b.ToTable("UNIVERSITIES", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0211581f-b23f-44e2-b175-8ceef7e60893",
                            ConcurrencyStamp = "3822655d-63a3-4094-a7ff-3ce4afa0f913",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "b34e6f58-53a8-4d41-a8d6-cb89977c3225",
                            ConcurrencyStamp = "4b1d9d3e-b7be-4220-8dd0-1c75c1b950f5",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "42c1d73e-efbe-43e9-9e2b-a4cbca203512",
                            ConcurrencyStamp = "572d6422-3ba5-444b-b404-83544d867864",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
