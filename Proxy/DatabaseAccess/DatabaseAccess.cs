using Proxy;
using System;

public class RealDatabaseAccess : IDatabaseAccess
{
    public void Request()
    {
        Console.WriteLine("Accessing sensitive database");
    }
}

public class ProtectionDatabaseProxy : IDatabaseAccess
{
    private RealDatabaseAccess realDatabase;
    private string userRole;

    public ProtectionDatabaseProxy(string userRole)
    {
        this.userRole = userRole;
    }

    public void Request()
    {
        if (realDatabase == null)
        {
            realDatabase = new RealDatabaseAccess();
        }

        // Check user permissions before accessing the database
        if (userRole == "Admin")
        {
            realDatabase.Request();
        }
        else
        {
            Console.WriteLine("Permission denied. Insufficient privileges.");
        }
    }
}

public class DatabaseAccess
{
    public static void Main(string[] args)
    {
        IDatabaseAccess databaseProxy = new ProtectionDatabaseProxy("Admin");

        // Database access is allowed for Admin role
        databaseProxy.Request();

        // Attempting database access with a non-admin role
        IDatabaseAccess restrictedDatabaseProxy = new ProtectionDatabaseProxy("User");
        restrictedDatabaseProxy.Request();
    }
}
