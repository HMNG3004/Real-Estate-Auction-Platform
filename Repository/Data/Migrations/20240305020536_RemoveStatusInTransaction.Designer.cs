﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240305020536_RemoveStatusInTransaction")]
    partial class RemoveStatusInTransaction
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Entity.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Account_Status")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Citizen_identification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_End")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MajorId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex("MajorId")
                        .IsUnique()
                        .HasFilter("[MajorId] IS NOT NULL");

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("API.Entity.Auction", b =>
                {
                    b.Property<int>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuctionId"));

                    b.Property<int>("AccountCreateId")
                        .HasColumnType("int");

                    b.Property<string>("AccountCreateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReasId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("AuctionId");

                    b.HasIndex("AccountCreateId");

                    b.HasIndex("ReasId")
                        .IsUnique();

                    b.ToTable("Auction");
                });

            modelBuilder.Entity("API.Entity.AuctionAccounting", b =>
                {
                    b.Property<int>("AuctionAccountingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuctionAccountingId"));

                    b.Property<int>("AccountOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("AccountOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountWinId")
                        .HasColumnType("int");

                    b.Property<string>("AccountWinName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AmountOwnerReceived")
                        .HasColumnType("float");

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<double>("CommissionAmount")
                        .HasColumnType("float");

                    b.Property<double>("DepositAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("EstimatedPaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("MaxAmount")
                        .HasColumnType("float");

                    b.Property<int>("ReasId")
                        .HasColumnType("int");

                    b.HasKey("AuctionAccountingId");

                    b.HasIndex("AccountOwnerId");

                    b.HasIndex("AccountWinId");

                    b.HasIndex("AuctionId")
                        .IsUnique();

                    b.HasIndex("ReasId")
                        .IsUnique();

                    b.ToTable("AuctionsAccounting");
                });

            modelBuilder.Entity("API.Entity.DepositAmount", b =>
                {
                    b.Property<int>("DepositId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepositId"));

                    b.Property<int>("AccountSignId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreateDepositDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DepositDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReasId")
                        .HasColumnType("int");

                    b.Property<int>("RuleId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("DepositId");

                    b.HasIndex("AccountSignId");

                    b.HasIndex("ReasId")
                        .IsUnique();

                    b.HasIndex("RuleId")
                        .IsUnique();

                    b.ToTable("DepositAmount");
                });

            modelBuilder.Entity("API.Entity.Log", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"));

                    b.Property<int>("AccountWriterId")
                        .HasColumnType("int");

                    b.Property<string>("AccountWriterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LogEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LogStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LogId");

                    b.HasIndex("AccountWriterId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("API.Entity.Major", b =>
                {
                    b.Property<int>("MajorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MajorId"));

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MajorId");

                    b.ToTable("Major");
                });

            modelBuilder.Entity("API.Entity.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<string>("AccounSerdertName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("AccountSerderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateSend")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("AccountReceiverId");

                    b.HasIndex("AccountSerderId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("API.Entity.MoneyTransaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<int?>("AccountReceiveId")
                        .HasColumnType("int");

                    b.Property<int?>("AccountSendId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateExecution")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepositId")
                        .HasColumnType("int");

                    b.Property<double>("Money")
                        .HasColumnType("float");

                    b.Property<int?>("ReasId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionStatus")
                        .HasColumnType("int");

                    b.Property<string>("TxnRef")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.HasIndex("AccountReceiveId");

                    b.HasIndex("AccountSendId");

                    b.HasIndex("DepositId")
                        .IsUnique()
                        .HasFilter("[DepositId] IS NOT NULL");

                    b.HasIndex("ReasId")
                        .IsUnique()
                        .HasFilter("[ReasId] IS NOT NULL");

                    b.HasIndex("TypeId")
                        .IsUnique();

                    b.ToTable("MoneyTransaction");
                });

            modelBuilder.Entity("API.Entity.MoneyTransactionType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("MoneyTransactionType");
                });

            modelBuilder.Entity("API.Entity.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<int>("AccountCreateId")
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewsContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsSumary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.HasIndex("AccountCreateId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("API.Entity.RealEstate", b =>
                {
                    b.Property<int>("ReasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReasId"));

                    b.Property<int>("AccountOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("AccountOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReasArea")
                        .HasColumnType("int");

                    b.Property<string>("ReasDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ReasPrice")
                        .HasColumnType("float");

                    b.Property<int>("ReasStatus")
                        .HasColumnType("int");

                    b.Property<int>("Type_Reas")
                        .HasColumnType("int");

                    b.HasKey("ReasId");

                    b.HasIndex("AccountOwnerId");

                    b.HasIndex("Type_Reas")
                        .IsUnique();

                    b.ToTable("RealEstate");
                });

            modelBuilder.Entity("API.Entity.RealEstateDetail", b =>
                {
                    b.Property<int>("ReasDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReasDetailId"));

                    b.Property<string>("Documents_Proving_Marital_Relationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReasId")
                        .HasColumnType("int");

                    b.Property<string>("Reas_Cert_Of_Home_Ownership")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reas_Cert_Of_Land_Img_After")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reas_Cert_Of_Land_Img_Front")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reas_Registration_Book")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sales_Authorization_Contract")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReasDetailId");

                    b.HasIndex("ReasId")
                        .IsUnique();

                    b.ToTable("RealEstateDetail");
                });

            modelBuilder.Entity("API.Entity.RealEstatePhoto", b =>
                {
                    b.Property<int>("ReasPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReasPhotoId"));

                    b.Property<int>("ReasId")
                        .HasColumnType("int");

                    b.Property<string>("ReasPhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReasPhotoId");

                    b.HasIndex("ReasId");

                    b.ToTable("RealEstatePhoto");
                });

            modelBuilder.Entity("API.Entity.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("API.Entity.Rule", b =>
                {
                    b.Property<int>("RuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RuleId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RuleId");

                    b.ToTable("Rule");
                });

            modelBuilder.Entity("API.Entity.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<int>("AccountAssignedId")
                        .HasColumnType("int");

                    b.Property<string>("AccountAssignedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountCreateId")
                        .HasColumnType("int");

                    b.Property<string>("AccountCreateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TaskContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskId");

                    b.HasIndex("AccountAssignedId");

                    b.HasIndex("AccountCreateId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("API.Entity.Type_REAS", b =>
                {
                    b.Property<int>("Type_ReasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Type_ReasId"));

                    b.Property<string>("Type_Reas_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Type_ReasId");

                    b.ToTable("type_REAS");
                });

            modelBuilder.Entity("API.Entity.Account", b =>
                {
                    b.HasOne("API.Entity.Major", "Major")
                        .WithOne()
                        .HasForeignKey("API.Entity.Account", "MajorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API.Entity.Role", "Role")
                        .WithOne()
                        .HasForeignKey("API.Entity.Account", "RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Major");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API.Entity.Auction", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountCreate")
                        .WithMany("Auctions")
                        .HasForeignKey("AccountCreateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Auction_RealEstate");

                    b.HasOne("API.Entity.RealEstate", "RealEstate")
                        .WithOne()
                        .HasForeignKey("API.Entity.Auction", "ReasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountCreate");

                    b.Navigation("RealEstate");
                });

            modelBuilder.Entity("API.Entity.AuctionAccounting", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountOwner")
                        .WithMany("OwnedAuctionAccountings")
                        .HasForeignKey("AccountOwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entity.Account", "AccountWin")
                        .WithMany("WonAuctionAccountings")
                        .HasForeignKey("AccountWinId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entity.Auction", "Auction")
                        .WithOne("AuctionAccounting")
                        .HasForeignKey("API.Entity.AuctionAccounting", "AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entity.RealEstate", "RealEstate")
                        .WithOne()
                        .HasForeignKey("API.Entity.AuctionAccounting", "ReasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AuctionAccounting_RealEstate");

                    b.Navigation("AccountOwner");

                    b.Navigation("AccountWin");

                    b.Navigation("Auction");

                    b.Navigation("RealEstate");
                });

            modelBuilder.Entity("API.Entity.DepositAmount", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountSign")
                        .WithMany("DepositAmount")
                        .HasForeignKey("AccountSignId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entity.RealEstate", "RealEstate")
                        .WithOne()
                        .HasForeignKey("API.Entity.DepositAmount", "ReasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entity.Rule", "Rule")
                        .WithOne()
                        .HasForeignKey("API.Entity.DepositAmount", "RuleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountSign");

                    b.Navigation("RealEstate");

                    b.Navigation("Rule");
                });

            modelBuilder.Entity("API.Entity.Log", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountWriter")
                        .WithMany("LogWrote")
                        .HasForeignKey("AccountWriterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountWriter");
                });

            modelBuilder.Entity("API.Entity.Message", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountReceiver")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("AccountReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entity.Account", "AccountSerder")
                        .WithMany("MessagesSent")
                        .HasForeignKey("AccountSerderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountReceiver");

                    b.Navigation("AccountSerder");
                });

            modelBuilder.Entity("API.Entity.MoneyTransaction", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountReceive")
                        .WithMany("MoneyTransactionsReceived")
                        .HasForeignKey("AccountReceiveId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API.Entity.Account", "AccountSend")
                        .WithMany("MoneyTransactionsSent")
                        .HasForeignKey("AccountSendId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API.Entity.DepositAmount", "DepositAmount")
                        .WithOne()
                        .HasForeignKey("API.Entity.MoneyTransaction", "DepositId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API.Entity.RealEstate", "RealEstate")
                        .WithOne()
                        .HasForeignKey("API.Entity.MoneyTransaction", "ReasId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API.Entity.MoneyTransactionType", "Type")
                        .WithOne()
                        .HasForeignKey("API.Entity.MoneyTransaction", "TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountReceive");

                    b.Navigation("AccountSend");

                    b.Navigation("DepositAmount");

                    b.Navigation("RealEstate");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("API.Entity.News", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountCreate")
                        .WithMany("NewsCreated")
                        .HasForeignKey("AccountCreateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountCreate");
                });

            modelBuilder.Entity("API.Entity.RealEstate", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountOwner")
                        .WithMany("RealEstate")
                        .HasForeignKey("AccountOwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entity.Type_REAS", "Type_REAS")
                        .WithOne()
                        .HasForeignKey("API.Entity.RealEstate", "Type_Reas")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountOwner");

                    b.Navigation("Type_REAS");
                });

            modelBuilder.Entity("API.Entity.RealEstateDetail", b =>
                {
                    b.HasOne("API.Entity.RealEstate", "RealEstate")
                        .WithOne("Detail")
                        .HasForeignKey("API.Entity.RealEstateDetail", "ReasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RealEstate");
                });

            modelBuilder.Entity("API.Entity.RealEstatePhoto", b =>
                {
                    b.HasOne("API.Entity.RealEstate", "RealEstate")
                        .WithMany("Photos")
                        .HasForeignKey("ReasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RealEstate");
                });

            modelBuilder.Entity("API.Entity.Task", b =>
                {
                    b.HasOne("API.Entity.Account", "AccountAssigned")
                        .WithMany("TasksAssigned")
                        .HasForeignKey("AccountAssignedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entity.Account", "AccountCreate")
                        .WithMany("TasksCreated")
                        .HasForeignKey("AccountCreateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountAssigned");

                    b.Navigation("AccountCreate");
                });

            modelBuilder.Entity("API.Entity.Account", b =>
                {
                    b.Navigation("Auctions");

                    b.Navigation("DepositAmount");

                    b.Navigation("LogWrote");

                    b.Navigation("MessagesReceived");

                    b.Navigation("MessagesSent");

                    b.Navigation("MoneyTransactionsReceived");

                    b.Navigation("MoneyTransactionsSent");

                    b.Navigation("NewsCreated");

                    b.Navigation("OwnedAuctionAccountings");

                    b.Navigation("RealEstate");

                    b.Navigation("TasksAssigned");

                    b.Navigation("TasksCreated");

                    b.Navigation("WonAuctionAccountings");
                });

            modelBuilder.Entity("API.Entity.Auction", b =>
                {
                    b.Navigation("AuctionAccounting")
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entity.RealEstate", b =>
                {
                    b.Navigation("Detail")
                        .IsRequired();

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
