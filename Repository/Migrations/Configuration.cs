namespace Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using Models;
    using Repository.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<Repository.Data.ZooDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZooDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Category.AddOrUpdate(
                new Category()
                {
                    IdCat = 1,
                    Name = "Влечуги"
                },
                new Category()
                {
                    IdCat = 2,
                    Name = "Бозайници"
                },
                new Category()
                {
                    IdCat = 3,
                    Name = "Птици"
                });

            //fills in information in the table (Animals) if empty
            context.Animal.AddOrUpdate(
                new Animal("Лъв", "Едър мъжки на 10 годишна възраст"
                    , File.ReadAllBytes("E:/Projects/Zoo/ZooSystem/Repository/Pictures/Lion_waiting_in_Namibia.jpg"), 2),
                new Animal("Орел", "Едър мъжки на 3 годишна възраст"
                    , File.ReadAllBytes("E:/Projects/Zoo/ZooSystem/Repository/Pictures/Orel.jpg"), 3),
                new Animal("Усойница", "Женска на 2 годишна възраст"
                    , File.ReadAllBytes("E:/Projects/Zoo/ZooSystem/Repository/Pictures/Usoinica.jpg"), 1)
                );

            context.EventsType.AddOrUpdate(
                new EventsType()
                {
                    IdType = 1,
                    Type = "За възрастни"
                }, new EventsType()
                {
                    IdType = 2,
                    Type = "За деца"
                }, new EventsType()
                {
                    IdType = 3,
                    Type = "За тийнейджъри"
                });

            context.Event.AddOrUpdate(
                new Event()
                {
                    Id = 1,
                    Name = "Шоу на прилепите",
                    Date = new DateTime(2022, 9, 9),
                    IdType = 1,
                    Description = "Едно уникално явление посред нощ"
                },
                new Event()
                {
                    Id = 2,
                    Name = "Игра с делфини",
                    Date = new DateTime(2022, 10, 10),
                    IdType = 2,
                    Description = "Водна топка с делфини"
                },
                new Event()
                {
                    Id = 3,
                    Name = "Хранене на Лъвове",
                    Date = new DateTime(2022, 10, 10),
                    IdType = 1,
                    Description = "Имате възможност да се доближите до лъвовете в парка и да се снимате с тях"
                },
                new Event()
                {
                    Id = 4,
                    Name = "Хранене на Маймуни",
                    Date = new DateTime(2022, 9, 9),
                    IdType = 3,
                    Description = "Имате възможност да се доближите до маймуните в парка и да се снимате с тях"
                });

            context.TicketsType.AddOrUpdate(
            new TicketsType()
            {
                IdTypeTicket = 1,
                Type = "Индивидуален",
                price = 9
            },
            new TicketsType()
            {
                IdTypeTicket = 2,
                Type = "Ученически",
                price = 6
            },
            new TicketsType()
            {
                IdTypeTicket = 3,
                Type = "Семеен",
                price = 12
            });
            context.User.AddOrUpdate(
                new User()
                {
                    IdUser = 1,
                    Name = "ivan",
                    Password = "ivan"
                });

        }

    }
}
