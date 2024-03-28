namespace Singleton;

public class Database
{
    private static Database instance;

    private Database()
    {
        Console.WriteLine("Database instance created");
    }

    public static Database Instance
    {
        get
        {
            if (instance == null)
                instance = new Database();

            return instance;
        }
    }
    
    public void Query(string sql)
    {
        Console.WriteLine($"Executing query: {sql}");
    }
}