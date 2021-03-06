﻿using CougarTown.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CougarTown.Models.Factory
{
    public class UserFactory : AutoFactory<User>
    {
        public UserFactory(HttpContextBase context) : base(context)
        {

        }


        protected override void SeedEntities()
        {
            allEntities.Add(new User()
            {
                ID = 1,
                DisplayName = "Chanel62",
                Password = "youngAdults1990",
                Name = "Dorte Nyholm",
                ProfileImage = "noprofileimageyet.jpg",
                Age = 62,
                Gender = "Female",
                Email = "dnyholm@live.dk"
            });

            allEntities.Add(new User()
            {
                ID = 2,
                DisplayName = "Hanne55",
                Password = "youngAdults1990",
                Name = "Hanne Fisker",
                ProfileImage = "noprofileimageyet.jpg",
                Age = 32,
                Gender = "Female",
                Email = "hanne.fisker@live.dk"
            });
        }

        public User GetUser(int id)
        {
            return allEntities.Find(x => x.ID == id);
        }

        public User UserLogin(string displayName, string password)
        {
            // If we find a user, with the specifications we've made we can return the user
            User user = allEntities.Find(x => x.DisplayName == displayName && x.Password == password);
            if (user != null)
            {
                return user;
            }
            return null;
        }
    }
}