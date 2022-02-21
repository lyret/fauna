using System.Collections.Generic;
using System.Linq;

public class Animal
{
	private List<string> _supportedEnvironments;

	public string Name { get; private set; }

	public Animal(string name)
	{
		this.Name = name;
		this._supportedEnvironments = new List<string>();
	}

	public void Adapt(Environment env)
	{
		this._supportedEnvironments.Add(env.Name.ToLower());
	}

	public bool IsSupportedIn(Environment env)
	{
		return (this._supportedEnvironments.FirstOrDefault(supportedEnvName => env.Name.ToLower() == supportedEnvName) != null);
	}
}