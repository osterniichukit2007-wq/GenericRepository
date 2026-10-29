using GenericRepository;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var postingRepository = new GenericRepository<Posting>();

postingRepository.Add(new Posting
{
    Id = 1,
    TrackingNumber = "TT123",
    Weight = 2.5,
    SenderAddress = "Рівне",
    ReceiverAddress = "Київ",
    Status = "В дорозі"
});

postingRepository.Add(new Posting
{
    Id = 2,
    TrackingNumber = "TT456",
    Weight = 1.2,
    SenderAddress = "Львів",
    ReceiverAddress = "Одеса",
    Status = "Очікує відправлення"
});

postingRepository.Add(new Posting
{
    Id = 3,
    TrackingNumber = "TT789",
    Weight = 3.0,
    SenderAddress = "Київ",
    ReceiverAddress = "Рівне",
    Status = "Доставлено"
});

Console.WriteLine("Пошук відправлення за Id = 1:");
var posting = postingRepository.GetById(1);
Console.WriteLine($"{posting?.TrackingNumber} - {posting?.Status}");

postingRepository.Update(new Posting
{
    Id = 1,
    TrackingNumber = "TT123",
    Weight = 2.5,
    SenderAddress = "Рівне",
    ReceiverAddress = "Київ",
    Status = "Доставлено"
});

postingRepository.Delete(2);

Console.WriteLine("\nСписок поштових відправлень:");
foreach (var item in postingRepository.GetAll())
{
    Console.WriteLine($"{item.Id}. {item.TrackingNumber} - {item.Status}");
}

var contactRepository = new GenericRepository<ContactPerson>();

contactRepository.Add(new ContactPerson
{
    Id = 1,
    Name = "Дарина",
    PhoneNumber = "0981234567",
    Email = "daryna@gmail.com"
});

contactRepository.Add(new ContactPerson
{
    Id = 2,
    Name = "Олена",
    PhoneNumber = "0671234567",
    Email = "olena@gmail.com"
});

contactRepository.Add(new ContactPerson
{
    Id = 3,
    Name = "Іван",
    PhoneNumber = "0501234567",
    Email = "ivan@gmail.com"
});

Console.WriteLine("\nПошук контактної особи за Id = 1:");
var contact = contactRepository.GetById(1);
Console.WriteLine($"{contact?.Name} - {contact?.Email}");

contactRepository.Update(new ContactPerson
{
    Id = 1,
    Name = "Дарина",
    PhoneNumber = "0981234567",
    Email = "daryna_new@gmail.com"
});

contactRepository.Delete(2);

Console.WriteLine("\nСписок контактних осіб:");
foreach (var item in contactRepository.GetAll())
{
    Console.WriteLine($"{item.Id}. {item.Name} - {item.Email}");
}
