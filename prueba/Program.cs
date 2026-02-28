Console.WriteLine("que caja quiere abrir");
int opciones = int.Parse(Console.ReadLine());

switch (opciones)
{
    case 1:
        int i = 1;
        while(i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        break; 
}
