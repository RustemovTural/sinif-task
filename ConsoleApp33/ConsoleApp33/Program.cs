namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>();

            int choice;
            do
            {
                Console.WriteLine("******Menu******");
                Console.WriteLine("1. Sisteme giris");
                Console.WriteLine("0. Cixis");
                Console.Write("Seciminiz: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Sisteme giris");
                        Console.WriteLine("1. Hotel yarat");
                        Console.WriteLine("2. Butun Hotelleri gor");
                        Console.WriteLine("3. Hotel sec");
                        Console.WriteLine("0. Exit");

                        int subChoice = int.Parse(Console.ReadLine());
                        switch (subChoice)
                        {
                            case 1:
                                Console.WriteLine("Hotel adini daxil edin: ");
                                string hotelName = Console.ReadLine();
                                Hotel hotel = new Hotel(hotelName);
                                hotels.Add(hotel);
                                Console.WriteLine("Hotel yaradildi.");
                                break;
                            case 2:
                                Console.WriteLine("Butun Hoteller:");
                                foreach (var h in hotels)
                                {
                                    Console.WriteLine($"Hotel Id: {h.Id}, Name: {h.Name}");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Hotelin adini daxil edin: ");
                                string selectedHotelName = Console.ReadLine();
                                Hotel selectedHotel = hotels.Find(h => h.Name == selectedHotelName);
                                if (selectedHotel != null)
                                {
                                    int hotelChoice;
                                    do
                                    {
                                        Console.WriteLine("*-*-*-Hotel Menu*-*-*-");
                                        Console.WriteLine("1. Room yarat");
                                        Console.WriteLine("2. Roomlari gor");
                                        Console.WriteLine("3. Rezervasya et");
                                        Console.WriteLine("4. Evvelki menuya qayit");
                                        Console.WriteLine("0. Exit");

                                        Console.Write("Seciminiz: ");
                                        hotelChoice = int.Parse(Console.ReadLine());

                                        switch (hotelChoice)
                                        {
                                            case 1:
                                                Console.WriteLine("Room adini daxil edin: ");
                                                string roomName = Console.ReadLine();
                                                Console.WriteLine("Roomun qiymetini daxil edin: ");
                                                decimal roomPrice = decimal.Parse(Console.ReadLine());
                                                Console.WriteLine("Roomun person capacity-sini daxil edin: ");
                                                int personCapacity = int.Parse(Console.ReadLine());
                                                Room newRoom = new Room(roomName, roomPrice, personCapacity);
                                                selectedHotel.AddRoom(newRoom);
                                                Console.WriteLine("Room yaradildi.");
                                                break;
                                            case 2:
                                                Console.WriteLine("Hoteldeki Butun Otaqlar:");
                                                foreach (var r in selectedHotel.GetAllRooms())
                                                {
                                                    Console.WriteLine(r);
                                                }
                                                break;
                                            case 3:
                                                Console.WriteLine("Rezervasya etmek istediyiniz otaqin Id-sini daxil edin: ");
                                                int roomId = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Musteri sayini daxil edin: ");
                                                int customerCount = int.Parse(Console.ReadLine());
                                                try
                                                {
                                                    selectedHotel.MakeReservation(roomId, customerCount);
                                                    Console.WriteLine("Rezervasya edildi.");
                                                }
                                                catch (NotAvailableException ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                }
                                                break;
                                            case 4:
                                                break;
                                            case 0:
                                                Environment.Exit(0);
                                                break;
                                            default:
                                                Console.WriteLine("Duzgun secim edin!");
                                                break;
                                        }
                                    } while (hotelChoice != 4);
                                }
                                else
                                {
                                    Console.WriteLine("Hotel tapilmadi.");
                                }
                                break;
                            case 0:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Duzgun secim edin!");
                                break;
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin!");
                        break;
                }
            } while (choice != 0);
        }
    }
    }

