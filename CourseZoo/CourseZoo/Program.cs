using CourseZoo;

class Program
{
    static Zoo zoo = new Zoo();
    static Show show = new Show();
    static DataStore dataStore = new DataStore();
    static DataGet dataGet = new DataGet();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Удалить животное");
            Console.WriteLine("3. Просмотреть всех животных");
            Console.WriteLine("4. Добавить работника");
            Console.WriteLine("5. Удалить работника");
            Console.WriteLine("6. Просмотреть всех работников");
            Console.WriteLine("7. Купить билет на шоу");
            Console.WriteLine("8. Посчитать стоймость посещения");
            Console.WriteLine("9. Сохранить данные в файл");
            Console.WriteLine("10. Загрузить данные из файла");
            Console.WriteLine("11. Поиск животного по имени");
            Console.WriteLine("12. Выход");
            Console.Write("Введите цифру с вашим вариантом: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите название животного: ");
                        string species = Console.ReadLine();
                        if(species.Contains('1') || species.Contains('2') || species.Contains('3') || species.Contains('4') ||
                            species.Contains('5') || species.Contains('6') || species.Contains('7') || species.Contains('8') ||
                            species.Contains('9') || species.Contains('0') || species.Contains('!') || species.Contains('@') ||
                            species.Contains('#') || species.Contains('$') || species.Contains('%') || species.Contains('^') ||
                            species.Contains('&') || species.Contains('*') || species.Contains('(') || species.Contains(')') ||
                            species.Contains('|') || species.Contains('/') || species.Contains(':') || species.Contains('"') ||
                            species.Contains("'") || species.Contains('<') || species.Contains('>') || species.Contains('?') ||
                            species.Contains(";") || species.Contains('-') || species.Contains(',') || species.Contains('.'))
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        Console.Write("Введите особенности животного: ");
                        string characteristics = Console.ReadLine();
                        if (characteristics.Contains('!') || characteristics.Contains('@') ||
                            characteristics.Contains('#') || characteristics.Contains('$') || characteristics.Contains('%') || characteristics.Contains('^') ||
                            characteristics.Contains('&') || characteristics.Contains('*') || characteristics.Contains('(') || characteristics.Contains(')') ||
                            characteristics.Contains('|') || characteristics.Contains('/') || characteristics.Contains(':') || characteristics.Contains('"') ||
                            characteristics.Contains("'") || characteristics.Contains('<') || characteristics.Contains('>') || characteristics.Contains('?') ||
                            characteristics.Contains("'") || characteristics.Contains('<') || characteristics.Contains('>') || characteristics.Contains('?') ||
                            characteristics.Contains(";") || characteristics.Contains('-') || characteristics.Contains(',') || characteristics.Contains('.'))
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        zoo.CreateAnimal(species, characteristics);
                        break;

                    case 2:
                        Console.Write("Введите низвание животного, которое хотите убрать: ");
                        string speciesToRemove = Console.ReadLine();
                        zoo.RemoveAnimal(speciesToRemove);
                        break;

                    case 3:
                        zoo.ViewAllAnimals();
                        break;

                    case 4:
                        Console.Write("Введите имя работника: ");
                        string name = Console.ReadLine();
                        if (name.Contains('1') || name.Contains('2') || name.Contains('3') || name.Contains('4') ||
                            name.Contains('5') || name.Contains('6') || name.Contains('7') || name.Contains('8') ||
                            name.Contains('9') || name.Contains('0') || name.Contains('!') || name.Contains('@') ||
                            name.Contains('#') || name.Contains('$') || name.Contains('%') || name.Contains('^') ||
                            name.Contains('&') || name.Contains('*') || name.Contains('(') || name.Contains(')') ||
                            name.Contains('|') || name.Contains('/') || name.Contains(':') || name.Contains('"') ||
                            name.Contains("'") || name.Contains('<') || name.Contains('>') || name.Contains('?') ||
                            name.Contains(";") || name.Contains('-') || name.Contains(',') || name.Contains('.'))
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        Console.Write("Введите название должности работника: ");
                        string job = Console.ReadLine();
                        if (job.Contains('1') || job.Contains('2') || job.Contains('3') || job.Contains('4') ||
                            job.Contains('5') || job.Contains('6') || job.Contains('7') || job.Contains('8') ||
                            job.Contains('9') || job.Contains('0') || job.Contains('!') || job.Contains('@') ||
                            job.Contains('#') || job.Contains('$') || job.Contains('%') || job.Contains('^') ||
                            job.Contains('&') || job.Contains('*') || job.Contains('(') || job.Contains(')') ||
                            job.Contains('|') || job.Contains('/') || job.Contains(':') || job.Contains('"') ||
                            job.Contains("'") || job.Contains('<') || job.Contains('>') || job.Contains('?') ||
                            job.Contains(";") || job.Contains('-') || job.Contains(',') || job.Contains('.'))
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        Console.Write("Введите зарплату работника: ");
                        int? salary = null;
                        if (int.TryParse(Console.ReadLine(), out int sal) && sal >= 0)
                            salary = sal;
                        Console.Write("Введите номер телефона работника: ");
                        string phone = Console.ReadLine();
                        phone = phone.ToLower();
                        if (phone.Contains('q') || phone.Contains('w') || phone.Contains('e') || phone.Contains('r') ||
                            phone.Contains('t') || phone.Contains('y') || phone.Contains('u') || phone.Contains('i') ||
                            phone.Contains('o') || phone.Contains('p') || phone.Contains('[') || phone.Contains(']') ||
                            phone.Contains('{') || phone.Contains('}') || phone.Contains('a') || phone.Contains('s') ||
                            phone.Contains('d') || phone.Contains('f') || phone.Contains('g') || phone.Contains('h') ||
                            phone.Contains('j') || phone.Contains('k') || phone.Contains('l') || phone.Contains(';') ||
                            phone.Contains(':') || phone.Contains('"') || phone.Contains("'") || phone.Contains('z') ||
                            phone.Contains('x') || phone.Contains('c') || phone.Contains('v') || phone.Contains('b') ||
                            phone.Contains('n') || phone.Contains('m') || phone.Contains('<') || phone.Contains('>') ||
                            phone.Contains('?') || phone.Contains('/') || phone.Contains('|') || phone.Contains('!') ||
                            phone.Contains('@') || phone.Contains('#') || phone.Contains('$') || phone.Contains('%') ||
                            phone.Contains('^') || phone.Contains('&') || phone.Contains('*') || phone.Contains('(') ||
                            phone.Contains(')') || phone.Contains('|') || phone.Contains('/')) 
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        zoo.CreateEmployee(name, salary, job, phone);
                        break;

                    case 5:
                        Console.Write("Введите имя работника, которого хотите удалить: ");
                        string nameToRemove = Console.ReadLine();
                        zoo.RemoveEmployee(nameToRemove);
                        break;

                    case 6:
                        zoo.ViewAllEmployees();
                        break;

                    case 7:
                        Console.WriteLine("Вы купили билет на шоу.");
                        show.ShowDescription();
                        break;

                    case 8:
                        Console.Write("Введите ФИО человека: ");
                        string userName = Console.ReadLine();
                        if (userName.Contains('1') || userName.Contains('2') || userName.Contains('3') || userName.Contains('4') ||
                            userName.Contains('5') || userName.Contains('6') || userName.Contains('7') || userName.Contains('8') ||
                            userName.Contains('9') || userName.Contains('0') || userName.Contains('!') || userName.Contains('@') ||
                            userName.Contains('#') || userName.Contains('$') || userName.Contains('%') || userName.Contains('^') ||
                            userName.Contains('&') || userName.Contains('*') || userName.Contains('(') || userName.Contains(')') ||
                            userName.Contains('|') || userName.Contains('/') || userName.Contains(':') || userName.Contains('"') ||
                            userName.Contains("'") || userName.Contains('<') || userName.Contains('>') || userName.Contains('?'))
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        User visitor = new User(userName);
                        Console.Write("Введите количество взрослых билетов: ");
                        if (int.TryParse(Console.ReadLine(), out int adultTickets) && adultTickets >= 0)
                            visitor.AdultTickets = adultTickets;
                        else
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        Console.Write("Введите количество детских билетов: ");
                        if (int.TryParse(Console.ReadLine(), out int childTickets) && childTickets >= 0)
                            visitor.ChildTickets = childTickets;
                        else
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }

                        Console.Write("Введите количество билетов со скидкой: ");
                        if (int.TryParse(Console.ReadLine(), out int discountTickets) && discountTickets >= 0)
                            visitor.DiscountTickets = discountTickets;
                        else
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }

                        Console.Write("Вы бы хотели приобрести участие в экскурсии? (y/n): ");
                        string guidedTourInput = Console.ReadLine();
                        if (guidedTourInput == "y" || guidedTourInput == "n")
                        {
                            visitor.Excursion = guidedTourInput.ToLower() == "y";
                        }
                        else
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }

                        Console.Write("Вы бы хотели докупить корм для животных? (y/n): ");
                        string animalFeedingInput = Console.ReadLine();
                        if (animalFeedingInput == "y" || animalFeedingInput == "n")
                        {
                            visitor.AnimalFood = animalFeedingInput.ToLower() == "y";
                        }
                        else
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }

                        Console.Write("Вы бы хотели приобрести абонемент в контактный зоопарк? (y/n): ");
                        string photoSessionInput = Console.ReadLine();
                        if (photoSessionInput == "y" || photoSessionInput == "n")
                        {
                            visitor.ContactZoo = photoSessionInput.ToLower() == "y";
                        }
                        else
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }

                        Console.Write("Вы бы хотели купить билет на шоу? (y/n): ");
                        string purchaseFantasyShowInput = Console.ReadLine();
                        if (purchaseFantasyShowInput == "y" || purchaseFantasyShowInput == "n")
                        {
                            visitor.Show = purchaseFantasyShowInput.ToLower() == "y";
                        }
                        else
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }

                        double totalCost = visitor.CalculateCost(zoo);
                        Console.WriteLine($"Итоговая цена: {totalCost}");
                        break;

                    case 9:
                        const string addFileName = "zoo_data.txt";
                        dataStore.SaveData(addFileName, zoo.GetAnimals(), zoo.GetEmployees());
                        Console.WriteLine($"Дата была сохранена в файл {addFileName} в корневой папке.");
                        break;

                    case 10:
                        Console.Write("Введите путь до файла: ");
                        string loadFilePath = Console.ReadLine();
                        dataGet.LoadData(loadFilePath, zoo.GetAnimals(), zoo.GetEmployees());
                        Console.WriteLine("Данные были загруженны.");
                        break;
                    
                    case 11:
                        Console.Write("Введите название животного: ");
                        string speciesCheck = Console.ReadLine();
                        if (speciesCheck.Contains('1') || speciesCheck.Contains('2') || speciesCheck.Contains('3') || speciesCheck.Contains('4') ||
                            speciesCheck.Contains('5') || speciesCheck.Contains('6') || speciesCheck.Contains('7') || speciesCheck.Contains('8') ||
                            speciesCheck.Contains('9') || speciesCheck.Contains('0') || speciesCheck.Contains('!') || speciesCheck.Contains('@') ||
                            speciesCheck.Contains('#') || speciesCheck.Contains('$') || speciesCheck.Contains('%') || speciesCheck.Contains('^') ||
                            speciesCheck.Contains('&') || speciesCheck.Contains('*') || speciesCheck.Contains('(') || speciesCheck.Contains(')') ||
                            speciesCheck.Contains('|') || speciesCheck.Contains('/') || speciesCheck.Contains(':') || speciesCheck.Contains('"') ||
                            speciesCheck.Contains("'") || speciesCheck.Contains('<') || speciesCheck.Contains('>') || speciesCheck.Contains('?'))
                        {
                            Console.WriteLine("Введены некорректные данные");
                            break;
                        }
                        zoo.FindAnimal(speciesCheck);
                        
                        break;

                    case 12:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Неправильно введён номер, пожалуйста вводите цифры от 1 до 12");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные, пожалуйста вводите цифры");
            }

            Console.WriteLine();
        }
    }
}
