﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamAssignment4A.Data;

#nullable disable

namespace TeamAssignment4A.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    partial class WebAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StemTopic", b =>
                {
                    b.Property<int>("StemsId")
                        .HasColumnType("int");

                    b.Property<int>("TopicsId")
                        .HasColumnType("int");

                    b.HasKey("StemsId", "TopicsId");

                    b.HasIndex("TopicsId");

                    b.ToTable("StemTopic");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Candidate", b =>
                {
                    b.Property<int>("CandidateNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateNumber"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("Date");

                    b.Property<string>("CountryOfResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandLineNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NativeLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PhotoIdDate")
                        .HasColumnType("Date");

                    b.Property<string>("PhotoIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoIdType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidateNumber");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("MaximumScore")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("PassingGrade")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("TitleOfCertificate")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("TopicId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ExamDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.CandidateExam", b =>
                {
                    b.Property<int>("CandidateExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateExamId"));

                    b.Property<string>("AssessmentResultLabel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AssessmentTestCode")
                        .HasColumnType("int");

                    b.Property<int>("CandidateScore")
                        .HasColumnType("int");

                    b.Property<int>("CandidatesCandidateNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("Date");

                    b.Property<int>("ExamsId")
                        .HasColumnType("int");

                    b.Property<string>("PercentageScore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ScoreReportDate")
                        .HasColumnType("Date");

                    b.Property<int>("ScoresId")
                        .HasColumnType("int");

                    b.HasKey("CandidateExamId");

                    b.HasIndex("CandidatesCandidateNumber");

                    b.HasIndex("ExamsId");

                    b.HasIndex("ScoresId");

                    b.ToTable("CandidateExam");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.ExamStem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExamsId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("StemsId")
                        .HasColumnType("int");

                    b.Property<string>("SubmittedAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("ExamsId");

                    b.HasIndex("StemsId");

                    b.ToTable("ExamStem");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.ExamTopic", b =>
                {
                    b.Property<int>("ExamTopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamTopicId"));

                    b.Property<int?>("CertificateId")
                        .HasColumnType("int");

                    b.Property<int>("ExamsId")
                        .HasColumnType("int");

                    b.Property<int>("TopicsId")
                        .HasColumnType("int");

                    b.HasKey("ExamTopicId");

                    b.HasIndex("CertificateId");

                    b.HasIndex("ExamsId");

                    b.HasIndex("TopicsId");

                    b.ToTable("ExamTopic");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExamStemsId")
                        .HasColumnType("int");

                    b.Property<int>("ExamTopicsExamTopicId")
                        .HasColumnType("int");

                    b.Property<int>("ScorePerTopic")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamStemsId");

                    b.HasIndex("ExamTopicsExamTopicId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Stem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("OptionA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stems");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertificateID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPossibleMarks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("StemTopic", b =>
                {
                    b.HasOne("TeamAssignment4A.Models.Stem", null)
                        .WithMany()
                        .HasForeignKey("StemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAssignment4A.Models.Topic", null)
                        .WithMany()
                        .HasForeignKey("TopicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Certificate", b =>
                {
                    b.HasOne("TeamAssignment4A.Models.Exam", "Exam")
                        .WithMany("Certificates")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAssignment4A.Models.Topic", "Topic")
                        .WithMany("Certificates")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Exam", b =>
                {
                    b.HasOne("TeamAssignment4A.Models.Topic", null)
                        .WithMany("Exams")
                        .HasForeignKey("TopicId");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.CandidateExam", b =>
                {
                    b.HasOne("TeamAssignment4A.Models.Candidate", "Candidates")
                        .WithMany("CandidateExams")
                        .HasForeignKey("CandidatesCandidateNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAssignment4A.Models.Exam", "Exams")
                        .WithMany("CandidateExams")
                        .HasForeignKey("ExamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAssignment4A.Models.JointTables.Score", "Scores")
                        .WithMany()
                        .HasForeignKey("ScoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidates");

                    b.Navigation("Exams");

                    b.Navigation("Scores");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.ExamStem", b =>
                {
                    b.HasOne("TeamAssignment4A.Models.Exam", "Exams")
                        .WithMany("ExamStems")
                        .HasForeignKey("ExamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAssignment4A.Models.Stem", "Stems")
                        .WithMany("ExamStems")
                        .HasForeignKey("StemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exams");

                    b.Navigation("Stems");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.ExamTopic", b =>
                {
                    b.HasOne("TeamAssignment4A.Models.Certificate", null)
                        .WithMany("ExamTopics")
                        .HasForeignKey("CertificateId");

                    b.HasOne("TeamAssignment4A.Models.Exam", "Exams")
                        .WithMany("ExamTopics")
                        .HasForeignKey("ExamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAssignment4A.Models.Topic", "Topics")
                        .WithMany()
                        .HasForeignKey("TopicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exams");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.JointTables.Score", b =>
                {
                    b.HasOne("TeamAssignment4A.Models.JointTables.ExamStem", "ExamStems")
                        .WithMany()
                        .HasForeignKey("ExamStemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamAssignment4A.Models.JointTables.ExamTopic", "ExamTopics")
                        .WithMany()
                        .HasForeignKey("ExamTopicsExamTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExamStems");

                    b.Navigation("ExamTopics");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Candidate", b =>
                {
                    b.Navigation("CandidateExams");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Certificate", b =>
                {
                    b.Navigation("ExamTopics");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Exam", b =>
                {
                    b.Navigation("CandidateExams");

                    b.Navigation("Certificates");

                    b.Navigation("ExamStems");

                    b.Navigation("ExamTopics");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Stem", b =>
                {
                    b.Navigation("ExamStems");
                });

            modelBuilder.Entity("TeamAssignment4A.Models.Topic", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
