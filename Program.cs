using MenuCalc.Models;

Calculadora calculadora = new Calculadora();

Menu menu = new Menu(calculadora);

while (true)
{
    menu.MenuCalculadora();
}

