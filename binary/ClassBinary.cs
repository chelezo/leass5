using System;

[Serializable]
public class ClassBinary
{
	private int _EnterNumer;
	public  int EnterNumer
	{
		get { return _EnterNumer; }
		set { _EnterNumer = value; }
	}
	
	public void TxtHello()
    {
		Console.WriteLine("Введите число от 0 до 255");
    }
    
	//public ClassBinary()
	//{

//	}
	 
}
