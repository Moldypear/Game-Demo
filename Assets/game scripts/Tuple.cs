using System;

public class Tuple{
	public int Item1;
	public string Item2;

	public Tuple(int item1, string item2)
	{
		Item1 = item1;
		Item2 = item2;
	}
	public int fst(){
		return Item1;
	}
	public string snd(){
		return Item2;
	}
}
