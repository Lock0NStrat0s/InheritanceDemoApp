List<Phone> phones = new List<Phone>();

phones.Add(new Smartphone());
phones.Add(new Cellphone());

foreach (var phone in phones)
{
    if (phone is Cellphone cell)
    {
        cell.Carrier = "";
    }

    if (phone is Smartphone smartphone)
    {
        smartphone.ConnectToInternet();
    }
}

Console.WriteLine();
