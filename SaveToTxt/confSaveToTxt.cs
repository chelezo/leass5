using System;

public class confSaveToTxt
{
	private string _NameCompany;
	private int _NumCompany;
	
	public confSaveToTxt()

		
	{
		
	}
	public string NameCompany
    { 
		get { return _NameCompany; }
		set { _NameCompany = value; }

    }
	public void TextHello ()
    {
		System.Console.WriteLine("Введите сколько хотите внести фирм");
	}
	public void FileDelete()
	{
		System.Console.WriteLine("Хотите удалить файл? ДА - 1 Нет -2 ");
	}
	public void YesDel()
	{
		System.Console.WriteLine("Удаляем файл");
	}

	public void NoFileDelete()
	{
		System.Console.WriteLine("Вы выбрали не удалять файл!");
	}
	public void ErrorNum()
	{
		System.Console.WriteLine("Не правильный выбор");
	}

	public int NumCompany
    {
		get { return _NumCompany; }
		set { _NumCompany = value; }
    }
	public int  QueryData(int EnterNum)
	{
		int Numbers = System.Convert.ToInt32(System.Console.ReadLine());

		
		return Numbers;
	}

}
