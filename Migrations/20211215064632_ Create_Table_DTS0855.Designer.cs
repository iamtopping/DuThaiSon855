// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DuThaiSon855.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211215064632_ Create_Table_DTS0855")]
    partial class Create_Table_DTS0855
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("DuThaiSon855.Models.Company_DTS855", b =>
                {
                    b.Property<string>("CompanyID")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyID");

                    b.ToTable("Company_DTS855s");
                });

            modelBuilder.Entity("DuThaiSon855.Models.DTS0855", b =>
                {
                    b.Property<string>("DTSID")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("DTSGender")
                        .HasColumnType("TEXT");

                    b.Property<string>("DTSName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("DTSID");

                    b.ToTable("DTS0855s");
                });
#pragma warning restore 612, 618
        }
    }
}
