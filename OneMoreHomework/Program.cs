using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OneMoreHomework;
using OneMoreHomework.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

//var builder = new ConfigurationBuilder();
//builder.SetBasePath(Directory.GetCurrentDirectory());
//builder.AddJsonFile("appsettings.json");
//var config = builder.Build();
//string connectionString = config.GetConnectionString("DefaultConnection");
//var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
//var options = optionsBuilder.UseSqlServer(connectionString).Options;
var option = new DbContextOptionsBuilder<ApplicationContext>()
    .UseSqlServer("Server=DESKTOP-MFCNCQ9\\SQLEXPRESS;Database=HomeWorkDb;Trusted_Connection=True;").Options;

using var Database = new ApplicationContext(option);
using (ApplicationContext db = new ApplicationContext(option))
{
    Client stas = new Client
    {
        Name = "Stas",
       Surname = "Ivanov",
        Phone = "093-123-45-67"
       
    };
    db.Clients.Add(stas);

    Delivery courierDelivery = new Delivery
    {
        
        DeliveryType = "Courier delivery",
        DateOf = "24.07.2022",
        Status = "Performed"
    };
    db.Deliveryes.Add(courierDelivery);

    Office office = new Office
    {
        Address = "Kyiv, st. Pushkin, d.1"
    };
    db.Offices.Add(office);

    Worker worker = new Worker
    {
        Name = "Ivan",
        Surname = "Grim",
        Phone = "4-45-54",
        Email = "I.Grim.2000",
        Position = "Accountant",
        Salary = 1500,
        Office = office
    };
    db.Workers.Add(worker);

    Order order = new Order
    {
        Status = "Performed",
        DateOf = "24.07.2022",
        Delivery = courierDelivery
    };
    db.Orders.Add(order);
    

    Product product = new Product
    {
        Name = "Heineken",
        Type = "Beer"
    };
    db.Products.Add(product);

    db.SaveChanges();
    Console.WriteLine("Successfully saved");



    var clients = db.Clients.ToList();
    Console.WriteLine("Список клиентов:");
    foreach (Client x in clients)
    {
        Console.WriteLine($"{x.Id}.{x.Name} - {x.Surname} - {x.Phone}");
    }

    var products = db.Products.ToList();
    Console.WriteLine("Список товаров:");
    foreach (Product y in products)
    {
        Console.WriteLine($"{y.Id}.{y.Name} - {y.Type}");
    }

    var workers = db.Workers.Include(y => y.Office).ToList();
    foreach (var z in workers)
        Console.WriteLine($"{z.Name} - {z.Office.Id} - {z.Office.Address}");
}

     
