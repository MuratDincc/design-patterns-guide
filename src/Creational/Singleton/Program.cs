using Singleton;

var db1 = Database.Instance;
db1.Query("SELECT * FROM users");

var db2 = Database.Instance;
db2.Query("SELECT * FROM products");

Console.WriteLine($"db1 == db2: {db1 == db2}");