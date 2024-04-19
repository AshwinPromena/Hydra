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
                });

            modelBuilder.Entity("Hydra.Database.Entities.Badge", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BadgeDescription")
                        .HasColumnType("longtext")
                        .HasColumnName("badge_description");

                    b.Property<string>("BadgeName")
                        .HasColumnType("longtext")
                        .HasColumnName("badge_name");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint")
                        .HasColumnName("department_id");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expiration_date");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_approved");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("issue_date");

                    b.Property<bool>("RequiresApproval")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("requires_approval");

                    b.Property<long>("SequenceId")
                        .HasColumnType("bigint")
                        .HasColumnName("sequence_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("SequenceId");

                    b.HasIndex("UserId");

                    b.ToTable("badge");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeApproval", b =>
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

                    b.Property<bool>("IsApproved")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_approved");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("BadgeId");

                    b.HasIndex("UserId");

                    b.ToTable("badge_approval");
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

                    b.Property<string>("FieldContent")
                        .HasColumnType("longtext")
                        .HasColumnName("field_content");

                    b.Property<string>("FieldName")
                        .HasColumnType("longtext")
                        .HasColumnName("field_name");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<string>("TypeName")
                        .HasColumnType("longtext")
                        .HasColumnName("type_name");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("BadgeId");

                    b.HasIndex("UserId");

                    b.ToTable("badge_field");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeMedia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BadgeId")
                        .HasColumnType("bigint")
                        .HasColumnName("badge_id");

                    b.Property<string>("BadgeImageUrl")
                        .HasColumnType("longtext")
                        .HasColumnName("badge_image_url");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("BadgeId");

                    b.HasIndex("UserId");

                    b.ToTable("badge_media");
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

                    b.Property<string>("SequenceName")
                        .HasColumnType("longtext")
                        .HasColumnName("sequence_name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("badge_sequence");
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

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("department_name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

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

                    b.Property<long>("AccessLevelId")
                        .HasColumnType("bigint")
                        .HasColumnName("access_level_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("bigint")
                        .HasColumnName("department_id");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

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
                });

            modelBuilder.Entity("Hydra.Database.Entities.Badge", b =>
                {
                    b.HasOne("Hydra.Database.Entities.Department", "Department")
                        .WithMany("Badge")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.BadgeSequence", "BadgeSequence")
                        .WithMany("Badge")
                        .HasForeignKey("SequenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("Badge")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BadgeSequence");

                    b.Navigation("Department");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeApproval", b =>
                {
                    b.HasOne("Hydra.Database.Entities.Badge", "Badge")
                        .WithMany("BadgeApproval")
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("BadgeApproval")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeField", b =>
                {
                    b.HasOne("Hydra.Database.Entities.Badge", "Badge")
                        .WithMany("BadgeField")
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("BadgeField")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeMedia", b =>
                {
                    b.HasOne("Hydra.Database.Entities.Badge", "Badge")
                        .WithMany("BadgeMedia")
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("BadgeMedia")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.BadgeSequence", b =>
                {
                    b.HasOne("Hydra.Database.Entities.User", "User")
                        .WithMany("BadgeSequence")
                        .HasForeignKey("UserId")
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

            modelBuilder.Entity("Hydra.Database.Entities.User", b =>
                {
                    b.HasOne("Hydra.Database.Entities.AccessLevel", "AccessLevel")
                        .WithMany("User")
                        .HasForeignKey("AccessLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hydra.Database.Entities.Department", "Department")
                        .WithMany("User")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Hydra.Database.Entities.AccessLevel", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Hydra.Database.Entities.Badge", b =>
                {
                    b.Navigation("BadgeApproval");

                    b.Navigation("BadgeField");

                    b.Navigation("BadgeMedia");

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

                    b.Navigation("BadgeApproval");

                    b.Navigation("BadgeField");

                    b.Navigation("BadgeMedia");

                    b.Navigation("BadgeSequence");

                    b.Navigation("LearnerBadge");

                    b.Navigation("LearnerBadgeIssuedBy");

                    b.Navigation("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
