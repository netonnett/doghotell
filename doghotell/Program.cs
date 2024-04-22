namespace doghotell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            dogHotel.PrintInfo();

            Console.ForegroundColor = ConsoleColor.Yellow;


        }
        static void AddTestData(DogHotel dogHotel)
        {
            adress tryname = new adress("fishstreet ", "tamanrasset ", "309211");
            adress tryname2 = new adress("st.alfonsostreet ", "volgograd ", "478902");
            Owner owner = new Owner("Pelle ", "Andersson", tryname);
            Owner owner2 = new Owner("Bertil ", "von Hederburg", tryname2);
            Dog testDog1 = new Dog("fido", "123456", owner);
            Dog testDog2 = new Dog("lassie", "654321,", owner2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);
        }

    }
}