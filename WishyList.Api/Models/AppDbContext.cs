using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<List> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Member Table
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberId = 1,
                    Name = "John One",
                    Email = "john1@example.com",
                    LastGroupId = 1,
                    LastListId = 1,
                    InsertDate = DateTime.Now
                });

            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberId = 2,
                    Name = "Suzie Two",
                    Email = "suzie2@example.com",
                    LastGroupId = 1,
                    LastListId = 1,
                    InsertDate = DateTime.Now
                });

            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberId = 3,
                    Name = "Pete Three",
                    Email = "pete3@example.com",
                    LastGroupId = 1,
                    LastListId = 1,
                    InsertDate = DateTime.Now
                });

            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberId = 4,
                    Name = "Jill Four",
                    Email = "jill4@example.com",
                    LastGroupId = 1,
                    LastListId = 1,
                    InsertDate = DateTime.Now
                });

            //Seed Group Table
            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    GroupId = 1,
                    Name = "Group A",
                    InsertDate = DateTime.Now
                });

            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    GroupId = 2,
                    Name = "Group B",
                    InsertDate = DateTime.Now
                });

            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    GroupId = 3,
                    Name = "Group C",
                    InsertDate = DateTime.Now
                });

            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    GroupId = 4,
                    Name = "Group D",
                    InsertDate = DateTime.Now
                });
        }
    }
}
