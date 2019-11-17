namespace WebApplicationHW7.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplicationHW7.Models;

    public class ProductContext : DbContext
    {
        // Контекст настроен для использования строки подключения "ProductContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebApplicationHW7.DataAccess.ProductContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ProductContext" 
        // в файле конфигурации приложения.
        public ProductContext()
            : base("name=ProductContext")
        {
        }


        public DbSet<Product> Products { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}