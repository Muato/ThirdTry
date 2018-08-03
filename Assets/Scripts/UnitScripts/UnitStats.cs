using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BaseUnitStats {
	public enum UnitClasses
	{
		Peasant,
		Warrior,
		Archer,
		Knight,
		Thief,
		Priest,
		Wizard,
		Blademaster
	};

	// Unit stats
	public int ID;
//	public int UnitID;
	public string Name;

	private UnitClasses unitClass;

	private int Strength;
	private int Vitality;
	private int Agility;
	private int Dexterity;
	private int Intelligence;
	private int Wisdom;
	private int Charisma;


	// Strength
	public void SetStrength(int value)
	{
		Strength = value;
	}

	public int GetStrength()
	{
		return Strength;
	}

	// Vitality
	public void SetVitality(int value)
	{
		Vitality = value;
	}

	public int GetVitality()
	{
		return Vitality;
	}

	// Agility
	public void SetAgility(int value)
	{
		Agility = value;
	}

	public int GetAgility()
	{
		return Agility;
	}

	// Dexterity
	public void SetDexterity(int value)
	{
		Dexterity = value;
	}

	public int GetDexterity()
	{
		return Dexterity;
	}

	// Intelligence
	public void SetIntelligence(int value)
	{
		Intelligence = value;
	}

	public int GetIntelligence()
	{
		return Intelligence;
	}

	// Wisdom
	public void SetWisdom(int value)
	{
		Wisdom = value;
	}

	public int GetWisdom()
	{
		return Wisdom;
	}

	// Charisma
	public void SetCharisma(int value)
	{
		Charisma = value;
	}

	public int GetCharisma()
	{
		return Charisma;
	}

	// Sets all stats.
	public void SetStats(int S, int V, int A, int D, int I, int W, int C)
	{
		Strength = S;
		Vitality = V;
		Agility = A;
		Dexterity = D;
		Intelligence = I;
		Wisdom = W;
		Charisma = C;
	}

	public int[] GetStats()
	{
		int[] stats = new int[7];
		stats[0] = Strength;
		stats[1] = Vitality;
		stats[2] = Agility;
		stats[3] = Dexterity;
		stats[4] = Intelligence;
		stats[5] = Wisdom;
		stats[6] = Charisma;

		return stats;
	}

	public void SetClass(UnitClasses uClass)
	{
		unitClass = uClass;
	}

	public void SetName(string _name)
	{
		Name = _name;
	}

	 public UnitClasses GetClass()
	{
		return unitClass;
	}
}
