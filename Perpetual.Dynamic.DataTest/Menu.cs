
partial class Menu
{
    public void Show()
    {

        var util = new utils();

        while (true) 
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("CHOOSE A OPTION 1= ADD / 2= DELETE / 3= Exit");

            var val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
                util.Add();
            }
            if (val == 2)
            {
                util.ShowPersons();
            }
            if (val == 3)
            {
                Console.WriteLine("THANK YOU COME AGAIN");
                break;
            }
        }

    }
   

}

