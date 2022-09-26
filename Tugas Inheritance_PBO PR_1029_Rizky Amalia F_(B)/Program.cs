class Vga
{
    public string merk;
}

class vAMD : Vga
{
    public vAMD()
    {
        merk = "AMD";
    }
}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class Processor
{
    public string merk;
    public string tipe;
}

class pAMD : Processor
{
    public pAMD()
    {
        merk = "AMD";
    }
}

class Ryzen : pAMD
{
    public Ryzen() : base()
    {
        base.tipe = "RYZEN";
    }
}

class Athlon : pAMD
{
    public Athlon() : base()
    {
        base.tipe = "ATHLON";
    }
}

class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
}

class CoreI3 : Intel
{
    public CoreI3() : base()
    {

        base.tipe = "Core I3";
    }
}

class CoreI5 : Intel
{
    public CoreI5() : base()
    {
        base.tipe = "Core I5";
    }
}
class CoreI7 : Intel
{
    public CoreI7() : base()
    {
        base.tipe = "Core I7";
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;
    public void LaptopDinyalakan()
    {
        System.Console.WriteLine("Laptop " + merk + " " + tipe + " menyala");
    }
    public void LaptopDimatikan()
    {
        System.Console.WriteLine("Laptop " + merk + " " + tipe + " mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}

class ROG : ASUS
{
    public ROG() : base()
    {
        base.tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook() : base()
    {
        base.tipe = "Vivobook";
    }
    public void Ngoding()
    {
        System.Console.WriteLine("Ctak Ctak Ctak, error lagi!!!");
    }
}

class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift() : base()
    {
        base.tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator() : base()
    {
        base.tipe = "Predator";
    }

    public void BermainGame()
    {
        System.Console.WriteLine("Laptop " + merk + " " + tipe + " sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad() : base()
    {
        base.tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion() : base()
    {
        base.tipe = "Legion";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();

        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new vAMD();
        laptop2.processor = new Ryzen();

        Predator predator = new Predator();
        predator.vga = new vAMD();
        predator.processor = new CoreI7();

        ////Soal Modul No 1////
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        ////Soal Modul No 2////
        //laptop1.Ngoding(); ==> Jawaban 
        ((Vivobook)laptop1).Ngoding(); //==> Alternatif agar tidak error

        ////Soal Modul No 3////
        System.Console.WriteLine("Spesifikasi yang digunakan oleh laptop1 ====> Merk Vga " + laptop1.vga.merk + "; Merk Processor " + laptop1.processor.merk + "; Tipe Processor " + laptop1.processor.tipe + ";");

        ////Soal Modul No 4////
        predator.BermainGame();

        ////Soal Modul No 4////
        ACER acer = predator;
        ((Predator)acer).BermainGame();
    }
}

