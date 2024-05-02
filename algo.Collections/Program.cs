using System.Collections;

Console.WriteLine("Collections");

/*----- nombre fixe d'élements -----*/
string[] tableau = new string[5];
tableau[0] = "value";

/*----- nombre non-fixe d'éléments -----*/


/* List = type Fixe | ArrayList = Mixte */
List<string> list = new List<string>();
list.Add("value");
ArrayList arrayList = new ArrayList();
arrayList.Add("value");
arrayList.Add(1);

/* Dictionary = types Fixe | Hashtable = Mixte */
Dictionary<int,string> dictionary = new Dictionary<int,string>();
dictionary.Add(1, "value");
Hashtable hashtable = new Hashtable();
hashtable.Add(1, 1);
hashtable.Add("un", "un");

/* Last In First Out */
Stack<string> stack = new Stack<string>();
// Ajouter à la stack
stack.Push("value");
// Prendre et afficher l'élément au dessus de la stack ( existe aussi tryPeek(); )
stack.Peek();
// Prendre et supprimer l'élément au dessu de la stack
stack.Pop();

/* First In First Out */
Queue<string> queue = new Queue<string>();
// Ajouter à la queue
queue.Enqueue("value");
// Prendre et afficher le premier élément de la queue ( existe aussi tryPeek(); )
queue.Peek();
// Prendre et supprimer le premier élément de la queue
queue.Dequeue();