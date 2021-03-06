﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using webapi_protobuf.contracts;

namespace webapi_protobuf.Controllers
{
    public class CoffeesController : ApiController
    {
        // GET: api/Coffees
        // GET: api/coffees?id=9111213f-bc79-4521-a762-b1dd5625a237
        // GET: api/coffees?withMilk=true
        // GET: api/coffees?name=Espresso
        // GET: api/coffees?size=small
        public async Task<IEnumerable<Coffee>> Get([FromUri] GetCoffeeRequest request)
        {
            if (request == null)
            {
                return DataSource();
            }

            var data = DataSource();

            if (request.ContainsMilk.HasValue)
            {
                data = data.Where(d => d.ContainsMilk == request.ContainsMilk.Value);
            }

            if (request.Id.HasValue)
            {
                data = data.Where(d => d.Id == request.Id.Value);
            }

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                data = data.Where(d => d.Name.Contains(request.Name));
            }

            if (request.Size.HasValue)
            {
                data = data.Where(d => d.Size == request.Size.Value);
            }

            return data;
        }

        private IQueryable<Coffee> DataSource()
        {
            return new[]
            {
                new Coffee()
                {
                    Id = new Guid("79b45748-62f9-4bf0-93d8-03a8f06d2af5"),
                    Name = "Flat White",
                    Size = Coffee.CoffeeSize.Small,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("315961ef-7f14-4d93-9ec4-f85d84b7c0bd"),
                    Name = "Latte",
                    Size = Coffee.CoffeeSize.Medium,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("5bbfc34c-007e-4ceb-a171-f19ea9ef65cf"),
                    Name = "Espresso",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = false
                },
                new Coffee()
                {
                    Id = new Guid("9111213f-bc79-4521-a762-b1dd5625a237"),
                    Name = "Short Macchiato",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("e9606fda-645d-4370-973c-8f8fe4336a70"),
                    Name = "Americano",
                    Size = Coffee.CoffeeSize.Large,
                    SugarCount = 0,
                    ContainsMilk = false
                },
                 new Coffee()
                {
                    Id = new Guid("79b45748-62f9-4bf0-93d8-03a8f06d2af6"),
                    Name = "Flat White",
                    Size = Coffee.CoffeeSize.Small,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("315961ef-7f14-4d93-9ec4-f85d84b7c0be"),
                    Name = "Latte",
                    Size = Coffee.CoffeeSize.Medium,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("5bbfc34c-007e-4ceb-a171-f19ea9ef65d0"),
                    Name = "Espresso",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = false
                },
                new Coffee()
                {
                    Id = new Guid("9111213f-bc79-4521-a762-b1dd5625a238"),
                    Name = "Short Macchiato",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("e9606fda-645d-4370-973c-8f8fe4336a71"),
                    Name = "Americano",
                    Size = Coffee.CoffeeSize.Large,
                    SugarCount = 0,
                    ContainsMilk = false
                },
                  new Coffee()
                {
                    Id = new Guid("79b45748-62f9-4bf0-93d8-03a8f06d2af6"),
                    Name = "Flat White",
                    Size = Coffee.CoffeeSize.Small,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("315961ef-7f14-4d93-9ec4-f85d84b7c0be"),
                    Name = "Latte",
                    Size = Coffee.CoffeeSize.Medium,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("5bbfc34c-007e-4ceb-a171-f19ea9ef65d0"),
                    Name = "Espresso",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = false
                },
                new Coffee()
                {
                    Id = new Guid("9111213f-bc79-4521-a762-b1dd5625a238"),
                    Name = "Short Macchiato",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("e9606fda-645d-4370-973c-8f8fe4336a71"),
                    Name = "Americano",
                    Size = Coffee.CoffeeSize.Large,
                    SugarCount = 0,
                    ContainsMilk = false
                },
                 new Coffee()
                {
                    Id = new Guid("79b45748-62f9-4bf0-93d8-03a8f06d2af7"),
                    Name = "Flat White",
                    Size = Coffee.CoffeeSize.Small,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("315961ef-7f14-4d93-9ec4-f85d84b7c0bf"),
                    Name = "Latte",
                    Size = Coffee.CoffeeSize.Medium,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("5bbfc34c-007e-4ceb-a171-f19ea9ef65d1"),
                    Name = "Espresso",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = false
                },
                new Coffee()
                {
                    Id = new Guid("9111213f-bc79-4521-a762-b1dd5625a239"),
                    Name = "Short Macchiato",
                    Size = Coffee.CoffeeSize.Short,
                    SugarCount = 0,
                    ContainsMilk = true
                },
                new Coffee()
                {
                    Id = new Guid("e9606fda-645d-4370-973c-8f8fe4336a72"),
                    Name = "Americano",
                    Size = Coffee.CoffeeSize.Large,
                    SugarCount = 0,
                    ContainsMilk = false
                }
            }.AsQueryable();
        }
    }
}