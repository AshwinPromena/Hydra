﻿// <auto-generated />
using System;
using Hydra.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hydra.Database.Migrations
{
    [DbContext(typeof(HydraContext))]
    partial class HydraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Hydra.Database.Entities.AccessLevel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("access_level");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "View only"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "View and edit"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "View, edit and delete"
                        });
                });

            modelBuilder.Entity("Hydra.Database.Entities.Badge", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("ApprovalUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("approvalUserId");

                    b.Property<long?>("BadgeSequenceId")
                        .HasColumnType("bigint")
                        .HasColumnName("badge_sequence_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint")
                        .HasColumnName("department_id");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expiration_date");

                    b.Property<string>("Image")
                        .HasColumnType("longtext")
                        .HasColumnName("image");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_approved");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("issue_date");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<bool>("RequiresApproval")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("requires_approval");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("ApprovalUserId");

                    b.HasIndex("BadgeSequenceId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("badge");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeField", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BadgeId")
                        .HasColumnType("bigint")
                        .HasColumnName("badge_id");

                    b.Property<string>("Content")
                        .HasColumnType("longtext")
                        .HasColumnName("content");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<string>("TypeName")
                        .HasColumnType("longtext")
                        .HasColumnName("type_name");

                    b.HasKey("Id");

                    b.HasIndex("BadgeId");

                    b.ToTable("badge_field");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeSequence", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.ToTable("badge_sequence");
                });

            modelBuilder.Entity("Hydra.Database.Entities.DeletedLearner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deleted_date");

                    b.Property<long>("LearnerId")
                        .HasColumnType("bigint")
                        .HasColumnName("learner_id");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext")
                        .HasColumnName("reason");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("LearnerId");

                    b.ToTable("deleted_learner");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.ToTable("department");
                });

            modelBuilder.Entity("Hydra.Database.Entities.LearnerBadge", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BadgeId")
                        .HasColumnType("bigint")
                        .HasColumnName("badge_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_revoked");

                    b.Property<long>("IssuedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("issued_by");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("BadgeId");

                    b.HasIndex("IssuedBy");

                    b.HasIndex("UserId");

                    b.ToTable("learner_badge");
                });

            modelBuilder.Entity("Hydra.Database.Entities.PasswordResetToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsTokenActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_token_active");

                    b.Property<string>("ResetToken")
                        .HasColumnType("longtext")
                        .HasColumnName("reset_token");

                    b.Property<DateTime>("TokenExpiryDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("token_expiry_date");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("passsword_reset_token");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("role");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "UniversityAdmin"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Staff"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Learner"
                        });
                });

            modelBuilder.Entity("Hydra.Database.Entities.University", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("longtext")
                        .HasColumnName("color");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("longtext")
                        .HasColumnName("logo_url");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.ToTable("university");
                });

            modelBuilder.Entity("Hydra.Database.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("AccessLevelId")
                        .HasColumnType("bigint")
                        .HasColumnName("access_level_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<long?>("DepartmentId")
                        .HasColumnType("bigint")
                        .HasColumnName("department_id");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Email2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email_2");

                    b.Property<string>("Email3")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email_3");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_approved");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_archived");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<long>("LearnerId")
                        .HasColumnType("bigint")
                        .HasColumnName("learner_id");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mobile_number");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("longtext")
                        .HasColumnName("profile_picture");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex("AccessLevelId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("user");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessLevelId = 3L,
                            CreatedDate = new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hydra@yopmail.com",
                            FirstName = "Admin",
                            IsActive = true,
                            IsApproved = true,
                            IsArchived = false,
                            LastName = "",
                            LearnerId = 0L,
                            Password = "3AhCUZedQxVLajDQSZhRirNTvEyK/luGud/X7oAXJX0=",
                            UpdatedDate = new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Hydra.Database.Entities.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("role_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("user_role");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            RoleId = 1L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("Hydra.Database.Entities.Verification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("OTP")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("otp");

                    b.Property<DateTime>("OtpExpiryDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("otp_expiry_date");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("verification");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Badge", b =>
                {
                    b.HasOne("Hydra.Database.Entities.User", "ApprovalUser")
                        .WithMany("Badge")
                        .HasForeignKey("ApprovalUserId");

                    b.HasOne("Hydra.Database.Entities.BadgeSequence", "BadgeSequence")
                        .WithMany("Badge")
                        .HasForeignKey("BadgeSequenceId");

                    b.HasOne("Hydra.Database.Entities.Department", "Department")
                        .WithMany("Badge")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApprovalUser");

                    b.Navigation("BadgeSequence");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeField", b =>
                {
                    b.HasOne("Hydra.Database.Entities.Badge", "Badge")
                        .WithMany("BadgeField")
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Badge");
                });

            modelBuilder.Entity("Hydra.Database.Entities.DeletedLearner", b =>
                {
                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("DeletedLearner")
                        .HasForeignKey("LearnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.LearnerBadge", b =>
                {
                    b.HasOne("Hydra.Database.Entities.Badge", "Badge")
                        .WithMany("LearnerBadge")
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.User", "IssuedUser")
                        .WithMany("LearnerBadgeIssuedBy")
                        .HasForeignKey("IssuedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("LearnerBadge")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("IssuedUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.PasswordResetToken", b =>
                {
                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("PasswordResetToken")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.User", b =>
                {
                    b.HasOne("Hydra.Database.Entities.AccessLevel", "AccessLevel")
                        .WithMany("User")
                        .HasForeignKey("AccessLevelId");

                    b.HasOne("Hydra.Database.Entities.Department", "Department")
                        .WithMany("User")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("AccessLevel");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hydra.Database.Entities.UserRole", b =>
                {
                    b.HasOne("Hydra.Database.Entities.Role", "Role")
                        .WithMany("UserRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("UserRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Verification", b =>
                {
                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("Verification")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.AccessLevel", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Badge", b =>
                {
                    b.Navigation("BadgeField");

                    b.Navigation("LearnerBadge");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeSequence", b =>
                {
                    b.Navigation("Badge");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Department", b =>
                {
                    b.Navigation("Badge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Role", b =>
                {
                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Hydra.Database.Entities.User", b =>
                {
                    b.Navigation("Badge");

                    b.Navigation("DeletedLearner");

                    b.Navigation("LearnerBadge");

                    b.Navigation("LearnerBadgeIssuedBy");

                    b.Navigation("PasswordResetToken");

                    b.Navigation("UserRole");

                    b.Navigation("Verification");
                });
#pragma warning restore 612, 618
        }
    }
}
