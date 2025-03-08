

Console.Write("Digite se seu animal é um mamifero ou ave:");
string tipo = Console.ReadLine().ToUpper();
string comida, locomocao;


    if (tipo == "MAMIFERO")
    {
        Console.Write("Digite se seu animal é quadrupede, bipede, voador ou aquatico: ");
        locomocao = Console.ReadLine().ToUpper();
        if (locomocao == "QUADRUPEDE")
        {
            Console.Write("Digite se seu animal é carnivoro ou herbivoro:");
            comida = Console.ReadLine().ToUpper();
            if (comida == "CARNIVORO")
            {
                Console.WriteLine("Seu animal é um leão");
                return;
            }
            if (comida == "HERBIVORO")
            {
                Console.WriteLine("Seu animal é um cavalo");
                return;
            }
            else
            {
                Console.WriteLine("Digite uma opção valida");
                return;
        }


        }
       
    if (locomocao == "BIPEDE")
        {
            Console.Write("Digite se seu animal é onivoro ou frutifero:");
            comida = Console.ReadLine().ToUpper();
            if (comida == "ONIVORO")
            {
                Console.WriteLine("Seu animal é um homem");
                return;
            }
            if (comida == "FRUTIFERO")
            {
                Console.WriteLine("Seu animal é um macaco");
                return;
            }


        }
     

    if (locomocao == "VOADOR")
        {
            Console.Write("Seu animal é um morcego");
             return;


    }
       

    if (locomocao == "AQUATICO")
        {
            Console.Write("Seu animal é uma baleia");
            return;
    }

    else
    {
        Console.WriteLine("Digite uma opção valida");
        return;
    }

}


if (tipo == "AVE")
    {
        Console.Write("Digite se seu animal é não voador, nadador, de rapina: ");
        locomocao = Console.ReadLine().ToUpper();
        if (locomocao == "NAO VOADOR")
        {
            Console.Write("Digite se seu animal é tropical ou polar:");
            comida = Console.ReadLine().ToUpper();
            if (comida == "TROPICAL")
            {
                Console.WriteLine("Seu animal é um avestruz");
                return;
            }
            if (comida == "POLAR")
            {
                Console.WriteLine("Seu animal é um pinguim");
                return;
            }
            else
            {
                Console.WriteLine("Digite uma opção valida");
            return;
        }


            }
        

    if (locomocao == "NADADOR")
        {
            Console.Write("Seu animal é um pato");
            return ;


        }
        


    if (locomocao == "RAPINA")
        {
            Console.Write("Seu animal é uma aguia");
            return;
        }
        else
        {
            Console.WriteLine("Digite uma opção valida");
            return;
    }

}
    




