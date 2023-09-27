// SUPERCLASS PROCESSOR
class Processor
{
    public string merk;
    public string tipe;

    public Processor(string Merk, string Tipe)
    {
        this.merk = Merk;
        this.tipe = Tipe;
    }
}

class Intel : Processor
{
    public Intel(string Tipe) : base("Intel", Tipe)
    {}
}

class CoreI3 : Intel
{
    public CoreI3() : base("Core i3")
    {}
}

class CoreI5 : Intel
{
    public CoreI5() : base("Core i5")
    {}
}

class CoreI7 : Intel
{
    public CoreI7() : base("Core i7")
    {}
}

class AMD : Processor
{
    public AMD(string Tipe) : base("AMD", Tipe)
    {}
}
 class Ryzen : AMD
{
    public Ryzen() : base("RAYZEN")
    {}
}

class Athlon : AMD
{
    public Athlon() : base("ATHLON")
    {}
}

// SUPERCLASS VGA
class Vga
{
    public string merk;

    public Vga(string Merk)
    {
        this.merk = Merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia") 
    {}
}

class Amd : Vga
{
    public Amd() : base("Amd")
    {}
}

// SUPERCLASS LAPTOP
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string Tipe, Vga Vvga, Processor Pprocessor)
    {
        this.merk = "ASUS";
        this.tipe = Tipe;
        this.vga = Vvga;
        this.processor = Pprocessor;
    }
}

class ROG : ASUS
{
    public ROG(Vga Vvga, Processor Pprocessor) : base("ROG", Vvga, Pprocessor)
    {}
}

class Vivobook : ASUS
{
    public Vivobook(Vga Vvga, Processor Pprocessor) : base("Vivobook", Vvga, Pprocessor)
    {}

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string Tipe, Vga Vvga, Processor Pprocessor)
    {
        this.merk = "ACER";
        this.tipe = Tipe;
        this.vga = Vvga;
        this.processor = Pprocessor;
    }
}

class Swift : ACER
{
    public Swift(Vga Vvga, Processor Pprocessor) : base("Swift", Vvga, Pprocessor)
    {}
}

class Predator : ACER
{
    public Predator(Vga Vvga, Processor Pprocessor) : base("Predator", Vvga, Pprocessor)
    {
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string Tipe, Vga Vvga, Processor Pprocessor)
    {
        this.merk = "Lenovo";
        this.tipe = Tipe;
        this.vga = Vvga;
        this.processor = Pprocessor;
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad(Vga Vvga, Processor Pprocessor) : base("IdeaPad", Vvga, Pprocessor)
    {}
}

class Legion : Lenovo
{
    public Legion(Vga Vvga, Processor Pprocessor) : base("Legion", Vvga, Pprocessor)
    {
        base.tipe = "Legion";
    }
}


class Program
{
    public static void Main(string[] args)
    {

        ////jawaban no 1
        //Laptop laptop2 = new IdeaPad(new Amd(), new Ryzen());
        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();

        //// Jawaban NO 2
        //Laptop laptop1 = new Vivobook(new Nvidia(), new CoreI5());
        ////laptop1.Ngoding(); //Dicomment karena tidak bisa dijalankan (a.k.a error)

        //////// Jawaban NO 3
        //Console.WriteLine($"Merk Vga = {laptop1.vga}");
        //Console.WriteLine($"Merk Processor = {laptop1.processor.merk}");
        //Console.WriteLine($"Tipe Processor = {laptop1.processor.tipe}");

        //// Jawaban NO 4
        //// Variabel predators
        //Predator predator = new Predator(new Amd(), new CoreI7());
        //predator.BermainGame();

        ////// Jawaban NO 5
        //ACER acer = new Predator(new Amd(), new CoreI7());
        //acer.vga = new Amd();
        //acer.processor = new CoreI7();
        //acer.BermainGame();

    }
}

