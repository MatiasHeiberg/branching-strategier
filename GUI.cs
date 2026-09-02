namespace branching_strategi
{
    public class GUI
    {
        bool flag = false;

        public GUI()
        {
            Startup();
        }

        public void tdfwdwadf()
        {
            // dadawidjawiodjaodjow
        }

        public void Startup()
        {
            while (!flag)
            {
                Console.Clear();
                Console.WriteLine("---- VELKOMMEN TIL LOMMEREGNER 9000 EXTREME ----\n");
                Console.WriteLine("---- AFSLUT VED AT TRYKKE 'Q' ----");
                Console.WriteLine("---- INDTAST REGNESTYKKE OG TRYK ENTER FOR UDREGNING' ----\n\n");

                string? userInteraction = PromptUserCalculation();

                if (userInteraction != null)
                {
                    // DEL UD I UDREGNINGER
                    if (userInteraction.ToLower() == "q")
                    {
                        flag = true;
                    }
                }
                else
                {
                    Startup();
                }
            }

        }

        public string? PromptUserCalculation()
        {
            Console.Write("Indtast din regnestykke: ");
            return Console.ReadLine();
        }


    }
}
