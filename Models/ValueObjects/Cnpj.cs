using System.Text.RegularExpressions;
using Flunt.Notifications;
using Models.Domain.Contracts;

namespace Models.Domain.ValueObjects;

public class Cnpj : Notifiable<Notification>
{
    public Cnpj(string value)
    {
        Value = value;
        
        AddNotifications(new CnpjContract(this));
    }

    public string Value { get; private set; }
    
    public static bool ValidateCNPJ(string cnpj)
    {
        int[] b = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        string c = new string(cnpj.Where(char.IsDigit).ToArray());
        if (c.Length != 14)
            return false;
        if (Regex.IsMatch(c, @"^0{14}$"))
            return false;
        int n = 0;
        for (int i = 0; i < 12; i++)
            n += (c[i] - '0') * b[i + 1];
        if (c[12] != ((n %= 11) < 2 ? '0' : (char)(11 - n + '0')))
            return false;
        n = 0;
        for (int i = 0; i <= 12; i++)
            n += (c[i] - '0') * b[i];
        return c[13] == ((n %= 11) < 2 ? '0' : (char)(11 - n + '0'));
    } 
}