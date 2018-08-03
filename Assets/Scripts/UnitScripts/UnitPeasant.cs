using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitPeasant : BaseUnitStats {

	public UnitPeasant(string _name)
	{
		SetStats(5, 5, 5, 5, 5, 0, 5);
		SetClass(UnitClasses.Peasant);
		SetName(_name);
		ID = 0;
	}

	
}
