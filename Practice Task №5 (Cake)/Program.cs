using System.ComponentModel.Design;

namespace Practice_Task__5__Cake_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Items Circle = new Items();
            Circle.Name = "Круг";
            Circle.Cost = 500;
            Items Kvadrat = new Items();
            Kvadrat.Name = "Квадрат";
            Kvadrat.Cost = 500;
            Items Hearth = new Items();
            Hearth.Name = "Сердечко";
            Hearth.Cost = 700;
            List<Items> Shapes = new List<Items>();
            Shapes.Add(Circle);
            Shapes.Add(Kvadrat);
            Shapes.Add(Hearth);

            Items Small = new Items();
            Small.Name = "Маленький";
            Small.Cost = 1000;
            Items Medium = new Items();
            Medium.Name = "Средний";
            Medium.Cost = 1200;
            Items Big = new Items();
            Big.Name = "Большой";
            Big.Cost = 2000;
            List<Items> Sizes = new List<Items>();
            Sizes.Add(Small);
            Sizes.Add(Medium);
            Sizes.Add(Big);

            Items Vanilla = new Items();
            Vanilla.Name = "Ванильный";
            Vanilla.Cost = 100;
            Items Chocolate = new Items();
            Chocolate.Name = "Шоколадный";
            Chocolate.Cost = 100;
            Items Caramel = new Items();
            Caramel.Name = "Карамельный";
            Caramel.Cost = 150;
            List<Items> Taste = new List<Items>();
            Taste.Add(Vanilla);
            Taste.Add(Chocolate);
            Taste.Add(Caramel);

            Items One = new Items();
            One.Name = "Один корж";
            One.Cost = 200;
            Items Two = new Items();
            Two.Name = "Два коржа";
            Two.Cost = 400;
            Items Three = new Items();
            Three.Name = "Три коржа";
            Three.Cost = 600;
            List<Items> Amount = new List<Items>();
            Amount.Add(One);
            Amount.Add(Two);
            Amount.Add(Three);

            Items chocolate = new Items();
            chocolate.Name = "Шоколад";
            chocolate.Cost = 100;
            Items cramel = new Items();
            cramel.Name = "Карамель";
            cramel.Cost = 100;
            Items bize = new Items();
            bize.Name = "Безе";
            bize.Cost = 150;
            List<Items> glaze = new List<Items>();
            glaze.Add(chocolate);
            glaze.Add(cramel);
            glaze.Add(bize);

            Items chocolateDecor = new Items();
            chocolateDecor.Name = "Шоколадный";
            chocolateDecor.Cost = 150;
            Items berryDecor = new Items();
            berryDecor.Name = "Ягодный";
            berryDecor.Cost = 150;
            Items creamDecor = new Items();
            creamDecor.Name = "Кремовый";
            creamDecor.Cost = 150;
            List<Items> decor = new List<Items>();
            decor.Add(chocolateDecor);
            decor.Add(berryDecor);
            decor.Add(creamDecor);

            Order StokMenu = new Order();
            int Position = StokMenu.Arrows();

            Order Cake = new Order();
            Cake.SubMenu(Shapes, Sizes, Taste, Amount, glaze, decor);


            /*Console.WriteLine(Order.position_In_SubMenu);
            Console.ReadKey();

            List<string> MyOrder = Order.SaveTXT(position, Order.position_In_SubMenu);

            foreach (string item in MyOrder)
            {
                Console.WriteLine($"{item}; ");
            }
            Console.ReadKey();*/
        }
    }
}