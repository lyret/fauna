using System.Collections.Generic;

public class Environment
{
	private List<Animal> _animals;

	public string Name { get; private set; }
	public int NumberOfSupportedAnimals
	{
		get
		{
			return this._animals.Count;
		}
	}

	public Environment(string name)
	{
		this.Name = name;
		this._animals = new List<Animal>();
	}

	public void AddFauna(Animal animal)
	{
		if (animal.IsSupportedIn(this))
		{
			this._animals.Add(animal);
		}
	}
}