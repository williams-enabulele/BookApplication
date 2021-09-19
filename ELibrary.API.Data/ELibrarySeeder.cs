﻿using ELibrary.API.Model;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ELibrary.API.Data
{
    public class ELibrarySeeder
    {
        public static void SeedELibraryDb(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, ElibraryDbContext context)
        {

            SeedUserRole(roleManager, userManager, context);
            SeedMainCategory(context);
            SeedSubCategory(context);
            SeedBook(context);
            SeedReview(context);
            SeedRating(context);
           
        }
        private static async void SeedUserRole(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, ElibraryDbContext context)
        {
            try
            {
                await context.Database.EnsureCreatedAsync();
                if (!context.Users.Any())
                {
                    string roles = File.ReadAllText(@"JsonFiles/Roles.json");
                    List<IdentityRole> listOfRoles = JsonConvert.DeserializeObject<List<IdentityRole>>(roles);
                    foreach (var role in listOfRoles)
                    {
                        await roleManager.CreateAsync(role);
                    }
                    string users = File.ReadAllText(@"JsonFiles/Users.json");
                    List<User> listOfUsers = JsonConvert.DeserializeObject<List<User>>(users);
                    int i = 0;
                    foreach (var user in listOfUsers)
                    {
                        await userManager.CreateAsync(user); // Adds the first 5 users to the Admin role and the others to the regular role
                        if (i < 1)
                        {
                            await userManager.AddToRoleAsync(user, "Admin");
                            i++;
                        }
                        else
                            await userManager.AddToRoleAsync(user, "Regular");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static async void SeedMainCategory(ElibraryDbContext context)
        {
            try
            {
                await context.Database.EnsureCreatedAsync();
                if (!context.MainCategories.Any())
                {
                    string data = File.ReadAllText(@"JsonFiles/MainCategories.json");
                    List<MainCategory> mainCategories = JsonConvert.DeserializeObject<List<MainCategory>>(data);
                    await context.MainCategories.AddRangeAsync(mainCategories);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static async void SeedSubCategory(ElibraryDbContext context)
        {
            try
            {
                await context.Database.EnsureCreatedAsync();
                if (!context.SubCategories.Any())
                {
                    string data = File.ReadAllText(@"JsonFiles/SubCategories.json");
                    List<SubCategory> subCategories = JsonConvert.DeserializeObject<List<SubCategory>>(data);
                    await context.SubCategories.AddRangeAsync(subCategories);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static async void SeedReview(ElibraryDbContext context)
        {
            try
            {
                await context.Database.EnsureCreatedAsync();
                if (!context.Reviews.Any())
                {
                    string data = File.ReadAllText(@"JsonFiles/Reviews.json");
                    List<Review> reviews = JsonConvert.DeserializeObject<List<Review>>(data);
                    await context.Reviews.AddRangeAsync(reviews);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static async void SeedRating(ElibraryDbContext context)
        {
            try
            {
                await context.Database.EnsureCreatedAsync();
                if (!context.Ratings.Any())
                {
                    string data = File.ReadAllText(@"JsonFiles/Ratings.json");
                    List<Rating> ratings = JsonConvert.DeserializeObject<List<Rating>>(data);
                    await context.Ratings.AddRangeAsync(ratings);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static async void SeedBook(ElibraryDbContext context)
        {
            try
            {
                await context.Database.EnsureCreatedAsync();
                if (!context.Ratings.Any())
                {
                    string data = File.ReadAllText(@"JsonFiles/Books.json");
                    List<Book> books = JsonConvert.DeserializeObject<List<Book>>(data);
                    await context.Books.AddRangeAsync(books);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
