using System.Collections;
using System.Text;

namespace Frank.IRC.Models;

public class IrcParameters : IEnumerable<string>
{
    private readonly List<string> _parameters = new();

    public IEnumerator<string> GetEnumerator() => _parameters.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
    public void Add(string parameter) => _parameters.Add(parameter);
    
    public void AddRange(IEnumerable<string> parameters) => _parameters.AddRange(parameters);
    
    public void Remove(string parameter) => _parameters.Remove(parameter);
    
    public void RemoveAt(int index) => _parameters.RemoveAt(index);
    
    public void Clear() => _parameters.Clear();
    
    public bool Contains(string parameter) => _parameters.Contains(parameter);
    
    public int Count => _parameters.Count;
    
    public string this[int index]
    {
        get => _parameters[index];
        set => _parameters[index] = value;
    }
    
    public override string ToString()
    {
        var parametersBuilder = new StringBuilder();
        foreach (var parameter in _parameters)
        {
            parametersBuilder.Append($" {parameter}");
        }
        return parametersBuilder.ToString();
    }
}