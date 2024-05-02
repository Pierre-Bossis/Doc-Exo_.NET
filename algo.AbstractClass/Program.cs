using algo.AbstractClass;

Ouvrier ouvrier = new("A1","Bossis","Pierre",new DateTime(1994,11,14),new DateTime(2022,01,01));
Cadre cadre = new("A1","Bossis","Pierre",new DateTime(1994,11,14),3);
Patron patron = new("A1","Bossis","Pierre",new DateTime(1994,11,14),300000,20);

Console.WriteLine(patron.GetSalaire());