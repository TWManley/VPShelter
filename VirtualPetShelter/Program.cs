using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualpetShelter theBigHouse = new VirtualpetShelter();
            Animals petOne = new Animals();
           Manager manager = new Manager();
            


            int playerInput;
            int managerInput;
            int volunteerInput;
            string petKind;
            string feedPet;
            string playPet;





            Console.WriteLine("welcome to the big house a virtual pet shelter");
            Console.WriteLine("enter 1 to be the manager");
            Console.WriteLine("enter 2 to be a volunteer");
            playerInput = int.Parse(Console.ReadLine());



            do
            {
                if (playerInput == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your time and managing the Big house");
                    Console.WriteLine("what are you going to do first?");
                    Console.WriteLine(" enter 1 to adopt a pet");
                    Console.WriteLine(" enter 2 to feed the pets");
                    Console.WriteLine(" enter 3 to play with the pets");
                    Console.WriteLine(" enter 4 to quit");
                    managerInput = int.Parse(Console.ReadLine());



                    if (managerInput == 1) 
                    petOne.SeeAnimalInfo();
                    Console.WriteLine("which of the pets have found a home cat, dog, or gecko?");
                    petKind = Console.ReadLine().ToLower();
                    if (petKind == "cat")
                    {
                        petOne.CatAdopted();
                        Console.WriteLine("press the enter key");
                        Console.ReadLine();
                        continue;

                    }
                    else if (petKind == "dog")
                    {
                        petOne.DogAdopted();
                        Console.WriteLine(" press the enter key");
                        Console.ReadLine();
                        continue;


                    }
                    else if (petKind == "gecko")
                    {
                        petOne.GeckoAdopted();
                        Console.WriteLine("press the enter key");
                        Console.ReadLine();
                        continue;


                    }
                    else if (managerInput == 2)
                    {
                        Console.WriteLine("feeding time which animal is going to get fed? cat, dog, gecko");
                        feedPet = Console.ReadLine().ToLower();
                        if (feedPet == "cat")
                        {
                            
                            petOne.CatEat();
                            petOne.SeeAnimalInfo();
                            Console.WriteLine("press the enter key");
                            Console.ReadLine();
                            continue;

                        }
                        else if (feedPet == "dog")
                        {
                            manager.Feed();
                            petOne.DogEat();
                            petOne.SeeAnimalInfo();
                            Console.WriteLine("press the enter key");
                            Console.ReadLine();
                            continue;

                        }
                        else if (feedPet == "gecko")
                        {
                          manager.Feed();
                            petOne.Geckoeat();
                            petOne.SeeAnimalInfo();
                            Console.WriteLine("press the enter key");
                            Console.ReadLine();
                            continue;

                        }






                    }
                    else if (managerInput == 3)
                    {
                        Console.WriteLine("which animal do you want to play with cat, dog, or gecko");
                        playPet = Console.ReadLine().ToLower();
                        if (playPet == "cat")
                        {
                            manager.Play();
                            petOne.Playing();
                            Console.WriteLine("press enter to keep playing");
                            Console.ReadLine();
                            continue;



                        }
                        else if (playPet == "dog")
                        {
                            manager.Play();
                            petOne.Playing();
                            Console.WriteLine("press enter to keep playing");
                            Console.ReadLine();
                            continue;

                        }
                        else if (playPet == "gecko")
                        {
                            manager.Play();
                            petOne.Playing();
                            Console.WriteLine("press enter to keep playing");
                            Console.ReadLine();
                            continue;


                        }
                        else if (managerInput == 4)
                        {
                            break;


                        }
                        else
                        {
                            Console.WriteLine("enter a number between 1 and 4 to make a choice");
                            Console.WriteLine("press enter to keep playing");
                            Console.ReadLine();
                            continue;

                        }





                    }
                    else if (playerInput == 2)
                    {
                        Console.ReadLine();
                        Volunteer volunteer = new Volunteer();
                        Console.WriteLine("thank you for your time here at the big house");
                        Console.WriteLine("this is the current staus of the animals");
                        petOne.SeeAnimalInfo();
                        Console.WriteLine("what do you want to help with?");
                        Console.WriteLine("1 feed the animals");
                        Console.WriteLine("2 to water the animals");
                        Console.WriteLine("3 play with the animals");
                        Console.WriteLine("4 to quit");
                        volunteerInput = int.Parse(Console.ReadLine());

                        if (volunteerInput == 1)
                        {
                            Console.WriteLine("which of the animals do you want to feed cat, dog, gecko?");
                            string volChoice = Console.ReadLine().ToLower();
                            petOne.SeeAnimalInfo();
                            if (volChoice == "cat")
                            {
                                volunteer.Feed();
                                petOne.PetHunger -= 20;
                                petOne.TickAttribute();
                                Console.WriteLine("press enter to keep playing");
                                Console.ReadLine();
                                continue;


                            }
                            else if (volChoice == "dog")
                            {
                                volunteer.Feed();
                                petOne.PetHunger -= 15;
                                petOne.TickAttribute();
                                Console.WriteLine("press enter to keep playing");
                                Console.ReadLine();
                                continue;

                            }
                            else if (volChoice == "gecko")
                            {
                                volunteer.Feed();
                                petOne.PetHunger -= 25;
                                petOne.TickAttribute();
                                Console.WriteLine("press enter to keep playing");
                                Console.ReadLine();
                                continue;

                            }
                            else if (playerInput == 2)
                            {
                                Console.WriteLine("which of the animals do you want to give water to cat, dog, gecko?");
                                string VolChoice = Console.ReadLine().ToLower();
                                petOne.SeeAnimalInfo();

                                if (VolChoice == "cat")
                                {
                                    volunteer.Water();
                                    petOne.Energy -= 15;
                                    petOne.TickAttribute();
                                    petOne.SeeAnimalInfo();
                                    Console.WriteLine("press enter to keep playing");
                                    Console.ReadLine();
                                    continue;

                                }
                                else if (VolChoice == "dog")
                                {
                                    volunteer.Water();
                                    petOne.Energy -= 10;
                                    petOne.TickAttribute();
                                    petOne.SeeAnimalInfo();
                                    Console.WriteLine("press enter to keep playing");
                                    Console.ReadLine();
                                    continue;

                                }
                                else if (VolChoice == "gecko")
                                {
                                    volunteer.Water();
                                    petOne.Energy -= 15;
                                    petOne.TickAttribute();
                                    petOne.SeeAnimalInfo();
                                    Console.WriteLine("press enter to keep playing");
                                    Console.ReadLine();
                                    continue;

                                }
                                else if (playerInput == 3)
                                {
                                    Console.WriteLine("which of the animals would you like to play with cat, dog, or gecko?");
                                    string petPlay = Console.ReadLine().ToLower();
                                    if (petPlay == "cat")
                                    {
                                        volunteer.Play();
                                        petOne.Playing();
                                        Console.WriteLine("press enter to keep playing");
                                        Console.ReadLine();
                                        continue;


                                    }
                                    else if (petPlay == "dog")
                                    {
                                        volunteer.Play();
                                        petOne.Playing();
                                        Console.WriteLine("press enter to keep playing");
                                        Console.ReadLine();
                                        continue;


                                    }
                                    else if (petPlay == "gecko")
                                    {
                                        volunteer.Play();
                                        petOne.Playing();
                                        Console.WriteLine("press enter to keep playing");
                                        Console.ReadLine();
                                        continue;

                                    }
                                    else if (volunteerInput == 4)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("enter a number between 1 and 4 to continue playing");
                                        Console.WriteLine("press enter to keep playing");
                                        Console.ReadLine();
                                        continue;


                                    }


                                }





                            }



                        }

                    }





                }

                {


                }














                
            } while (playerInput != 5);






        }

        private class manager
        {
            internal static void Play()
            {
                throw new NotImplementedException();
            }
        }
    }
}
