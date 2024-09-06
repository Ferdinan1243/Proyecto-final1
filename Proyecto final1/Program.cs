using System;


class Proyecto
{
    static void Main()

    {

        Console.WriteLine($"Bienvenido al programa de venta de carros :* ");

        List<string> listaProductos = new List<string>();
        List<double> listaPrecios = new List<double>();

        int opcionFord;
        do
        {

            Console.WriteLine("=============MENU------------");
            Console.WriteLine("Seleccione la marca del carro que deseaa comprar ");
            Console.WriteLine("1.Ford ");
            Console.WriteLine("2.Honda");
            Console.WriteLine("3.Toyota");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese su opción: ");
            opcionFord = int.Parse(Console.ReadLine());

            switch (opcionFord)
            {
                case 1:
                    {

                    }
                    int opcion;
                    do
                    {
                        Console.WriteLine("Tipos de Ford que tenemos");
                        Console.WriteLine("1. Ford B-Max - lps - 15.400");
                        Console.WriteLine("2. Ford Bronco - lps - 86.900");
                        Console.WriteLine("3. Ford C-Max - lps - 21.715");
                        Console.WriteLine("4. Ford EcoSport - lps - 19.835");
                        Console.WriteLine("5. Ford Edge  - lps - 44.575");
                        Console.WriteLine("6. Ford Evos - lps 10.445");
                        Console.WriteLine("7. Ford Explorer - lps 51.765");
                        Console.WriteLine("8. Volver al menu principal");
                        Console.Write("Seleccione el tipo de Ford: ");
                        opcionFord = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcionFord)
                        {
                            case 1:
                                precio = 15400;
                                impuesto = 010;
                                break;
                            case 2:
                                precio = 86900;
                                impuesto = 0.07;
                                break;
                            case 3:
                                precio = 21715;
                                impuesto = 0.11;
                                break;
                            case 4:
                                precio = 19835;
                                impuesto = 0.12;
                                break;
                            case 5:
                                precio = 44475;
                                impuesto = 0.15;
                                break;
                            case 6:
                                precio = 10445;
                                impuesto = 0.16;
                                break;
                            case 7:
                                precio = 51765;
                                impuesto = 0.13;
                                break;






                                Console.WriteLine("volver al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción incorrecta. Por favor, intente mas tarde.");
                                continue;
                        }

                        if (opcionFord >= 1 && opcionFord <= 7)
                        {
                            Console.Write("Ingrese la cantidad de carros que deseea comprar (máximo 10): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 10)
                            {
                                Console.WriteLine("Lamentablemente no tenemos esa cantidad en nuestra empresa.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(opcionFord == 1 ? "Ford B-Max" : opcionFord == 2 ? "Ford Bronco" : opcionFord == 3 ? "Ford C-Max" : opcionFord == 4 ? "Ford EcoSport" : opcionFord == 5 ? "Ford Edge" : opcionFord == 6 ? "Ford Evos" : opcionFord == 7 ? "Ford Explorer" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: lps{precioConImpuesto:F2}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: lps{precioFinal:F2}");


                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcionFord != 8);
                    break;

                case 2:

                    int Honda;
                    do
                    {
                        Console.WriteLine("Tipos de honda que tenemos");
                        Console.WriteLine("1. Civic - lps - 16.000");
                        Console.WriteLine("2. CR-V - lps - 17.000");
                        Console.WriteLine("3. Pilot - lps - 18.000");
                        Console.WriteLine("4. Accord - lps - 19.000");
                        Console.WriteLine("5. Odyssey - lps - 20.000");
                        Console.WriteLine("6. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        Honda = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (Honda)
                        {
                            case 1:
                                precio = 16000;
                                impuesto = 0.03;
                                break;
                            case 2:
                                precio = 17000;
                                impuesto = 0.04;
                                break;
                            case 3:
                                precio = 18000;
                                impuesto = 0.08;
                                break;
                            case 4:
                                precio = 19000;
                                impuesto = 0.10;
                                break;
                            case 5:
                                precio = 20000;
                                impuesto = 0.11;
                                break;


                                Console.WriteLine("volver al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción incorrecta. Por favor, intente mas tarde.");
                                continue;
                        }

                        if (Honda >= 1 && Honda <= 5)
                        {
                            Console.Write("Ingrese la cantidad de carros que desse comprar (máximo 8): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 8)
                            {
                                Console.WriteLine("Lamentablemente no tenemos esa cantidad en nuestra empresa.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;

                            listaProductos.Add($"{(Honda == 1 ? "Civic" : Honda == 2 ? "CR-V" : Honda == 3 ? "Pilot" : Honda == 4 ? "Accord" : Honda == 5 ? "Odyssey" : Honda == 6 ? "" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2}");

                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Honda != 6);
                    break;

                case 3:

                    int Toyota;
                    do
                    {
                        Console.WriteLine("Tipos de Toyota que tenemos");
                        Console.WriteLine("1. Hillux - lps 200.000");
                        Console.WriteLine("2. Tacoma - lps 300.000");
                        Console.WriteLine("3. Tundra - lps 400.000");
                        Console.WriteLine("4. Prado - lps 500.000");
                        Console.WriteLine("5. Rav4 - lps 600.000");
                        Console.WriteLine("6. Land Cruiser - lps 700.000");
                        Console.WriteLine("7. Grand Highlander - lps 800.000");
                        Console.WriteLine("8. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        Toyota = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (Toyota)
                        {
                            case 1:
                                precio = 200000;
                                impuesto = 0.20;
                                break;
                            case 2:
                                precio = 300000;
                                impuesto = 0.30;
                                break;
                            case 3:
                                precio = 400000;
                                impuesto = 0.40;
                                break;
                            case 4:
                                precio = 500000;
                                impuesto = 0.50;
                                break;
                            case 5:
                                precio = 600000;
                                impuesto = 0.60;
                                break;
                            case 6:
                                precio = 700000;
                                impuesto = 0.70;
                                break;
                            case 7:
                                precio = 800000;
                                impuesto = 0.80;
                                break;



                                Console.WriteLine("volver al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción incorrecta. Por favor, intente mas tarde.");
                                continue;
                        }

                        if (Toyota >= 1 && Toyota <= 7)
                        {
                            Console.Write("Ingrese la cantidad que deseea comprar (máximo 5): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 5)
                            {
                                Console.WriteLine("Lamentablemente no tenemos esa cantidad en nuestra empresa");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;

                            listaProductos.Add($"{(Toyota == 1 ? "Hillux" : Toyota == 2 ? "Tacoma" : Toyota == 3 ? "Tundra" : Toyota == 4 ? "Prado" : Toyota == 5 ? "Rav4" : Toyota == 6 ? "Land Crusier" : Toyota == 7 ? "Grand Highlander" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2}");

                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Toyota != 8);
                    break;

                case 4:

                    Console.WriteLine("Generando factura final...");
                    MostrarFacturaFinal(listaProductos, listaPrecios);
                    break;

                default:

                    Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                    break;
            }

        } while (opcionFord != 3);
    }


    static double CalcularDescuento(int cantidad)
    {
        if (cantidad >= 50)
        {
            return 0.15;
        }
        else if (cantidad >= 20)
        {
            return 0.10;
        }
        else if (cantidad >= 10)
        {
            return 0.05;
        }
        else
        {
            return 0;
        }
    }


    static void MostrarFacturaFinal(List<string> listaProductos, List<double> listaPrecios)
    {
        double total = 0;

        for (int i = 0; i < listaProductos.Count; i++)
        {
            Console.WriteLine($"{listaProductos[i]} - {listaPrecios[i]:F2}");
            total += listaPrecios[i];
        }

        Console.WriteLine($"TOTAL A PAGAR: {total}");

    }
}