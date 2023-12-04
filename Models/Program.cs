using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AplicatieProiect.Data;
namespace AplicatieProiect.Models;
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Link-ul către pagina web
        string link = "https://www.exemplu.com";

        // Deschide link-ul în browserul implicit al sistemului
        OpenWebPage(link);
    }

    static void OpenWebPage(string url)
    {
        try
        {
            // Creează un proces pentru a deschide browserul web
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"A apărut o eroare: {ex.Message}");
        }
    }
}


