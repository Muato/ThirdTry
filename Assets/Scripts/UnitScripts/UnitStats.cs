using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum UnitClasses
{
	Peasent,
	Warrior,
	Archer,
	Knight,
	Thief,
	Priest,
	Wizard,
	Blademaster
};

public class UnitStats {

	// Unit stats
	public int ID;
	public int UnitID;
	public string Name;

	UnitClasses unitClass { get; set; }

	int Strength;
	int Vitality;
	int Agility;
	int Dexterity;
	int Intelligence;
	int Wisdom;
	int Charisma;



}
