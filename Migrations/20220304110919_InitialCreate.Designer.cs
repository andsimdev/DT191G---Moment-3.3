// <auto-generated />
using DT191G___Moment_3._3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DT191G___Moment_3._3.Migrations
{
    [DbContext(typeof(TrackContext))]
    [Migration("20220304110919_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("DT191G___Moment_3._3.Models.Track", b =>
                {
                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("artist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("length")
                        .HasColumnType("INTEGER");

                    b.HasKey("title");

                    b.ToTable("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
