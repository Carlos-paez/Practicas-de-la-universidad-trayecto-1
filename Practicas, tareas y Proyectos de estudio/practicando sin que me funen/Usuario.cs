using System.Collections.Generic;
using System.Runtime.Remoting.Activation;

public class Users
{
    private string nombre;
    private string password;
    private Dictionary<string, int> levels = new Dictionary<string, int>()
    {
        {"Estandar" , 1 },
        {"Administrador", 0 }
    };

    public Users(string Nombre, string Password, Dictionary<string, int> levels)
    {
        this.nombre = Nombre;
        this.password = Password;
        this.levels = new Dictionary<string, int>(levels);
    }

    public string GetNombre() => nombre;
    public void setNombre(string nombre) => this.nombre = nombre;

    public string GetPassword() => password;
    public void setPassword(string password) => this.password = password;


    public IReadOnlyDictionary<string, int> Levels => levels;

    public void AddLevel(string key, int value)
    {
        if (!levels.ContainsKey(key))
        {
            levels.Add(key, value);
        }
    }

    public bool UpdateLevel(string key, int value)
    {
        if (levels.ContainsKey(key))
        {
            levels[key] = value;
            return true;
        }
        return false;
    }

    public bool RemoveLevel(string key)
    {
        return levels.Remove(key);
    }
}
