using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public enum Size {Small = 599, Medium = 699, Large = 799};
    public enum Topping {peperoni = 50, sausage = 50, bacon = 50, peppers = 50, mushrooms = 50};
    public enum Crust {handTossed = 0, thin = 150, deepDish = 300};
    public enum Cheese {mozzerella = 0, threeCheese = 150, sixCheese = 300};
    public enum Sauce { regular = 0, buffalo = 150, barbque = 150 };
    public class Pizza
    {
        
        private float totalPrice = 0;

        private string size;
        private string topping;
        private string crust;
        private string cheese;
        private string sauce;

        public string getSize()
        {
            return size;
        }

        public void setSize(string size)
        {
            this.size = size;
        }

        public string getTopping()
        {
            return topping;
        }

        public void setTopping(string topping)
        {
            this.topping = topping;
        }

        public string getCrust()
        {
            return crust;
        }

        public void setCrust(string crust)
        {
            this.crust = crust;
        }

        public string getCheese()
        {
            return cheese;
        }

        public void setCheese(string cheese)
        {
            this.cheese = cheese;
        }

        public string getSauce()
        {
            return sauce;
        }

        public void setSauce(string sauce)
        {
            this.sauce = sauce;
        }

        public float getTotalPrice()
        {
            return totalPrice / 100;
        }

        public void addToPrice(float price)
        {
            this.totalPrice = totalPrice + price;
        }

        public List<string> Options = new List<string>();

        public void createOptions()
        {
            Options.Add("Small\t5.99");
            Options.Add("Medium\t6.99");
            Options.Add("Large\t7.99");
        }
    }

    public class PizzaBuilder
    {

        Pizza pizza = new Pizza();

        Topping _top;
        Size _size;
        Crust _crust;
        Cheese _cheese;
        Sauce _sauce;
        public PizzaBuilder withTopping(string topping)
        {
            
            pizza.setTopping(topping);
            _top = (Topping)Enum.Parse(typeof(Topping), topping);
            pizza.addToPrice((float)_top);
            return this;
        }

        public PizzaBuilder withSize(string size)
        {
            pizza.setSize(size);
            _size = (Size)Enum.Parse(typeof(Size), size);
            pizza.addToPrice((float)_size);
            return this;
        }

        public PizzaBuilder withCrust(string crust)
        {
            pizza.setCrust(crust);
            _crust = (Crust)Enum.Parse(typeof(Crust), crust);
            pizza.addToPrice((float)_crust);
            return this;
        }

        public PizzaBuilder withCheese(string cheese)
        {
            pizza.setCheese(cheese);
            _cheese = (Cheese)Enum.Parse(typeof(Cheese), cheese);
            pizza.addToPrice((float)_cheese);
            return this;
        }

        public PizzaBuilder withSauce(string sauce)
        {
            pizza.setCrust(sauce);
            _sauce = (Sauce)Enum.Parse(typeof(Sauce), sauce);
            pizza.addToPrice((float)_sauce);
            return this;
        }

        public Pizza build()
        {
            return pizza;
        }

        public double calculatePrice()
        {
            return pizza.getTotalPrice();
        }

    }

    public class customer
    {
        private string name;
        private string address;
        private long cardNumber;
        private bool isCash;
        public customer(string _name, string _address, long _cardNumber, bool _isCash) {
            name = _name;
            address = _address;
            cardNumber = _cardNumber;
            isCash = _isCash;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public long getCardNumber()
        {
            return cardNumber;
        }

        public void setCardNumber(long cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public bool getIsCash()
        {
            return isCash;
        }

        public void setIsCash(bool isCash)
        {
            this.isCash = isCash;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string _crust = "";
            string _size = "";
            string _cheese = "";
            string _topping = "";
            string _sauce = "";
            string payment = "";
            long _cardNumber;
            bool _isCash;

            Console.WriteLine("Welcome to Oriented Pizzas!\n");

            Pizza fakePizza = new PizzaBuilder().build();
            Console.WriteLine("Size\t" + "Price\t");
            Console.WriteLine("-------------");
            fakePizza.createOptions();
            foreach (string p in fakePizza.Options)
                Console.WriteLine(p);

            Console.WriteLine("\nWhat size pizza would you like? Enter the size.");
            _size = Console.ReadLine();
            Console.Clear();

            
            foreach (string crust in Enum.GetNames(typeof(Crust)))
            {
                Console.WriteLine("{0}\t{1:D}\t", crust, 
                    ((((float)((int)(Enum.Parse(typeof(Crust), crust)))))/100).ToString("0.00"));
            }

            Console.WriteLine("\nWhat stlye crust would you like? Enter crust name.");
            _crust = Console.ReadLine();
            Console.Clear();

            foreach (string sauce in Enum.GetNames(typeof(Sauce)))
            {
                Console.WriteLine("{0}\t  {1:D}\t", sauce, 
                    ((((float)((int)(Enum.Parse(typeof(Sauce), sauce))))) / 100).ToString("0.00"));
            }

            Console.WriteLine("\nWhat kind of sauce would you like? Enter sauce name.");
            _sauce = Console.ReadLine();
            Console.Clear();

            foreach (string cheese in Enum.GetNames(typeof(Cheese)))
            {
                Console.WriteLine("{0}\t{1:D}\t", cheese, 
                    ((((float)((int)(Enum.Parse(typeof(Cheese), cheese))))) / 100).ToString("0.00"));
            }

            Console.WriteLine("\nWhat cheese would you like? Enter cheese name.");
            _cheese = Console.ReadLine();
            Console.Clear();

            foreach (string topping in Enum.GetNames(typeof(Topping)))
            {
                Console.WriteLine("{0}\t{1:D}\t", topping, 
                    ((((float)((int)(Enum.Parse(typeof(Topping), topping))))) / 100).ToString("0.00"));
            }

            Console.WriteLine("\nWhat topping would you like? Enter topping name.");
            _topping = Console.ReadLine();
            Console.Clear();

            Pizza pizza = new PizzaBuilder().withCrust(_crust).withTopping(_topping)
                .withSize(_size).withCheese(_cheese).withSauce(_sauce).build();

            float price = pizza.getTotalPrice();
            Console.WriteLine("You're pizza is " + price.ToString("0.00") + " are you paying with cash or card? Enter cash or card.");
            payment = Console.ReadLine();
            Console.Clear();


            if(payment == "card")
            {
                _isCash = false;
                Console.WriteLine("What is your card number?");
                _cardNumber = long.Parse(Console.ReadLine());
                Console.Clear();
            }
            else
            {
                _isCash = true;
                _cardNumber = 0;
            }

            Console.WriteLine("What is the name for the order? Enter it below.");
            string _name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Where would your pizza delivered? Enter an adress.");
            string _address = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Thanks for choosing Oriented Pizza " + _name + ", your order has been submitted.");
            Console.ReadLine();
            Console.Clear();
        
            customer newCust = new customer(_name, _address, _cardNumber, _isCash);
        }
    }
}