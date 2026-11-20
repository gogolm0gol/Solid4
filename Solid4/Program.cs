using System;

namespace Solid_4
{
    
    interface IPriced
    {
        void SetPrice(double price);
    }

    interface IDiscountable
    {
        void ApplyDiscount(string discount);
        void ApplyPromocode(string promocode);
    }

    interface ISizedColorable
    {
        void SetColor(byte color);
        void SetSize(byte size);
    }

    class Book : IPriced, IDiscountable
    {
        public double Price { get; private set; }

        public void SetPrice(double price)
        {
            Price = price;
            Console.WriteLine($"Ціну книги встановлено: {Price} грн");
        }

        public void ApplyDiscount(string discount)
        {
            Console.WriteLine($"До книги застосовано знижку: {discount}");
        }

        public void ApplyPromocode(string promocode)
        {
            Console.WriteLine($"Застосовано промокод для книги: {promocode}");
        }
    }

    class Outerwear : IPriced, IDiscountable, ISizedColorable
    {
        public double Price { get; private set; }
        public byte Color { get; private set; }
        public byte Size { get; private set; }

        public void SetPrice(double price)
        {
            Price = price;
            Console.WriteLine($"Ціну одягу встановлено: {Price} грн");
        }

        public void ApplyDiscount(string discount)
        {
            Console.WriteLine($"До одягу застосовано знижку: {discount}");
        }

        public void ApplyPromocode(string promocode)
        {
            Console.WriteLine($"Застосовано промокод для одягу: {promocode}");
        }

        public void SetColor(byte color)
        {
            Color = color;
            Console.WriteLine($"Колір одягу встановили у код: {Color}");
        }

        public void SetSize(byte size)
        {
            Size = size;
            Console.WriteLine($"Розмір одягу встановлено: {Size}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ТОВАР: КНИГА ===");
            Book myBook = new Book();
            myBook.SetPrice(350);
            myBook.ApplyDiscount("15%");
            myBook.ApplyPromocode("BOOK2026");

            Console.WriteLine("\n=== ТОВАР: ВЕРХНІЙ ОДЯГ ===");
            Outerwear jacket = new Outerwear();
            jacket.SetPrice(2500);
            jacket.SetSize(52);
            jacket.SetColor(3);
            jacket.ApplyDiscount("20%");

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}