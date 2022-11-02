using ConsoleApp7;
using System.IO;
using System.Xml.Linq;

Cats Cat1 = new Cats();
Cat1.name = "Снежок";
Cat1.poroda = "Веслоухий";
Cat1.age = "2";


Cats Cat2 = new Cats();
Cat2.name = "Телепузик";
Cat2.poroda = "Немец";
Cat2.age = "9";

Cats Cat3 = new Cats();
Cat3.name = "Бушар";
Cat3.poroda = "Британец";
Cat3.age = "1";


Cats[] cats = new Cats[3];
cats[0] = Cat1;
cats[1] = Cat2;
cats[2] = Cat3;

Controller controller = new Controller();

controller.Save(cats);
string path = "cats.json";


var t = controller.Load(path); 
foreach (var item in t)
{
    Console.WriteLine("{0} {1} {2} " , item.name, item.poroda, item.age);
}