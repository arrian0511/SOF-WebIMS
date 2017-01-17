using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Sof.IMS.Dal.Context;

namespace Sof.IMS.Dal.Context.Migrations
{
    [DbContext(typeof(IMSContext))]
    partial class IMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sof.IMS.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Sof.IMS.Models.DailyTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActualMH");

                    b.Property<int>("PlanMH");

                    b.Property<int?>("ProcessId");

                    b.Property<int?>("ProjectId");

                    b.Property<string>("Remarks");

                    b.Property<int?>("StatusId");

                    b.Property<int?>("TimesheetId");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TimesheetId");

                    b.ToTable("DailyTask");
                });

            modelBuilder.Entity("Sof.IMS.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlbumId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Sof.IMS.Models.Phase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProjectId");

                    b.Property<string>("Remarks");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Phase");
                });

            modelBuilder.Entity("Sof.IMS.Models.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PhaseId");

                    b.Property<string>("Remarks");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PhaseId");

                    b.ToTable("Process");
                });

            modelBuilder.Entity("Sof.IMS.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActMH");

                    b.Property<string>("Code");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("DisplayFlag");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("EstMH");

                    b.Property<string>("Remarks");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.Property<int?>("TypeId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Sof.IMS.Models.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Remarks");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("ProjectType");
                });

            modelBuilder.Entity("Sof.IMS.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Remarks");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("Sof.IMS.Models.Timesheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Break");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("HasValue");

                    b.Property<int>("OvertimeMH");

                    b.Property<int?>("ShiftId");

                    b.Property<int?>("StatusId");

                    b.Property<TimeSpan>("TimeIn");

                    b.Property<TimeSpan>("TimeOut");

                    b.Property<int>("TotalMH");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ShiftId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Timesheet");
                });

            modelBuilder.Entity("Sof.IMS.Models.TimesheetStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Remarks");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("TimesheetStatus");
                });

            modelBuilder.Entity("Sof.IMS.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Position");

                    b.Property<int?>("ProjectId");

                    b.Property<int?>("StatusId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StatusId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Sof.IMS.Models.UserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Remarks");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("UserStatus");
                });

            modelBuilder.Entity("Sof.IMS.Models.WorkStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Remarks");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("WorkStatus");
                });

            modelBuilder.Entity("Sof.IMS.Models.DailyTask", b =>
                {
                    b.HasOne("Sof.IMS.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessId");

                    b.HasOne("Sof.IMS.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("Sof.IMS.Models.WorkStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Sof.IMS.Models.Timesheet")
                        .WithMany("DailyTasks")
                        .HasForeignKey("TimesheetId");
                });

            modelBuilder.Entity("Sof.IMS.Models.Image", b =>
                {
                    b.HasOne("Sof.IMS.Models.Album")
                        .WithMany("Images")
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("Sof.IMS.Models.Phase", b =>
                {
                    b.HasOne("Sof.IMS.Models.Project")
                        .WithMany("Phases")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("Sof.IMS.Models.Process", b =>
                {
                    b.HasOne("Sof.IMS.Models.Phase")
                        .WithMany("Process")
                        .HasForeignKey("PhaseId");
                });

            modelBuilder.Entity("Sof.IMS.Models.Project", b =>
                {
                    b.HasOne("Sof.IMS.Models.ProjectType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.HasOne("Sof.IMS.Models.User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Sof.IMS.Models.Timesheet", b =>
                {
                    b.HasOne("Sof.IMS.Models.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId");

                    b.HasOne("Sof.IMS.Models.TimesheetStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Sof.IMS.Models.User")
                        .WithMany("Timesheets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Sof.IMS.Models.User", b =>
                {
                    b.HasOne("Sof.IMS.Models.Project")
                        .WithMany("Users")
                        .HasForeignKey("ProjectId");

                    b.HasOne("Sof.IMS.Models.UserStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });
        }
    }
}
