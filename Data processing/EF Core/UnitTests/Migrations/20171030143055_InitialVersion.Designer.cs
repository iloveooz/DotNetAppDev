﻿// <auto-generated />
using DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace UnitTests.Migrations
{
    [DbContext(typeof(ProjectsContext))]
    [Migration("20171030143055_InitialVersion")]
    partial class InitialVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainModel.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DomainModel.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("End");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("Start");

                    b.HasKey("ProjectId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DomainModel.ProjectDetail", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<decimal>("Budget");

                    b.Property<bool>("Critical");

                    b.HasKey("ProjectId");

                    b.ToTable("ProjectDetail");
                });

            modelBuilder.Entity("DomainModel.ProjectResource", b =>
                {
                    b.Property<int>("ProjectResourceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProjectId")
                        .IsRequired();

                    b.Property<int?>("ResourceId");

                    b.Property<int>("Role");

                    b.HasKey("ProjectResourceId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ResourceId");

                    b.ToTable("ProjectResource");
                });

            modelBuilder.Entity("DomainModel.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("TechnologyId");

                    b.HasKey("ResourceId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("DomainModel.Technology", b =>
                {
                    b.Property<int>("TechnologyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("ResourceId");

                    b.HasKey("TechnologyId");

                    b.HasIndex("ResourceId");

                    b.ToTable("Technologies");
                });

            modelBuilder.Entity("DomainModel.Customer", b =>
                {
                    b.OwnsOne("DomainModel.ContactInformation", "Contact", b1 =>
                        {
                            b1.Property<int?>("CustomerId");

                            b1.Property<string>("Email");

                            b1.Property<string>("Phone");

                            b1.ToTable("Customers");

                            b1.HasOne("DomainModel.Customer")
                                .WithOne("Contact")
                                .HasForeignKey("DomainModel.ContactInformation", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("DomainModel.Project", b =>
                {
                    b.HasOne("DomainModel.Customer", "Customer")
                        .WithMany("Projects")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModel.ProjectDetail", b =>
                {
                    b.HasOne("DomainModel.Project", "Project")
                        .WithOne("Detail")
                        .HasForeignKey("DomainModel.ProjectDetail", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModel.ProjectResource", b =>
                {
                    b.HasOne("DomainModel.Project", "Project")
                        .WithMany("ProjectResources")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomainModel.Resource", "Resource")
                        .WithMany("ProjectResources")
                        .HasForeignKey("ResourceId");
                });

            modelBuilder.Entity("DomainModel.Resource", b =>
                {
                    b.HasOne("DomainModel.Technology")
                        .WithMany("Resources")
                        .HasForeignKey("TechnologyId");

                    b.OwnsOne("DomainModel.ContactInformation", "Contact", b1 =>
                        {
                            b1.Property<int>("ResourceId");

                            b1.Property<string>("Email");

                            b1.Property<string>("Phone");

                            b1.ToTable("Resources");

                            b1.HasOne("DomainModel.Resource")
                                .WithOne("Contact")
                                .HasForeignKey("DomainModel.ContactInformation", "ResourceId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("DomainModel.Technology", b =>
                {
                    b.HasOne("DomainModel.Resource")
                        .WithMany("Technologies")
                        .HasForeignKey("ResourceId");
                });
#pragma warning restore 612, 618
        }
    }
}
