

using Microsoft.EntityFrameworkCore.Diagnostics;
using DatabaseFirstApproach.Models;
using DatabaseFirstApproach.Data;
using Ubiety.Dns.Core.Records;


/*
using(var context = new AppDbContext())
{
    Manager manager = new Manager();
    manager.FirstName = "Adnan";
    manager.LastName = "Anam";

    context.Managers.Add(manager);
    context.SaveChanges();
}
*/

using (var context = new AppDbContext())
{
    /*
    Manager manager = new Manager();
    manager.FirstName = "Harry";
    manager.LastName = "Potter";

    context.Managers.Add(manager);
    context.SaveChanges();
    */

    /*
    Manager manager = new Manager();
    var m = context.Managers.Single(a => a.FirstName == "Harry");

    context.Managers.Remove(m);
    context.SaveChanges();
    Console.WriteLine("Record Deleted Successfully!!");
    */

    
    Manager manager = new Manager();

    var m = context.Managers.Single(a => a.FirstName == "Harry");

    if(m != null)
    {
        m.FirstName = "Hermione";
        m.LastName = "Granger";
        context.SaveChanges();
        Console.WriteLine("Record Updated Successfully!!");
    }
    

}




