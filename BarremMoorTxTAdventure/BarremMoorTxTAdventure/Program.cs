namespace BarremMoorTxTAdventure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person x = new Person();
            x.creation();
            x.intro();
            
            reach player = new reach();
            player.function(2);
            Console.ReadLine();

        }
    }
    class Person
    {
        int correct = 0;

        //Strings:
        string Player_Gender;
        string Input;

        public void creation()
        {
              //Character Creation:
             do
            {
                Console.Clear();
                Console.WriteLine("Please choose a gender as below:");
                Console.WriteLine("Male / Female");
                Player_Gender = Console.ReadLine().ToUpper();
                if (Player_Gender == "MALE" || Player_Gender == "FEMALE")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Player Description
            Console.Clear();
            Console.WriteLine("Your Full Character Gender, is:");
            Console.WriteLine(Player_Gender);
            Console.ReadLine();

        }

        public void intro()
        {

            //Introduction
            do
            {
                Console.Clear();
                Console.WriteLine("You awaken to find yourself in a Barren Moor. It's dark and there seems to be no end in sight.");
                Console.WriteLine("Try looking around to see if you can find anything to help you ('USE LOOK')");
                Input = Console.ReadLine().ToUpper();
                if (Input == "LOOK")
                {
                    do
                    {
                        Console.WriteLine("You look around and you see seemingly endless land. You feel something in your pocket and notice a compass");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        { correct = 1; }
                        if (Input != "BACK")
                        { correct = 0; }
                    } while (correct == 0);
                }


            } while (correct == 0);

            Console.ReadLine();
        }

        public void playerposition(int pos)
        {
         
        }
           class reach
    {
        public void function(int player)
        {
            if ((player >= 1 && player <= 2))
            {
                switch (player)
                {
                    case 1:
                        Console.WriteLine("Game Won!");
                        break;
                    case 2:
                    Console.WriteLine("Treasure Found!");
                        break;

                }
            }
            else Console.WriteLine("Go back to Start");
        }
    

    }

}
