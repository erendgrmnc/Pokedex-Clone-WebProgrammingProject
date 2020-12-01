﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201130195054_Migration01")]
    partial class Migration01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebProgramlamaOdev.Models.Abilities", b =>
                {
                    b.Property<int>("ABILITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ABILITY_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ABILITY_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ABILITY_ID");

                    b.ToTable("ABILITY");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Pokemon", b =>
                {
                    b.Property<int>("POKEMON_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("POKEMON_CATEGORY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_HEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_IMG_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POKEMON_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("POKEMON_PRICE")
                        .HasColumnType("int");

                    b.Property<string>("POKEMON_WEIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("POKEMON_ID");

                    b.ToTable("POKEMON");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonAbility", b =>
                {
                    b.Property<int>("POKEMON_ABILITY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ABILITY_ID")
                        .HasColumnType("int");

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_ABILITY_ID");

                    b.HasIndex("ABILITY_ID");

                    b.HasIndex("POKEMON_ID");

                    b.ToTable("POKEMON_ABILITY");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonStat", b =>
                {
                    b.Property<int>("POKEMON_STAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("STAT_ID")
                        .HasColumnType("int");

                    b.Property<int>("STAT_VALUE")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_STAT_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("STAT_ID");

                    b.ToTable("POKEMON_STAT");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonType", b =>
                {
                    b.Property<int>("POKEMON_TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("TYPE_ID")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_TYPE_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("TYPE_ID");

                    b.ToTable("POKEMON_TYPE");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonWeakness", b =>
                {
                    b.Property<int>("POKEMON_WEAKNESS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("WEAKNESS_ID")
                        .HasColumnType("int");

                    b.HasKey("POKEMON_WEAKNESS_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("WEAKNESS_ID");

                    b.ToTable("POKEMON_WEAKNESS");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Stat", b =>
                {
                    b.Property<int>("STAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("STAT_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("STAT_ID");

                    b.ToTable("STAT");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Type", b =>
                {
                    b.Property<int>("TYPE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TYPE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TYPE_ID");

                    b.ToTable("TYPE");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.User", b =>
                {
                    b.Property<int>("USER_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("USER_ABOUT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("USER_BALANCE")
                        .HasColumnType("int");

                    b.Property<DateTime>("USER_BIRTHDATE")
                        .HasColumnType("datetime2");

                    b.Property<bool>("USER_ISADMIN")
                        .HasColumnType("bit");

                    b.Property<string>("USER_MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER_PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("USER_ID");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserPokemon", b =>
                {
                    b.Property<int>("USER_POKEMON_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATION_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("USER_ID")
                        .HasColumnType("int");

                    b.HasKey("USER_POKEMON_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("USER_ID");

                    b.ToTable("USER_POKEMON");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserWishlist", b =>
                {
                    b.Property<int>("USER_WISH_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATION_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("POKEMON_ID")
                        .HasColumnType("int");

                    b.Property<int>("USER_ID")
                        .HasColumnType("int");

                    b.HasKey("USER_WISH_ID");

                    b.HasIndex("POKEMON_ID");

                    b.HasIndex("USER_ID");

                    b.ToTable("USER_WISHLIST");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Weakness", b =>
                {
                    b.Property<int>("WEAKNESS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("WEAKNESS_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WEAKNESS_ID");

                    b.ToTable("WEAKNESS");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonAbility", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.Abilities", "Ability")
                        .WithMany("PokemonAbility")
                        .HasForeignKey("ABILITY_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgramlamaOdev.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonAbility")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ability");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonStat", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonStat")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgramlamaOdev.Models.Stat", "Stat")
                        .WithMany("PokemonStat")
                        .HasForeignKey("STAT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonType", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonType")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgramlamaOdev.Models.Type", "Type")
                        .WithMany("PokemonType")
                        .HasForeignKey("TYPE_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.PokemonWeakness", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonWeakness")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgramlamaOdev.Models.Weakness", "Weakness")
                        .WithMany("PokemonWeakness")
                        .HasForeignKey("WEAKNESS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("Weakness");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserPokemon", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.Pokemon", "Pokemon")
                        .WithMany("UserPokemon")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgramlamaOdev.Models.User", "User")
                        .WithMany("UserPokemon")
                        .HasForeignKey("USER_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.UserWishlist", b =>
                {
                    b.HasOne("WebProgramlamaOdev.Models.Pokemon", "Pokemon")
                        .WithMany("UserWishlist")
                        .HasForeignKey("POKEMON_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgramlamaOdev.Models.User", "User")
                        .WithMany("UserWishlist")
                        .HasForeignKey("USER_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Abilities", b =>
                {
                    b.Navigation("PokemonAbility");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Pokemon", b =>
                {
                    b.Navigation("PokemonAbility");

                    b.Navigation("PokemonStat");

                    b.Navigation("PokemonType");

                    b.Navigation("PokemonWeakness");

                    b.Navigation("UserPokemon");

                    b.Navigation("UserWishlist");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Stat", b =>
                {
                    b.Navigation("PokemonStat");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Type", b =>
                {
                    b.Navigation("PokemonType");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.User", b =>
                {
                    b.Navigation("UserPokemon");

                    b.Navigation("UserWishlist");
                });

            modelBuilder.Entity("WebProgramlamaOdev.Models.Weakness", b =>
                {
                    b.Navigation("PokemonWeakness");
                });
#pragma warning restore 612, 618
        }
    }
}
