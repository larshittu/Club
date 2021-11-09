﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POClubs.Data;

namespace POClubs.Data.Migrations
{
    [DbContext(typeof(POClubsContext))]
    [Migration("20210918211556_TableUpdate")]
    partial class TableUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("POClubs.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnName("artistId")
                        .HasColumnType("int");

                    b.Property<double>("MinimumHourlyRate")
                        .HasColumnName("minimumHourlyRate")
                        .HasColumnType("float");

                    b.Property<int>("NameAddressid")
                        .HasColumnName("nameAddressid")
                        .HasColumnType("int");

                    b.HasKey("ArtistId");

                    b.HasIndex("NameAddressid");

                    b.ToTable("artist");
                });

            modelBuilder.Entity("POClubs.Models.ArtistInstrument", b =>
                {
                    b.Property<int>("ArtistInstrumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("artistInstrumentId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnName("artistId")
                        .HasColumnType("int");

                    b.Property<int>("InstrumentId")
                        .HasColumnName("instrumentId")
                        .HasColumnType("int");

                    b.HasKey("ArtistInstrumentId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("artistInstrument");
                });

            modelBuilder.Entity("POClubs.Models.ArtistStyle", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnName("artistId")
                        .HasColumnType("int");

                    b.Property<string>("StyleName")
                        .HasColumnName("styleName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ArtistId", "StyleName");

                    b.HasIndex("StyleName");

                    b.ToTable("artistStyle");
                });

            modelBuilder.Entity("POClubs.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .HasColumnName("clubId")
                        .HasColumnType("int");

                    b.HasKey("ClubId");

                    b.ToTable("club");
                });

            modelBuilder.Entity("POClubs.Models.ClubStyle", b =>
                {
                    b.Property<int>("ClubId")
                        .HasColumnName("clubId")
                        .HasColumnType("int");

                    b.Property<string>("StyleName")
                        .HasColumnName("styleName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ClubId", "StyleName");

                    b.HasIndex("StyleName");

                    b.ToTable("clubStyle");
                });

            modelBuilder.Entity("POClubs.Models.Contract", b =>
                {
                    b.Property<int>("Contract1")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("contract")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnName("artistId")
                        .HasColumnType("int");

                    b.Property<int>("ClubId")
                        .HasColumnName("clubId")
                        .HasColumnType("int");

                    b.Property<int>("NumberPerformances")
                        .HasColumnName("numberPerformances")
                        .HasColumnType("int");

                    b.Property<double>("PricePerPerformance")
                        .HasColumnName("pricePerPerformance")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("startDate")
                        .HasColumnType("datetime");

                    b.Property<double>("TotalPrice")
                        .HasColumnName("totalPrice")
                        .HasColumnType("float");

                    b.HasKey("Contract1");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ClubId");

                    b.ToTable("contract");
                });

            modelBuilder.Entity("POClubs.Models.Country", b =>
                {
                    b.Property<string>("CountryCode")
                        .HasColumnName("countryCode")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<double>("FederalSalesTax")
                        .HasColumnName("federalSalesTax")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PhonePattern")
                        .HasColumnName("phonePattern")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PostalPattern")
                        .HasColumnName("postalPattern")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("ProvinceTerminology")
                        .HasColumnName("provinceTerminology")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("CountryCode");

                    b.ToTable("country");
                });

            modelBuilder.Entity("POClubs.Models.GroupMember", b =>
                {
                    b.Property<int>("ArtistIdGroup")
                        .HasColumnName("artistIdGroup")
                        .HasColumnType("int");

                    b.Property<int>("ArtistIdMember")
                        .HasColumnName("artistIdMember")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateJoined")
                        .HasColumnName("dateJoined")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateLeft")
                        .HasColumnName("dateLeft")
                        .HasColumnType("datetime");

                    b.HasKey("ArtistIdGroup", "ArtistIdMember")
                        .HasName("PK_groupMember_1");

                    b.HasIndex("ArtistIdMember");

                    b.ToTable("groupMember");
                });

            modelBuilder.Entity("POClubs.Models.Instrument", b =>
                {
                    b.Property<int>("InstrumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("instrumentId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("InstrumentId");

                    b.ToTable("instrument");
                });

            modelBuilder.Entity("POClubs.Models.NameAddress", b =>
                {
                    b.Property<int>("NameAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("nameAddressId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CompanyName")
                        .HasColumnName("companyName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasColumnName("firstName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .HasColumnName("lastName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PostalCode")
                        .HasColumnName("postalCode")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProvinceCode")
                        .HasColumnName("provinceCode")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("StreetAddress")
                        .HasColumnName("streetAddress")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("NameAddressId");

                    b.HasIndex("ProvinceCode");

                    b.ToTable("nameAddress");
                });

            modelBuilder.Entity("POClubs.Models.Province", b =>
                {
                    b.Property<string>("ProvinceCode")
                        .HasColumnName("provinceCode")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnName("countryCode")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("FirstPostalLetter")
                        .HasColumnName("firstPostalLetter")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("IncludesFederalTax")
                        .HasColumnName("includesFederalTax")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<double>("SalesTax")
                        .HasColumnName("salesTax")
                        .HasColumnType("float");

                    b.Property<string>("SalesTaxCode")
                        .HasColumnName("salesTaxCode")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ProvinceCode");

                    b.HasIndex("CountryCode");

                    b.ToTable("province");
                });

            modelBuilder.Entity("POClubs.Models.Style", b =>
                {
                    b.Property<string>("StyleName")
                        .HasColumnName("styleName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("StyleName");

                    b.ToTable("style");
                });

            modelBuilder.Entity("POClubs.Models.Artist", b =>
                {
                    b.HasOne("POClubs.Models.NameAddress", "NameAddress")
                        .WithMany("Artist")
                        .HasForeignKey("NameAddressid")
                        .HasConstraintName("FK_artist_nameAddress")
                        .IsRequired();
                });

            modelBuilder.Entity("POClubs.Models.ArtistInstrument", b =>
                {
                    b.HasOne("POClubs.Models.Artist", "Artist")
                        .WithMany("ArtistInstrument")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("FK_artistInstrument_artist")
                        .IsRequired();

                    b.HasOne("POClubs.Models.Instrument", "Instrument")
                        .WithMany("ArtistInstrument")
                        .HasForeignKey("InstrumentId")
                        .HasConstraintName("FK_artistInstrument_instrument")
                        .IsRequired();
                });

            modelBuilder.Entity("POClubs.Models.ArtistStyle", b =>
                {
                    b.HasOne("POClubs.Models.Artist", "Artist")
                        .WithMany("ArtistStyle")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("FK_artistStyle_artist")
                        .IsRequired();

                    b.HasOne("POClubs.Models.Style", "StyleNameNavigation")
                        .WithMany("ArtistStyle")
                        .HasForeignKey("StyleName")
                        .HasConstraintName("FK_artistStyle_style")
                        .IsRequired();
                });

            modelBuilder.Entity("POClubs.Models.Club", b =>
                {
                    b.HasOne("POClubs.Models.NameAddress", "ClubNavigation")
                        .WithOne("Club")
                        .HasForeignKey("POClubs.Models.Club", "ClubId")
                        .HasConstraintName("FK_club_nameAddress")
                        .IsRequired();
                });

            modelBuilder.Entity("POClubs.Models.ClubStyle", b =>
                {
                    b.HasOne("POClubs.Models.Club", "Club")
                        .WithMany("ClubStyle")
                        .HasForeignKey("ClubId")
                        .HasConstraintName("FK_clubStyle_club")
                        .IsRequired();

                    b.HasOne("POClubs.Models.Style", "StyleNameNavigation")
                        .WithMany("ClubStyle")
                        .HasForeignKey("StyleName")
                        .HasConstraintName("FK_clubStyle_style")
                        .IsRequired();
                });

            modelBuilder.Entity("POClubs.Models.Contract", b =>
                {
                    b.HasOne("POClubs.Models.Artist", "Artist")
                        .WithMany("Contract")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("FK_contract_artist")
                        .IsRequired();

                    b.HasOne("POClubs.Models.Club", "Club")
                        .WithMany("Contract")
                        .HasForeignKey("ClubId")
                        .HasConstraintName("FK_contract_club")
                        .IsRequired();
                });

            modelBuilder.Entity("POClubs.Models.GroupMember", b =>
                {
                    b.HasOne("POClubs.Models.Artist", "ArtistIdGroupNavigation")
                        .WithMany("GroupMemberArtistIdGroupNavigation")
                        .HasForeignKey("ArtistIdGroup")
                        .HasConstraintName("FK_groupMember_artist")
                        .IsRequired();

                    b.HasOne("POClubs.Models.Artist", "ArtistIdMemberNavigation")
                        .WithMany("GroupMemberArtistIdMemberNavigation")
                        .HasForeignKey("ArtistIdMember")
                        .HasConstraintName("FK_groupMember_artist1")
                        .IsRequired();
                });

            modelBuilder.Entity("POClubs.Models.NameAddress", b =>
                {
                    b.HasOne("POClubs.Models.Province", "ProvinceCodeNavigation")
                        .WithMany("NameAddress")
                        .HasForeignKey("ProvinceCode")
                        .HasConstraintName("FK_nameAddress_province");
                });

            modelBuilder.Entity("POClubs.Models.Province", b =>
                {
                    b.HasOne("POClubs.Models.Country", "CountryCodeNavigation")
                        .WithMany("Province")
                        .HasForeignKey("CountryCode")
                        .HasConstraintName("FK_province_country")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
