﻿using UnityEngine;
using System.Collections;
using cloudsoft ;

public class Test19: Test {

	override public void DoTest()
	{
		Description = "Test 19 Succeed" ;
		Succeed = false ;

		/*float t = Time.realtimeSinceStartup ;
		DataSize = d.Length ;
		SerializeTime = (Time.realtimeSinceStartup-t);
		t = Time.realtimeSinceStartup ;
		DeserializeTime = (Time.realtimeSinceStartup-t);*/
		Succeed = true ;
	}
}
