string permission = "Admi|Manager";
int level = 25;

var response = permission.Contains("Admin")  ? (level > 55 ? "Welcome, Super Admin user." : "Welcome Admin User") : (permission.Contains("Manager") ? (level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.") : "You do not have sufficient privileges.");

Console.WriteLine(response);