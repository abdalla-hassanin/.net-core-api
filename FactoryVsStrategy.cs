using System;

namespace FactoryAndStrategyExample
{
    // واجهة تمثل فئة التذكرة
    public interface ITicket
    {
        void ShowDetails();
        decimal CalculatePrice(decimal basePrice);
    }

    // واجهة تمثل استراتيجية حساب السعر
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice);
    }

    // استراتيجيات حساب السعر المختلفة
    public class RegularPricing : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice;  // السعر الأساسي بدون خصومات
        }
    }

    public class SeasonalDiscountPricing : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice * 0.9m;  // خصم 10% خلال موسم التخفيضات
        }
    }

    public class InternationalFlightPricing : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice + 200;  // رسوم إضافية على الرحلات الدولية
        }
    }

    // التذكرة الاقتصادية
    public class EconomyTicket : ITicket
    {
        private IPricingStrategy _pricingStrategy;

        public EconomyTicket(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Economy Class Ticket: Basic amenities, no extra perks.");
        }

        public decimal CalculatePrice(decimal basePrice)
        {
            return _pricingStrategy.CalculatePrice(basePrice);
        }
    }

    // تذكرة الأعمال
    public class BusinessTicket : ITicket
    {
        private IPricingStrategy _pricingStrategy;

        public BusinessTicket(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Business Class Ticket: More space, better service.");
        }

        public decimal CalculatePrice(decimal basePrice)
        {
            return _pricingStrategy.CalculatePrice(basePrice);
        }
    }

    // تذكرة الدرجة الأولى
    public class FirstClassTicket : ITicket
    {
        private IPricingStrategy _pricingStrategy;

        public FirstClassTicket(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public void ShowDetails()
        {
            Console.WriteLine("First Class Ticket: Premium experience with luxury amenities.");
        }

        public decimal CalculatePrice(decimal basePrice)
        {
            return _pricingStrategy.CalculatePrice(basePrice);
        }
    }

    // Factory Method لإنشاء التذاكر
    public abstract class TicketFactory
    {
        public abstract ITicket CreateTicket();
    }

    public class EconomyTicketFactory : TicketFactory
    {
        private IPricingStrategy _pricingStrategy;

        public EconomyTicketFactory(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public override ITicket CreateTicket()
        {
            return new EconomyTicket(_pricingStrategy);
        }
    }

    public class BusinessTicketFactory : TicketFactory
    {
        private IPricingStrategy _pricingStrategy;

        public BusinessTicketFactory(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public override ITicket CreateTicket()
        {
            return new BusinessTicket(_pricingStrategy);
        }
    }

    public class FirstClassTicketFactory : TicketFactory
    {
        private IPricingStrategy _pricingStrategy;

        public FirstClassTicketFactory(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public override ITicket CreateTicket()
        {
            return new FirstClassTicket(_pricingStrategy);
        }
    }

    // البرنامج الرئيسي لتجربة المصنع والاستراتيجية
    class Program
    {
        static void Main(string[] args)
        {
            // إنشاء مصنع لتذكرة اقتصادية مع استراتيجية تسعير عادية
            TicketFactory economyFactory = new EconomyTicketFactory(new RegularPricing());
            ITicket economyTicket = economyFactory.CreateTicket();
            economyTicket.ShowDetails();
            Console.WriteLine("Ticket Price: " + economyTicket.CalculatePrice(1000));  // سعر التذكرة

            Console.WriteLine();

            // إنشاء مصنع لتذكرة أعمال مع استراتيجية خصم موسمي
            TicketFactory businessFactory = new BusinessTicketFactory(new SeasonalDiscountPricing());
            ITicket businessTicket = businessFactory.CreateTicket();
            businessTicket.ShowDetails();
            Console.WriteLine("Ticket Price: " + businessTicket.CalculatePrice(2000));  // سعر التذكرة

            Console.WriteLine();

            // إنشاء مصنع لتذكرة درجة أولى مع استراتيجية رسوم إضافية على الرحلات الدولية
            TicketFactory firstClassFactory = new FirstClassTicketFactory(new InternationalFlightPricing());
            ITicket firstClassTicket = firstClassFactory.CreateTicket();
            firstClassTicket.ShowDetails();
            Console.WriteLine("Ticket Price: " + firstClassTicket.CalculatePrice(5000));  // سعر التذكرة
        }
    }
}
