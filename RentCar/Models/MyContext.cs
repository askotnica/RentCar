﻿using System.Data.Entity;

namespace RentCar.Models
{
    public class MyContext :DbContext
    {
        public MyContext() : base(@"Data Source=PIOTR-PC;Initial Catalog=RentCar;Integrated Security=True;MultipleActiveResultSets=True") { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<User> Users { get; set; }      
    }
}