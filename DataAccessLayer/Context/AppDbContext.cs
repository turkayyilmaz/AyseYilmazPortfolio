﻿using AyseYilmazPortfolio.DataAccessLayer.Entites;
using Microsoft.EntityFrameworkCore;

namespace AyseYilmazPortfolio.DataAccessLayer.Context
{
	public class AppDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = DESKTOP-LSBVFQN\\SQLEXPRESS; Initial Catalog = AyseYilmazDb; integrated Security = True;TrustServerCertificate = True");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<SocailMedia> SocailMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<ToDoList> ToDoLists { get; set; }
	}
}
