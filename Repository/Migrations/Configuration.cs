namespace Repository.Migrations
{
    using Repository.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Repository.Data.ZooDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Repository.Data.ZooDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Category.AddOrUpdate(
                 new Category()
                 {
                     CategoryId = 1,
                     Name = "Всички"
                 },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Влечуги"
                },
                new Category()
                {
                    CategoryId = 3,
                    Name = "Бозайници"
                },
                new Category()
                {
                    CategoryId = 4,
                    Name = "Птици"
                });

            //fills in information in the table (Animals) if empty
            context.Animal.AddOrUpdate(
                new Animal("Лъв", "Едър мъжки на 10 годишна възраст"
                    , File.ReadAllBytes("E:/Projects/Zoo/ZooSystem/Repository/Pictures/Lion_waiting_in_Namibia.jpg"), 3),
                new Animal("Орел", "Едър мъжки на 3 годишна възраст"
                    , File.ReadAllBytes("E:/Projects/Zoo/ZooSystem/Repository/Pictures/Orel.jpg"), 4),
                new Animal("Усойница", "Женска на 2 годишна възраст"
                    , File.ReadAllBytes("E:/Projects/Zoo/ZooSystem/Repository/Pictures/Usoinica.jpg"), 2)
                );

            context.EventsType.AddOrUpdate(
                new EventsType()
                {
                    TypeId = 1,
                    Type = "Всички"
                },
                new EventsType()
                {
                    TypeId = 2,
                    Type = "За възрастни"
                }, new EventsType()
                {
                    TypeId = 3,
                    Type = "За деца"
                }, new EventsType()
                {
                    TypeId = 4,
                    Type = "За тийнейджъри"
                });

            context.Event.AddOrUpdate(
                new Event()
                {
                    Id = 1,
                    Name = "Шоу на прилепите",
                    Date = new DateTime(2022, 9, 9),
                    TypeId = 2,
                    Description = "Едно уникално явление посред нощ"
                },
                new Event()
                {
                    Id = 2,
                    Name = "Игра с делфини",
                    Date = new DateTime(2022, 10, 10),
                    TypeId = 3,
                    Description = "Водна топка с делфини"
                },
                new Event()
                {
                    Id = 3,
                    Name = "Хранене на Лъвове",
                    Date = new DateTime(2022, 10, 10),
                    TypeId = 2,
                    Description = "Имате възможност да се доближите до лъвовете в парка и да се снимате с тях"
                },
                new Event()
                {
                    Id = 4,
                    Name = "Хранене на Маймуни",
                    Date = new DateTime(2022, 9, 9),
                    TypeId = 4,
                    Description = "Имате възможност да се доближите до маймуните в парка и да се снимате с тях"
                });

            context.TicketsType.AddOrUpdate(
            new TicketsType()
            {
                TypeTicketId = 1,
                Type = "Индивидуален",
                price = 9
            },
            new TicketsType()
            {
                TypeTicketId = 2,
                Type = "Ученически",
                price = 6
            },
            new TicketsType()
            {
                TypeTicketId = 3,
                Type = "Семеен",
                price = 12
            });
            context.User.AddOrUpdate(
                new User()
                {
                    UserId = 2,
                    Name = "pesho",
                    Password = "pesho",
                    Role = Roles.DefaultUser
                },
                new User()
                {
                    UserId = 1,
                    Name = "ivan",
                    Password = "ivan",
                    Role = Roles.Admin
                });
            
        }
       
    }
}
